using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using Stream.BLL;

namespace Webservices
{
    /// <summary>
    /// Summary description for Streams
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Streams : System.Web.Services.WebService {

        public Streams () {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void HelloWorld()
        {
            var t = new hello();
            t.Message = "Hello World ";

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Context.Response.Write(js.Serialize(t));
        }

        class hello
        {
            public string Message { get; set; }
        }

        [WebMethod]
        public void StreamList()
        {
            var streamList = new StreamData().GetStreamList();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Context.Response.Write(js.Serialize(streamList));
        }

        [WebMethod]
        public string IncrementStreamViews(int streamID)
        {
            new StreamData().StreamViewsCounter(streamID);
            return "Added";
        }

    }
}
