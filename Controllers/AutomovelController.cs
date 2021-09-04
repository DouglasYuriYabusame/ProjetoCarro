using Microsoft.AspNetCore.Mvc;
using ProjetoCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCarro.Controllers
{
    public class AutomovelController : Controller
    {
        private Contexto contexto;

        public AutomovelController(Contexto novoContexto)
        {
            this.contexto = novoContexto;
        }
        public IActionResult Index()
        {

            // pegando uma lista de pessoas
            List<Automovel> lista = contexto.Automovels.ToList();

            // pegando uma pessoa
            Automovel p = contexto.Automovels.Where(e => e.Auto_Cod== 6).First();

            // Alterar uma pesso -- pega a pessoa, altera e grava
            Automovel Carro = contexto.Automovels.Where(e => e.Auto_Cod == 6).First();
            Carro.Auto_Nome = "Panamera";
            contexto.Automovels.Update(Carro);

            // Incluir uma pessoa, Criar a classe pessoa, popular e gravar
            // quando vai incluir nao se coloca a chave primaria
            Automovel novoCarro = new Automovel();
            novoCarro.Auto_Nome = "Ciclano da Silva";
            novoCarro.Auto_Cod = 2;
            novoCarro.Marca_Cod = 2;
            novoCarro.Modelo_Cod = 2;
            contexto.Automovels.Add(novoCarro);
            contexto.SaveChanges();

            return View();
        }
    }
}
