using System;
namespace temario4.Models
{
    public class Contenido
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public TemaPrincipal TipoTema { get; set; }
        public PosiblesContenidos TipoContenido { get; set; }
    }
    public enum PosiblesContenidos
    {
        p,
        h1,
        img,
        video,
        audio,
        ul,
        ol,
        li,
        a
    }
}