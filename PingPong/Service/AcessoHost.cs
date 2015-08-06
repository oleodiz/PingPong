using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using PingPong.Model;

namespace PingPong.Service
{
    public class AcessoHost
    {

        SQLiteConnection conn;
        String stringConn;
        
        public AcessoHost(String diretorioBanco)
        {
            stringConn = @"Data Source=" + diretorioBanco;
            conn = new SQLiteConnection(stringConn);
        }

        public List<HostModel> obterHosts()
        {
            DataTable dt = new DataTable();
            List<HostModel> hosts = new List<HostModel>();
            String insSQL = "select id_host, nome, ip, cast (ativo as varchar) as ativo, cast(em_pe as varchar) as em_pe, ultima_alteracao from TB_HOST";

            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, stringConn);
           
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++ )
            {
                HostModel h = new HostModel();

                h.id_host = Convert.ToInt32(dt.Rows[i]["ID_HOST"].ToString());
                h.nome = dt.Rows[i]["NOME"].ToString();
                h.ip = dt.Rows[i]["IP"].ToString();
                h.ativo = Convert.ToBoolean(dt.Rows[i]["ATIVO"]);
                h.em_pe = Convert.ToBoolean(dt.Rows[i]["EM_PE"]);
                h.ultima_alteracao = dt.Rows[i]["ULTIMA_ALTERACAO"].ToString();
                hosts.Add(h);
            }
            return hosts;
        }

        public void inserirHost(HostModel host)
        {
            DataTable dt = new DataTable();
            String insSQL = "INSERT INTO TB_HOST (NOME, IP, ATIVO, EM_PE, ULTIMA_ALTERACAO) VALUES ('"+
                             host.nome + "', '" + host.ip + "','" + host.ativo + "','" + host.em_pe + "', '" + host.ultima_alteracao + "')";

            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, stringConn);

            da.Fill(dt);
        }

        public void atualizarHost(HostModel host)
        {
            DataTable dt = new DataTable();
            String insSQL = "UPDATE TB_HOST SET NOME = '" + host.nome + "', IP='" + host.ip + "', ATIVO = '" + host.ativo + "', EM_PE = '" + host.em_pe + "', ULTIMA_ALTERACAO = '" + host.ultima_alteracao +"' WHERE ID_HOST = "+host.id_host;

            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, stringConn);

            da.Fill(dt);
        }

        public void removerHost(HostModel host)
        {
            DataTable dt = new DataTable();
            String insSQL = "DELETE FROM TB_HOST WHERE ID_HOST = " + host.id_host;

            SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, stringConn);

            da.Fill(dt);
        }     
    }
 
}
