using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bjerre.Scraper
{
    public class Scraper
    {
        public CookieContainer _cookieContainer = new CookieContainer();

        public string LastContent { get; set; }
        public string LastCookies { get; set; }

        public string PerformRequest(string url)
        {
            return PerformRequest(url, null);
        }

        public string PerformRequest(string url, string postdata)
        {
            var request = CreateRequest(url, postdata);
            MakeRequest(postdata,request);
            return LastContent;
        }

        private HttpWebRequest CreateRequest(string url, string postdata)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = (postdata != null) ? Constants.ScrapeConstants.POST_REQUEST : Constants.ScrapeConstants.GET_REQUEST;
            request.CookieContainer = _cookieContainer;
            if (postdata != null)
            {
                request.ContentType = "application/x-www-form-urlencoded";
                var bytes = Encoding.UTF8.GetBytes(postdata);
                request.ContentLength = bytes.Length;
                var requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
            }
            return request;
        }

        private void MakeRequest(string postdata, HttpWebRequest request)
        {
            using (var response = request.GetResponse())
            {
                //_location = response.Headers["Location"];
                using (var stream = response.GetResponseStream())
                {
                    if (stream == null) return;
                    using (var reader = new StreamReader(stream))
                    {
                        LastContent = reader.ReadToEnd();
                    }
                }
            }
        }

        public string ShowCookies(string url)
        {
            var uri = new Uri(url);
            return _cookieContainer.GetCookies(uri).ToString();

            //for (int i = 0; i < response.Headers.Count; ++i)
            //    Console.WriteLine("\nHeader Name:{0}, Value :{1}", response.Headers.Keys[i], response.Headers[i]);
        }
    }
}
