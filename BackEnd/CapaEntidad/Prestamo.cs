namespace CapaEntidad
{
    public class Prestamo
    {
        public int nId_Prestamo { get; set; }
        public DateTime dFechaPrestamo { get; set; }
        public DateTime dFechaDevolucion { get; set; }
        public int nId_Usuario { get; set; }
        public int nId_Libro { get; set; }
        public string? cNombreUsuario { get; set; }
        public string? cTitulo { get; set; }
    }
}
