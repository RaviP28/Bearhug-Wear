using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
        {
            using (BearhugWearEntities e = new BearhugWearEntities())
            {
                return e.Products.ToList();
            }
        }
    }
}