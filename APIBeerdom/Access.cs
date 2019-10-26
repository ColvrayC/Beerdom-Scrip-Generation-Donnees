using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace APIBeerdom
{
    public class Access
    {

        public List<beers> Get()
        {
            //?page={1}&per_page=80
            var beers = new List<beers>();
            var page =1;
            var nothing = false;

            while(!nothing)
            {
                var url = string.Format("{0}beers?page={1}&per_page=80", ServiceConnection.RestClient.BaseAddress.AbsoluteUri, page);
                var response = ServiceConnection.RestClient.GetAsync(new Uri(url)).Result;
                var resut = JsonConvert.DeserializeObject<List<beers>>(response.Content.ReadAsStringAsync().Result);

                if(resut.Count==0) { nothing = true; }
                page += 1;
                beers.AddRange(resut);
            }
         
            return beers;
        }
    }
}
