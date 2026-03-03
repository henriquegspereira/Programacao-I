using Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exemplo01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // -----------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Variables()
        {

            string retorno = string.Empty;

            return View("Variables", retorno);
        }

        // -----------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<IActionResult> Numbers()
        {
            string retorno = string.Empty;

                retorno += $"Valor máximo para int: {int.MaxValue}<br/>";
                retorno += $"Valor mínimo para int: {int.MinValue}<br/>";
                retorno += $"Valor máximo para double: {double.MaxValue}<br/>";
                retorno += $"Valor mínimo para double: {double.MaxValue}<br/>";
                retorno += $"Valor máximo para decimal: {decimal.MaxValue}<br/>";
                retorno += $"Valor mínimo para decimal: {decimal.MinValue}<br/>";
                retorno += $"Valor máximo para long: {long.MaxValue}<br/>";
                retorno += $"Valor mínimo para long: {long.MinValue}<br/>";
                retorno += $"Valor máximo para float: {float.MaxValue}<br/>";
                retorno += $"Valor mínimo para float: {float.MinValue}<br/>";
                retorno += $"Valor máximo para byte: {byte.MaxValue}<br/>";
                retorno += $"Valor mínimo para byte: {byte.MinValue}<br/>";
                retorno += $"Valor máximo para short: {short.MaxValue}<br/>";
                retorno += $"Valor mínimo para short: {short.MinValue}<br/>";
                retorno += $"Valor máximo para sbyte: {sbyte.MaxValue}<br/>";
                retorno += $"Valor mínimo para sbyte: {sbyte.MinValue}<br/>";
                retorno += $"Valor máximo para uint: {uint.MaxValue}<br/>";
                retorno += $"Valor mínimo para uint: {uint.MinValue}<br/>";
            
                return View("Numbers", retorno);
        }

        // -----------------------------------------------------------------------------------------------------------

        [HttpGet]

        public async Task<IActionResult> Dictionary()
        {
            Dictionary<int, string> data = [];

            for(int i = 1; i <= 10; i++)
            {
                data.Add(i, $"Valor {i}");
            }

            return View("Dictionary", data);
        }

        // ----------------------------------------------------------------------------------------------------------
        public IActionResult Privacy()
        {
            return View(); 
        }

        // -----------------------------------------------------------------------------------------------------------

        [HttpGet]
            public IActionResult NotesDictionary()
            {


                Dictionary<string, double> boletim =
                    new Dictionary<string, double>
                    {
                    {"Carequinha", 4.5},
                    {"Hernique lenda", 10.0},
                    {"Bernardo", 5.0},
                    {"Miguel", 6.5},
                    {"Luiz", 9.0},

                    };

                double soma = 0;
                double maior = 0;
                double menor = 10;

                int aprovados = 0;
                int recuperacao = 0;
                int reprovados = 0;

                foreach (var aluno in boletim)
                {
                    double notaAtual = aluno.Value;

                    soma += notaAtual;

                    if (notaAtual > maior) maior = notaAtual;

                    if (notaAtual < menor) menor = notaAtual;

                    if (notaAtual >= 7.0)
                        aprovados++;

                    else if (notaAtual >= 5.0 && notaAtual <= 6.9)
                        recuperacao++;

                    else reprovados++;

                }

                double media = soma / boletim.Count;

                List<string> relatorio = new List<string>();
                relatorio.Add($"Média: {media}");
                relatorio.Add($"Maior nota: {maior}");
                relatorio.Add($"Menor nota: {menor}");
                relatorio.Add($"Alunos aprovados: {aprovados}");
                relatorio.Add($"Alunos em recuperação: {recuperacao}");
                relatorio.Add($"Alunos reprovados: {reprovados}");

                return View("NotesDictionary", relatorio);

            }

        // ----------------------------------------------------------------------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

// Resumo capitlo 8 livro C# 13 net 9