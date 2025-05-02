
namespace GestionPersonne
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDecon = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btPhone = new System.Windows.Forms.Button();
            this.btPerson = new System.Windows.Forms.Button();
            this.ControlerUser = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1127, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btUsers);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btPhone);
            this.panel2.Controls.Add(this.btPerson);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 697);
            this.panel2.TabIndex = 13;
            // 
            // btDecon
            // 
            this.btDecon.FlatAppearance.BorderSize = 0;
            this.btDecon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecon.ForeColor = System.Drawing.Color.Red;
            this.btDecon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDecon.Location = new System.Drawing.Point(207, 3);
            this.btDecon.Name = "btDecon";
            this.btDecon.Size = new System.Drawing.Size(203, 52);
            this.btDecon.TabIndex = 14;
            this.btDecon.Text = "Deconnexion";
            this.btDecon.UseVisualStyleBackColor = true;
            this.btDecon.Click += new System.EventHandler(this.btDecon_Click);
            // 
            // btUsers
            // 
            this.btUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btUsers.FlatAppearance.BorderSize = 0;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.ForeColor = System.Drawing.Color.White;
            this.btUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsers.Location = new System.Drawing.Point(4, 428);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(203, 52);
            this.btUsers.TabIndex = 13;
            this.btUsers.Text = "Utilisateurs";
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(5, 360);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(202, 52);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Adresses";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btPhone
            // 
            this.btPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btPhone.FlatAppearance.BorderSize = 0;
            this.btPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhone.ForeColor = System.Drawing.Color.White;
            this.btPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPhone.Location = new System.Drawing.Point(4, 288);
            this.btPhone.Name = "btPhone";
            this.btPhone.Size = new System.Drawing.Size(203, 52);
            this.btPhone.TabIndex = 11;
            this.btPhone.Text = "Telephones";
            this.btPhone.UseVisualStyleBackColor = true;
            this.btPhone.Click += new System.EventHandler(this.btPhone_Click);
            // 
            // btPerson
            // 
            this.btPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btPerson.FlatAppearance.BorderSize = 0;
            this.btPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerson.ForeColor = System.Drawing.Color.White;
            this.btPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPerson.Location = new System.Drawing.Point(4, 216);
            this.btPerson.Name = "btPerson";
            this.btPerson.Size = new System.Drawing.Size(203, 52);
            this.btPerson.TabIndex = 10;
            this.btPerson.Text = "Personnes";
            this.btPerson.UseVisualStyleBackColor = true;
            this.btPerson.Click += new System.EventHandler(this.btPerson_Click);
            // 
            // ControlerUser
            // 
            this.ControlerUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlerUser.Location = new System.Drawing.Point(207, 58);
            this.ControlerUser.Name = "ControlerUser";
            this.ControlerUser.Size = new System.Drawing.Size(1028, 639);
            this.ControlerUser.TabIndex = 14;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.Image = global::GestionPersonne.Properties.Resources.icons8_Close_40px;
            this.btExit.Location = new System.Drawing.Point(1184, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(51, 52);
            this.btExit.TabIndex = 5;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GestionPersonne.Properties.Resources.icons8_crowd_200px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 193);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 52);
            this.button2.TabIndex = 15;
            this.button2.Text = "Restorer Config";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 697);
            this.Controls.Add(this.btDecon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ControlerUser);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDecon;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btPhone;
        private System.Windows.Forms.Button btPerson;
        private System.Windows.Forms.Panel ControlerUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}