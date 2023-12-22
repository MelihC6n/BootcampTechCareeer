using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootcampWebApiCreate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        public List<string> Get()
        {
            return new List<string>
            {
                "Ankara",
                "Erzurum",
                "İstanbul",
                "Adana",
                "İzmir"
            };

        }
    }

}