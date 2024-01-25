using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        ///  This method receives a number and returns 10 more than the input
        /// </summary>
        /// <param name="id"> The input {id}</param>
        /// <returns>
        /// A number that is 10 greater than {id}
        ///</returns>
        ///<example>
        /// GET localhost:/xx/api/AddTen/10 => 20
        ///</example>

        public int Get(int id)
        {
            //set the variable 'addTen' to (id + 10)
            int addTen = id + 10;
            return addTen;
        }
    }
}