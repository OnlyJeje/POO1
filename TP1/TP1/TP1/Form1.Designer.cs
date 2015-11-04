namespace TP1
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
            this.components = new System.ComponentModel.Container();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.gbPunLocal = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lScoreLocal = new System.Windows.Forms.Label();
            this.gbVisiteur = new System.Windows.Forms.GroupBox();
            this.gbPunVisiteur = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lScoreVisiteur = new System.Windows.Forms.Label();
            this.gbCtrlLocal = new System.Windows.Forms.GroupBox();
            this.bPunLocal = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudLocal = new System.Windows.Forms.NumericUpDown();
            this.gbCtrlVisiteur = new System.Windows.Forms.GroupBox();
            this.bPunVisiteur = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.nudVisiteur = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lPeriode = new System.Windows.Forms.Label();
            this.lHorloge = new System.Windows.Forms.Label();
            this.gbCtrlTime = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPeriode = new System.Windows.Forms.NumericUpDown();
            this.bSetTime = new System.Windows.Forms.Button();
            this.tbNewTime = new System.Windows.Forms.TextBox();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbLocal.SuspendLayout();
            this.gbPunLocal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbVisiteur.SuspendLayout();
            this.gbPunVisiteur.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbCtrlLocal.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).BeginInit();
            this.gbCtrlVisiteur.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisiteur)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.gbCtrlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriode)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.gbPunLocal);
            this.gbLocal.Controls.Add(this.panel1);
            this.gbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocal.Location = new System.Drawing.Point(12, 27);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(384, 417);
            this.gbLocal.TabIndex = 0;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "Local";
            // 
            // gbPunLocal
            // 
            this.gbPunLocal.Controls.Add(this.label4);
            this.gbPunLocal.Controls.Add(this.label3);
            this.gbPunLocal.Controls.Add(this.label2);
            this.gbPunLocal.Location = new System.Drawing.Point(17, 149);
            this.gbPunLocal.Name = "gbPunLocal";
            this.gbPunLocal.Size = new System.Drawing.Size(361, 259);
            this.gbPunLocal.TabIndex = 1;
            this.gbPunLocal.TabStop = false;
            this.gbPunLocal.Text = "Punitions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 85);
            this.label4.TabIndex = 2;
            this.label4.Text = "00 00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 85);
            this.label3.TabIndex = 1;
            this.label3.Text = "00 00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 85);
            this.label2.TabIndex = 0;
            this.label2.Text = "00 00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lScoreLocal);
            this.panel1.Location = new System.Drawing.Point(17, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 112);
            this.panel1.TabIndex = 0;
            // 
            // lScoreLocal
            // 
            this.lScoreLocal.AutoSize = true;
            this.lScoreLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreLocal.Location = new System.Drawing.Point(2, 3);
            this.lScoreLocal.Name = "lScoreLocal";
            this.lScoreLocal.Size = new System.Drawing.Size(145, 102);
            this.lScoreLocal.TabIndex = 1;
            this.lScoreLocal.Text = "00";
            // 
            // gbVisiteur
            // 
            this.gbVisiteur.Controls.Add(this.gbPunVisiteur);
            this.gbVisiteur.Controls.Add(this.panel2);
            this.gbVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisiteur.Location = new System.Drawing.Point(718, 27);
            this.gbVisiteur.Name = "gbVisiteur";
            this.gbVisiteur.Size = new System.Drawing.Size(384, 417);
            this.gbVisiteur.TabIndex = 1;
            this.gbVisiteur.TabStop = false;
            this.gbVisiteur.Text = "Visiteurs";
            // 
            // gbPunVisiteur
            // 
            this.gbPunVisiteur.Controls.Add(this.label5);
            this.gbPunVisiteur.Controls.Add(this.label6);
            this.gbPunVisiteur.Controls.Add(this.label7);
            this.gbPunVisiteur.Location = new System.Drawing.Point(17, 149);
            this.gbPunVisiteur.Name = "gbPunVisiteur";
            this.gbPunVisiteur.Size = new System.Drawing.Size(361, 259);
            this.gbPunVisiteur.TabIndex = 1;
            this.gbPunVisiteur.TabStop = false;
            this.gbPunVisiteur.Text = "Punitions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 85);
            this.label5.TabIndex = 2;
            this.label5.Text = "00 00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 85);
            this.label6.TabIndex = 1;
            this.label6.Text = "00 00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 85);
            this.label7.TabIndex = 0;
            this.label7.Text = "00 00:00";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lScoreVisiteur);
            this.panel2.Location = new System.Drawing.Point(17, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 112);
            this.panel2.TabIndex = 0;
            // 
            // lScoreVisiteur
            // 
            this.lScoreVisiteur.AutoSize = true;
            this.lScoreVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreVisiteur.Location = new System.Drawing.Point(2, 3);
            this.lScoreVisiteur.Name = "lScoreVisiteur";
            this.lScoreVisiteur.Size = new System.Drawing.Size(145, 102);
            this.lScoreVisiteur.TabIndex = 1;
            this.lScoreVisiteur.Text = "00";
            this.lScoreVisiteur.Click += new System.EventHandler(this.lScoreVisiteur_Click);
            // 
            // gbCtrlLocal
            // 
            this.gbCtrlLocal.Controls.Add(this.bPunLocal);
            this.gbCtrlLocal.Controls.Add(this.groupBox6);
            this.gbCtrlLocal.Location = new System.Drawing.Point(12, 450);
            this.gbCtrlLocal.Name = "gbCtrlLocal";
            this.gbCtrlLocal.Size = new System.Drawing.Size(384, 78);
            this.gbCtrlLocal.TabIndex = 2;
            this.gbCtrlLocal.TabStop = false;
            this.gbCtrlLocal.Text = "Contrôles pour l\'équipe locale";
            // 
            // bPunLocal
            // 
            this.bPunLocal.Location = new System.Drawing.Point(118, 33);
            this.bPunLocal.Name = "bPunLocal";
            this.bPunLocal.Size = new System.Drawing.Size(246, 23);
            this.bPunLocal.TabIndex = 2;
            this.bPunLocal.Text = "Éditer les punitions";
            this.bPunLocal.UseVisualStyleBackColor = true;
            this.bPunLocal.Click += new System.EventHandler(this.bPun_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudLocal);
            this.groupBox6.Location = new System.Drawing.Point(17, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(78, 55);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Buts";
            // 
            // nudLocal
            // 
            this.nudLocal.Location = new System.Drawing.Point(21, 19);
            this.nudLocal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLocal.Name = "nudLocal";
            this.nudLocal.Size = new System.Drawing.Size(45, 20);
            this.nudLocal.TabIndex = 0;
            this.nudLocal.ValueChanged += new System.EventHandler(this.nudValueChanged);
            // 
            // gbCtrlVisiteur
            // 
            this.gbCtrlVisiteur.Controls.Add(this.bPunVisiteur);
            this.gbCtrlVisiteur.Controls.Add(this.groupBox8);
            this.gbCtrlVisiteur.Location = new System.Drawing.Point(718, 450);
            this.gbCtrlVisiteur.Name = "gbCtrlVisiteur";
            this.gbCtrlVisiteur.Size = new System.Drawing.Size(384, 78);
            this.gbCtrlVisiteur.TabIndex = 3;
            this.gbCtrlVisiteur.TabStop = false;
            this.gbCtrlVisiteur.Text = "Contrôles pour l\'équipe visiteuse";
            // 
            // bPunVisiteur
            // 
            this.bPunVisiteur.Location = new System.Drawing.Point(118, 33);
            this.bPunVisiteur.Name = "bPunVisiteur";
            this.bPunVisiteur.Size = new System.Drawing.Size(246, 23);
            this.bPunVisiteur.TabIndex = 2;
            this.bPunVisiteur.Text = "Éditer les punitions";
            this.bPunVisiteur.UseVisualStyleBackColor = true;
            this.bPunVisiteur.Click += new System.EventHandler(this.bPun_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.nudVisiteur);
            this.groupBox8.Location = new System.Drawing.Point(17, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(78, 55);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Buts";
            // 
            // nudVisiteur
            // 
            this.nudVisiteur.Location = new System.Drawing.Point(21, 19);
            this.nudVisiteur.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudVisiteur.Name = "nudVisiteur";
            this.nudVisiteur.Size = new System.Drawing.Size(45, 20);
            this.nudVisiteur.TabIndex = 0;
            this.nudVisiteur.ValueChanged += new System.EventHandler(this.nudValueChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lPeriode);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(495, 162);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(125, 115);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "PÉRIODE";
            // 
            // lPeriode
            // 
            this.lPeriode.AutoSize = true;
            this.lPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeriode.Location = new System.Drawing.Point(21, 16);
            this.lPeriode.Name = "lPeriode";
            this.lPeriode.Size = new System.Drawing.Size(83, 91);
            this.lPeriode.TabIndex = 0;
            this.lPeriode.Text = "3";
            this.lPeriode.Click += new System.EventHandler(this.lPeriode_Click);
            // 
            // lHorloge
            // 
            this.lHorloge.AutoSize = true;
            this.lHorloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHorloge.Location = new System.Drawing.Point(402, 39);
            this.lHorloge.Name = "lHorloge";
            this.lHorloge.Size = new System.Drawing.Size(320, 120);
            this.lHorloge.TabIndex = 5;
            this.lHorloge.Text = "00:00";
            // 
            // gbCtrlTime
            // 
            this.gbCtrlTime.Controls.Add(this.label1);
            this.gbCtrlTime.Controls.Add(this.nudPeriode);
            this.gbCtrlTime.Controls.Add(this.bSetTime);
            this.gbCtrlTime.Controls.Add(this.tbNewTime);
            this.gbCtrlTime.Controls.Add(this.bStop);
            this.gbCtrlTime.Controls.Add(this.bStart);
            this.gbCtrlTime.Location = new System.Drawing.Point(405, 413);
            this.gbCtrlTime.Name = "gbCtrlTime";
            this.gbCtrlTime.Size = new System.Drawing.Size(307, 109);
            this.gbCtrlTime.TabIndex = 6;
            this.gbCtrlTime.TabStop = false;
            this.gbCtrlTime.Text = "Contrôle du temps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Période";
            // 
            // nudPeriode
            // 
            this.nudPeriode.Location = new System.Drawing.Point(16, 76);
            this.nudPeriode.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPeriode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeriode.Name = "nudPeriode";
            this.nudPeriode.Size = new System.Drawing.Size(56, 20);
            this.nudPeriode.TabIndex = 4;
            this.nudPeriode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeriode.ValueChanged += new System.EventHandler(this.nudPeriode_ValueChanged);
            // 
            // bSetTime
            // 
            this.bSetTime.Location = new System.Drawing.Point(182, 43);
            this.bSetTime.Name = "bSetTime";
            this.bSetTime.Size = new System.Drawing.Size(100, 23);
            this.bSetTime.TabIndex = 3;
            this.bSetTime.Text = "Ajuster";
            this.bSetTime.UseVisualStyleBackColor = true;
            this.bSetTime.Click += new System.EventHandler(this.bSetTime_Click);
            // 
            // tbNewTime
            // 
            this.tbNewTime.Location = new System.Drawing.Point(182, 16);
            this.tbNewTime.MaxLength = 5;
            this.tbNewTime.Name = "tbNewTime";
            this.tbNewTime.Size = new System.Drawing.Size(100, 20);
            this.tbNewTime.TabIndex = 2;
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(94, 25);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(13, 25);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 534);
            this.Controls.Add(this.gbCtrlTime);
            this.Controls.Add(this.lHorloge);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.gbCtrlVisiteur);
            this.Controls.Add(this.gbCtrlLocal);
            this.Controls.Add(this.gbVisiteur);
            this.Controls.Add(this.gbLocal);
            this.Name = "Form1";
            this.Text = "Travail Pratique #1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLocal.ResumeLayout(false);
            this.gbPunLocal.ResumeLayout(false);
            this.gbPunLocal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbVisiteur.ResumeLayout(false);
            this.gbPunVisiteur.ResumeLayout(false);
            this.gbPunVisiteur.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbCtrlLocal.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).EndInit();
            this.gbCtrlVisiteur.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudVisiteur)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.gbCtrlTime.ResumeLayout(false);
            this.gbCtrlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.GroupBox gbPunLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lScoreLocal;
        private System.Windows.Forms.GroupBox gbVisiteur;
        private System.Windows.Forms.GroupBox gbPunVisiteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lScoreVisiteur;
        private System.Windows.Forms.GroupBox gbCtrlLocal;
        private System.Windows.Forms.Button bPunLocal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudLocal;
        private System.Windows.Forms.GroupBox gbCtrlVisiteur;
        private System.Windows.Forms.Button bPunVisiteur;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown nudVisiteur;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lPeriode;
        private System.Windows.Forms.Label lHorloge;
        private System.Windows.Forms.GroupBox gbCtrlTime;
        private System.Windows.Forms.Button bSetTime;
        private System.Windows.Forms.TextBox tbNewTime;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPeriode;
    }
}

