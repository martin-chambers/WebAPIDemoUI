using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.Configuration;

namespace WebAPIDemoUI.Models
{
    public class WebjobService
    {
        [DisplayName("History:")]
        public string History { get; set; }
        [DisplayName("Status:")]
        public HttpStatusCode StatusCode{get;set;}
        public async Task RunWebjob()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
            // the creds from my .publishsettings file
            string username = ConfigurationManager.AppSettings["User"];
            string password = ConfigurationManager.AppSettings["Password"];
            var byteArray = Encoding.ASCII.GetBytes(username + ":" + password);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            // POST to the run action for my job
            var runResponse = await client.PostAsync("api/triggeredwebjobs/pca/run/", null);
            this.StatusCode = runResponse.StatusCode;
            string historyResponse = await client.GetStringAsync("api/triggeredwebjobs/pca/history/");
            History = historyResponse;
        }
    }
}