using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1,Port=3306;Database=pedidos;User=root;Password="))
            {

                Conexao.Open();
                using(MySqlCommand cmd= Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSER INTO cliente(nome, documento, datacontrato, ncontrato, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao, valor)" +
                        "VALUES (@nome, @documento, @datacontrato, @ncontrato, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao, @valor)";
                    cmd.Parameters.AddWithValue("nome", txtNome);
                    cmd.Parameters.AddWithValue("documento", maskCPF);
                    cmd.Parameters.AddWithValue("datacontrato", maskDATA);
                    cmd.Parameters.AddWithValue("ncontrato", maskContrato);
                    cmd.Parameters.AddWithValue("cep", maskCEP);
                    cmd.Parameters.AddWithValue("endereco", txtEndereco);
                    cmd.Parameters.AddWithValue("numero", maskN);
                    cmd.Parameters.AddWithValue("bairro", cBoxBairro);
                    cmd.Parameters.AddWithValue("cidade", CboxCidade);
                    cmd.Parameters.AddWithValue("estado", cBoxEstado);
                    cmd.Parameters.AddWithValue("celular", maskCelular);
                    cmd.Parameters.AddWithValue("email", txtEmail);
                    cmd.Parameters.AddWithValue("obs", txtObs);
                    cmd.Parameters.AddWithValue("valor", txtValor);
                }
                MessageBox.Show("ok");

            }
        }
        private void SalvarClienteMysql()
        {

            using (MySqlConnection Conexao = new MySqlConnection("Server=127.0.0.1,Port=3306;Database=pedidos;User=root;Password="))
            {

                Conexao.Open();
                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSER INTO cliente(nome, documento, datacontrato, ncontrato, cep, endereco, numero, bairro, cidade, estado, celular, email, obs, situacao, valor)" +
                        "VALUES (@nome, @documento, @datacontrato, @ncontrato, @cep, @endereco, @numero, @bairro, @cidade, @estado, @celular, @email, @obs, @situacao, @valor)";
                    cmd.Parameters.AddWithValue("nome", txtNome);
                    cmd.Parameters.AddWithValue("documento", maskCPF);
                    cmd.Parameters.AddWithValue("datacontrato", maskDATA);
                    cmd.Parameters.AddWithValue("ncontrato", maskContrato);
                    cmd.Parameters.AddWithValue("cep", maskCEP);
                    cmd.Parameters.AddWithValue("endereco", txtEndereco);
                    cmd.Parameters.AddWithValue("numero", maskN);
                    cmd.Parameters.AddWithValue("bairro", cBoxBairro);
                    cmd.Parameters.AddWithValue("cidade", CboxCidade);
                    cmd.Parameters.AddWithValue("estado", cBoxEstado);
                    cmd.Parameters.AddWithValue("celular", maskCelular);
                    cmd.Parameters.AddWithValue("email", txtEmail);
                    cmd.Parameters.AddWithValue("obs", txtObs);
                    cmd.Parameters.AddWithValue("situacao", "@situaçao");
                    cmd.Parameters.AddWithValue("valor", txtValor);
                }
                MessageBox.Show("ok");

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
