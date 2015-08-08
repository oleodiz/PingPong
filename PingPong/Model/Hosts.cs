using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PingPong.Model
{
    public class Hosts
    {
        [XmlElement(ElementName = "Hosts")]
        public List<Host> hosts { get; set; }

        public Hosts()
        {
            hosts = new List<Host>();
        }
    }
}
