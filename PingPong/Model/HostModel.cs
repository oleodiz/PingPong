using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Model
{
    public class HostModel
    {
        public int id_host { get; set; }
        public string nome { get; set; }
        public string ip { get; set; }
        public bool ativo { get; set; }
        public bool em_pe { get; set; }
        public String ultima_alteracao { get; set; }
    }
}
