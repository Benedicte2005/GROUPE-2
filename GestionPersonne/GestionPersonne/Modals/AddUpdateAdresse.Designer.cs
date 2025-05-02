
namespace GestionPersonne.Modals
{
    partial class AddUpdateAdresse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateAdresse));
            this.titre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAv = new System.Windows.Forms.TextBox();
            this.ListePersonnes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titre.Location = new System.Drawing.Point(72, 61);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(268, 37);
            this.titre.TabIndex = 18;
            this.titre.Text = "Ajouter Adresse";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 58);
            this.panel1.TabIndex = 17;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Image = global::GestionPersonne.Properties.Resources.icons8_Close_40px;
            this.btExit.Location = new System.Drawing.Point(350, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(51, 52);
            this.btExit.TabIndex = 5;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(8, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 95;
            this.label4.Text = "Quartier";
            // 
            // txtQ
            // 
            this.txtQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtQ.ForeColor = System.Drawing.Color.Teal;
            this.txtQ.Location = new System.Drawing.Point(12, 273);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(380, 35);
            this.txtQ.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(8, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Avenue";
            // 
            // txtAv
            // 
            this.txtAv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtAv.ForeColor = System.Drawing.Color.Teal;
            this.txtAv.Location = new System.Drawing.Point(12, 203);
            this.txtAv.Name = "txtAv";
            this.txtAv.Size = new System.Drawing.Size(380, 35);
            this.txtAv.TabIndex = 92;
            // 
            // ListePersonnes
            // 
            this.ListePersonnes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListePersonnes.ForeColor = System.Drawing.Color.Teal;
            this.ListePersonnes.FormattingEnabled = true;
            this.ListePersonnes.Location = new System.Drawing.Point(12, 138);
            this.ListePersonnes.Name = "ListePersonnes";
            this.ListePersonnes.Size = new System.Drawing.Size(380, 36);
            this.ListePersonnes.TabIndex = 91;
            this.ListePersonnes.SelectedIndexChanged += new System.EventHandler(this.ListePersonnes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 90;
            this.label2.Text = "Personnes";
            // 
            // comboCountry
            // 
            this.comboCountry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCountry.ForeColor = System.Drawing.Color.Teal;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(12, 495);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(380, 36);
            this.comboCountry.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(8, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 100;
            this.label7.Text = "Pays";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(8, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 99;
            this.label6.Text = "Ville";
            // 
            // txtVi
            // 
            this.txtVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtVi.ForeColor = System.Drawing.Color.Teal;
            this.txtVi.Location = new System.Drawing.Point(12, 419);
            this.txtVi.Name = "txtVi";
            this.txtVi.Size = new System.Drawing.Size(380, 35);
            this.txtVi.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(8, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 97;
            this.label5.Text = "Commune";
            // 
            // txtCom
            // 
            this.txtCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtCom.ForeColor = System.Drawing.Color.Teal;
            this.txtCom.Location = new System.Drawing.Point(12, 346);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(380, 35);
            this.txtCom.TabIndex = 96;
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSave.FlatAppearance.BorderSize = 2;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSave.Location = new System.Drawing.Point(12, 556);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(383, 53);
            this.btSave.TabIndex = 102;
            this.btSave.Text = "Ajouter";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // AddUpdateAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 618);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAv);
            this.Controls.Add(this.ListePersonnes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUpdateAdresse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateAdresse";
            this.Load += new System.EventHandler(this.AddUpdateAdresse_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label titre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtQ;
        public System.Windows.Forms.TextBox txtAv;
        public System.Windows.Forms.ComboBox ListePersonnes;
        public System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtVi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCom;
        public System.Windows.Forms.Button btSave;
    }
}