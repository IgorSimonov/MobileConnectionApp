namespace MobileConnectionApp
{
    partial class MainStockForm
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
            this.simBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainOfficeContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainOfficeContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(363, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(945, 662);
            this.dataGridView1.TabIndex = 0;
            // 
            // simBindingSource
            // 
            this.simBindingSource.DataSource = typeof(MobileConnectionApp.DataBase.MainOfficeDataBase.Models.Sim);
            // 
            // simBindingSource1
            // 
            this.simBindingSource1.DataSource = typeof(MobileConnectionApp.DataBase.MainOfficeDataBase.Models.Sim);
            // 
            // mainOfficeContextBindingSource
            // 
            this.mainOfficeContextBindingSource.DataSource = typeof(MobileConnectionApp.DataBase.MainOfficeDataBase.MainOfficeContext);
            // 
            // simBindingSource2
            // 
            this.simBindingSource2.DataSource = typeof(MobileConnectionApp.DataBase.MainOfficeDataBase.Models.Sim);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // MainStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 686);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainStockForm";
            this.Text = "MainStockForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainOfficeContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource simBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapTarifServicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestigeNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDevicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mainOfficeContextBindingSource;
        private System.Windows.Forms.BindingSource simBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource simBindingSource2;
    }
}