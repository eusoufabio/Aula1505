using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD_PESSOA.Models
{
    public class PessoaModel
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
    }
}