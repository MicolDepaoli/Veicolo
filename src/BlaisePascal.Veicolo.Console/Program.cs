using System;
using System.Collections.Generic;
using System.Text;

namespace blaisePascal.veicolo.domain{
    internal class Veicolo1
    {
        static void Main(string[] args)
        {
            Veicolo veicolo=new Veicolo("abc");
            //veicolo.LicensePlate = "abc";
            string license = veicolo.LicensePlate;

            
            Console.WriteLine(license);
            

        }
    }
       
}