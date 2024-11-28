namespace FrontEnd.Models
{
    public class Libro
    {
        public int nId_Libro { get; set; }
        public string? cTitulo { get; set; }
        public int dAnio { get; set; }
        public int nId_Autor { get; set; }
        public int nId_Genero { get; set; }
        public string? cNombreAutor { get; set; }
        public string? cNombreGenero { get; set; }
    }
}
