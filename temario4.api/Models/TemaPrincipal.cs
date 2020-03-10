using System;
namespace temario4.Models
{
    public class TemaPrincipal
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Menus> SubMenus { get; set; }

    }
}