using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCRUD_DS
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = textBox4.Text;
            var login = textBox1.Text;
            var password = textBox2.Text;
            var nome = textBox3.Text;

            String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao = new MySqlConnection(caminhobd);
            conexao.Open();
            string alterar = "UPDATE usuario set ID='" + id + "',Login='" + login + "',password='" + password + "',nome='"
                + nome + "' where id= '" + id + "';";
            MySqlCommand command = new MySqlCommand(alterar, conexao);
            MySqlDataReader myreader;
            myreader = command.ExecuteReader();
            conexao.Close();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = textBox4.Text;
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao = new MySqlConnection(caminhobd);
            conexao.Open();
            string deletar = "Delete From usuario where id=" + id;
            MySqlCommand command = new MySqlCommand(deletar, conexao);
            MySqlDataReader myreader;
            myreader = command.ExecuteReader();
            conexao.Close();
            MessageBox.Show("Deletado com Sucesso!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text=("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == (""))
            {
                MessageBox.Show("Escolha uma forma de pesquisa");
            }
            else
            {
                String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhodb);
                con.Open();
                String op = (String)comboBox1.SelectedItem;

                switch (op)
                {
                    case "Nome":
                        string pesquisa = "select ID,Login,Password,Nome from usuario where Nome like @valor";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox5.Text + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView1.DataSource = table;
                        con.Close();
                        break;

                    case "Login":
                        string pesquisa1 = "select ID,Login,Password,Nome from usuario where Login like @valor";
                        MySqlDataAdapter ad1 = new MySqlDataAdapter(pesquisa1, con);
                        ad1.SelectCommand.Parameters.AddWithValue("valor", textBox5.Text + "%");
                        DataTable table1 = new DataTable();
                        ad1.Fill(table1);
                        dataGridView1.DataSource = table1;
                        con.Close();
                        break;


                }
                dataGridView1.Columns["Nome"].ReadOnly = true;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhodb);
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand("select ID,Login,Password,Nome from usuario where ID ='" + codigo + "'", cn);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                //Inserindo os dados do banco de dados nas Combo e textbox;
                textBox4.Text = reader.GetString(0);
                textBox1.Text = reader.GetString(1);
                textBox2.Text = reader.GetString(2);
                textBox3.Text = reader.GetString(3);
                tabControl1.SelectedTab = tabPage1;
            }
            }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            var login = textBox1.Text;
            var password = textBox2.Text;
            var nome = textBox3.Text;
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string inserir = "INSERT INTO usuario (Login,Password,Nome)"
                    + "values (@Login,@Password,@Nome)";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                MySqlDataReader reader;

                comandos.Parameters.Add(new MySqlParameter("@Login", login));
                comandos.Parameters.Add(new MySqlParameter("@Password", password));
                comandos.Parameters.Add(new MySqlParameter("@Nome", nome));


                reader = comandos.ExecuteReader();
                MessageBox.Show("Cadastro do usuario no sistema feito com sucesso!!");
                conexao.Close();

            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var id = textBox4.Text;
            var login = textBox1.Text;
            var password = textBox2.Text;
            var nome = textBox3.Text;

            String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao = new MySqlConnection(caminhobd);
            conexao.Open();
            string alterar = "UPDATE usuario set ID='" + id + "',Login='" + login + "',password='" + password + "',nome='"
                + nome + "' where id= '" + id + "';";
            MySqlCommand command = new MySqlCommand(alterar, conexao);
            MySqlDataReader myreader;
            myreader = command.ExecuteReader();
            conexao.Close();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var id = textBox4.Text;
            String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao = new MySqlConnection(caminhobd);
            conexao.Open();
            string deletar = "Delete From usuario where id=" + id;
            MySqlCommand command = new MySqlCommand(deletar, conexao);
            MySqlDataReader myreader;
            myreader = command.ExecuteReader();
            conexao.Close();
            MessageBox.Show("Deletado com Sucesso!!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
        }
    }
    }

