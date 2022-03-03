using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WebApi_Handson.filter
{
    public class CustomExceptionfilter:IExceptionFilter
    {

        StreamWriter sw = new StreamWriter("C://naruto/WebApi/Custom.txt");

        public void OnException(ExceptionContext context)
        {
            sw.Write(context.Result);
        }
    }
}
