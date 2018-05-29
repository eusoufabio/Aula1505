using MVC_CRUD_PESSOA.Models;
using MVC_CRUD_PESSOA.RegraNegocio;
using MVC_CRUD_PESSOA.RN;
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
            cls_RegraNegocio rn = new cls_RegraNegocio();
            return View(rn.get_lista());
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(string id)
        {
            return View(new cls_RegraNegocio().get_lista(id));
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
        public ActionResult Delete(string id)
        {
            try
            {
                for (int i = 0; i < lst_Pessoa.Count ; i++)
                    if (lst_Pessoa[i].cpf == id)
                    {
                        lst_Pessoa.Remove(lst_Pessoa[i]);
                        break;
                    }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
