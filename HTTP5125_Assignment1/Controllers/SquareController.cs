using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This methods receives a a number and multiplies the number by itself
        /// </summary>
        /// <param name="id">The input {id}</param>
        /// <returns>{id} multiplied by {id} resulting in a squared number</returns>
        /// <example>
        /// GET: localhost:/xx/api/Square/10 => 100
        /// </example>
        /// Default
        public int Get(int id)
        {
            //set the variable 'square' to a multiple of itself (id * id) resulting in a squared number
            int square = id * id;
            return square;
        }
    }
}