using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IPEndPoint server_point;
        private string serverIp = "127.0.0.1";
        private short serverPort = 2525;
        TcpClient client;
        public MainWindow()
        {
            InitializeComponent();
            server_point = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);
            client = new TcpClient();
            client.Connect(server_point);
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                string message = searchTb.Text;
                NetworkStream ns = client.GetStream();

                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine(message);
                sw.Flush();

                StreamReader sr = new StreamReader(ns);
                string response = sr.ReadLine();
                //if (response == "Wrong Code")
                //    client.Close();
                MessageBox.Show(response);      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}