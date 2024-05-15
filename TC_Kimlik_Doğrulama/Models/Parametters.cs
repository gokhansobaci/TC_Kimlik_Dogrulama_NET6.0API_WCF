namespace TC_Kimlik_Doğrulama.Models
{
    public class Parametters
    {
        //          <soap:Body>
        //    <TCKimlikNoDogrula xmlns = "http://tckimlik.nvi.gov.tr/WS" >
        //      < TCKimlikNo > long </ TCKimlikNo >
        //      < Ad > string </ Ad >
        //      < Soyad > string </ Soyad >
        //      < DogumYili > int </ DogumYili >
        //    </ TCKimlikNoDogrula >
        //  </ soap:Body>
        //</soap:Envelope>


        public long TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
    }
}
