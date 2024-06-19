using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCRUD_DS
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();

            label13.Text = Frm_principal.Func;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhodb);
            con.Open();
            String op = (String)comboBox1.SelectedItem;
            if ((comboBox1.Text) == (""))
            {
                MessageBox.Show("Escolha uma forma de pesquisa");
            }
            else
            {
                switch (op)
                {
                    case "Nome":
                        string pesquisa = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where nome like @valor";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox6.Text + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView1.DataSource = table;
                        con.Close();
                        break;
                    case "CPF":
                        string pesquisa2 = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where CPF like @valor";
                        MySqlDataAdapter ad1 = new MySqlDataAdapter(pesquisa2, con);
                        ad1.SelectCommand.Parameters.AddWithValue("valor", textBox6.Text + "%");
                        DataTable table1 = new DataTable();
                        ad1.Fill(table1);
                        dataGridView1.DataSource = table1;
                        con.Close();
                        break;
                    case "RG":
                        string pesquisa3 = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where RG like @valor";
                        MySqlDataAdapter ad2 = new MySqlDataAdapter(pesquisa3, con);
                        ad2.SelectCommand.Parameters.AddWithValue("valor", textBox6.Text + "%");
                        DataTable table2 = new DataTable();
                        ad2.Fill(table2);
                        dataGridView1.DataSource = table2;
                        con.Close();
                        break;
                    case "Endereço":
                        string pesquisa4 = "select id,nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo from cliente where Endereço like @valor";
                        MySqlDataAdapter ad3 = new MySqlDataAdapter(pesquisa4, con);
                        ad3.SelectCommand.Parameters.AddWithValue("valor", textBox6.Text + "%");
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
        private void button3_Click(object sender, EventArgs e)
        {
            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhodb);
            con.Open();
            String op = (String)comboBox2.SelectedItem;
            if ((comboBox2.Text) == (""))
            {
                MessageBox.Show("Escolha uma forma de pesquisa");
            }
            else
            {
                string status = "Disponivel";
                switch (op)
                {
                    case "Placa":
                        string pesquisa = "select id,Condicao,Marca,Modelo,Ano,Placa,Proprietario,Cor,Portas,Combustivel,Chassi,Renavan,Kilometragem,Valor,Descricao,status from carros where Placa like @valor and status like @valor2";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox7.Text + "%");
                        ad.SelectCommand.Parameters.AddWithValue("valor2", status + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView2.DataSource = table;
                        con.Close();
                        break;



                }
                dataGridView2.Columns["Placa"].ReadOnly = true;
                dataGridView2.Columns[0].HeaderText = "ID";
                dataGridView2.Columns[1].HeaderText = "Condição";
                dataGridView2.Columns[6].HeaderText = "Proprietário";
                dataGridView2.Columns[9].HeaderText = "Combustível";
                dataGridView2.Columns[14].HeaderText = "Descrição";

            }
        }


        private void frm_venda_Load(object sender, EventArgs e)
        {
            comboBox5.Enabled = false;
            textBox9.Enabled = false;
            button8.Enabled = false;
            MaximizeBox = false;
            tabControl1.SelectedTab = tabPage2;
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_de_veiculo menu = new Cadastro_de_veiculo();
            menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string status = "Vendindo", tipo_pag = comboBox4.Text, obs_venda = textBox3.Text, dono_atual = textBox5.Text;
            var data_venda = maskedTextBox1.Text;
            var valor_vendido = textBox8.Text;
            var entrada = textBox2.Text;
            var id = textBox4.Text;
            var id2 = label20.Text;
            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao2 = new MySqlConnection(caminhodb);
            conexao2.Open();
            string alterar2 = "UPDATE carros set ID='" + id + "',status='" + status + "',valor_vendido='" + valor_vendido + "',tipo_pag='" + tipo_pag + "',data_venda='"
                + data_venda + "',obs_venda='" + obs_venda + "',entrada='" + entrada + "',dono_atual='" + dono_atual + "',ID_Dono_Atual='" + id2 + "' where id= '" + id + "';";
            MySqlCommand command2 = new MySqlCommand(alterar2, conexao2);
            MySqlDataReader myreader2;
            myreader2 = command2.ExecuteReader();
            conexao2.Close();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);

            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhodb);
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand("select ID,condicao,marca,modelo,ano,Placa,Proprietario,Cor,Portas,Combustivel,Chassi,Renavan"
                + ",Kilometragem,Valor,Descricao,Foto,Foto2,Foto3,amortecedor,borracharia,documentacao,estofado,funilaria,ipva,lavajato,mecanica,suspencao"
                + ",transporte,volante,total,lucro,lucro_total from carros where ID ='" + codigo + "'", cn);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                //Inserindo os dados do banco de dados nas Combo e textbox;
                textBox4.Text = reader.GetString(0);
                label12.Text = reader.GetString(31);
                textBox1.Text = reader.GetString(12);
            }
            cn.Close();
            tabControl1.SelectedTab = tabPage2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhodb);
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand("Select ID,nome,rg,endereço,num_telefone,CPF,Bairro,Num_celular,CEP,cidade"
                + ",data_de_nascimento,numero,OBS,sexo from cliente where ID ='" + codigo + "'", cn);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                textBox5.Text = reader.GetString(1);
                label20.Text = reader.GetString(0);
            }
            cn.Close();
            tabControl1.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string status = "Trocado", tipo_pag = comboBox4.Text, obs_venda = textBox3.Text, dono_atual = textBox5.Text;
            var data_venda = maskedTextBox1.Text;
            var valor_vendido = textBox8.Text;
            var entrada = textBox2.Text;
            var id = textBox4.Text;
            var id2 = textBox9.Text;
            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao2 = new MySqlConnection(caminhodb);
            conexao2.Open();
            string alterar2 = "UPDATE carros set ID='" + id + "',status='" + status + "' where id= '" + id + "';";
            MySqlCommand command2 = new MySqlCommand(alterar2, conexao2);
            MySqlDataReader myreader2;
            myreader2 = command2.ExecuteReader();
            conexao2.Close();
            conexao2.Open();
            string alterar3 = "UPDATE carros set ID='" + id2 + "',status='" + status + "' where id= '" + id2 + "';";
            MySqlCommand command3 = new MySqlCommand(alterar3, conexao2);
            MySqlDataReader myreader3;
            myreader3 = command3.ExecuteReader();
            conexao2.Close();
            conexao2.Open();

            string inserir = "INSERT INTO troca (Veiculo,Cliente,Data,Valor_Vendido,KM_Saida,Lojista,Entrada,Tipo_pag,Parcela,Obs,Total_parc)"
                + "values (@Veiculo,@Cliente,@Data,@Valor_Vendido,@KM_Saida,@Lojista,@Entrada,@Tipo_pag,@Parcela,@Obs,@Total_parc)";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao2);
            MySqlDataReader reader;

            comandos.Parameters.Add(new MySqlParameter("@Veiculo", textBox4.Text + "-" + textBox9.Text));
            comandos.Parameters.Add(new MySqlParameter("@Cliente", textBox5.Text));
            comandos.Parameters.Add(new MySqlParameter("@Data", maskedTextBox1.Text));
            comandos.Parameters.Add(new MySqlParameter("@Valor_Vendido", textBox8.Text));
            comandos.Parameters.Add(new MySqlParameter("@KM_Saida", textBox1.Text));
            comandos.Parameters.Add(new MySqlParameter("@Lojista", label13.Text));
            comandos.Parameters.Add(new MySqlParameter("@Entrada", textBox2.Text));
            comandos.Parameters.Add(new MySqlParameter("@Tipo_pag", comboBox4.Text));
            comandos.Parameters.Add(new MySqlParameter("@Parcela", comboBox5.Text));
            comandos.Parameters.Add(new MySqlParameter("@Obs", textBox3.Text));
            comandos.Parameters.Add(new MySqlParameter("@Total_parc", label19.Text));
            reader = comandos.ExecuteReader();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = false;
            button8.Enabled = false;
            textBox9.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhodb);
            con.Open();
            String op = (String)comboBox3.SelectedItem;
            if ((comboBox3.Text) == (""))
            {
                MessageBox.Show("Escolha uma forma de pesquisa");
            }
            else
            {
                string status = "Disponivel";
                switch (op)
                {
                    case "Placa":
                        string pesquisa = "select id,Condicao,Marca,Modelo,Ano,Placa,Proprietario,Cor,Portas,Combustivel,Chassi,Renavan,Kilometragem,Valor,Descricao,status from carros where Placa like @valor and status like @valor2";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox7.Text + "%");
                        ad.SelectCommand.Parameters.AddWithValue("valor2", status + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView3.DataSource = table;
                        con.Close();
                        break;


                }
                dataGridView3.Columns["Placa"].ReadOnly = true;
                dataGridView3.Columns[0].HeaderText = "ID";
                dataGridView3.Columns[1].HeaderText = "Condição";
                dataGridView3.Columns[6].HeaderText = "Proprietário";
                dataGridView3.Columns[9].HeaderText = "Combustível";
                dataGridView3.Columns[14].HeaderText = "Descrição";

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(dataGridView3.CurrentRow.Cells[0].Value);

            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection cn = new MySqlConnection(caminhodb);
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand("select ID,condicao,marca,modelo,ano,Placa,Proprietario,Cor,Portas,Combustivel,Chassi,Renavan"
                + ",Kilometragem,Valor,Descricao,Foto,Foto2,Foto3,amortecedor,borracharia,documentacao,estofado,funilaria,ipva,lavajato,mecanica,suspencao"
                + ",transporte,volante,total,lucro,lucro_total from carros where ID ='" + codigo + "'", cn);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                //Inserindo os dados do banco de dados nas Combo e textbox;
                textBox9.Text = reader.GetString(0);
            }
            cn.Close();
            tabControl1.SelectedTab = tabPage2;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == ("Parcelado"))
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox5.Text = "";
            }
            if (comboBox5.Enabled == true)
            {
                button7.Enabled = true;
            }
            else
            {
                button7.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double valor_dono = Convert.ToDouble(textBox8.Text);
                double valor_entrada = Convert.ToDouble(textBox2.Text);
                label17.Text = Convert.ToString(valor_dono - valor_entrada);


                double principal = Convert.ToDouble(label17.Text); //= X;
                double CETam = 0.542; //a.m. //= A;
                double CETaa = 0.12; //a.a. = B;
                double Juros = 6;//= C:
                double IOF = 450; //= Y;
                int meses = Convert.ToInt32(comboBox5.Text); //= Z;
                double total_parcial;

                double Juros_Cthum = (Juros / 100) + 1;

                total_parcial = IOF + (principal * Math.Pow((1 + CETam + CETaa), Juros_Cthum));
                double parcela = total_parcial / meses;
                label19.Text = Convert.ToString(String.Format("{0:N2}", parcela));

                //X = Valor do carro
                //Y = Valor IOF
                //Z = Quantidade de meses
                //A = Juro CET
                //B = Juro CET
                //C = Juros
                //Para A, B, C
                //Valor em % / 100
            }
            catch
            {
                MessageBox.Show("Falta valor");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string status = "Trocado", tipo_pag = comboBox4.Text, obs_venda = textBox3.Text, dono_atual = textBox5.Text;
            var data_venda = maskedTextBox1.Text;
            var valor_vendido = textBox8.Text;
            var entrada = textBox2.Text;
            var id = textBox4.Text;
            var id2 = textBox9.Text;
            String caminhodb = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection conexao2 = new MySqlConnection(caminhodb);
            conexao2.Open();
            string alterar2 = "UPDATE carros set ID='" + id + "',status='" + status + "' where id= '" + id + "';";
            MySqlCommand command2 = new MySqlCommand(alterar2, conexao2);
            MySqlDataReader myreader2;
            myreader2 = command2.ExecuteReader();
            conexao2.Close();
            conexao2.Open();
            string alterar3 = "UPDATE carros set ID='" + id2 + "',status='" + status + "' where id= '" + id2 + "';";
            MySqlCommand command3 = new MySqlCommand(alterar3, conexao2);
            MySqlDataReader myreader3;
            myreader3 = command3.ExecuteReader();
            conexao2.Close();
            conexao2.Open();

            string inserir = "INSERT INTO troca (Veiculo,Cliente,ID_Cliente,Data,Valor_Vendido,KM_Saida,Lojista,Entrada,Tipo_pag,Parcela,Obs,Total_parc)"
                + "values (@Veiculo,@Cliente,@ID_Cliente,@Data,@Valor_Vendido,@KM_Saida,@Lojista,@Entrada,@Tipo_pag,@Parcela,@Obs,@Total_parc)";
            MySqlCommand comandos = new MySqlCommand(inserir, conexao2);
            MySqlDataReader reader;

            comandos.Parameters.Add(new MySqlParameter("@Veiculo", textBox4.Text + "-" + textBox9.Text));
            comandos.Parameters.Add(new MySqlParameter("@Cliente", textBox5.Text));
            comandos.Parameters.Add(new MySqlParameter("@ID_Cliente", label20.Text));
            comandos.Parameters.Add(new MySqlParameter("@Data", maskedTextBox1.Text));
            comandos.Parameters.Add(new MySqlParameter("@Valor_Vendido", textBox8.Text));
            comandos.Parameters.Add(new MySqlParameter("@KM_Saida", textBox1.Text));
            comandos.Parameters.Add(new MySqlParameter("@Lojista", label13.Text));
            comandos.Parameters.Add(new MySqlParameter("@Entrada", textBox2.Text));
            comandos.Parameters.Add(new MySqlParameter("@Tipo_pag", comboBox4.Text));
            comandos.Parameters.Add(new MySqlParameter("@Parcela", comboBox5.Text));
            comandos.Parameters.Add(new MySqlParameter("@Obs", textBox3.Text));
            comandos.Parameters.Add(new MySqlParameter("@Total_parc", label19.Text));
            reader = comandos.ExecuteReader();
            MessageBox.Show("Dados atualizados com sucesso");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox9.Text = "";
            textBox5.Text = "";
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox8.Text = "";
            textBox2.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhodb);
            con.Open();
            String op = (String)comboBox6.SelectedItem;
            if ((comboBox6.Text) == (""))
            {
                MessageBox.Show("Escolha uma forma de pesquisa");
            }
            else
            {
                switch (op)
                {
                    case "ID Veiculo":
                        string pesquisa = "select ID,Veiculo,Cliente,ID_Cliente,Data,Valor_Vendido,KM_Saida,Lojista,Entrada,Tipo_Pag,Parcela,Obs,Total_parc from troca where Veiculo like @valor";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox11.Text + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView4.DataSource = table;
                        con.Close();
                        break;
                }
                dataGridView4.Columns["ID"].ReadOnly = true;
            }
        }
    }
}
