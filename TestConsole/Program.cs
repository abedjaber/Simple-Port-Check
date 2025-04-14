using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using zkemkeeper;
namespace TestConsole
    {
    internal class Program
        {
        static void Main(string[] args)
            {
        //Label
        StartCode:
            Console.WriteLine("\nEnter Destinatin IP Address: ");
            var ip = Console.ReadLine();
            Console.WriteLine("\nEnter Destinatin Port ");
            var input = Console.ReadLine();
            int port = Int32.Parse(input);
            using (TcpClient tcpClient = new TcpClient())
                {
                try
                    {
                    tcpClient.Connect(ip, port);
                    Console.WriteLine("\nPort " + "'" + port + "'" + " on " + "'" + ip + "'" + " is Open!");
                    Console.WriteLine("\nTry Again? 1 = Yes, 0 = No ");
                    var continue1 = Console.ReadLine();
                    if(continue1 == "1")
                        {
                        goto StartCode;
                        }
                    else
                        {
                        Environment.Exit(0);
                        }
                    }
                catch (Exception)
                    {
                    Console.WriteLine("\nPort " + "'" + port + "'" + " on " + "'" + ip + "'" + " is Closed!");
                    Console.WriteLine("\nTry Again? 1 = Yes, 0 = No ");
                    var continue1 = Console.ReadLine();
                    if (continue1 == "1")
                        {
                        goto StartCode;
                        }
                    else
                        {
                        Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
