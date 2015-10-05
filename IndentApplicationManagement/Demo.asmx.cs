using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Data.SqlClient;
namespace IndentApplicationManagement
{
    /// <summary>
    /// Summary description for Demo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Demo : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetData()
        {
            User auser = new User();
            auser.firstName = "shila";
            auser.lastName = "aysha";
            auser.position = "manager";
            auser.office = "dhaka";
            auser.startDate = "february 2";
            auser.salary = "20000";

            JavaScriptSerializer js=new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(auser));
        }
    }
}
