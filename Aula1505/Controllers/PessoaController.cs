using MVC_CRUD_PESSOA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_PESSOA.Controllers
{
    public class PessoaController : Controller
    {
        static List<PessoaModel> lst_Pessoa = new List<PessoaModel>();

        // GET: Pessoa
        public ActionResult Index()
        {
            if (lst_Pessoa.Count == 0)
            {
                PessoaModel aux;

                aux = new PessoaModel();
                aux.nome = "Fábio";
                aux.idade = 30;
                aux.cpf = "12380260796";
                aux.email = "wwwpontofabio@gmail.com";
                lst_Pessoa.Add(aux);

                aux = new PessoaModel();
                aux.nome = "Carol";
                aux.idade = 24;
                aux.cpf = "123.456.789-10";
                aux.email = "carol@gmail.com";
                lst_Pessoa.Add(aux);

                aux = new PessoaModel();
                aux.nome = "Letícia";
                aux.idade = 1;
                aux.cpf = "987.654.321-00";
                aux.email = "le@gmail.com";
                lst_Pessoa.Add(aux);

            }
            return View(lst_Pessoa);
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(string id)
        {
            PessoaModel pessoa = new PessoaModel();

            foreach (var item in lst_Pessoa)
            {
                if (item.cpf == id)
                {
                    return View(item);
                }
            }
            return View();
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaModel collection)
        {
            try
            {
                lst_Pessoa.Add(collection);
                return RedirectToAction("Index");
                //Teste
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
