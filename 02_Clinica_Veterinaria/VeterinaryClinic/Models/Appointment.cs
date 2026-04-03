namespace VeterinaryClinic.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int IdAnimal { get; set; }

        public DateTime? AdmissionDate { get; set; }

        public DateTime? DischargeDate { get; set; }

        public string? Observations { get; set; }

        public int IdProcedure { get; set; }

        public int IdClinic { get; set; }
    }
}
