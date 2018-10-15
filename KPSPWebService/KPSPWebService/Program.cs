using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPSPWebService.KpspService;

namespace KPSPWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            KPSPublicSoapClient kpsPublicSoapClient = new KPSPublicSoapClient();

            //Console.WriteLine(kpsPublicSoapClient.TCKimlikNoDogrula(Long TC NO, "String Büyük Harf Ad".ToUpper(), "String Büyük Harf Soyad".ToUpper(), int Doğum Yılı));

            Console.ReadLine();
        }
    }
}
