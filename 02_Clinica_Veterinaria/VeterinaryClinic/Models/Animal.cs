namespace VeterinaryClinic.Models
{
    public class Animal
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        public string? Species { get; set; }

        public string? Breed { get; set; } //raça

        public string? Status { get; set; }

        public float Weight { get; set; } //peso

        public string? Sex { get; set; }

        public string? Observations { get; set; }


    }
}
