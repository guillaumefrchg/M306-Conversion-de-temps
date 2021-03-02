namespace M306_Conversion_de_temps
{
    partial class Home
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
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblLocalTime = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblLocalTimeZone = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVille1 = new System.Windows.Forms.ComboBox();
            this.cbxVille2 = new System.Windows.Forms.ComboBox();
            this.cbxVille3 = new System.Windows.Forms.ComboBox();
            this.ms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1.Location = new System.Drawing.Point(81, 184);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(97, 29);
            this.dtp1.TabIndex = 0;
            // 
            // dtp2
            // 
            this.dtp2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp2.Location = new System.Drawing.Point(608, 184);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(97, 29);
            this.dtp2.TabIndex = 1;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(63, 150);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(134, 20);
            this.lblTime1.TabIndex = 4;
            this.lblTime1.Text = "Heure à convertir:";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(604, 150);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(121, 20);
            this.lblTime2.TabIndex = 5;
            this.lblTime2.Text = "Heure convertie";
            // 
            // lblLocalTime
            // 
            this.lblLocalTime.AutoSize = true;
            this.lblLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalTime.Location = new System.Drawing.Point(340, 38);
            this.lblLocalTime.Name = "lblLocalTime";
            this.lblLocalTime.Size = new System.Drawing.Size(102, 20);
            this.lblLocalTime.TabIndex = 7;
            this.lblLocalTime.Text = "Heure locale:";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimeNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.Location = new System.Drawing.Point(344, 81);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(112, 28);
            this.lblTimeNow.TabIndex = 8;
            this.lblTimeNow.Text = "Time Now";
            this.lblTimeNow.Click += new System.EventHandler(this.lblTimeNow_Click);
            // 
            // lblLocalTimeZone
            // 
            this.lblLocalTimeZone.AutoSize = true;
            this.lblLocalTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalTimeZone.Location = new System.Drawing.Point(325, 275);
            this.lblLocalTimeZone.Name = "lblLocalTimeZone";
            this.lblLocalTimeZone.Size = new System.Drawing.Size(157, 20);
            this.lblLocalTimeZone.TabIndex = 9;
            this.lblLocalTimeZone.Text = "Fuseau-horaire local:";
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(329, 310);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(141, 17);
            this.cbx1.TabIndex = 10;
            this.cbx1.Text = "Forcer un fuseau horaire";
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.vueToolStripMenuItem,
            this.langueToolStripMenuItem});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(794, 24);
            this.ms1.TabIndex = 12;
            this.ms1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // vueToolStripMenuItem
            // 
            this.vueToolStripMenuItem.Name = "vueToolStripMenuItem";
            this.vueToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.vueToolStripMenuItem.Text = "Vue";
            // 
            // langueToolStripMenuItem
            // 
            this.langueToolStripMenuItem.Name = "langueToolStripMenuItem";
            this.langueToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.langueToolStripMenuItem.Text = "Langue";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.Window;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(563, 184);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(39, 28);
            this.lblDay.TabIndex = 13;
            this.lblDay.Text = "+1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxVille1
            // 
            this.cbxVille1.FormattingEnabled = true;
            this.cbxVille1.Location = new System.Drawing.Point(218, 184);
            this.cbxVille1.Name = "cbxVille1";
            this.cbxVille1.Size = new System.Drawing.Size(121, 21);
            this.cbxVille1.TabIndex = 14;
            this.cbxVille1.SelectedIndexChanged += new System.EventHandler(this.cbxVille1_SelectedIndexChanged);
            // 
            // cbxVille2
            // 
            this.cbxVille2.AutoCompleteCustomSource.AddRange(new string[] {
            "villesBindingSource - UTC"});
            this.cbxVille2.FormattingEnabled = true;
            this.cbxVille2.Location = new System.Drawing.Point(425, 184);
            this.cbxVille2.Name = "cbxVille2";
            this.cbxVille2.Size = new System.Drawing.Size(121, 21);
            this.cbxVille2.TabIndex = 15;
            // 
            // cbxVille3
            // 
            this.cbxVille3.FormattingEnabled = true;
            this.cbxVille3.Location = new System.Drawing.Point(344, 348);
            this.cbxVille3.Name = "cbxVille3";
            this.cbxVille3.Size = new System.Drawing.Size(121, 21);
            this.cbxVille3.TabIndex = 16;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.cbxVille3);
            this.Controls.Add(this.cbxVille2);
            this.Controls.Add(this.cbxVille1);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.lblLocalTimeZone);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblLocalTime);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.ms1);
            this.Name = "Home";
            this.Text = "Hour Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Label lblLocalTimeZone;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langueToolStripMenuItem;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private System.Windows.Forms.ComboBox cbxVille1;
        private System.Windows.Forms.ComboBox cbxVille2;
        private System.Windows.Forms.ComboBox cbxVille3;
    }
}

