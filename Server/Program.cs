using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {
        private const int VIDEO_W = 1280;
        private const int VIDEO_H = 720;

        private static object clientLock = new object();
        private static LinkedList<TcpClient> clients = new LinkedList<TcpClient>();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(AddClients);
            Thread thread2 = new Thread(BroadcastVideoData);
            thread1.Start();
            thread2.Start();

            Console.WriteLine("server started");

            thread1.Join();
            thread2.Join();
        }

        static void AddClients()
        {
            // Threads: ThreadAcceptClients, ThreadSend
            TcpListener tcpListener = new TcpListener(1337);
            tcpListener.Start();
            for (;;)
            {
                // Accept a client
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Console.WriteLine("[" + tcpClient.Client.RemoteEndPoint + "] client connected");
                lock (clientLock) clients.AddLast(tcpClient);
                Thread.Sleep(50);
            }
        }

        static void BroadcastVideoData()
        {
            Random rand = new Random();
            byte[] videoBuf = new byte[VIDEO_W * VIDEO_H * 3];
            for (;;)
            {
                // Sleep (~60 fps)
                Thread.Sleep(1000/60);

                // Skip if there are no clients
                if (clients.First == null) continue;

                // Generate random video packet
                // rand.NextBytes(videoBuf);

                // Randomly update pixel bytes
                int i = 0;
                do
                {
                    int r = rand.Next();
                    videoBuf[i] = unchecked((byte)r);
                    i += ((r >> 8) & 0x1FF) + 1;
                } while (i < videoBuf.Length);

                // Send to clients
                lock (clientLock)
                {
                    LinkedListNode<TcpClient> it = clients.First;
                    while (it != null)
                    {
                        LinkedListNode<TcpClient> curNode = it;
                        TcpClient cur = curNode.Value;
                        it = it.Next;

                        // Check if client has disconnected
                        if (!cur.Connected || !cur.GetStream().CanWrite) {
                            Console.WriteLine("[" + cur.Client.RemoteEndPoint + "] client disconnected");
                            clients.Remove(curNode);
                            continue;
                        }

                        // Send video data to client
                        try
                        {
                            cur.GetStream().Write(videoBuf, 0, videoBuf.Length);
                        }
                        catch { }
                    }
                }
                //Console.WriteLine("sent video packet");
            }
        }
    }
}
