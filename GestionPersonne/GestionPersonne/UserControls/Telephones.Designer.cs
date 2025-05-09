
namespace GestionPersonne.UserControls
{
    partial class Telephones
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSup = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePhone = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.init = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhone)).BeginInit();
            this.SuspendLayout();
            // 
            // btSup
            // 
            this.btSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSup.FlatAppearance.BorderSize = 2;
            this.btSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSup.Location = new System.Drawing.Point(1146, 102);
            this.btSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(392, 69);
            this.btSup.TabIndex = 53;
            this.btSup.Text = "Supprimer";
            this.btSup.UseVisualStyleBackColor = true;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAdd.FlatAppearance.BorderSize = 2;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAdd.Location = new System.Drawing.Point(10, 102);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(392, 69);
            this.btAdd.TabIndex = 51;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btMod
            // 
            this.btMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMod.FlatAppearance.BorderSize = 2;
            this.btMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMod.Location = new System.Drawing.Point(594, 102);
            this.btMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(392, 69);
            this.btMod.TabIndex = 52;
            this.btMod.Text = "Modifier";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(624, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 64);
            this.label1.TabIndex = 41;
            this.label1.Text = "Telephones";
            // 
            // tablePhone
            // 
            this.tablePhone.AllowUserToAddRows = false;
            this.tablePhone.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tablePhone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePhone.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePhone.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePhone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.id,
            this.personId,
            this.nam,
            this.init,
            this.Pnum});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePhone.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePhone.EnableHeadersVisualStyles = false;
            this.tablePhone.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tablePhone.Location = new System.Drawing.Point(10, 282);
            this.tablePhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablePhone.MultiSelect = false;
            this.tablePhone.Name = "tablePhone";
            this.tablePhone.ReadOnly = true;
            this.tablePhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tablePhone.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tablePhone.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablePhone.RowTemplate.Height = 30;
            this.tablePhone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePhone.Size = new System.Drawing.Size(1527, 697);
            this.tablePhone.TabIndex = 58;
            this.tablePhone.Click += new System.EventHandler(this.tablePhone_Click);
            // 
            // num
            // 
            this.num.FillWeight = 25F;
            this.num.HeaderText = "#";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // personId
            // 
            this.personId.HeaderText = "IdP";
            this.personId.Name = "personId";
            this.personId.ReadOnly = true;
            this.personId.Visible = false;
            // 
            // nam
            // 
            this.nam.HeaderText = "Name";
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // init
            // 
            this.init.HeaderText = "Initial";
            this.init.Name = "init";
            this.init.ReadOnly = true;
            // 
            // Pnum
            // 
            this.Pnum.HeaderText = "Phone Number";
            this.Pnum.Name = "Pnum";
            this.Pnum.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1146, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 69);
            this.button1.TabIndex = 59;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Telephones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablePhone);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Telephones";
            this.Size = new System.Drawing.Size(1542, 983);
            this.Load += new System.EventHandler(this.Telephones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tablePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn init;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pnum;
        private System.Windows.Forms.Button button1;
    }
}
