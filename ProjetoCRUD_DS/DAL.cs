using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCRUD_DS
{
    class DAL
    {
        public void adm(Construtor uhu)
        {
            uhu.test = "1";
        }
        public void Alterar2(Construtor2 con2)
        {
            String caminhobd = "Server=127.0.0.1;Database=tcc;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();
                string alterar2 = "UPDATE carros set ID='" + con2.id + "',Condicao='" + con2.condicao + "',marca='" + con2.marca_do_veiculo + "',modelo='"
                    + con2.modelo_do_veiculo + "',Ano='" + con2.ano_do_veiculo+ "',Placa='" + con2.placa_do_carro + "',Proprietario='" + con2.dono_anterior + "',cor='"
                    + con2.cor_veiculo + "',Portas='" + con2.num_portas +
                    "',Combustivel='" + con2.combustivel + "',Chassi='" + con2.chassi + "',Renavan='" + con2.renavan + "',Kilometragem='" + con2.kilometragem + "',valor='" + con2.preço + "',descricao='" + con2.Descricao + "' where id= '" + con2.id + "';";
                MySqlCommand command = new MySqlCommand(alterar2, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);

            }

        }

        public void Adicionar2(Construtor2 mo2)
        {
            String caminhobd = "Server=127.0.0.1;Database=tcc;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                String adicionar2 = "insert into carros (condicao,marca,modelo,ano,placa,Proprietario,cor,portas,Combustivel,chassi,renavan,kilometragem,Valor,Descricao)" +
                    "values ('" + mo2.condicao + "','" + mo2.marca_do_veiculo + "','" + mo2.modelo_do_veiculo + "','" + mo2.ano_do_veiculo + "','" + mo2.placa_do_carro + "','" + mo2.dono_anterior + "','" +
                    mo2.cor_veiculo + "','" + mo2.num_portas + "','" + mo2.combustivel + "','" + mo2.chassi + "','" + mo2.renavan + "','" + mo2.kilometragem + "','" + mo2.preço + "','"
                    + mo2.Descricao + "')";


                MySqlCommand command = new MySqlCommand(adicionar2, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();



            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);
            }



        }
        
        public void Adicionar(Construtor mo)
        {
            String caminhobd = "Server=127.0.0.1;Database=tcc;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();
                String adicionar = "insert into cliente (nome,RG,endereço,num_telefone,CPF,Bairro,num_celular,CEP,cidade,data_de_nascimento,numero,OBS,Sexo)" +
                    "values ('" + mo.nome + "','" + mo.RG + "','" + mo.endereco + "','" + mo.num_telefone + "','" + mo.cpf + "','" + mo.bairro + "','" +
                    mo.num_celular + "','" + mo.cep + "','" + mo.cidade + "','" + mo.data_de_nascimento + "','" + mo.numero + "','" + mo.OBS + "','" 
                    + mo.sexo + "')";


                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
                


            }

            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);
            }



        }
        public void Alterar(Construtor con)
        {
            String caminhobd = "Server=127.0.0.1;Database=tcc;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();
                string alterar = "UPDATE cliente set id='" + con.id + "',Nome='" + con.nome + "',RG='" + con.RG + "',endereço='"
                    + con.endereco + "',num_telefone='" + con.num_telefone + "',CPF='" + con.cpf + "',Bairro='" + con.bairro + "',num_celular='" 
                    + con.num_celular + "',CEP='" + con.cep +
                    "',cidade='" + con.cidade + "',data_de_nascimento='" + con.data_de_nascimento + "',numero='" + con.numero + "',OBS='" + con.OBS + "',Sexo='" + con.sexo + "' where id= '" + con.id+"';";
                MySqlCommand command = new MySqlCommand(alterar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);

            }

        }
        public void Deletar(Construtor con)
        {
            String caminhobd = "Server=127.0.0.1;Database=tcc;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();
                string deletar = "Delete From cliente where id=" + con.id;
                MySqlCommand command = new MySqlCommand(deletar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);

            }
        }

              public void Deletar2(Construtor2 con2)
        {
            String caminhobd = "Server=127.0.0.1;Database=tcc;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();
                string deletar2 = "Delete From Carros where id="+con2.id;
                MySqlCommand command = new MySqlCommand(deletar2, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos" + ex.Message);

            }

        }

    }
}