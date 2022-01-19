using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;
using IOperationFilter = Swashbuckle.Swagger.IOperationFilter;

namespace TestApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/test123")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string GetMessage(string x)
        {
            return "Good Morning1234";
        }
    }

    //[ApiVersion("2.0")]
    //[Route("api/test")]
    //[ApiController]
    //public class Test2Controller : ControllerBase
    //{
    //    [HttpGet]
    //    public string GetMessage()
    //    {
    //        return "Good Night";
    //    }
    //}

    public class AddRequiredHeaderParameter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
                operation.parameters = new List<Parameter>();

            operation.parameters.Add(new Parameter
            {
                name = "MyHeaderField",
                @in = "header",
                type = "string",
                description = "My header field",
                required = true
            });
        }
    }
}
