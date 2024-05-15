using Microsoft.AspNetCore.Identity;
using TC_Kimlik_Doğrulama.Services;
using Kimlik_Sorgu_KPS;
using Microsoft.IdentityModel.Xml;
namespace TC_Kimlik_Doğrulama.Services.Concretes
{
    public class ServiceKPSPublic
    {
        public async Task<bool> OnGetServiceAsync(long TCKimlikNo, string Ad, string Soyad, int DogumYili)
        {
            var result = false; 
            var client = new Kimlik_Sorgu_KPS.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(TCKimlikNo, Ad, Soyad, DogumYili);
             result = response.Body.TCKimlikNoDogrulaResult;
            return result;
               
        }  
        
    }
}
