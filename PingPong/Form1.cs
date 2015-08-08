using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using MetroFramework.Forms;
using PingPong.Arquivo;
using PingPong.Model;
using PingPong.Service;

namespace PingPong
{
    public partial class Form1 : MetroForm
    {
        AcessoHost banco;
        List<Host> hosts;
        public Form1()
        {
            InitializeComponent();
            lbl_diretorioDados.Text = Properties.Settings.Default.diretorioDados;
            banco = new AcessoHost("banco.s3db");
            hosts = banco.obterHosts();
            preencheList();
            iniciaChecagem();
        }

        public void preencheList()
        {
            int i = 0;
            lst_hosts.Items.Clear();
            foreach (Host h in hosts)
            {
                lst_hosts.Items.Add(h.id_host + "");
                lst_hosts.Items[i].SubItems.Add(h.nome);
                lst_hosts.Items[i].SubItems.Add(h.ip);
                lst_hosts.Items[i].SubItems.Add(h.em_pe ? "Sim" : "Não");
                lst_hosts.Items[i].SubItems.Add(h.ultima_alteracao);

                i++;
            } 
        }

        public void iniciaChecagem()
        {
            foreach (Host h in hosts)
            {
                Thread t = new Thread(() => vaiTestando(h));
                t.Start();
            }         
        }

        public void vaiTestando(Host host)
        {
            while (host.ativo)
            {
                Thread t = new Thread(() => PingHost(host, 5));
                t.Start();
                Thread.Sleep(5000);
            }
        }

        public void PingHost(Host host, int numeroTestes)
        {
            bool pingou = true;
            Ping pinger = new Ping();
            try
            {
                for (int i = 0; i < numeroTestes; i++)
                {
                    if (!pingou)
                        break;
                    PingReply reply = pinger.Send(host.ip);
                    pingou = reply.Status == IPStatus.Success;
                }
            }
            catch (PingException)
            {
                pingou = false;
            }

            if (host.em_pe != pingou)
            {
                host.em_pe = pingou;
                host.ultima_alteracao = DateTime.Now.ToString();
                banco.atualizarHost(host);
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int posicao = -1;
            if (lst_hosts.SelectedIndices.Count > 0)
                posicao = lst_hosts.SelectedIndices[0];

            if (posicao != -1)
            {
                banco.removerHost(hosts[posicao]);
                hosts = banco.obterHosts();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoHost novo = new NovoHost(banco);
            novo.ShowDialog();
            if (novo.getCadastrou())
            {
                hosts = banco.obterHosts();

                Thread t = new Thread(() => vaiTestando(hosts[hosts.Count-1]));
                t.Start();
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void timerLista_Tick(object sender, EventArgs e)
        {
            hosts = banco.obterHosts();
            preencheList();

            XElement xml = new Conversao().parseToXML<List<Host>>(hosts);
            System.IO.File.WriteAllText(Properties.Settings.Default.diretorioDados + @"\dados.xml", xml.ToString().Replace("ArrayOfHost", "list").Replace("Host", "Model.Host"));

        }

        private void lbl_diretorioDados_Click(object sender, EventArgs e)
        {
            buscaDiretorioDados();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            buscaDiretorioDados();
        }
        private void buscaDiretorioDados()
        {
            DialogResult result = buscaDiretorio.ShowDialog();
            lbl_diretorioDados.Text = buscaDiretorio.SelectedPath;

            Properties.Settings.Default.diretorioDados = buscaDiretorio.SelectedPath;
            Properties.Settings.Default.Save();
        }
    }
}
