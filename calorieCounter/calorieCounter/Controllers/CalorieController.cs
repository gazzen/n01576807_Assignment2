using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace calorieCounter.Controllers
{
    public class CalorieController : ApiController
    {
        ///<summary>
        ///Choose the options 
        /// </summary>
        /// <example>
        /// GET ../api/J1/Menu/4/4/4/4 -> 0 Calorie
        /// 
        /// GET ../api/J1/Menu/1/2/3/4 -> 691
        /// </example>

        ///GET : /api/J1/Menu/{burger}/{drink}/{side}/{dessert}

        [HttpGet]
        [Route("api/Calorie/sum/{burger}/{drink}/{side}/{desset}")]

        public int Menu(int burger, int drink, int side, int dessert)
        {
            int sum=0;


            //Using the Switch cases:

            switch(burger)
            {
                case 1:
                    sum = sum + 461;
                    break;
                case 2:
                    sum = sum + 431;
                    break;
                case 3:
                    sum = sum + 420;
                    break;
                           
                default:
                    sum = sum + sum;
                    break;


            }

            switch (drink)
            {
                case 1:
                    sum = sum + 130;
                    break;
                case 2:
                    sum = sum + 160;
                    break;
                case 3:
                    sum = sum + 118;
                    break;

                default:
                    sum = sum + sum;
                    break;


            }

            switch (side)
            {
                case 1:
                    sum = sum + 100;
                    break;
                case 2:
                    sum = sum + 57;
                    break;
                case 3:
                    sum = sum + 70;
                    break;

                default:
                    sum = sum + sum;
                    break;


            }

            switch (dessert)
            {
                case 1:
                    sum = sum + 167;
                    break;
                case 2:
                    sum = sum + 266;
                    break;
                case 3:
                    sum = sum + 75;
                    break;

                default:
                    sum = sum + sum;
                    break;


            }


            return sum;
        }
    
        
    }

}
