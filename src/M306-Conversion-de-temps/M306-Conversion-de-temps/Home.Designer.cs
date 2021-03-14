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
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblLocalTime = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblLocalTimeZone = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.CheckBox();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuresAnalogiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heuresDigitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxVille1 = new System.Windows.Forms.ComboBox();
            this.villesBS1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new M306_Conversion_de_temps.DBDataSet();
            this.cbxVille2 = new System.Windows.Forms.ComboBox();
            this.villesTableAdapter = new M306_Conversion_de_temps.DBDataSetTableAdapters.VillesTableAdapter();
            this.tableAdapterManager = new M306_Conversion_de_temps.DBDataSetTableAdapters.TableAdapterManager();
            this.cbxVille3 = new System.Windows.Forms.ComboBox();
            this.villesBS2 = new System.Windows.Forms.BindingSource(this.components);
            this.villesBS3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblConverti = new System.Windows.Forms.Label();
            this.lbldebug = new System.Windows.Forms.Label();
            this.ms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villesBS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBS3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp1.Location = new System.Drawing.Point(81, 184);
            this.dtp1.Name = "dtp1";
            this.dtp1.ShowUpDown = true;
            this.dtp1.Size = new System.Drawing.Size(97, 29);
            this.dtp1.TabIndex = 0;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
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
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Location = new System.Drawing.Point(329, 310);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(141, 17);
            this.tb1.TabIndex = 10;
            this.tb1.Text = "Forcer un fuseau horaire";
            this.tb1.UseVisualStyleBackColor = true;
            this.tb1.CheckedChanged += new System.EventHandler(this.tb1_CheckedChanged);
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
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI1,
            this.TSMI2});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // TSMI1
            // 
            this.TSMI1.Name = "TSMI1";
            this.TSMI1.Size = new System.Drawing.Size(180, 22);
            this.TSMI1.Text = "Editer la BD";
            this.TSMI1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // TSMI2
            // 
            this.TSMI2.Name = "TSMI2";
            this.TSMI2.Size = new System.Drawing.Size(180, 22);
            this.TSMI2.Text = "Quitter";
            this.TSMI2.Click += new System.EventHandler(this.TSMI2_Click);
            // 
            // vueToolStripMenuItem
            // 
            this.vueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heuresAnalogiquesToolStripMenuItem,
            this.heuresDigitalesToolStripMenuItem});
            this.vueToolStripMenuItem.Name = "vueToolStripMenuItem";
            this.vueToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.vueToolStripMenuItem.Text = "Vue";
            // 
            // heuresAnalogiquesToolStripMenuItem
            // 
            this.heuresAnalogiquesToolStripMenuItem.Name = "heuresAnalogiquesToolStripMenuItem";
            this.heuresAnalogiquesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heuresAnalogiquesToolStripMenuItem.Text = "Heures Analogiques";
            // 
            // heuresDigitalesToolStripMenuItem
            // 
            this.heuresDigitalesToolStripMenuItem.Name = "heuresDigitalesToolStripMenuItem";
            this.heuresDigitalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heuresDigitalesToolStripMenuItem.Text = "Heures Digitales";
            // 
            // langueToolStripMenuItem
            // 
            this.langueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem});
            this.langueToolStripMenuItem.Name = "langueToolStripMenuItem";
            this.langueToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.langueToolStripMenuItem.Text = "Langue";
            // 
            // françaisToolStripMenuItem
            // 
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.françaisToolStripMenuItem.Text = "Français";
            // 
            // anglaisToolStripMenuItem
            // 
            this.anglaisToolStripMenuItem.Name = "anglaisToolStripMenuItem";
            this.anglaisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.anglaisToolStripMenuItem.Text = "Anglais";
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
            this.cbxVille1.DataSource = this.villesBS1;
            this.cbxVille1.DisplayMember = "NomVilleFR";
            this.cbxVille1.FormattingEnabled = true;
            this.cbxVille1.Location = new System.Drawing.Point(218, 184);
            this.cbxVille1.Name = "cbxVille1";
            this.cbxVille1.Size = new System.Drawing.Size(121, 21);
            this.cbxVille1.TabIndex = 14;
            this.cbxVille1.ValueMember = "ID";
            this.cbxVille1.SelectedIndexChanged += new System.EventHandler(this.cbxVille1_SelectedIndexChanged);
            this.cbxVille1.Click += new System.EventHandler(this.cbxVille1_Click);
            // 
            // villesBS1
            // 
            this.villesBS1.DataMember = "Villes";
            this.villesBS1.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxVille2
            // 
            this.cbxVille2.AutoCompleteCustomSource.AddRange(new string[] {
            "villesBindingSource - UTC"});
            this.cbxVille2.DataSource = this.villesBS2;
            this.cbxVille2.DisplayMember = "NomVilleFR";
            this.cbxVille2.FormattingEnabled = true;
            this.cbxVille2.Location = new System.Drawing.Point(425, 184);
            this.cbxVille2.Name = "cbxVille2";
            this.cbxVille2.Size = new System.Drawing.Size(121, 21);
            this.cbxVille2.TabIndex = 15;
            this.cbxVille2.ValueMember = "ID";
            // 
            // villesTableAdapter
            // 
            this.villesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = M306_Conversion_de_temps.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VillesTableAdapter = this.villesTableAdapter;
            // 
            // cbxVille3
            // 
            this.cbxVille3.DataSource = this.villesBS3;
            this.cbxVille3.DisplayMember = "NomVilleFR";
            this.cbxVille3.Enabled = false;
            this.cbxVille3.FormattingEnabled = true;
            this.cbxVille3.Location = new System.Drawing.Point(344, 346);
            this.cbxVille3.Name = "cbxVille3";
            this.cbxVille3.Size = new System.Drawing.Size(121, 21);
            this.cbxVille3.TabIndex = 16;
            this.cbxVille3.ValueMember = "ID";
            // 
            // villesBS2
            // 
            this.villesBS2.DataMember = "Villes";
            this.villesBS2.DataSource = this.dBDataSet;
            // 
            // villesBS3
            // 
            this.villesBS3.DataMember = "Villes";
            this.villesBS3.DataSource = this.dBDataSet;
            // 
            // lblConverti
            // 
            this.lblConverti.AutoSize = true;
            this.lblConverti.BackColor = System.Drawing.SystemColors.Window;
            this.lblConverti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConverti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverti.Location = new System.Drawing.Point(608, 184);
            this.lblConverti.Name = "lblConverti";
            this.lblConverti.Size = new System.Drawing.Size(151, 28);
            this.lblConverti.TabIndex = 17;
            this.lblConverti.Text = "Temp converti";
            // 
            // lbldebug
            // 
            this.lbldebug.AutoSize = true;
            this.lbldebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebug.Location = new System.Drawing.Point(81, 310);
            this.lbldebug.Name = "lbldebug";
            this.lbldebug.Size = new System.Drawing.Size(51, 20);
            this.lbldebug.TabIndex = 18;
            this.lbldebug.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.lbldebug);
            this.Controls.Add(this.lblConverti);
            this.Controls.Add(this.cbxVille3);
            this.Controls.Add(this.cbxVille2);
            this.Controls.Add(this.cbxVille1);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lblLocalTimeZone);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblLocalTime);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.ms1);
            this.Name = "Home";
            this.Text = "Hour Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villesBS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBS3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Label lblLocalTimeZone;
        private System.Windows.Forms.CheckBox tb1;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langueToolStripMenuItem;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbxVille1;
        private System.Windows.Forms.ToolStripMenuItem TSMI1;
        private System.Windows.Forms.ToolStripMenuItem TSMI2;
        private System.Windows.Forms.ToolStripMenuItem heuresAnalogiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heuresDigitalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem françaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anglaisToolStripMenuItem;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource villesBS1;
        private DBDataSetTableAdapters.VillesTableAdapter villesTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxVille2;
        private System.Windows.Forms.ComboBox cbxVille3;
        private System.Windows.Forms.BindingSource villesBS2;
        private System.Windows.Forms.BindingSource villesBS3;
        private System.Windows.Forms.Label lblConverti;
        private System.Windows.Forms.Label lbldebug;
    }
}

