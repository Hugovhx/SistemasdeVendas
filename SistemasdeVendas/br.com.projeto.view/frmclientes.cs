using SistemasdeVendas.br.com.projeto.dao;
using SistemasdeVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SistemasdeVendas.br.com.projeto.view
{
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            // 1 passo - Receber os dados dentro do objeto modelo de cliente

            Cliente obj = new Cliente();

            obj.Nome = txtnome.Text;
            obj.rg = txtrg.Text; 
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefonefixo.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = txtnumero.Text;
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbuf.Text;

            // passo - Criar um objeto da classe DAO e chamar o metodo...

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);
        }
    }
}
