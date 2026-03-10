using System.Net.Mail;

namespace Exemplo01.Models
{
    public class Flower
    {
        public int FlowerId { get; set; }
        public string Tipo { get; set; }

        public string Cor { get; set; }

        public string Aroma { get; set; }

        public string Tamanho { get; set; }

        public decimal Valor { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Tipo)
             || string.IsNullOrEmpty(Cor)
             || string.IsNullOrEmpty(Aroma)
            )
                return false;

            return true;
        }
    }
}
