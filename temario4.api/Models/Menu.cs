using System;
using System.Collections.Generic;

namespace temario4.Models
{
    public class Menu
    {
        public int Id { get; set; }

        //public string Descripcion { get; set; }
        public int IdMenuSuperior { get; set; }
        public List<Contenido> Contenidos { get; set; }
        public string Nombre { get; set; }
        public TemaPrincipal TipoTema { get; set; }

    }
}