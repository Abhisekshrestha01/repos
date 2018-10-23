using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Web;
using System.Xml.Linq;

namespace XMLLink
{
    public class XMLhelper
    {
        string location = HttpContext.Current.Server.MapPath("~/Flight_registration.xml");
        public void InsertData(string fname, string name, string Dcity, string Ddate, string Acity, string ATime, string NSeats)
        {
            XDocument xmlDocument = XDocument.Load(location);
               

               xmlDocument.Element("Flights").Add(
                                new XElement("Flight",
                               new XElement("flightno", fname),
                               new XElement("fligHtName", name),
                               new XElement("DepartureCity", Dcity),
                               new XElement("DepartureDate", Ddate),
                               new XElement("ArrivalCity", Acity),
                               new XElement("ArrivalTime", ATime),
                               new XElement("NoOfSeats", NSeats))
                               
                           );

            xmlDocument.Save(location);
            //XmlDocument xmldoc = new XmlDocument();

            //xmldoc.Load(location);
            //XmlElement parentelement = xmldoc.CreateElement("Flights");

            //XmlElement flightno = xmldoc.CreateElement("flightno");
            //flightno.InnerText = fname;
            //XmlElement name1 = xmldoc.CreateElement("fligHtName");
            //name1.InnerText = name;
            //XmlElement Dcity1 = xmldoc.CreateElement("DepartureCity");
            //Dcity1.InnerText = Dcity;
            //XmlElement Ddate1 = xmldoc.CreateElement("DepartureDate");
            //Ddate1.InnerText = Ddate;
            //XmlElement Acity1 = xmldoc.CreateElement("ArrivalCity");
            //Acity1.InnerText = Acity;
            //XmlElement ATime1 = xmldoc.CreateElement("ArrivalTime");
            //ATime1.InnerText = ATime;
            //XmlElement Nseats1 = xmldoc.CreateElement("NoOfSeats");
            //Nseats1.InnerText = NSeats;
            //parentelement.AppendChild(flightno);
            //parentelement.AppendChild(name1);
            //parentelement.AppendChild(Dcity1);
            //parentelement.AppendChild(Ddate1);
            //parentelement.AppendChild(Acity1);
            //parentelement.AppendChild(ATime1);
            //parentelement.AppendChild(Nseats1);
            //xmldoc.DocumentElement.AppendChild(parentelement);

            //xmldoc.Save(location);

        }
        public DataSet GetList()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(HttpContext.Current.Server.MapPath(@"~\Flights.xml"));
            return ds;
        }
        public XmlNode GetselectedData(string flightid)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(location);
            XmlNode node = xmldoc.SelectSingleNode("Flights/Flight[flightno='" + flightid + "']");
            return node;
        }
        public DataSet ShowXMLFIleData()
        {
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(location);
                return ds;
            }
        }

    }
}
