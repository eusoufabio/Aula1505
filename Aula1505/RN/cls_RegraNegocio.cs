using MVC_CRUD_PESSOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_CRUD_PESSOA.RN;


namespace MVC_CRUD_PESSOA.RegraNegocio
{
    public class cls_RegraNegocio
    {
        public List<PessoaModel> get_lista()
        {
            return cls_lista.lst_Pessoas;
        }

        public List<PessoaModel> get_lista(string cpf)
        {
            List<PessoaModel> aux = new List<PessoaModel>();

            foreach (var item in cls_lista.lst_Pessoas)
                if (item.cpf.Contains(cpf))
                    aux.Add(item);

            return cls_lista.lst_Pessoas.FindAll(p => p.cpf.Contains(cpf));
        }
    }
}