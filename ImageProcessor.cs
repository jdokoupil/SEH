using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SEH.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;

namespace SEH
{
    public class ImageProcessor
    {
        public ResultModel LoadImage(string query)
        {
            string key = "AIzaSyCfDWelLn7sI1ggN7_TM128MPPURD8B1k0";
            string cx = "b085523138bb4b441";
            string url = "https://customsearch.googleapis.com/customsearch/v1?key=AIzaSyCfDWelLn7sI1ggN7_TM128MPPURD8B1k0&cx=b085523138bb4b441&fileType=.png&q=dogs";
            //string url = "https://www.customsearch.googleapis.com/customsearch/v1?key=" + key + "&cx" + cx + "&q=" + query;
            //var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + key + "&cx" + cx + "&q=" + query);

            HttpResponseMessage response = Google_API.Get(url);
            response.EnsureSuccessStatusCode();
            HttpContent content = response.Content;
            Task<string> s = content.ReadAsStringAsync();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(s.Result);

            //List<JToken> pagemap_objs = new List<JToken>();
            List<JToken> final = new List<JToken>();

            foreach (JObject obj in jsonData["items"])
            {
                JObject jsonData2 = (JObject)JsonConvert.DeserializeObject(obj.ToString());

                foreach (JObject pagemap_obj in jsonData2["pagemap"])
                {
                    Console.WriteLine("found a pagemap");
                }


                //JObject entry = (JObject)JsonConvert.DeserializeObject(sub_obj.ToString());
                //foreach (KeyValuePair<string, JToken> subentry in entry)
                //{
                //    if (subentry.Key.Equals("pagemap"))
                //    {
                //        String s2 = subentry.Value.ToString();
                //        //Console.WriteLine(s2);
                //        JObject img_json = (JObject)JsonConvert.DeserializeObject(s2);
                //        foreach (JObject img_entry in img_json["pagemap"])
                //        {
                //            foreach(KeyValuePair<string,JToken> sub_img_entry in )
                //        }
                //    }
                //}
                //if (obj.ContainsKey("pagemap"))
                //{
                //    Console.WriteLine("found a pagemap");
                //    pagemap_objs.Add(obj);
                //}
                //foreach (JObject pagemap_obj in pagemap_objs[])
                //{
                //    if (pagemap_obj.ContainsKey("img_src"))
                //    {
                //        Console.WriteLine("found an img_src");
                //    }
                //}
            }

            return new ResultModel();
        }
    }
}
