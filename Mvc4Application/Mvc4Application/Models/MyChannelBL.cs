using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4Application.Models
{
    public class MyChannelBL
    {
        public void AddChannel(MyChannels objChn)
        {
            Channellibrary.ChannelDAL obj = new Channellibrary.ChannelDAL();
            obj.AddChannel(objChn.Name, objChn.Type, objChn.Status);
        }
    }
}