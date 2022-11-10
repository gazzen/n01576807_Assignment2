using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc.Html;
using System.Xml.Schema;

namespace calorieCounter.Controllers
{
    [Route("api/dice/{m}/{n}")]
    public class rollDiceController : ApiController
    {
        public int DiceGame( int m, int n)
        {
            m = 6;
            n = 6;
            int counter = 0;
            int fails = 0;

            
            Random rnd = new Random();

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (m + n == 10)
                        counter++;
                    else
                        fails++;
                }
                    
            }
                return  total;
        }
    }
}
