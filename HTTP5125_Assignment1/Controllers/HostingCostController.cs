using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5125_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method receives a number and returns a message of the hosting costs
        /// </summary>
        /// <param name="id">The input {id}</param>
        /// <returns>
        /// Returns 3 different lines of messages describing the total costs of hosting including tax and number of fortnights
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/15 
        /// => "2 fortnights at $5.50/FN = $11.50 CAD"
        ///    "HST 13% = $1.43 CAD"
        ///    "Total = "$12.43 CAD"
        ///</example>
        public IEnumerable<string> Get(int id)
        {
            //Declare constant variables 
            const double pricePerFN = 5.50;
            const double percentHST = 0.13;

            //Declare variable expressions
            int fnDays = id / 14 + 1; //Set fnDays to 1 if {id} is 0 - Forward billed.
            double clientCost = pricePerFN * fnDays;
            double hstAmount = percentHST * clientCost;
            double totalAmount = clientCost + hstAmount;


            //Returns a string to output the total amount
            //The ToString() method allows for the hst and total to be set to 2 decimal places
            return new String[] {
                fnDays + " fortnight(s) at $" + pricePerFN.ToString("F2") + "/FN = $" + clientCost.ToString("F2") + " CAD",
                "HST 13% = $" + hstAmount.ToString("F2") + " CAD",
                "Total = " + totalAmount.ToString("F2") + " CAD"
            };
        }
    }
}
