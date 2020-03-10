using System;
using System.Collections.Generic;
using temario4.Models;
namespace temario4.Models
{
    public class TemaPrincipal
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Menu> SubMenus { get; set; }

    }
}