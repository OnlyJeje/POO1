namespace TP1
{
    partial class fEditPun
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
            this.lvPun = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctsPun = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTemps = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbJoueur = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.ctsPun.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPun
            // 
            this.lvPun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPun.ContextMenuStrip = this.ctsPun;
            this.lvPun.FullRowSelect = true;
            this.lvPun.GridLines = true;
            this.lvPun.Location = new System.Drawing.Point(154, 12);
            this.lvPun.MultiSelect = false;
            this.lvPun.Name = "lvPun";
            this.lvPun.Size = new System.Drawing.Size(141, 156);
            this.lvPun.TabIndex = 0;
            this.lvPun.UseCompatibleStateImageBehavior = false;
            this.lvPun.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Joueur";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Durée";
            // 
            // ctsPun
            // 
            this.ctsPun.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAnnuler});
            this.ctsPun.Name = "ctsPun";
            this.ctsPun.Size = new System.Drawing.Size(194, 26);
            // 
            // menuAnnuler
            // 
            this.menuAnnuler.Name = "menuAnnuler";
            this.menuAnnuler.Size = new System.Drawing.Size(193, 22);
            this.menuAnnuler.Text = "Annuler cette punition";
            this.menuAnnuler.Click += new System.EventHandler(this.menuAnnuler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle punition";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTemps);
            this.groupBox3.Location = new System.Drawing.Point(15, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 47);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durée (min.)";
            // 
            // cbTemps
            // 
            this.cbTemps.FormattingEnabled = true;
            this.cbTemps.Items.AddRange(new object[] {
            "1",
            "4",
            "5",
            "10"});
            this.cbTemps.Location = new System.Drawing.Point(22, 19);
            this.cbTemps.Name = "cbTemps";
            this.cbTemps.Size = new System.Drawing.Size(60, 21);
            this.cbTemps.TabIndex = 2;
            this.cbTemps.Text = "2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbJoueur);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Joueur";
            // 
            // tbJoueur
            // 
            this.tbJoueur.Location = new System.Drawing.Point(22, 19);
            this.tbJoueur.Name = "tbJoueur";
            this.tbJoueur.Size = new System.Drawing.Size(51, 20);
            this.tbJoueur.TabIndex = 2;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(15, 125);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(103, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Ajouter";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(220, 174);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // fEditPun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 204);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvPun);
            this.Name = "fEditPun";
            this.Text = "fEditPun";
            this.Load += new System.EventHandler(this.fEditPun_Load);
            this.ctsPun.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPun;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTemps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbJoueur;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.ContextMenuStrip ctsPun;
        private System.Windows.Forms.ToolStripMenuItem menuAnnuler;
    }
}