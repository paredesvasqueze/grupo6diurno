namespace FrontEnd.Models
{
    public class Reserva
    {
        public int nId_Reserva { get; set; }
        public DateTime dFechaReserva { get; set; }
        public int nId_Usuario { get; set; }
        public int nId_Libro { get; set; }
    }
}
