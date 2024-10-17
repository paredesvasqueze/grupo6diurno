namespace CapaEntidad
{
    public class Sancion
    {
        public int nId_Sancion { get; set; }
        public int nMonto { get; set; }
        public string? cMotivo { get; set; }
        public DateTime dFechaInicio { get; set; }
        public DateTime dFechaFin { get; set; }
        public int nId_Usuario { get; set; }
    }
}
