using MVC_CRUD_PESSOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD_PESSOA.RegraNegocio
{
    public class cls_RegraNegocio
    {
        public static List<PessoaModel> listaVazia(List<PessoaModel> lista)
        {
            List<PessoaModel> retorno = new List<PessoaModel>();

            if (lista.Count == 0)
            {
                retorno.Add(new PessoaModel());
            }

            return retorno;
        }
    }
}