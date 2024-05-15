using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TC_Kimlik_Doğrulama.Services.Concretes;

namespace TC_Kimlik_Doğrulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Validate(long TCKimlikNo,string Ad,string Soyad,int DogumYili)
        {
            ServiceKPSPublic serviceKPS = new ServiceKPSPublic();
            var result = await serviceKPS.OnGetServiceAsync(TCKimlikNo, Ad, Soyad, DogumYili); 
            if(result == true)
            {
                return Ok("Kimlik No Geçerlidir");
            }
            else
            {
                return BadRequest("Bu bir Kimlik No değildir");
            }
           
        }
       

    }
}
