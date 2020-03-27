using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteDePerformance03.Models;

namespace TesteDePerformance03.Controllers
{
    public class PessoaController : Controller
    {
        private readonly PessoaRepository _pessoaRepository;

        public PessoaController()
        {
            _pessoaRepository = new PessoaRepository();
        }

        // GET: Pessoa
        public ActionResult Index(string nome = null)
        {
            var pessoas = _pessoaRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                pessoas = pessoas.Where(x => x.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            return View(pessoas);
        }

        //public ActionResult ProcuraPorNome(string nome)
        //{
         //   if (!string.IsNullOrWhiteSpace(nome))
        //    {
       //        var resultado = _pessoaRepository.ProcurarPorNome(nome);
       //     }

      //      return View("Index", resultado);
    //    }
    
        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);

            return View(pessoa);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaModel pessoaModel)
        {
            try
            {
                _pessoaRepository.Adicionar(pessoaModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);
            return View(pessoa);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaModel pessoaModel)
        {
            try
            {
                _pessoaRepository.Atualizar(pessoaModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);
            return View(pessoa);
        }

        // POST: Pessoa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PessoaModel pessoaModel)
        {
            try
            {
                _pessoaRepository.Deletar(pessoaModel.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}