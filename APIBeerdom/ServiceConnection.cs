using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace APIBeerdom
{
    public static class ServiceConnection
    {
        private static HttpClient _RestClient;
        public static HttpClient RestClient
        {
            get
            {
                if (_RestClient == null)
                    RestClient = new HttpClient();

                return _RestClient;
            }
            private set
            {
                if (_RestClient == null)
                {
                    _RestClient = value;
                    _RestClient.BaseAddress = new Uri(Const.UriBaseAdress);
                    _RestClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                }
            }
        }

        static ServiceConnection()
        {
            Init();
        }

        public static void Init()
        {
            RestClient = new HttpClient();
        }

    }
}
