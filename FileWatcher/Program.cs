using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer ws = new Observer(Common.Common.PATH);
            //Common.Common.SerializeList(new Producto()
            //{
            //    Id=95,
            //    idBrand = 1,
            //    idCatalog = 4,
            //    idColor = 2,
            //    idProvider = 1,
            //    idType = 1,
            //    title = "ADIDAS",
            //    nombre = "NIKE",
            //    observations = "sdadasd",
            //    description = "sdadadadadadadad",
            //    priceClient = 150m,
            //    priceDistributor = 200m,
            //    priceMember = 300m,
            //    isEnabled = true,
            //    dateUpdate = DateTime.Now
            //}, "1.xml");
            
            Console.ReadLine();
        }
    }
}
