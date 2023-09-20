using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n11111111Assignment1.Controllers
{
    public class TimesFiftyController : ApiController
    {

        //GET api/TimesFifty/7 --> 49 
        public int Get(int id)
        {
            int product = id * 50;
            return product;
        }

        //POST api/TimesFifty -> "Secret POST Method"
        
        public string Post()
        {

            return "Secret POST Method!";
        }


    }
}
