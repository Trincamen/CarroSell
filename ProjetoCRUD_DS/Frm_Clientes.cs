using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCRUD_DS
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_alunos_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Construtor mo = new Construtor();
            DAL da = new DAL();
            //mo.id = Convert.ToInt16(textBox1.Text);
            mo.nome = textBox2.Text;
            mo.RG = maskedTextBox1.Text;
            mo.endereco = textBox4.Text;
            mo.num_telefone = maskedTextBox5.Text;
            mo.cpf = maskedTextBox2.Text;
            mo.bairro = textBox6.Text;
            mo.num_celular = maskedTextBox6.Text;
            mo.cep = maskedTextBox4.Text;
            mo.cidade = textBox3.Text;
            mo.data_de_nascimento = maskedTextBox3.Text;
            mo.numero =textBox5.Text;
            mo.OBS = textBox7.Text;
            mo.sexo = comboBox1.Text;

            da.Adicionar(mo);
            MessageBox.Show("Dados gravados com sucesso");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = ("");
            textBox4.Text = (""); 
            textBox3.Text = ("");
            textBox5.Text = ("");
            maskedTextBox3.Text = ("");
            maskedTextBox4.Text = ("");
            maskedTextBox5.Text = ("");
            maskedTextBox6.Text = ("");
            textBox2.Text = ("");
            comboBox1.Text = ("");
            maskedTextBox1.Text = ("");
            maskedTextBox2.Text = ("");
            textBox6.Text = ("");
            textBox5.Text = ("");
            textBox7.Text = ("");


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Construtor mo = new Construtor();
            DAL da = new DAL();
            mo.id = Convert.ToInt16(textBox1.Text);
            mo.nome = textBox2.Text;
            mo.RG = maskedTextBox1.Text;
            mo.endereco = textBox4.Text;
            mo.num_telefone = maskedTextBox5.Text;
            mo.cpf = maskedTextBox2.Text;
            mo.bairro = textBox6.Text;
            mo.num_celular = maskedTextBox6.Text;
            mo.cep = maskedTextBox4.Text;
            mo.cidade = textBox3.Text;
            mo.data_de_nascimento = maskedTextBox3.Text;
            mo.numero = textBox5.Text;
            mo.OBS = textBox7.Text;
            mo.sexo = comboBox1.Text;
            da.Deletar(mo);
            MessageBox.Show("Deletado com Sucesso");

            textBox1.Text = ("");
            textBox4.Text = ("");
            textBox3.Text = ("");
            textBox5.Text = ("");
            maskedTextBox3.Text = ("");
            maskedTextBox4.Text = ("");
            maskedTextBox5.Text = ("");
            maskedTextBox6.Text = ("");
            textBox2.Text = ("");
            comboBox1.Text = ("");
            maskedTextBox1.Text = ("");
            maskedTextBox2.Text = ("");
            textBox6.Text = ("");
            textBox5.Text = ("");
            textBox7.Text = ("");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == (""))
            {
                textBox1.Text = ("Coloque o ID aqui");

            }

            else
            {
                Construtor mo = new Construtor();
                DAL da = new DAL();
                mo.id = Convert.ToInt16(textBox1.Text);
                mo.nome = textBox2.Text;
                mo.RG = maskedTextBox1.Text;
                mo.endereco = textBox4.Text;
                mo.num_telefone = maskedTextBox5.Text;
                mo.cpf = maskedTextBox2.Text;
                mo.bairro = textBox6.Text;
                mo.num_celular = maskedTextBox6.Text;
                mo.cep = maskedTextBox4.Text;
                mo.cidade = textBox3.Text;
                mo.data_de_nascimento = maskedTextBox3.Text;
                mo.numero = textBox5.Text;
                mo.OBS = textBox7.Text;
                mo.sexo = comboBox1.Text;
                da.Alterar(mo);
                MessageBox.Show("Alterado com Sucesso");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhodb);
            con.Open();
            String op = (String)comboBox2.SelectedItem;
            if ((comboBox2.Text) == (""))
            {
                textBox8.Text = ("Por Favor Escolha uma forma de pesquisa na caixa ao lado");
            }
            else
            {
                switch (op)
                {
                    case "Nome":
                        string pesquisa = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where nome like @valor";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox8.Text + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView1.DataSource = table;
                        con.Close();
                        break;
                    case "CPF":
                        string pesquisa2 = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where CPF like @valor";
                        MySqlDataAdapter ad1 = new MySqlDataAdapter(pesquisa2, con);
                        ad1.SelectCommand.Parameters.AddWithValue("valor", textBox8.Text + "%");
                        DataTable table1 = new DataTable();
                        ad1.Fill(table1);
                        dataGridView1.DataSource = table1;
                        con.Close();
                        break;
                    case "RG":
                        string pesquisa3 = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where RG like @valor";
                        MySqlDataAdapter ad2 = new MySqlDataAdapter(pesquisa3, con);
                        ad2.SelectCommand.Parameters.AddWithValue("valor", textBox8.Text + "%");
                        DataTable table2 = new DataTable();
                        ad2.Fill(table2);
                        dataGridView1.DataSource = table2;
                        con.Close();
                        break;
                    case "Endereço":
                        string pesquisa4 = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where Endereço like @valor";
                        MySqlDataAdapter ad3 = new MySqlDataAdapter(pesquisa4, con);
                        ad3.SelectCommand.Parameters.AddWithValue("valor", textBox8.Text + "%");
                        DataTable table3 = new DataTable();
                        ad3.Fill(table3);
                        dataGridView1.DataSource = table3;
                        con.Close();
                        break;

                }
                dataGridView1.Columns["Nome"].ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Nome";
                dataGridView1.Columns[3].HeaderText = "Endereço";
                dataGridView1.Columns[4].HeaderText = "Telefone Fixo";
                dataGridView1.Columns[7].HeaderText = "Telefone Celular";
                dataGridView1.Columns[9].HeaderText = "Cidade";
                dataGridView1.Columns[10].HeaderText = "Data de Nascimento";
                dataGridView1.Columns[11].HeaderText = "Número da Casa";
                dataGridView1.Columns[12].HeaderText = "Observação";
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox8.Text = ("");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            String caminhodb= "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhodb);
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand("Select ID,nome,rg,endereço,num_telefone,CPF,Bairro,Num_celular,CEP,cidade"
                + ",data_de_nascimento,numero,OBS,sexo from cliente where ID ='" + codigo + "'", cn);
                MySqlDataReader reader = null;
                reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                textBox1.Text = reader.GetString(0);
                textBox2.Text = reader.GetString(1);
                maskedTextBox1.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);
                maskedTextBox5.Text = reader.GetString(4);
                maskedTextBox2.Text = reader.GetString(5);
                textBox6.Text = reader.GetString(6);
                maskedTextBox6.Text = reader.GetString(7);
                maskedTextBox4.Text = reader.GetString(8);
                textBox3.Text = reader.GetString(9);
                maskedTextBox3.Text = reader.GetString(10);
                textBox5.Text = reader.GetString(11);
                textBox7.Text = reader.GetString(12);
                comboBox1.Text = reader.GetString(13);





            }
            cn.Close();
            tabControl1.SelectedTab = tabPage1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }





  
 

