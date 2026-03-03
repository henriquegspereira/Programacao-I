using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Exemplo01.Controllers
{
    public class NotesController : Controller
    {
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

                        else if(notaAtual >= 5.0 && notaAtual <= 6.9) 
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
    }
}
