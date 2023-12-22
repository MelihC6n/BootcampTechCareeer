using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootcampWebApiCreate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            string[] countries = new string[]{
            "United States", "Canada", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and/or Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh"
             };

            return countries;
        }

        [HttpGet("{id}")]
        public string Get2(int id)
        {
            string[] countries = new string[]{
            "United States", "Canada", "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and/or Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh"
            };



        if (id < 0 || id >= countries.Length)
            {
                return "ID bulunamadı";
            }
            else
            {
                string result = "";
                for (int i = 0; i < id; i++)
                {
                    result += countries[i]+", ";
                };
                return result;

            }
        }

    } 
}