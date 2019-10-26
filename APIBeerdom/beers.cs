using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBeerdom
{
    public class beers
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string first_brewed { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public string abv { get; set; }
        public string ibu { get; set; }
        public string target_fg { get; set; }
        public string target_og { get; set; }
        public string ebc { get; set; }
        public string srm { get; set; }
        public string ph { get; set; }
        public string attenuation_level { get; set; }
        public Volume volume { get; set; }
        public BoilVolume boil_volume { get; set; }
        public Method method { get; set; }
        public Ingredients ingredients { get; set; }
        public IList<string> food_pairing { get; set; }
        public string brewers_tips { get; set; }
        public string contributed_by { get; set; }
    }

    public class Amount
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class Malt
    {
        public string name { get; set; }
        public Amount amount { get; set; }
    }

    public class Hop
    {
        public string name { get; set; }
        public Amount amount { get; set; }
        public string add { get; set; }
        public string attribute { get; set; }
    }

    public class Ingredients
    {
        public IList<Malt> malt { get; set; }
        public IList<Hop> hops { get; set; }
        public string yeast { get; set; }
    }

    public class Volume
    {
        public decimal value { get; set; }
        public string unit { get; set; }
    }

    public class BoilVolume
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class Temp
    {
        public string value { get;
            set; }
        public string unit { get; set; }
    }

    public class MashTemp
    {
        public Temp temp { get; set; }
        public string duration { get; set; }
    }

    public class Fermentation
    {
        public Temp temp { get; set; }
    }

    public class Method
    {
        public IList<MashTemp> mash_temp { get; set; }
        public Fermentation fermentation { get; set; }
        public object twist { get; set; }
    }

}
