using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemasdeVendas.br.com.projeto.model
{
    public class Fornecedor
    {
 public int id { get; set; } 
 public string nome { get; set; }
 public string cnpj { get; set; }
 public string email { get; set; }
 public string telefone { get; set; }
 public string celular { get; set; }
 public string cep { get; set; }
 public string  endereco { get; set; }
 public int numero { get; set; }
 public string complemento { get; set; }
 public string bairro { get; set; }
 public string cidade { get; set; }
 public string estado { get; set; }
    }
}
