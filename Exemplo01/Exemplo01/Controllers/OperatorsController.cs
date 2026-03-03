using Microsoft.AspNetCore.Mvc;

namespace Exemplo01.Controllers
{
    public class OperatorsController : Controller
    {
        public IActionResult Index()
        {
            // Aritiméticos
            int y = -10; // = É operador unário de atribuição
            int x = 2;
            int z = y - x;

            //Precedencia
            int xx = 10 - 20 * 10;

            //Neste caso o C# já conhece a regra de precedência dos operadores aritiméticos
            // No entanto se eu desejar manipular a ordem das operações, podemos usar ()
            int yy = (10 - 20) * 10;

            //Operadores de composição

            int xXx = 10;
            int yXy = 20;

            xXx += yXy;

            //Operadores de Incremento e Decremento

            //Podemos incrementar de forma original
            int luiz = x + 1;
            luiz = x++; //Incrementando
            luiz = x--;
            //No entanto existe outra forma de controlar a precedência do incremento ou decremento
            //Se eu desejar que a incrementação ocorra antes de quakquer outra operação, colocamos os operadores antes da variável
            luiz = ++luiz * 2;

            //Operadores de Comparação
            int num1 = 9;
            int num2 = 9;
            string resultado = string.Empty;

            if(num1 == num2)
            {
                resultado = "São iguais";
            }

            //Tmabém podemos atribuir uma comparação diretamente a uma variável
            bool eIgual = (num1 == num2);



            return View();
        }
    }
}
