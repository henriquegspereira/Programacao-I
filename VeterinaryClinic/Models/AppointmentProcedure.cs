namespace VeterinaryClinic.Models
{
    public class AppointmentProcedure
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int ProcedureId { get; set; }
    }
}
