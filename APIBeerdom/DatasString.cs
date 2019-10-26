using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBeerdom
{
    public class DatasString
    {
        public string requestBeers { get; set; }
        public DatasString()
        {
            string sqlIngredients = $@"INSERT INTO ingredients (id, name) 
            VALUES (41472, 'Practical PostgreSQL', 1212, 4);";

           
        }
        private int i = 19;
        public void setSqlBeers(beers beer)
        {
            
            //id_ingredients
            string sqlBeers = $@"INSERT INTO beer (id,alcohol,brand, brewery, ebc, ibu, name, uuid,image_path) VALUES ({i},{beer.abv},'{this.ReplaceEscape(beer.tagline)}','',{this.EmptyZero(beer.ebc)}, {this.EmptyZero(beer.ibu)}, '{this.ReplaceEscape(beer.name)}','{System.Guid.NewGuid()}','{this.FileNameImg(beer.image_url)}' );" + Environment.NewLine;
            i += 1;
            requestBeers += sqlBeers;
        }

        public  string ReplaceEscape(string str)
        {
            str = str.Replace("'", "''");
            return str;
        }

        public string fixNumber(string number)
        {
            if (number != null)
            {
                number = Convert.ToDecimal(Convert.ToDecimal(number.Replace(".", ",")) / 10).ToString().Replace(",", ".");
                return number;
            }
            else
            {
                return string.Empty;
            }
        }

        public string EmptyZero(string str)
        {
            if (str == string.Empty|| str == null)
                return "0";
            else
            {
                str = Convert.ToDecimal(Convert.ToDecimal(str.Replace(".", ","))).ToString().Replace(",", ".");
                return str;
            }
        }

        public string FileNameImg(string url)
        {
            

            if (url != null)
            {
                Uri uri = new Uri(url);
                var filename = string.Empty;
                filename = System.IO.Path.GetFileName(uri.LocalPath);
                return filename;
            }
            else
            {
                return string.Empty;
            }

            
        }

    }
}
