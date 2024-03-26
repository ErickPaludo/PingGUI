using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace ServerOnOrOff
{
    public partial class PinHome : Form
    {
        public static string ip;
        Dados arquivo = new Dados();
        public PinHome()
        {
            InitializeComponent();
            Thread threadPing = new Thread(IniciaPing);
            threadPing.IsBackground = true;
            threadPing.Start();
        }

        public void IniciaPing()
        {
            while (true)
            {
                arquivo.Lerdados();
                bool servidorOnline = PingHost(ip); // Altere o endereço IP para o endereço do seu servidor
                // Atualiza a interface do usuário com base no status do servidor
                try
                {

                    Invoke(new Action(() =>
                    {
                        labelIp.Text = ip;
                        if (servidorOnline)
                        {
                            pictureOnOff.Image = Image.FromFile("statuson.png");
                        }
                        else
                        {
                            pictureOnOff.Image = Image.FromFile("statusoff.png");
                        }
                    }));

                    Thread.Sleep(1000);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao buscar pelo ip/endereco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.Start("notepad.exe", "settings.txt");
                }
            }
        }

        public bool PingHost(string host)
        {
            using (Ping pingSender = new Ping())
            {
                try
                {
                    PingReply reply = pingSender.Send(host);
                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                }
                catch (PingException)
                {
                    // O ping falhou
                }
            }
            return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Configuracao(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "settings.txt");
        }
    }
}
