using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APIBeerdom
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chargement des donées depuis l'API.");
            var result = new Access().Get();


            var sql = new DatasString();
            foreach(var beer in result)
            {
                sql.setSqlBeers(beer);

                //Download Img
                //var oImg = new DownloadImg();
                //oImg.start(beer.image_url);
            }

            //save
            File.WriteAllText(Const.PathContent+"\\beers.sql", sql.requestBeers);
  
            

            Console.WriteLine(@"Fichier sql dans : C:\DownloadedImageFromUrl\beers.sql");
            Console.Read();



        }
    }
}
