using data_access;
using data_access.Entities;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    internal class Program
    {
        static int port = 2525;
        static void Main(string[] args)
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipPoint = new IPEndPoint(iPAddress, port);
            RegionCodeDbContext context = new RegionCodeDbContext();
            CodeRegions exc = new CodeRegions() { Code = "f", Region = "Wrong Code" };
            TcpListener listener = new TcpListener(ipPoint);
            try
            {
                listener.Start();
                Console.WriteLine("Server started! Waiting for connection...");
                TcpClient client = listener.AcceptTcpClient();

                while (client.Connected)
                {
                    Console.WriteLine("Connected");
                    NetworkStream ns = client.GetStream();

                    StreamReader sr = new StreamReader(ns);
                    string response = sr.ReadLine();

                    Console.WriteLine($"{client.Client.RemoteEndPoint} - {response} at {DateTime.Now.ToShortTimeString()}");

                    var res = context.CodeRegions.Where(c => c.Code == response).ToList().FirstOrDefault(exc);
                    CodeRegions info = res;
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(info.Region);

                    sw.Flush();
                }
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            listener.Stop();
        }
    }
}
