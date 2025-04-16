using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemasdeVendas.br.com.projeto.model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade  { get; set; }
        public string estado { get; set; }

        public Pessoa ()
        { }

         public Pessoa (int Id, string Nome, string email, string telefone, string celular, string cep, string endereco, string complemento, string bairro, string cidade, string estado) 
        {
            this.Id = Id;
            this.Nome = Nome;
            this.email = email;
            this.telefone = telefone;
            this.celular = celular; 
            this.cep = cep;
            this.endereco = endereco;
            this.complemento = complemento;
            this.estado = estado;
            this.bairro = bairro;
            this.cidade = cidade;
        
        }
    }
}
