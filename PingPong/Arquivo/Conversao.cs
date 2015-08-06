using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Net;
//using System.Net.Sockets;

namespace PingPong.Arquivo
{
    public class Conversao
    {
        public XElement parseToXML<T>(T dicionario)
        {
            XElement xml = null;
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                using (MemoryStream memory = new MemoryStream())
                {
                    using (TextReader tr = new StreamReader(memory, Encoding.UTF8))
                    {
                        ser.Serialize(memory, dicionario);
                        memory.Position = 0;
                        xml = XElement.Load(tr);
                        xml.Attributes().Where(x => x.Name.LocalName.Equals("xsd") || x.Name.LocalName.Equals("xsi")).Remove();

                    }
                }

            }
            catch (Exception e)
            {
                throw;
            }

            return xml;
        }

        internal XmlDocument parserToXml(string dados)
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(dados);
            }
            catch (Exception E)
            {
                E.ToString();
            }

            return xml;
        }

        internal T parseToObjet<T>(XmlDocument xml, T obj)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(xml.OuterXml.ToString())))
                obj = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
            return obj;
        }


    }
}
