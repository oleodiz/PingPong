using MetroFramework.Controls;
namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctx_hosts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_hosts = new System.Windows.Forms.ListView();
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerLista = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_diretorioDados = new System.Windows.Forms.Label();
            this.buscaDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.ctx_hosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctx_hosts
            // 
            this.ctx_hosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem});
            this.ctx_hosts.Name = "ctx_hosts";
            this.ctx_hosts.Size = new System.Drawing.Size(122, 26);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_hosts
            // 
            this.lst_hosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_hosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_hosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader41,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lst_hosts.ContextMenuStrip = this.ctx_hosts;
            this.lst_hosts.Font = new System.Drawing.Font("Calibri", 10F);
            this.lst_hosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lst_hosts.FullRowSelect = true;
            this.lst_hosts.GridLines = true;
            this.lst_hosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_hosts.HideSelection = false;
            this.lst_hosts.Location = new System.Drawing.Point(20, 60);
            this.lst_hosts.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lst_hosts.Name = "lst_hosts";
            this.lst_hosts.Size = new System.Drawing.Size(634, 306);
            this.lst_hosts.TabIndex = 64;
            this.lst_hosts.TabStop = false;
            this.lst_hosts.UseCompatibleStateImageBehavior = false;
            this.lst_hosts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "ID";
            this.columnHeader41.Width = 36;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Em pé";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Última alteração";
            this.columnHeader4.Width = 158;
            // 
            // timerLista
            // 
            this.timerLista.Enabled = true;
            this.timerLista.Interval = 3000;
            this.timerLista.Tick += new System.EventHandler(this.timerLista_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Dados salvos em: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_diretorioDados
            // 
            this.lbl_diretorioDados.AutoSize = true;
            this.lbl_diretorioDados.BackColor = System.Drawing.Color.White;
            this.lbl_diretorioDados.Location = new System.Drawing.Point(147, 379);
            this.lbl_diretorioDados.Name = "lbl_diretorioDados";
            this.lbl_diretorioDados.Size = new System.Drawing.Size(22, 13);
            this.lbl_diretorioDados.TabIndex = 66;
            this.lbl_diretorioDados.Text = "C:/";
            this.lbl_diretorioDados.Click += new System.EventHandler(this.lbl_diretorioDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 400);
            this.Controls.Add(this.lbl_diretorioDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_hosts);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "HOSTS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ctx_hosts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctx_hosts;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lst_hosts;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Timer timerLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_diretorioDados;
        private System.Windows.Forms.FolderBrowserDialog buscaDiretorio;


    }
}

