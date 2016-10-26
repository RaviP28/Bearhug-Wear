using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    public class ReviewsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { };
            //string connectionString = ConfigurationManager.ConnectionStrings["Bearhug"].ConnectionString;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = connection.CreateCommand();
            //    connection.Open();
            //    //using Lambda expressions
            //    var newReveiw = ValueType.reviews.First(x => x.id == 0);

            //    command.CommandText = string.Format("INSERT INTO Review(ProductId, stars, author, body) VALUES({0}, {1}, {2}, {3}", value.id, newReview.stars, newReview.author, newReview.body);

            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}
            //}

            //// GET api/<controller>/5
            //public string Get(int id)
            //{
            //    return "value";
            //}

            //// POST api/<controller>
            //public void Post([FromBody]string value)
            //{
            //}

            //// PUT api/<controller>/5
            //public void Put(int id, [FromBody]string value)
            //{
            //}

            //// DELETE api/<controller>/5
            //public void Delete(int id)
            //{
            //}
        }
    }
}
