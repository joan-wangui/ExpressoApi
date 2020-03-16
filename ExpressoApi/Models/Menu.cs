using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressoApi.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        //creating a one to many relationship with the submenu class
        //navigation collection property
        // use the collection property to get all the submenus thats why we have not added the submenu Dbcontext in the ExpressoDbContext

        public ICollection <SubMenu> subMenus{ get; set; }


    }
}