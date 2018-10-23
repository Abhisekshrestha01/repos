using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Channellibrary
{
    public class ChannelDAL
    {
        public void AddChannel(string name, string type, bool staus)
        {
            SQLHelper obj = new SQLHelper();
            obj.RunSql("insert into tbl_channel(name,type,status)values('" + name + "','" + type + "',1)");
        }

        public DataSet GetChannel()
        {
            SQLHelper obj = new SQLHelper();
           return  obj.RunSqlReturnDs("select * from  tbl_channel");
        }
        public DataSet GetSupplier()
        {
            SQLHelper obj = new SQLHelper();
            return obj.RunSqlReturnDs("select distinct s.Id,s.CompanyName,s.ContactName,s.Phone,s.Country from supplier s ");
        }

        public DataSet GetProduct()
        {
            SQLHelper obj = new SQLHelper();
            return obj.RunSqlReturnDs("select distinct p.Id as ProductID,p.ProductName,p.UnitPrice,p.Package from product p ");
        }

    }
}