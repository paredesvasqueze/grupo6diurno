﻿namespace CapaEntidad
{
    public class Comentario
    {
        public int nId_Comentario { get; set; }
        public string cComentario { get; set; }
        public DateTime dFecha { get; set; }
        public int nId_Usuario { get; set; }
        public int nId_Libro { get; set; }
        public int nPuntuacion { get; set; }
    }
}