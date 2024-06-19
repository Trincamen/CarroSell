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
    public partial class Frm_principal : Form
    {
        public static String Func;
        public Frm_principal()
        {
            InitializeComponent();

        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientes alunos = new Frm_Clientes();
            alunos.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_Clientes alunos = new Frm_Clientes();
            alunos.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                        
            //Timer Tick Event

            private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Today.ToLongDateString();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }


        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            maskedTextBox1.Text = ("");
            maskedTextBox2.Text = ("");
            textBox1.Text = ("");
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 menu = new AboutBox1();
            menu.Show();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_veiculo menu = new Cadastro_de_veiculo();
            menu.Show();

        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {
            {
                if (button4.Visible == true)
                {
                    maskedTextBox1.Text = maskedTextBox2.Text;
                }
                else{

                }
                String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
                MySqlConnection cn = new MySqlConnection(caminhodb);
                cn.Open();
                MySqlCommand cmd2 = new MySqlCommand("select ID,Login,Password,Nome from adm where Login ='" + textBox1.Text + "'", cn);
                MySqlDataReader reader = null;
                reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    label5.Text = reader.GetString(3);
                }
                cn.Close();



                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM adm where Login =?Login and password  =?password", cn);
                cmd.Parameters.Add("?Login", MySqlDbType.VarChar).Value = textBox1.Text;
                cmd.Parameters.Add("?Password", MySqlDbType.VarChar).Value = maskedTextBox1.Text;
                MySqlDataReader le = null;
                le = cmd.ExecuteReader();
                if (le.Read())
                {
                    toolStripMenuItem2.Visible = true;
                    panel1.Visible = false;
                    maskedTextBox1.Text = ("");
                    maskedTextBox2.Text = ("");
                    textBox1.Text = ("");
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");

                }
            }
        }

        private void Frm_principal_SizeChanged(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (button4.Visible == true)
            {
                maskedTextBox1.Text = maskedTextBox2.Text;
            }
            else
            {

            }
            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhodb);
            //Select do nome
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand("select ID,Login,Password,Nome from usuario where Login ='" + textBox1.Text + "'", cn);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                label5.Text = reader.GetString(3);
                Func = reader.GetString(3);
            }
            cn.Close();

            //Login
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario where Login =?Login and password  =?password", cn);
            cmd.Parameters.Add("?Login", MySqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("?Password", MySqlDbType.VarChar).Value = maskedTextBox1.Text;
            MySqlDataReader le = null;
            le = cmd.ExecuteReader();
            if (le.Read())

            {
                toolStripMenuItem2.Visible = false;
                panel1.Visible = false;
                maskedTextBox1.Text = ("");
                maskedTextBox2.Text = ("");
                textBox1.Text = ("");

            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");

            }
        }

        public void Frm_principal_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var senha=maskedTextBox1.Text;
            maskedTextBox2.Text = senha;
            maskedTextBox2.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var senha = maskedTextBox2.Text;
            maskedTextBox1.Text = senha;
            maskedTextBox2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {



            string message = "Tem certeza que deseja sair?";
            string caption = "Carrosell";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Administrador menu = new Administrador();
            menu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cadastro_de_veiculo menu = new Cadastro_de_veiculo();
            menu.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Cadastro_de_veiculo menu = new Cadastro_de_veiculo();
            menu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_Clientes alunos = new Frm_Clientes();
            alunos.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda menu = new frm_venda();
            menu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AboutBox1 menu = new AboutBox1();
            menu.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_venda menu = new frm_venda();
            menu.Show();
        }
    }
    }

    

