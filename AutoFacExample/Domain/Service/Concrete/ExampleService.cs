using AutoFacExample.Domain.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacExample.Domain.Service.Concrete
{
    public class ExampleService : IExampleService
    {
        public string GetMessage(string message)
        {
            return message + " " + DateTime.Now.ToString();
        }
    }
}