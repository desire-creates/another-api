using Microsoft.AspNetCore.HTTP;
using Microsoft.AspNetCore.MVC;

namespace HPlusSport.API.Controllers{
    [Route("api/controller")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts(){
            return "OK";
        }
    }
}