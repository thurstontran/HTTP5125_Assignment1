using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method receives an input and applies 4 math operations to it
        /// </summary>
        /// <param name="id">The input {id}</param>
        /// <returns>Returns the {id} input when altered by the math operations</returns>
        /// <example>
        /// GET localhost:xx/api/NumberMachine/5 => 0
        /// </example>
        ///  <example>
        /// GET localhost:xx/api/NumberMachine/100 => 19
        /// </example>
        public int Get(int id)
        {
            //Set a variable 'mathExpression' and apply 4 different mathematical operations to the {id} and display it
            int mathExpression = (id + 20) * 2 / 10 - 5;
            return mathExpression;
        }
    }
}