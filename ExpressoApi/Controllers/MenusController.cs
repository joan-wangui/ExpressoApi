using ExpressoApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpressoApi.Controllers
   
{
    
    public class MenusController : ApiController
    {
        
        //acess the data from the menus table
        ExpressoDbContext expressoDbContext = new ExpressoDbContext();
   
        public IHttpActionResult GetMenus()
        {
            //using expressoDbContext object and call menus roperty that comes from ExpressoDbcontext class
           var menus =  expressoDbContext.Menus;
            return Ok(menus);
        }
    }
}
