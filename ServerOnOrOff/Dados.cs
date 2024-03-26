using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerOnOrOff
{
    public class Dados
    {
        static string arquivo = "settings.txt";
        public void Lerdados() //lê o endereço do banco
        {
            try
            {
                using (StreamReader sr = File.OpenText(arquivo))
                {
                    PinHome.ip = sr.ReadLine();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("O Arquivo de endereço de banco não existe!");
            }
        }
    }
}

