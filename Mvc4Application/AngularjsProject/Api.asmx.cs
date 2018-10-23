using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.Services;
using Channellibrary;
using System.Web.Script.Serialization;
namespace AngularjsProject
{
    /// <summary>
    /// Summary description for Api
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void GetChannel()
        {
            var obj = new ChannelDAL();
            DataSet ds = obj.GetChannel();
            JavaScriptSerializer objSerial = new JavaScriptSerializer();
            HttpContext.Current.Response.Write(objSerial.Serialize(DataTableToJSONWithJavaScriptSerializer(ds.Tables[0])));
            //   return "Hello World";
        }

        [WebMethod]
        public void GetSupplier()
        {
            var obj = new ChannelDAL();
            DataSet ds = obj.GetSupplier();
            JavaScriptSerializer objSerial = new JavaScriptSerializer();
            HttpContext.Current.Response.Write(objSerial.Serialize(DataTableToJSONWithJavaScriptSerializer(ds.Tables[0])));
            //   return "Hello World";
        }

        [WebMethod]
        public void GeProduct()
        {
            var obj = new ChannelDAL();
            DataSet ds = obj.GetProduct();
            JavaScriptSerializer objSerial = new JavaScriptSerializer();
            HttpContext.Current.Response.Write(objSerial.Serialize(DataTableToJSONWithJavaScriptSerializer(ds.Tables[0])));
            //   return "Hello World";
        }

        private string DataTableToJSONWithJavaScriptSerializer(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return jsSerializer.Serialize(parentRow);
        }
    }
}
