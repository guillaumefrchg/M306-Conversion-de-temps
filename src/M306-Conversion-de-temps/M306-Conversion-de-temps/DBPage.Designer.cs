namespace M306_Conversion_de_temps
{
    partial class DBPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVilleFRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomVilleENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new M306_Conversion_de_temps.DBDataSet();
            this.villesTableAdapter = new M306_Conversion_de_temps.DBDataSetTableAdapters.VillesTableAdapter();
            this.tableAdapterManager = new M306_Conversion_de_temps.DBDataSetTableAdapters.TableAdapterManager();
            this.dbDataSet1 = new M306_Conversion_de_temps.DBDataSet();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomVilleFRDataGridViewTextBoxColumn,
            this.nomVilleENDataGridViewTextBoxColumn,
            this.uTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.villesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(184, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nomVilleFRDataGridViewTextBoxColumn
            // 
            this.nomVilleFRDataGridViewTextBoxColumn.DataPropertyName = "NomVilleFR";
            this.nomVilleFRDataGridViewTextBoxColumn.HeaderText = "NomVilleFR";
            this.nomVilleFRDataGridViewTextBoxColumn.Name = "nomVilleFRDataGridViewTextBoxColumn";
            // 
            // nomVilleENDataGridViewTextBoxColumn
            // 
            this.nomVilleENDataGridViewTextBoxColumn.DataPropertyName = "NomVilleEN";
            this.nomVilleENDataGridViewTextBoxColumn.HeaderText = "NomVilleEN";
            this.nomVilleENDataGridViewTextBoxColumn.Name = "nomVilleENDataGridViewTextBoxColumn";
            // 
            // uTCDataGridViewTextBoxColumn
            // 
            this.uTCDataGridViewTextBoxColumn.DataPropertyName = "UTC";
            this.uTCDataGridViewTextBoxColumn.HeaderText = "UTC";
            this.uTCDataGridViewTextBoxColumn.Name = "uTCDataGridViewTextBoxColumn";
            // 
            // villesBindingSource
            // 
            this.villesBindingSource.DataMember = "Villes";
            this.villesBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "DBDataSet";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(524, 363);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 29);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Export to csv";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // DBPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBPage";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBPage_FormClosing);
            this.Load += new System.EventHandler(this.DBPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private DBDataSetTableAdapters.VillesTableAdapter villesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVilleFRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomVilleENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uTCDataGridViewTextBoxColumn;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DBDataSet dbDataSet1;
        private System.Windows.Forms.Button btnsave;
    }
}