using SEH.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SEH
{
    public class ImageProcessor
    {
        public ResultModel LoadImage( string query )
        {
            string key = "AIzaSyCfDWelLn7sI1ggN7_TM128MPPURD8B1k0";
            string cx = "b085523138bb4b441";
            string url = "https://www.googleapis.com/customsearch/v1?key=" + key + "&cx" + cx + "&q=" + query;
            //var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + key + "&cx" + cx + "&q=" + query);
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //using (HttpResponseMessage response = await Google_API.ApiClient.GetAsync(url))
            //{
            //    if ( response.IsSuccessStatusCode)
            //    {
            //        ResultModel result = await response.Content.ReadAsAsync<ResultModel>();
            //        return result;
            //    }
            //    else
            //    {
            //        throw new Exception(response.ReasonPhrase);
            //    }
            //}
            HttpResponseMessage response = Google_API.Get(url);
            MessageBox.Show(response.ToString());
            return new ResultModel();
        }
    }
}
