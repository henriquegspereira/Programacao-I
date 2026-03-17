namespace VeterinaryClinic.Models
{
    public class AnimalOwner
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }

        public int OwnerId { get; set; }
    }
}
