using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using SistemasdeVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasdeVendas.br.com.projeto.dao
{
    internal class ClienteDAO
    {

        private MySqlConnection conexao;

        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarClientes

        public void cadastrarCliente(Cliente obj) 
        {

            try 
            {

                //passo 1 - Definir o comando sql para o insert

                string sql = "insert into tb_clientes(nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) valeus (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                // 3 passo - Abrir a conexao e executar o comando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso");

                //Avaliar a situação com o fechamento do banco nesse momento
                // Fechamento a conexao com o banco de dados

                conexao.Close();
                
            } 
            catch (Exception erro) 
            {
            
                MessageBox.Show("Aconteceu o erro: " + erro);
            
            }
            // 2 passo - organizar o comando sql

            




        }

        #endregion

    }
}
