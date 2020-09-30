namespace ChatApplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textlocalport = new System.Windows.Forms.TextBox();
            this.textlocalip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textdestport = new System.Windows.Forms.TextBox();
            this.textdestip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textmsg = new System.Windows.Forms.TextBox();
            this.buttonenv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listmsgs = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textlocalport);
            this.groupBox1.Controls.Add(this.textlocalip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(268, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // textlocalport
            // 
            this.textlocalport.Location = new System.Drawing.Point(108, 66);
            this.textlocalport.Name = "textlocalport";
            this.textlocalport.Size = new System.Drawing.Size(100, 20);
            this.textlocalport.TabIndex = 3;
            // 
            // textlocalip
            // 
            this.textlocalip.Location = new System.Drawing.Point(108, 29);
            this.textlocalip.Name = "textlocalip";
            this.textlocalip.Size = new System.Drawing.Size(100, 20);
            this.textlocalip.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textdestport);
            this.groupBox2.Controls.Add(this.textdestip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(268, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // textdestport
            // 
            this.textdestport.Location = new System.Drawing.Point(104, 66);
            this.textdestport.Name = "textdestport";
            this.textdestport.Size = new System.Drawing.Size(100, 20);
            this.textdestport.TabIndex = 5;
            // 
            // textdestip
            // 
            this.textdestip.Location = new System.Drawing.Point(104, 29);
            this.textdestip.Name = "textdestip";
            this.textdestip.Size = new System.Drawing.Size(100, 20);
            this.textdestip.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 149);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(789, 40);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Star server";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textmsg
            // 
            this.textmsg.Location = new System.Drawing.Point(51, 441);
            this.textmsg.Name = "textmsg";
            this.textmsg.Size = new System.Drawing.Size(556, 20);
            this.textmsg.TabIndex = 3;
            // 
            // buttonenv
            // 
            this.buttonenv.Location = new System.Drawing.Point(622, 434);
            this.buttonenv.Name = "buttonenv";
            this.buttonenv.Size = new System.Drawing.Size(163, 27);
            this.buttonenv.TabIndex = 5;
            this.buttonenv.Text = "Envoyer";
            this.buttonenv.UseVisualStyleBackColor = true;
            this.buttonenv.Click += new System.EventHandler(this.buttonenv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(773, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // listmsgs
            // 
            this.listmsgs.Location = new System.Drawing.Point(51, 360);
            this.listmsgs.Multiline = true;
            this.listmsgs.Name = "listmsgs";
            this.listmsgs.Size = new System.Drawing.Size(556, 57);
            this.listmsgs.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listmsgs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonenv);
            this.Controls.Add(this.textmsg);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chat Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textlocalport;
        private System.Windows.Forms.TextBox textlocalip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textdestport;
        private System.Windows.Forms.TextBox textdestip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textmsg;
        private System.Windows.Forms.Button buttonenv;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox listmsgs;
        private System.Windows.Forms.Button button2;
    }
}

