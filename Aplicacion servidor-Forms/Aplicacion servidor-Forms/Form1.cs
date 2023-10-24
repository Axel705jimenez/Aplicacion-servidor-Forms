using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicacion_servidor_Forms
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private TcpClient client;
        private List<string> dataHistory = new List<string>(); // Lista para almacenar datos

        public Form1()
        {
            InitializeComponent();
        }
        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            string ipAddress = "192.168.1.8";
            int port = 80;

            try
            {
                server = new TcpListener(IPAddress.Parse(ipAddress), port);
                server.Start();

                // Esperar una conexión entrante
                client = server.AcceptTcpClient();
                lblestatus.Text = "Cliente conectado.";

                // Obtener el flujo de red para leer los datos del cliente
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesRead);

                // Dividir los datos por saltos de línea y agregar al ListBox
                string[] dataParts = message.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // Si hay datos en el historial, agregar la línea divisoria
                if (dataHistory.Count > 0)
                {
                    dataHistory.Add("------------------------");
                }

                dataHistory.AddRange(dataParts);

                // Mostrar los datos en el ListBox
                lstbDatos.Items.Clear();
                lstbDatos.Items.AddRange(dataHistory.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
