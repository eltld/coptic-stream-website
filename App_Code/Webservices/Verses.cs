using System.Web.Script.Serialization;
using System.Web.Services;
using Verse.BLL;

namespace Webservices
{
    /// <summary>
    /// Summary description for Verses
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
    public class Verses : System.Web.Services.WebService {

        public Verses () {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public void GetVerseOfTheDay()
        {
            var Verse = VerseData.GetVerseOfTheDay();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            //Context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Context.Response.Write(js.Serialize(Verse));
        }
    }
}
