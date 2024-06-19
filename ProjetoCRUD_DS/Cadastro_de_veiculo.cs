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
    public partial class Cadastro_de_veiculo : Form
    {
        public Cadastro_de_veiculo()
        {
            InitializeComponent();
        }
        private void Cadastro_de_veiculo_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Volkswagen")
            {
                comboBox2.Items.Add("Amarok");
                comboBox2.Items.Add("Crossfox");
                comboBox2.Items.Add("Fox");
                comboBox2.Items.Add("Gol");
                comboBox2.Items.Add("Gol G4");
                comboBox2.Items.Add("Golf");
                comboBox2.Items.Add("Jetta");
                comboBox2.Items.Add("Jetta Variant");
                comboBox2.Items.Add("Kombi");
                comboBox2.Items.Add("Parati");
                comboBox2.Items.Add("Passat");
                comboBox2.Items.Add("Passat Variant");
                comboBox2.Items.Add("Polo");
                comboBox2.Items.Add("Polo Sedan");
                comboBox2.Items.Add("Saveiro");
                comboBox2.Items.Add("Space Cross");
                comboBox2.Items.Add("SpaceFox");
                comboBox2.Items.Add("Tiguan");
                comboBox2.Items.Add("Up!");
                comboBox2.Items.Add("Voyage");
            }
            if (comboBox1.Text == "Agrale")
            {

                comboBox2.Items.Add("Marruá");
            }

            if (comboBox1.Text == "Aston Martin")
            {
                comboBox2.Items.Add("DB9 Volante");
                comboBox2.Items.Add("DBS Coupe");
                comboBox2.Items.Add("DBS Volante");
                comboBox2.Items.Add("Rapide");
                comboBox2.Items.Add("V12 Vantage Coupe");
                comboBox2.Items.Add("V8 Vantage Coupe");
                comboBox2.Items.Add("V12 Vantage Coupe");
                comboBox2.Items.Add("V8 Vantage Coupe");
                comboBox2.Items.Add("V8 Vantage Roadster");
                comboBox2.Items.Add("Virage");
            }

            if (comboBox1.Text == "Audi")
            {
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A3");
                comboBox2.Items.Add("A3 Sedan");
                comboBox2.Items.Add("A4 Avant");
                comboBox2.Items.Add("A4 Sedã");
                comboBox2.Items.Add("A5");
                comboBox2.Items.Add("A7");
                comboBox2.Items.Add("A8");
                comboBox2.Items.Add("Q3");
                comboBox2.Items.Add("Q5");
                comboBox2.Items.Add("Q7");
                comboBox2.Items.Add("R8");
                comboBox2.Items.Add("R8 GT");
                comboBox2.Items.Add("RS 3 Sportback");
                comboBox2.Items.Add("RS 5");
                comboBox2.Items.Add("RS6 Avant");
                comboBox2.Items.Add("TT Coupé");
                comboBox2.Items.Add("TT Roadster");

            }
            if (comboBox1.Text == "Bentley")
            {
                comboBox2.Items.Add("Continental Flying Spur");
                comboBox2.Items.Add("Continental Supersports Coupé");

            }
            if (comboBox1.Text == "BMW")
            {
                comboBox2.Items.Add("Série 1");
                comboBox2.Items.Add("Série 1 Cabrio");
                comboBox2.Items.Add("Série 1 Coupé");
                comboBox2.Items.Add("Série 1 M");
                comboBox2.Items.Add("Série 3 Cabrio");
                comboBox2.Items.Add("Série 3 M3 Coupé");
                comboBox2.Items.Add("Série 3 M3 Sedã");
                comboBox2.Items.Add("Série 3 Sedã");
                comboBox2.Items.Add("Série 5 Gran Turismo");
                comboBox2.Items.Add("Série 5 Sedã");
                comboBox2.Items.Add("Série 7 Sedã");
                comboBox2.Items.Add("X1");
                comboBox2.Items.Add("X3");
                comboBox2.Items.Add("X5");
                comboBox2.Items.Add("X6");
                comboBox2.Items.Add("Z4 Roadster");
                comboBox2.Items.Add("i3");
            }
            if (comboBox1.Text == "Changan")
            {
                comboBox2.Items.Add("Chana Cargo");
                comboBox2.Items.Add("Chana Family");
                comboBox2.Items.Add("Chana Utility");
            }
            if (comboBox1.Text == "Chery")
            {
                comboBox2.Items.Add("Celer Hatch");
                comboBox2.Items.Add("Celer Sedan");
                comboBox2.Items.Add("Cielo Hatch");
                comboBox2.Items.Add("Cielo Sedan");
                comboBox2.Items.Add("Face");
                comboBox2.Items.Add("QQ");
                comboBox2.Items.Add("S-18");
                comboBox2.Items.Add("Tiggo");
            }
            if (comboBox1.Text == "GM/Chevrolet")
            {
                comboBox2.Items.Add("Agile");
                comboBox2.Items.Add("Astra Hatch");
                comboBox2.Items.Add("Astra Sedan");
                comboBox2.Items.Add("Blazer");
                comboBox2.Items.Add("Camaro");
                comboBox2.Items.Add("Captiva");
                comboBox2.Items.Add("Celta");
                comboBox2.Items.Add("Classic");
                comboBox2.Items.Add("Cobalt");
                comboBox2.Items.Add("Corsa Hatch");
                comboBox2.Items.Add("Corsa Sedã");
                comboBox2.Items.Add("Cruze");
                comboBox2.Items.Add("Cruze Sport");
                comboBox2.Items.Add("Malibu");
                comboBox2.Items.Add("Meriva");
                comboBox2.Items.Add("Montana");
                comboBox2.Items.Add("Omega");
                comboBox2.Items.Add("Onix");
                comboBox2.Items.Add("Prisma");
                comboBox2.Items.Add("S10");
                comboBox2.Items.Add("Sonic");
                comboBox2.Items.Add("Spin");
                comboBox2.Items.Add("Tracker");
                comboBox2.Items.Add("Trailblazer");
                comboBox2.Items.Add("Vectra");
                comboBox2.Items.Add("Vectra GT");
                comboBox2.Items.Add("Zafira");
            }
            if (comboBox1.Text == "Chrysler")
            {
                comboBox2.Items.Add("300C");
                comboBox2.Items.Add("Town & Country");
            }
            if (comboBox1.Text == "Citroën")
            {
                comboBox2.Items.Add("Aircross");
                comboBox2.Items.Add("C3");
                comboBox2.Items.Add("C3 Picasso");
                comboBox2.Items.Add("C4");
                comboBox2.Items.Add("C4 Lounge");
                comboBox2.Items.Add("C4 Pallas");
                comboBox2.Items.Add("C4 Picasso");
                comboBox2.Items.Add("C5");
                comboBox2.Items.Add("C5 Tourer");
                comboBox2.Items.Add("DS3");
                comboBox2.Items.Add("DS5");
                comboBox2.Items.Add("Jumper");
                comboBox2.Items.Add("Xsara Picasso");

            }
            if (comboBox1.Text == "Dodge")
            {
                comboBox2.Items.Add("Durango");
                comboBox2.Items.Add("Journey");
            }
            if (comboBox1.Text == "Effa")
            {
                comboBox2.Items.Add("Effa Hafei Furgão");
                comboBox2.Items.Add("Effa Hafei Picape Baú");
                comboBox2.Items.Add("Effa Hafei Picape Cabine Dupla");
                comboBox2.Items.Add("Effa Hafei Picape Cabine Simples");
                comboBox2.Items.Add("Effa Hafei Van");
                comboBox2.Items.Add("Effa M100");
                comboBox2.Items.Add("S-18");
                comboBox2.Items.Add("Tiggo");
            }

            if (comboBox1.Text == "Fiat")
            {
                comboBox2.Items.Add("500");
                comboBox2.Items.Add("500 Abarth");
                comboBox2.Items.Add("Bravo");
                comboBox2.Items.Add("Blazer");
                comboBox2.Items.Add("Doblò");
                comboBox2.Items.Add("Doblò Cargo");
                comboBox2.Items.Add("Ducato");
                comboBox2.Items.Add("Fiat Mobi");
                comboBox2.Items.Add("Fiat Toro");
                comboBox2.Items.Add("Fiorino");
                comboBox2.Items.Add("Freemont");
                comboBox2.Items.Add("Idea");
                comboBox2.Items.Add("Linea");
                comboBox2.Items.Add("Mille");
                comboBox2.Items.Add("Palio");
                comboBox2.Items.Add("Palio Adventure");
                comboBox2.Items.Add("Palio Weekend");
                comboBox2.Items.Add("Punto");
                comboBox2.Items.Add("Siena EL");
                comboBox2.Items.Add("Strada");
                comboBox2.Items.Add("Uno");
            }
            if (comboBox1.Text == "Ford")
            {
                comboBox2.Items.Add("Courier");
                comboBox2.Items.Add("EcoSport");
                comboBox2.Items.Add("Edge");
                comboBox2.Items.Add("F-250");
                comboBox2.Items.Add("Fiesta Rocam Hatch");
                comboBox2.Items.Add("Fiesta Rocam Sedan");
                comboBox2.Items.Add("Focus Fastback");
                comboBox2.Items.Add("Focus Hatch");
                comboBox2.Items.Add("Fusion");
                comboBox2.Items.Add("Ka");
                comboBox2.Items.Add("Ka+");
                comboBox2.Items.Add("New Fiesta");
                comboBox2.Items.Add("New Fiesta Hatch");
                comboBox2.Items.Add("Transit");
            }
            if (comboBox1.Text == "Geely")
            {
                comboBox2.Items.Add("EC7");
                comboBox2.Items.Add("GC2");
            }
            if (comboBox1.Text == "Hafei")
            {
                comboBox2.Items.Add("Pick-up");
                comboBox2.Items.Add("Towner Furgão");
                comboBox2.Items.Add("Towner Jr");
                comboBox2.Items.Add("Towner Passageiro");
            }
            if (comboBox1.Text == "Honda")
            {
                comboBox2.Items.Add("Accord");
                comboBox2.Items.Add("City");
                comboBox2.Items.Add("Civic");
                comboBox2.Items.Add("Civic Si");
                comboBox2.Items.Add("CR-V");
                comboBox2.Items.Add("Fit");
                comboBox2.Items.Add("HR-V");
            }
            if (comboBox1.Text == "Hyundai")
            {
                comboBox2.Items.Add("Azera");
                comboBox2.Items.Add("Elantra");
                comboBox2.Items.Add("Equus");
                comboBox2.Items.Add("HB20");
                comboBox2.Items.Add("HB20S");
                comboBox2.Items.Add("HB20X");
                comboBox2.Items.Add("HR");
                comboBox2.Items.Add("Santa Fe");
                comboBox2.Items.Add("Sonata");
                comboBox2.Items.Add("Tucson");
                comboBox2.Items.Add("Veloster");
                comboBox2.Items.Add("Veracruz");
                comboBox2.Items.Add("i30");
                comboBox2.Items.Add("i30 CW");
                comboBox2.Items.Add("iX35");
            }
            if (comboBox1.Text == "Iveco")
            {
                comboBox2.Items.Add("Daily 35S14");
            }
            if (comboBox1.Text == "Jac Motors")
            {
                comboBox2.Items.Add("J2");
                comboBox2.Items.Add("J3");
                comboBox2.Items.Add("J3 Turin");
                comboBox2.Items.Add("J5");
                comboBox2.Items.Add("J6");
                comboBox2.Items.Add("T5");
                comboBox2.Items.Add("T6");
            }
            if (comboBox1.Text == "Jaguar")
            {
                comboBox2.Items.Add("F-Type Coupé");
                comboBox2.Items.Add("XF");
                comboBox2.Items.Add("XJ Supersport");
                comboBox2.Items.Add("XKR");
            }
            if (comboBox1.Text == "Jeep")
            {
                comboBox2.Items.Add("Cherokee");
                comboBox2.Items.Add("Grand Cherokee");
                comboBox2.Items.Add("Jeep Renegade");
                comboBox2.Items.Add("Wrangler");
            }
            if (comboBox1.Text == "Jinbei")
            {
                comboBox2.Items.Add("Topic Furgão");
                comboBox2.Items.Add("Topic Passageiro");
            }
            if (comboBox1.Text == "Kia")
            {
                comboBox2.Items.Add("Bongo");
                comboBox2.Items.Add("Cadenza");
                comboBox2.Items.Add("Carens");
                comboBox2.Items.Add("Carnival");
                comboBox2.Items.Add("Cerato");
                comboBox2.Items.Add("Mohave");
                comboBox2.Items.Add("Optima");
                comboBox2.Items.Add("Picanto");
                comboBox2.Items.Add("Sorento");
                comboBox2.Items.Add("Soul");
                comboBox2.Items.Add("Sportage");
            }
            if (comboBox1.Text == "Land Rover")
            {
                comboBox2.Items.Add("Defender");
                comboBox2.Items.Add("Discovery 4");
                comboBox2.Items.Add("Discovery Sport");
                comboBox2.Items.Add("Freelander 2");
                comboBox2.Items.Add("Range Rover Evoque");
                comboBox2.Items.Add("Range Rover Sport");
                comboBox2.Items.Add("Range Rover Vogue");
            }
            if (comboBox1.Text == "Lexus")
            {
                comboBox2.Items.Add("NX 200t");
            }
            if (comboBox1.Text == "Lifan")
            {
                comboBox2.Items.Add("320");
                comboBox2.Items.Add("530");
                comboBox2.Items.Add("620");
                comboBox2.Items.Add("X60");
            }
            if (comboBox1.Text == "Mahindra")
            {
                comboBox2.Items.Add("Mahindra Picape");
                comboBox2.Items.Add("Mahindra SUV");
            }
            if (comboBox1.Text == "Mercedes-Benz")
            {
                comboBox2.Items.Add("CLA");
                comboBox2.Items.Add("Classe A");
                comboBox2.Items.Add("Classe B");
                comboBox2.Items.Add("Classe C");
                comboBox2.Items.Add("Classe C 250 Turbo Sport");
                comboBox2.Items.Add("Classe C 63 AMG Touring");
                comboBox2.Items.Add("Classe CL");
                comboBox2.Items.Add("Classe CLS 63 AMG");
                comboBox2.Items.Add("Classe E");
                comboBox2.Items.Add("Classe G");
                comboBox2.Items.Add("Classe GL");
                comboBox2.Items.Add("Classe GLK");
                comboBox2.Items.Add("Classe M");
                comboBox2.Items.Add("Classe S");
                comboBox2.Items.Add("Classe S 400 Hybrid");
                comboBox2.Items.Add("Classe SLK");
                comboBox2.Items.Add("Classe SLS AMG");
                comboBox2.Items.Add("GLA");
                comboBox2.Items.Add("GLC");
                comboBox2.Items.Add("GLE Coupé");
            }
            if (comboBox1.Text == "MG Motors")
            {
                comboBox2.Items.Add("MG 550");
                comboBox2.Items.Add("MG 6");
            }
            if (comboBox1.Text == "MG Motors")
            {
                comboBox2.Items.Add("Cooper");
                comboBox2.Items.Add("Cooper Cabrio");
                comboBox2.Items.Add("Cooper Countryman");
                comboBox2.Items.Add("Cooper S Clubman-Hampton");
                comboBox2.Items.Add("Mini Clubman");
                comboBox2.Items.Add("One");
            }
            if (comboBox1.Text == "Mitsubishi")
            {
                comboBox2.Items.Add("ASX");
                comboBox2.Items.Add("L200 Outdoor");
                comboBox2.Items.Add("L200 Savana");
                comboBox2.Items.Add("L200 Triton");
                comboBox2.Items.Add("Lancer Evolution X");
                comboBox2.Items.Add("Outlander");
                comboBox2.Items.Add("Pajero Dakar");
                comboBox2.Items.Add("Pajero Full");
                comboBox2.Items.Add("Pajero Sport");
                comboBox2.Items.Add("Pajero TR4");
            }
            if (comboBox1.Text == "Nissan")
            {
                comboBox2.Items.Add("Altima");
                comboBox2.Items.Add("Frontier");
                comboBox2.Items.Add("Grand Livina");
                comboBox2.Items.Add("Kicks");
                comboBox2.Items.Add("Livina");
                comboBox2.Items.Add("March");
                comboBox2.Items.Add("Sentra");
                comboBox2.Items.Add("Tiida Hatch");
                comboBox2.Items.Add("Tiida Sedan");
                comboBox2.Items.Add("Versa");
            }
            if (comboBox1.Text == "Peugeot")
            {
                comboBox2.Items.Add("2008");
                comboBox2.Items.Add("207");
                comboBox2.Items.Add("207 SW");
                comboBox2.Items.Add("207 Sedan");
                comboBox2.Items.Add("208");
                comboBox2.Items.Add("3008");
                comboBox2.Items.Add("307");
                comboBox2.Items.Add("308");
                comboBox2.Items.Add("308 CC");
                comboBox2.Items.Add("408");
                comboBox2.Items.Add("508");
                comboBox2.Items.Add("Boxer");
                comboBox2.Items.Add("Hoggar");
                comboBox2.Items.Add("Partner");
                comboBox2.Items.Add("RCZ");
            }
            if (comboBox1.Text == "Ram")
            {
                comboBox2.Items.Add("2500");
            }
            if (comboBox1.Text == "Renault")
            {
                comboBox2.Items.Add("Clio");
                comboBox2.Items.Add("Duster");
                comboBox2.Items.Add("Fluence");
                comboBox2.Items.Add("Grand Tour");
                comboBox2.Items.Add("Kangoo Express");
                comboBox2.Items.Add("Logan");
                comboBox2.Items.Add("Master");
                comboBox2.Items.Add("Oroch");
                comboBox2.Items.Add("Sandero");
                comboBox2.Items.Add("Sandero RS");
                comboBox2.Items.Add("Sandero Stepway");
                comboBox2.Items.Add("Symbol");
            }
            if (comboBox1.Text == "Smart")
            {
                comboBox2.Items.Add("Fortwo MHD");
                comboBox2.Items.Add("Fortwo Passion Cabrio");
                comboBox2.Items.Add("Fortwo Passion Coupé");
            }
            if (comboBox1.Text == "Ssangyong")
            {
                comboBox2.Items.Add("Actyon Sports");
                comboBox2.Items.Add("Korando");
                comboBox2.Items.Add("Kyron");
            }
            if (comboBox1.Text == "Suburu")
            {
                comboBox2.Items.Add("Forester");
                comboBox2.Items.Add("Impreza Hatch");
                comboBox2.Items.Add("Impreza Sedã");
                comboBox2.Items.Add("Legacy");
                comboBox2.Items.Add("Outback");
                comboBox2.Items.Add("Tribeca");
            }
            if (comboBox1.Text == "Suzuki")
            {
                comboBox2.Items.Add("Grand Vitara");
                comboBox2.Items.Add("Jimny");
                comboBox2.Items.Add("SX4");
            }
            if (comboBox1.Text == "Toyota")
            {
                comboBox2.Items.Add("Camry");
                comboBox2.Items.Add("Corolla");
                comboBox2.Items.Add("Etios Hatch");
                comboBox2.Items.Add("Etios Sedã");
                comboBox2.Items.Add("Hilux");
                comboBox2.Items.Add("Prius");
                comboBox2.Items.Add("RAV4");
                comboBox2.Items.Add("SW4");
            }
            if (comboBox1.Text == "Troller")
            {
                comboBox2.Items.Add("T4");
            }
            if (comboBox1.Text == "Volvo")
            {
                comboBox2.Items.Add("C30");
                comboBox2.Items.Add("S60");
                comboBox2.Items.Add("V40");
                comboBox2.Items.Add("XC60");
                comboBox2.Items.Add("XC90");
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBox5.Text = picPath;
                pictureBox1.ImageLocation = picPath;
                pictureBox4.Visible = false;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" & textBox6.Text !="" & textBox7.Text !="")
            {
                byte[] imageBT = null;
                FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);

                byte[] imageBT2 = null;
                FileStream fstream2 = new FileStream(this.textBox6.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br2 = new BinaryReader(fstream2);
                imageBT2 = br2.ReadBytes((int)fstream2.Length);

                byte[] imageBT3 = null;
                FileStream fstream3 = new FileStream(this.textBox7.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br3 = new BinaryReader(fstream3);
                imageBT3 = br3.ReadBytes((int)fstream3.Length);

                String condicao, marca, modelo, ano, placa, proprietario, cor, portas, combustivel, descricao = null,status ="Disponivel";
                var chassi = textBox10.Text;
                var renavan = maskedTextBox2.Text;
                var kilometragem = maskedTextBox4.Text;
                var Valor = maskedTextBox16.Text;
                var amortecedor = maskedTextBox3.Text;
                var borracharia = maskedTextBox5.Text;
                var documentacao = maskedTextBox6.Text;
                var estofado = maskedTextBox7.Text;
                var funilaria = maskedTextBox8.Text;
                var ipva = maskedTextBox9.Text;
                var lavajato = maskedTextBox10.Text;
                var mecanica = maskedTextBox11.Text;
                var suspencao = maskedTextBox12.Text;
                var transporte = maskedTextBox13.Text;
                var volante = maskedTextBox14.Text;
                var totaldespesas = label14.Text;
                var lucro = textBox4.Text;
                var lucrototal = label29.Text;
                condicao = comboBox6.Text;
                marca = comboBox1.Text;
                modelo = comboBox2.Text;
                ano = comboBox3.Text;
                placa = maskedTextBox1.Text;
                proprietario = textBox1.Text;
                cor = textBox2.Text;
                portas = comboBox4.Text;
                combustivel = comboBox5.Text;
                descricao = textBox3.Text;


                String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";

                try
                {
                    MySqlConnection conexao = new MySqlConnection(caminhobd);
                    conexao.Open();

                    string inserir = "INSERT INTO carros (condicao,marca,modelo,ano,placa,proprietario,cor,portas,combustivel,chassi,renavan,kilometragem,valor,descricao,foto,foto2,foto3," +
                    "amortecedor,borracharia,documentacao,estofado,funilaria,ipva,lavajato,mecanica,suspencao,transporte,volante,total,lucro,lucro_total,status)"
                        + "values (@condicao,@marca,@modelo,@ano,@placa,@proprietario,@cor,@portas,@combustivel,@chassi,@renavan,@kilometragem,@valor,@descricao,@img,@img2,@img3," +
                        "@amortecedor,@borracharia,@documentacao,@estofado,@funilaria,@ipva,@lavajato,@mecanica,@suspencao,@transporte,@volante,@total,@lucro,@lucro_total,@status)";
                    MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                    MySqlDataReader reader;

                    comandos.Parameters.Add(new MySqlParameter("@condicao", condicao));
                    comandos.Parameters.Add(new MySqlParameter("@marca", marca));
                    comandos.Parameters.Add(new MySqlParameter("@modelo", modelo));
                    comandos.Parameters.Add(new MySqlParameter("@ano", ano));
                    comandos.Parameters.Add(new MySqlParameter("@placa", placa));
                    comandos.Parameters.Add(new MySqlParameter("@proprietario", proprietario));
                    comandos.Parameters.Add(new MySqlParameter("@cor", cor));
                    comandos.Parameters.Add(new MySqlParameter("@portas", portas));
                    comandos.Parameters.Add(new MySqlParameter("@combustivel", combustivel));
                    comandos.Parameters.Add(new MySqlParameter("@chassi", chassi));
                    comandos.Parameters.Add(new MySqlParameter("@renavan", renavan));
                    comandos.Parameters.Add(new MySqlParameter("@kilometragem", kilometragem));
                    comandos.Parameters.Add(new MySqlParameter("@valor", Valor));
                    comandos.Parameters.Add(new MySqlParameter("@descricao", descricao));
                    comandos.Parameters.Add(new MySqlParameter("@img", imageBT));
                    comandos.Parameters.Add(new MySqlParameter("@img2", imageBT2));
                    comandos.Parameters.Add(new MySqlParameter("@img3", imageBT3));
                    comandos.Parameters.Add(new MySqlParameter("@amortecedor", amortecedor));
                    comandos.Parameters.Add(new MySqlParameter("@borracharia", borracharia));
                    comandos.Parameters.Add(new MySqlParameter("@documentacao", documentacao));
                    comandos.Parameters.Add(new MySqlParameter("@estofado", estofado));
                    comandos.Parameters.Add(new MySqlParameter("@funilaria", funilaria));
                    comandos.Parameters.Add(new MySqlParameter("@ipva", ipva));
                    comandos.Parameters.Add(new MySqlParameter("@lavajato", lavajato));
                    comandos.Parameters.Add(new MySqlParameter("@mecanica", suspencao));
                    comandos.Parameters.Add(new MySqlParameter("@suspencao", suspencao));
                    comandos.Parameters.Add(new MySqlParameter("@transporte", transporte));
                    comandos.Parameters.Add(new MySqlParameter("@volante", volante));
                    comandos.Parameters.Add(new MySqlParameter("@total", totaldespesas));
                    comandos.Parameters.Add(new MySqlParameter("@lucro", lucro));
                    comandos.Parameters.Add(new MySqlParameter("@lucro_total", lucrototal));
                    comandos.Parameters.Add(new MySqlParameter("@status", status));


                    reader = comandos.ExecuteReader();
                    MessageBox.Show("Cadastro do veiculo feito com sucesso!!");
                    conexao.Close();

                }

                catch (Exception ex)
                {
                    throw new Exception("Erro de comandos" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Adicione as imagens");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBox6.Text = picPath;
                pictureBox2.ImageLocation = picPath;
                pictureBox5.Visible = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBox7.Text = picPath;
                pictureBox3.ImageLocation = picPath;
                pictureBox6.Visible = false;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Construtor2 mo2 = new Construtor2();
            DAL da2 = new DAL();
            //mo2.id = Convert.ToInt16(textBox8.Text);
            mo2.condicao = comboBox6.Text;
            mo2.marca_do_veiculo = comboBox1.Text;
            mo2.modelo_do_veiculo = comboBox2.Text;
            mo2.ano_do_veiculo = comboBox3.Text;
            mo2.placa_do_carro = maskedTextBox1.Text;
            mo2.dono_anterior = textBox1.Text;
            mo2.cor_veiculo = textBox2.Text;
            mo2.num_portas = comboBox4.Text;
            mo2.combustivel = comboBox5.Text;
            mo2.chassi = textBox10.Text;
            mo2.renavan = maskedTextBox2.Text;
            mo2.kilometragem = maskedTextBox4.Text;
            mo2.preço = maskedTextBox16.Text;
            mo2.Descricao = textBox3.Text;

            da2.Adicionar2(mo2);
            MessageBox.Show("Dados gravados com sucesso");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox8.Text == (""))
            {
                MessageBox.Show("Insira o ID antes de atualizar os dados");
            }

            else
            {
                String condicao, marca, modelo, ano, placa, proprietario, cor, portas, combustivel, descricao = null;
                var chassi = textBox10.Text;
                var renavan = maskedTextBox2.Text;
                var kilometragem = maskedTextBox4.Text;
                var Valor = maskedTextBox16.Text;
                var id = textBox8.Text;
                var foto1 = textBox5.Text;
                var foto2 = textBox6.Text;
                var foto3 = textBox7.Text;
                condicao = comboBox6.Text;
                marca = comboBox1.Text;
                modelo = comboBox2.Text;
                ano = comboBox3.Text;
                placa = maskedTextBox1.Text;
                proprietario = textBox1.Text;
                cor = textBox2.Text;
                portas = comboBox4.Text;
                combustivel = comboBox5.Text;
                descricao = textBox3.Text;



                String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
                try
                {
                    //caso o valor dentro das textbox 5,6 e 7 seja vazio ele vai executar o if
                    if (((foto1) == ("") & (foto2) == ("")) & (foto3) == (""))
                    {

                        MySqlConnection conexao2 = new MySqlConnection(caminhobd);
                        conexao2.Open();
                        string alterar2 = "UPDATE carros set ID='" + id + "',Condicao='" + condicao + "',marca='" + marca + "',modelo='"
                            + modelo + "',Ano='" + ano + "',Placa='" + placa + "',Proprietario='" + proprietario + "',cor='"
                            + cor + "',Portas='" + portas +
                            "',Combustivel='" + combustivel + "',Chassi='" + chassi + "',Renavan='" + renavan + "',Kilometragem='"
                            + kilometragem + "',valor='" + Valor + "',descricao='" + descricao + "' where id= '" + id + "';";
                        MySqlCommand command2 = new MySqlCommand(alterar2, conexao2);
                        MySqlDataReader myreader2;
                        myreader2 = command2.ExecuteReader();
                        conexao2.Close();
                        textBox5.Text = ("");
                        textBox6.Text = ("");
                        textBox7.Text = ("");
                        MessageBox.Show("Dados atualizados com sucesso");


                    }
                    else
                    {




                        MySqlConnection conexao = new MySqlConnection(caminhobd);
                        //delete
                        conexao.Open();
                        string deletar2 = "Delete From Carros where id=" + id;
                        MySqlCommand command = new MySqlCommand(deletar2, conexao);
                        MySqlDataReader myreader;
                        myreader = command.ExecuteReader();
                        conexao.Close();

                        //insert

                        if (foto1 == (""))
                        {
                            MessageBox.Show("Insira imagem 1");
                            pictureBox4.Visible = true;
                        }
                        else if (foto2 == (""))
                        {
                            MessageBox.Show("Insira imagem 2");
                            pictureBox5.Visible = true;

                        }
                        else if (foto3 == (""))
                        {
                            MessageBox.Show("Insira imagem 3");
                            pictureBox6.Visible = true;
                        }
                        else
                        {
                            byte[] imageBT = null;
                            FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fstream);
                            imageBT = br.ReadBytes((int)fstream.Length);

                            byte[] imageBT2 = null;
                            FileStream fstream2 = new FileStream(this.textBox6.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br2 = new BinaryReader(fstream2);
                            imageBT2 = br2.ReadBytes((int)fstream2.Length);

                            byte[] imageBT3 = null;
                            FileStream fstream3 = new FileStream(this.textBox7.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br3 = new BinaryReader(fstream3);
                            imageBT3 = br3.ReadBytes((int)fstream3.Length);

                            conexao.Open();
                            string inserir = "INSERT INTO carros (condicao,marca,modelo,ano,placa,proprietario,cor,portas,combustivel,chassi,renavan,kilometragem,valor,descricao,foto,foto2,foto3)"
                                + "values (@condicao,@marca,@modelo,@ano,@placa,@proprietario,@cor,@portas,@combustivel,@chassi,@renavan,@kilometragem,@valor,@descricao,@img,@img2,@img3)";
                            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                            MySqlDataReader reader;

                            comandos.Parameters.Add(new MySqlParameter("@condicao", condicao));
                            comandos.Parameters.Add(new MySqlParameter("@marca", marca));
                            comandos.Parameters.Add(new MySqlParameter("@modelo", modelo));
                            comandos.Parameters.Add(new MySqlParameter("@ano", ano));
                            comandos.Parameters.Add(new MySqlParameter("@placa", placa));
                            comandos.Parameters.Add(new MySqlParameter("@proprietario", proprietario));
                            comandos.Parameters.Add(new MySqlParameter("@cor", cor));
                            comandos.Parameters.Add(new MySqlParameter("@portas", portas));
                            comandos.Parameters.Add(new MySqlParameter("@combustivel", combustivel));
                            comandos.Parameters.Add(new MySqlParameter("@chassi", chassi));
                            comandos.Parameters.Add(new MySqlParameter("@renavan", renavan));
                            comandos.Parameters.Add(new MySqlParameter("@kilometragem", kilometragem));
                            comandos.Parameters.Add(new MySqlParameter("@valor", Valor));
                            comandos.Parameters.Add(new MySqlParameter("@descricao", descricao));
                            comandos.Parameters.Add(new MySqlParameter("@img", imageBT));
                            comandos.Parameters.Add(new MySqlParameter("@img2", imageBT2));
                            comandos.Parameters.Add(new MySqlParameter("@img3", imageBT3));


                            reader = comandos.ExecuteReader();
                            conexao.Close();
                            textBox5.Text = ("");
                            textBox6.Text = ("");
                            textBox7.Text = ("");
                            MessageBox.Show("Dados Atualizados com sucesso!!");

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro de comandos" + ex.Message);

                }

            }
            //fim do update
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Construtor2 mo2 = new Construtor2();
            DAL da2 = new DAL();
            mo2.id = Convert.ToInt16(textBox8.Text);
            mo2.condicao = comboBox6.Text;
            mo2.marca_do_veiculo = comboBox1.Text;
            mo2.modelo_do_veiculo = comboBox2.Text;
            mo2.ano_do_veiculo = comboBox3.Text;
            mo2.placa_do_carro = maskedTextBox1.Text;
            mo2.dono_anterior = textBox1.Text;
            mo2.cor_veiculo = textBox2.Text;
            mo2.num_portas = comboBox4.Text;
            mo2.combustivel = comboBox5.Text;
            mo2.chassi = textBox10.Text;
            mo2.renavan = maskedTextBox2.Text;
            mo2.kilometragem = maskedTextBox4.Text;
            mo2.preço = maskedTextBox16.Text;
            mo2.Descricao = textBox3.Text;
            da2.Deletar2(mo2);
            MessageBox.Show("Deletado com Sucesso");
            textBox8.Text = ("");
            comboBox6.Text = ("");
            comboBox1.Text = ("");
            comboBox2.Text = ("");
            comboBox3.Text = ("");
            maskedTextBox1.Text = ("");
            textBox1.Text = ("");
            textBox2.Text = ("");
            comboBox4.Text = ("");
            comboBox5.Text = ("");
            textBox10.Text = ("");
            maskedTextBox2.Text = ("");
            maskedTextBox4.Text = ("");
            maskedTextBox16.Text = ("");
            textBox3.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            textBox7.Text = ("");
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            maskedTextBox3.Text = ("");
            maskedTextBox5.Text = ("");
            maskedTextBox6.Text = ("");
            maskedTextBox7.Text = ("");
            maskedTextBox8.Text = ("");
            maskedTextBox9.Text = ("");
            maskedTextBox10.Text = ("");
            maskedTextBox11.Text = ("");
            maskedTextBox12.Text = ("");
            maskedTextBox13.Text = ("");
            maskedTextBox14.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            maskedTextBox16.Text = ("");
            label14.Text = ("");
            label29.Text = ("");

        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox8.Text = ("");
            comboBox6.Text = ("");
            comboBox1.Text = ("");
            comboBox2.Text = ("");
            comboBox3.Text = ("");
            maskedTextBox1.Text = ("");
            textBox1.Text = ("");
            textBox2.Text = ("");
            comboBox4.Text = ("");
            comboBox5.Text = ("");
            textBox10.Text = ("");
            maskedTextBox2.Text = ("");
            maskedTextBox4.Text = ("");
            maskedTextBox16.Text = ("");
            textBox3.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            textBox7.Text = ("");
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.MaxLength = 17;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String caminhodb = "Server = 127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhodb);
            con.Open();
            String op = (String)comboBox7.SelectedItem;
            if ((comboBox7.Text) == (""))
            {
                MessageBox.Show("Escolha uma forma de pesquisa");
            }
            else
            {
                switch (op)
                {
                    case "Placa":
                        string pesquisa = "select id,Condicao,Marca,Modelo,Ano,Placa,Proprietario,Cor,Portas,Combustivel,Chassi,Renavan,Kilometragem,Valor,Descricao from carros where Placa like @valor";
                        MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                        ad.SelectCommand.Parameters.AddWithValue("valor", textBox11.Text + "%");
                        DataTable table = new DataTable();
                        ad.Fill(table);
                        dataGridView1.DataSource = table;
                        con.Close();
                        break;


                }
                dataGridView1.Columns["Placa"].ReadOnly = true;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Condição";
                dataGridView1.Columns[6].HeaderText = "Proprietário";
                dataGridView1.Columns[9].HeaderText = "Combustível";
                dataGridView1.Columns[14].HeaderText = "Descrição";

            }
        }

        private void comboBox7_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox11.Text = ("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = ("");
            comboBox6.Text = ("");
            comboBox1.Text = ("");
            comboBox2.Text = ("");
            comboBox3.Text = ("");
            maskedTextBox1.Text = ("");
            textBox1.Text = ("");
            textBox2.Text = ("");
            comboBox4.Text = ("");
            comboBox5.Text = ("");
            textBox10.Text = ("");
            maskedTextBox2.Text = ("");
            maskedTextBox4.Text = ("");
            maskedTextBox16.Text = ("");
            textBox3.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            textBox7.Text = ("");
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            maskedTextBox3.Text = ("");
            maskedTextBox5.Text = ("");
            maskedTextBox6.Text = ("");
            maskedTextBox7.Text = ("");
            maskedTextBox8.Text = ("");
            maskedTextBox9.Text = ("");
            maskedTextBox10.Text = ("");
            maskedTextBox11.Text = ("");
            maskedTextBox12.Text = ("");
            maskedTextBox13.Text = ("");
            maskedTextBox14.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            maskedTextBox16.Text = ("");
            label14.Text = ("");
            label29.Text = ("");


            String codigo;
            codigo = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

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
                textBox8.Text = reader.GetString(0);
                comboBox6.Text = reader.GetString(1);
                comboBox1.Text = reader.GetString(2);
                comboBox2.Text = reader.GetString(3);
                comboBox3.Text = reader.GetString(4);
                maskedTextBox1.Text = reader.GetString(5);
                textBox1.Text = reader.GetString(6);
                textBox2.Text = reader.GetString(7);
                comboBox4.Text = reader.GetString(8);
                comboBox5.Text = reader.GetString(9);
                textBox10.Text = reader.GetString(10);
                maskedTextBox2.Text = reader.GetString(11);
                maskedTextBox4.Text = reader.GetString(12);
                maskedTextBox16.Text = reader.GetString(13);
                textBox3.Text = reader.GetString(14);
                maskedTextBox3.Text = reader.GetString(18);
                maskedTextBox5.Text = reader.GetString(19);
                maskedTextBox6.Text = reader.GetString(20);
                maskedTextBox7.Text = reader.GetString(21);
                maskedTextBox8.Text = reader.GetString(22);
                maskedTextBox9.Text = reader.GetString(23);
                maskedTextBox10.Text = reader.GetString(24);
                maskedTextBox11.Text = reader.GetString(25);
                maskedTextBox12.Text = reader.GetString(26);
                maskedTextBox13.Text = reader.GetString(27);
                maskedTextBox14.Text = reader.GetString(28);
                label14.Text = reader.GetString(29);
                textBox4.Text = reader.GetString(30);
                label29.Text = reader.GetString(31);

                //Pegando os bytes das imagens e armazenando na variaves;
                byte[] imgg = (byte[])(reader["Foto"]);
                byte[] imgg2 = (byte[])(reader["Foto2"]);
                byte[] imgg3 = (byte[])(reader["Foto3"]);

                if (imgg == null)
                {
                    pictureBox1.InitialImage = null;
                    pictureBox2.InitialImage = null;
                    pictureBox3.InitialImage = null;
                    textBox11.Text = ("Erro carro cadastrado no sistema não há foto");

                }
                else
                {
                    //Convertendo Bytes em imgagem e Jogando na picturebox;
                    MemoryStream mstream = new MemoryStream(imgg);
                    pictureBox1.Image = System.Drawing.Image.FromStream(mstream);

                    MemoryStream mstream2 = new MemoryStream(imgg2);
                    pictureBox2.Image = System.Drawing.Image.FromStream(mstream2);

                    MemoryStream mstream3 = new MemoryStream(imgg3);
                    pictureBox3.Image = System.Drawing.Image.FromStream(mstream3);
                }

            }
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            cn.Close();
            tabControl1.SelectedTab = tabPage1;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                byte[] imageBT = null;
                FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBT = br.ReadBytes((int)fstream.Length);

                byte[] imageBT2 = null;
                FileStream fstream2 = new FileStream(this.textBox6.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br2 = new BinaryReader(fstream2);
                imageBT2 = br2.ReadBytes((int)fstream2.Length);

                byte[] imageBT3 = null;
                FileStream fstream3 = new FileStream(this.textBox7.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br3 = new BinaryReader(fstream3);
                imageBT3 = br3.ReadBytes((int)fstream3.Length);

                String condicao, marca, modelo, ano, placa, proprietario, cor, portas, combustivel, descricao = null,status="Disponivel";
                var chassi = textBox10.Text;
                var renavan = maskedTextBox2.Text;
                var kilometragem = maskedTextBox4.Text;
                var Valor = maskedTextBox16.Text;
                var amortecedor = maskedTextBox3.Text;
                var borracharia = maskedTextBox5.Text;
                var documentacao = maskedTextBox6.Text;
                var estofado = maskedTextBox7.Text;
                var funilaria = maskedTextBox8.Text;
                var ipva = maskedTextBox9.Text;
                var lavajato = maskedTextBox10.Text;
                var mecanica = maskedTextBox11.Text;
                var suspencao = maskedTextBox12.Text;
                var transporte = maskedTextBox13.Text;
                var volante = maskedTextBox14.Text;
                var totaldespesas = label14.Text;
                var lucro = textBox4.Text;
                var lucrototal = label29.Text;
                condicao = comboBox6.Text;
                marca = comboBox1.Text;
                modelo = comboBox2.Text;
                ano = comboBox3.Text;
                placa = maskedTextBox1.Text;
                proprietario = textBox1.Text;
                cor = textBox2.Text;
                portas = comboBox4.Text;
                combustivel = comboBox5.Text;
                descricao = textBox3.Text;


                String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";

                try
                {
                    MySqlConnection conexao = new MySqlConnection(caminhobd);
                    conexao.Open();

                    string inserir = "INSERT INTO carros (condicao,marca,modelo,ano,placa,proprietario,cor,portas,combustivel,chassi,renavan,kilometragem,valor,descricao,foto,foto2,foto3," +
                    "amortecedor,borracharia,documentacao,estofado,funilaria,ipva,lavajato,mecanica,suspencao,transporte,volante,total,lucro,lucro_total,status)"
                        + "values (@condicao,@marca,@modelo,@ano,@placa,@proprietario,@cor,@portas,@combustivel,@chassi,@renavan,@kilometragem,@valor,@descricao,@img,@img2,@img3," +
                        "@amortecedor,@borracharia,@documentacao,@estofado,@funilaria,@ipva,@lavajato,@mecanica,@suspencao,@transporte,@volante,@total,@lucro,@lucro_total,@status)";
                    MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                    MySqlDataReader reader;

                    comandos.Parameters.Add(new MySqlParameter("@condicao", condicao));
                    comandos.Parameters.Add(new MySqlParameter("@marca", marca));
                    comandos.Parameters.Add(new MySqlParameter("@modelo", modelo));
                    comandos.Parameters.Add(new MySqlParameter("@ano", ano));
                    comandos.Parameters.Add(new MySqlParameter("@placa", placa));
                    comandos.Parameters.Add(new MySqlParameter("@proprietario", proprietario));
                    comandos.Parameters.Add(new MySqlParameter("@cor", cor));
                    comandos.Parameters.Add(new MySqlParameter("@portas", portas));
                    comandos.Parameters.Add(new MySqlParameter("@combustivel", combustivel));
                    comandos.Parameters.Add(new MySqlParameter("@chassi", chassi));
                    comandos.Parameters.Add(new MySqlParameter("@renavan", renavan));
                    comandos.Parameters.Add(new MySqlParameter("@kilometragem", kilometragem));
                    comandos.Parameters.Add(new MySqlParameter("@valor", Valor));
                    comandos.Parameters.Add(new MySqlParameter("@descricao", descricao));
                    comandos.Parameters.Add(new MySqlParameter("@img", imageBT));
                    comandos.Parameters.Add(new MySqlParameter("@img2", imageBT2));
                    comandos.Parameters.Add(new MySqlParameter("@img3", imageBT3));
                    comandos.Parameters.Add(new MySqlParameter("@amortecedor", amortecedor));
                    comandos.Parameters.Add(new MySqlParameter("@borracharia", borracharia));
                    comandos.Parameters.Add(new MySqlParameter("@documentacao", documentacao));
                    comandos.Parameters.Add(new MySqlParameter("@estofado", estofado));
                    comandos.Parameters.Add(new MySqlParameter("@funilaria", funilaria));
                    comandos.Parameters.Add(new MySqlParameter("@ipva", ipva));
                    comandos.Parameters.Add(new MySqlParameter("@lavajato", lavajato));
                    comandos.Parameters.Add(new MySqlParameter("@mecanica", suspencao));
                    comandos.Parameters.Add(new MySqlParameter("@suspencao", suspencao));
                    comandos.Parameters.Add(new MySqlParameter("@transporte", transporte));
                    comandos.Parameters.Add(new MySqlParameter("@volante", volante));
                    comandos.Parameters.Add(new MySqlParameter("@total", totaldespesas));
                    comandos.Parameters.Add(new MySqlParameter("@lucro", lucro));
                    comandos.Parameters.Add(new MySqlParameter("@lucro_total", lucrototal));
                    comandos.Parameters.Add(new MySqlParameter("@status", status));


                    reader = comandos.ExecuteReader();
                    MessageBox.Show("Cadastro do veiculo feito com sucesso!!");
                    conexao.Close();

                }

                catch (Exception ex)
                {
                    throw new Exception("Erro de comandos" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Adicione as imagens");

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text==(""))
            {
                maskedTextBox3.Text = ("0");
            }
            if (maskedTextBox5.Text == (""))
            {
                maskedTextBox5.Text = ("0");
            }
            if (maskedTextBox6.Text == (""))
            {
                maskedTextBox6.Text = ("0");
            }
            if (maskedTextBox7.Text == (""))
            {
                maskedTextBox7.Text = ("0");
            }
            if (maskedTextBox8.Text == (""))
            {
                maskedTextBox8.Text = ("0");
            }
            if (maskedTextBox9.Text == (""))
            {
                maskedTextBox9.Text = ("0");
            }
            if (maskedTextBox10.Text == (""))
            {
                maskedTextBox10.Text = ("0");
            }
            if (maskedTextBox11.Text == (""))
            {
                maskedTextBox11.Text = ("0");
            }
            if (maskedTextBox12.Text == (""))
            {
                maskedTextBox12.Text = ("0");
            }
            if (maskedTextBox13.Text == (""))
            {
                maskedTextBox13.Text = ("0");
            }
            if (maskedTextBox14.Text == (""))
            {
                maskedTextBox14.Text = ("0");
            }
            try
            {
                Decimal valor1=0, valor2=0,valor3=0,valor4=0,valor5=0,valor6=0,valor7=0,valor8=0,valor9=0,valor10=0,valor11=0,valortotal=0,valor_compra=0
                    ,valortotal2=0,porce=0,valortotal3=0,test=0;
                valor1 = Convert.ToDecimal(maskedTextBox3.Text);
                valor2 = Convert.ToDecimal(maskedTextBox5.Text);
                valor3 = Convert.ToDecimal(maskedTextBox6.Text);
                valor4 = Convert.ToDecimal(maskedTextBox7.Text);
                valor5 = Convert.ToDecimal(maskedTextBox8.Text);
                valor6 = Convert.ToDecimal(maskedTextBox9.Text);
                valor7 = Convert.ToDecimal(maskedTextBox10.Text);
                valor8 = Convert.ToDecimal(maskedTextBox11.Text);
                valor9 = Convert.ToDecimal(maskedTextBox12.Text);
                valor10 = Convert.ToDecimal(maskedTextBox13.Text);
                valor11 = Convert.ToDecimal(maskedTextBox14.Text);
                valortotal = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8 + valor9 +
                    valor10 + valor11;
                label14.Text = Convert.ToString(String.Format("{0:N2}", valortotal));
                valor_compra = Convert.ToDecimal(maskedTextBox16.Text);
                valortotal2=valor_compra + valortotal;
                porce = Convert.ToDecimal(textBox4.Text);
                test=   (porce / 100)+1;
                valortotal3=test*valortotal2;
                label29.Text = Convert.ToString(String.Format("{0:N2}",valortotal3));
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox8.Text = ("");
            comboBox6.Text = ("");
            comboBox1.Text = ("");
            comboBox2.Text = ("");
            comboBox3.Text = ("");
            maskedTextBox1.Text = ("");
            textBox1.Text = ("");
            textBox2.Text = ("");
            comboBox4.Text = ("");
            comboBox5.Text = ("");
            textBox10.Text = ("");
            maskedTextBox2.Text = ("");
            maskedTextBox4.Text = ("");
            maskedTextBox16.Text = ("");
            textBox3.Text = ("");
            textBox5.Text = ("");
            textBox6.Text = ("");
            textBox7.Text = ("");
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            maskedTextBox3.Text = ("");
            maskedTextBox5.Text = ("");
            maskedTextBox6.Text = ("");
            maskedTextBox7.Text = ("");
            maskedTextBox8.Text = ("");
            maskedTextBox9.Text = ("");
            maskedTextBox10.Text = ("");
            maskedTextBox11.Text = ("");
            maskedTextBox12.Text = ("");
            maskedTextBox13.Text = ("");
            maskedTextBox14.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            maskedTextBox16.Text = ("");
            label14.Text = ("");
            label29.Text = ("");
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox8.Text == (""))
            {
                MessageBox.Show("Insira o ID antes de atualizar os dados");
            }

            else
            {
                String condicao, marca, modelo, ano, placa, proprietario, cor, portas, combustivel, descricao = null;
                var chassi = textBox10.Text;
                var renavan = maskedTextBox2.Text;
                var kilometragem = maskedTextBox4.Text;
                var Valor = maskedTextBox16.Text;
                var id = textBox8.Text;
                var foto1 = textBox5.Text;
                var foto2 = textBox6.Text;
                var foto3 = textBox7.Text;
                var amortecedor = maskedTextBox3.Text;
                var borracharia = maskedTextBox5.Text;
                var documentacao = maskedTextBox6.Text;
                var estofado = maskedTextBox7.Text;
                var funilaria = maskedTextBox8.Text;
                var ipva = maskedTextBox9.Text;
                var lavajato = maskedTextBox10.Text;
                var mecanica = maskedTextBox11.Text;
                var suspencao = maskedTextBox12.Text;
                var transporte = maskedTextBox13.Text;
                var volante = maskedTextBox14.Text;
                var totaldespesas = label14.Text;
                var lucro = textBox4.Text;
                var lucrototal = label29.Text;
                condicao = comboBox6.Text;
                marca = comboBox1.Text;
                modelo = comboBox2.Text;
                ano = comboBox3.Text;
                placa = maskedTextBox1.Text;
                proprietario = textBox1.Text;
                cor = textBox2.Text;
                portas = comboBox4.Text;
                combustivel = comboBox5.Text;
                descricao = textBox3.Text;



                String caminhobd = "Server=127.0.0.1;DATABASE=tcc;UID=root;PASSWORD=";
                try
                {
                    //caso o valor dentro das textbox 5,6 e 7 seja vazio ele vai executar o if
                    if (((foto1) == ("") & (foto2) == ("")) & (foto3) == (""))
                    {

                        MySqlConnection conexao2 = new MySqlConnection(caminhobd);
                        conexao2.Open();
                        string alterar2 = "UPDATE carros set ID='" + id + "',Condicao='" + condicao + "',marca='" + marca + "',modelo='"
                            + modelo + "',Ano='" + ano + "',Placa='" + placa + "',Proprietario='" + proprietario + "',cor='"
                            + cor + "',Portas='" + portas +
                            "',Combustivel='" + combustivel + "',Chassi='" + chassi + "',Renavan='" + renavan + "',Kilometragem='"
                            + kilometragem + "',valor='" + Valor + "',descricao='" + descricao + "',amortecedor='" + amortecedor + "',borracharia='" + borracharia +
                            "',documentacao='" + documentacao + "',estofado='" + estofado + "',funilaria='" + funilaria + "',ipva='" + ipva +
                            "',lavajato='" + lavajato + "',mecanica='" + mecanica + "',suspencao='" + suspencao + "',transporte='" + transporte +
                            "',volante='" + volante + "',total='" + totaldespesas + "',lucro='" + lucro + "',lucro_total='" + lucrototal + "' where id= '" + id + "';";


                        MySqlCommand command2 = new MySqlCommand(alterar2, conexao2);
                        MySqlDataReader myreader2;
                        myreader2 = command2.ExecuteReader();
                        conexao2.Close();
                        textBox5.Text = ("");
                        textBox6.Text = ("");
                        textBox7.Text = ("");
                        MessageBox.Show("Dados atualizados com sucesso");


                    }
                    else
                    {




                        MySqlConnection conexao = new MySqlConnection(caminhobd);
                        //delete
                        conexao.Open();
                        string deletar2 = "Delete From Carros where id=" + id;
                        MySqlCommand command = new MySqlCommand(deletar2, conexao);
                        MySqlDataReader myreader;
                        myreader = command.ExecuteReader();
                        conexao.Close();

                        //insert

                        if (foto1 == (""))
                        {
                            MessageBox.Show("Insira imagem 1");
                            pictureBox4.Visible = true;
                        }
                        else if (foto2 == (""))
                        {
                            MessageBox.Show("Insira imagem 2");
                            pictureBox5.Visible = true;

                        }
                        else if (foto3 == (""))
                        {
                            MessageBox.Show("Insira imagem 3");
                            pictureBox6.Visible = true;
                        }
                        else
                        {
                            byte[] imageBT = null;
                            FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fstream);
                            imageBT = br.ReadBytes((int)fstream.Length);

                            byte[] imageBT2 = null;
                            FileStream fstream2 = new FileStream(this.textBox6.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br2 = new BinaryReader(fstream2);
                            imageBT2 = br2.ReadBytes((int)fstream2.Length);

                            byte[] imageBT3 = null;
                            FileStream fstream3 = new FileStream(this.textBox7.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br3 = new BinaryReader(fstream3);
                            imageBT3 = br3.ReadBytes((int)fstream3.Length);

                            conexao.Open();
                            string inserir = "INSERT INTO carros (condicao,marca,modelo,ano,placa,proprietario,cor,portas,combustivel,chassi,renavan,kilometragem,valor,descricao,foto,foto2,foto3," +
                       "amortecedor,borracharia,documentacao,estofado,funilaria,ipva,lavajato,mecanica,suspencao,transporte,volante,total,lucro,lucro_total)"
                           + "values (@condicao,@marca,@modelo,@ano,@placa,@proprietario,@cor,@portas,@combustivel,@chassi,@renavan,@kilometragem,@valor,@descricao,@img,@img2,@img3," +
                           "@amortecedor,@borracharia,@documentacao,@estofado,@funilaria,@ipva,@lavajato,@mecanica,@suspencao,@transporte,@volante,@total,@lucro,@lucro_total)";
                            MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                            MySqlDataReader reader;

                            comandos.Parameters.Add(new MySqlParameter("@condicao", condicao));
                            comandos.Parameters.Add(new MySqlParameter("@marca", marca));
                            comandos.Parameters.Add(new MySqlParameter("@modelo", modelo));
                            comandos.Parameters.Add(new MySqlParameter("@ano", ano));
                            comandos.Parameters.Add(new MySqlParameter("@placa", placa));
                            comandos.Parameters.Add(new MySqlParameter("@proprietario", proprietario));
                            comandos.Parameters.Add(new MySqlParameter("@cor", cor));
                            comandos.Parameters.Add(new MySqlParameter("@portas", portas));
                            comandos.Parameters.Add(new MySqlParameter("@combustivel", combustivel));
                            comandos.Parameters.Add(new MySqlParameter("@chassi", chassi));
                            comandos.Parameters.Add(new MySqlParameter("@renavan", renavan));
                            comandos.Parameters.Add(new MySqlParameter("@kilometragem", kilometragem));
                            comandos.Parameters.Add(new MySqlParameter("@valor", Valor));
                            comandos.Parameters.Add(new MySqlParameter("@descricao", descricao));
                            comandos.Parameters.Add(new MySqlParameter("@img", imageBT));
                            comandos.Parameters.Add(new MySqlParameter("@img2", imageBT2));
                            comandos.Parameters.Add(new MySqlParameter("@img3", imageBT3));
                            comandos.Parameters.Add(new MySqlParameter("@amortecedor", amortecedor));
                            comandos.Parameters.Add(new MySqlParameter("@borracharia", borracharia));
                            comandos.Parameters.Add(new MySqlParameter("@documentacao", documentacao));
                            comandos.Parameters.Add(new MySqlParameter("@estofado", estofado));
                            comandos.Parameters.Add(new MySqlParameter("@funilaria", funilaria));
                            comandos.Parameters.Add(new MySqlParameter("@ipva", ipva));
                            comandos.Parameters.Add(new MySqlParameter("@lavajato", lavajato));
                            comandos.Parameters.Add(new MySqlParameter("@mecanica", suspencao));
                            comandos.Parameters.Add(new MySqlParameter("@suspencao", suspencao));
                            comandos.Parameters.Add(new MySqlParameter("@transporte", transporte));
                            comandos.Parameters.Add(new MySqlParameter("@volante", volante));
                            comandos.Parameters.Add(new MySqlParameter("@total", totaldespesas));
                            comandos.Parameters.Add(new MySqlParameter("@lucro", lucro));
                            comandos.Parameters.Add(new MySqlParameter("@lucro_total", lucrototal));


                            reader = comandos.ExecuteReader();
                            conexao.Close();
                            textBox5.Text = ("");
                            textBox6.Text = ("");
                            textBox7.Text = ("");
                            MessageBox.Show("Dados Atualizados com sucesso!!");

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro de comandos" + ex.Message);

                }

            }
            //fim do update
        }
    }
    }


