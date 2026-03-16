using Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo01.Controllers
{
    public class FlowerController : Controller
    {
        public IActionResult Index()
        {
            int id = 1;

            Flower fl1 = new Flower
            {
                FlowerId = id,
                Tipo = "Rosa",
                Cor = "Vermelha",
                Aroma = "Doce",
                Tamanho = "Média",
                Valor = 15
            };

            Flower fl2 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Orquídea",
                Cor = "Roxa",
                Aroma = "Suave",
                Tamanho = "Pequena",
                Valor = 45
            };

            Flower fl3 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Girassol",
                Cor = "Amarelo",
                Aroma = "Neutro",
                Tamanho = "Grande",
                Valor = 12
            };

            Flower fl4 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Tulipa",
                Cor = "Azul",
                Aroma = "Leve",
                Tamanho = "Média",
                Valor = 22
            };

            Flower fl5 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Lírio",
                Cor = "Branco",
                Aroma = "Forte",
                Tamanho = "Grande",
                Valor = 30
            };

            Flower fl6 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Lavanda",
                Cor = "Lilás",
                Aroma = "Relaxante",
                Tamanho = "Pequena",
                Valor = 18
            };

            Flower fl7 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Margarida",
                Cor = "Branco",
                Aroma = "Campo",
                Tamanho = "Pequena",
                Valor = 8
            };

            Flower fl8 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Hortênsia",
                Cor = "Azul",
                Aroma = "Suave",
                Tamanho = "Grande",
                Valor = 35
            };

            Flower fl9 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Cravina",
                Cor = "Rosa",
                Aroma = "Picante",
                Tamanho = "Média",
                Valor = 10
            };

            Flower fl10 = new Flower
            {
                FlowerId = ++id,
                Tipo = "Antúrio",
                Cor = "Vermelho",
                Aroma = "Neutro",
                Tamanho = "Média",
                Valor = 28
            };

            List<Flower> flowers = new List<Flower>();
            flowers.Add(fl1);
            flowers.Add(fl2);
            flowers.Add(fl3);
            flowers.Add(fl4);
            flowers.Add(fl5);
            flowers.Add(fl6);
            flowers.Add(fl7);
            flowers.Add(fl8);
            flowers.Add(fl9);
            flowers.Add(fl10);



            return View(flowers);
        }
    }
}
