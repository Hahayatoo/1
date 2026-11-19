using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atv1_3Etapa_HayatoDaviMiyamoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Teste da conexão (Parte 1): se não aparecer erro, a ponte com o MySQL foi construída
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao banco = new Conexao();
                MySqlConnection conn = banco.conectarBD();

                MessageBox.Show("Conexão estabelecida com sucesso!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
