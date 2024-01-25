using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        ///  This method receives and posts a message of 'Hello World' in the terminal.
        /// </summary>
        /// <returns>
        /// A message of 'Hello World'
        ///</returns>
        ///<example>
        ///POST curl -d "" localhost:xx/api/Greeting
        ///</example>

        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method receives an input and returns a string greeting the 'input' number of people
        /// </summary>
        /// <param name="id">The input {id}</param>
        /// <returns>Returns a message greeting {id} people</returns>
        /// <example>
        /// GET localhost:xx/api/Greeting/5 => "Greetings to 5 people!"
        /// </example>
        public string Get(int id)
        {
            //Display a message to greet a number {id} of people
            return "Greetings to " + id + " people!";
        }
    }
}