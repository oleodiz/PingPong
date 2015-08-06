namespace PingPong
{
    partial class NovoHost
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
            this.btn_cadastrar = new MetroFramework.Controls.MetroButton();
            this.txt_nome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_ip = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(140, 177);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseSelectable = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Lines = new string[0];
            this.txt_nome.Location = new System.Drawing.Point(23, 78);
            this.txt_nome.MaxLength = 32767;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(192, 23);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(23, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "IP:";
            // 
            // txt_ip
            // 
            this.txt_ip.Lines = new string[0];
            this.txt_ip.Location = new System.Drawing.Point(23, 138);
            this.txt_ip.MaxLength = 32767;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.PasswordChar = '\0';
            this.txt_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ip.SelectedText = "";
            this.txt_ip.Size = new System.Drawing.Size(192, 23);
            this.txt_ip.TabIndex = 3;
            this.txt_ip.UseSelectable = true;
            // 
            // NovoHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 223);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_cadastrar);
            this.Name = "NovoHost";
            this.Text = "Novo Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_cadastrar;
        private MetroFramework.Controls.MetroTextBox txt_nome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_ip;
    }
}