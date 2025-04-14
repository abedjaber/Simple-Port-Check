using System;
using System.Net;using System.Net.Sockets;
using zkemkeeper;

namespace TestConsole
    {
    internal class Program
        {


        static void Main(string[] args)
            {
            Console.WriteLine("Enter Destinatin IP Address: ");
            var ip = Console.ReadLine();
            Console.WriteLine("Enter Destinatin Port ");
            var input = Console.ReadLine();
            int port = Int32.Parse(input);
            using (TcpClient tcpClient = new TcpClient())
                {
                try
                    {
                    tcpClient.Connect(ip, port);
                    Console.WriteLine("Port " + "'" + port + "'" + " on " + "'" + ip + "'" + " is Open!");
                    }
                catch (Exception)
                    {
                    Console.WriteLine("Port " + "'" + port + "'" + " on " + "'" + ip + "'" + " is Closed!");
                    }
                }
            }
        }
    }



