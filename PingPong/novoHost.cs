using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PingPong.Model;
using PingPong.Service;

namespace PingPong
{
    public partial class NovoHost : MetroForm
    {
        Host host;
        AcessoHost banco;
        bool cadastrou;
        public NovoHost(AcessoHost banco)
        {
            cadastrou = false;
            this.banco = banco;
            InitializeComponent();
        }
        public bool getCadastrou()
        {
            return cadastrou;
        }
        public Host getHost()
        {
            return host;
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            host = new Host();
            host.nome = txt_nome.Text;
            host.ip = txt_ip.Text;
            host.em_pe = false;
            host.ativo = true;
            host.ultima_alteracao = DateTime.Now.ToString();
            banco.inserirHost(host);
            cadastrou = true;

            this.Close();
        }

    
    }
}
