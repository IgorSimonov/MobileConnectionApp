namespace MobileConnectionApp.SaleForms
{
    partial class AddContractForm
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
            this.addClient = new System.Windows.Forms.Button();
            this.priceText = new System.Windows.Forms.TextBox();
            this.dateCre = new System.Windows.Forms.Label();
            this.sim = new System.Windows.Forms.Label();
            this.tarif = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.Label();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.numberBox = new System.Windows.Forms.ComboBox();
            this.tarifBox = new System.Windows.Forms.ComboBox();
            this.simBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(168, 382);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(125, 37);
            this.addClient.TabIndex = 33;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // priceText
            // 
            this.priceText.Enabled = false;
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceText.Location = new System.Drawing.Point(179, 270);
            this.priceText.Name = "priceText";
            this.priceText.ReadOnly = true;
            this.priceText.Size = new System.Drawing.Size(233, 29);
            this.priceText.TabIndex = 32;
            // 
            // dateCre
            // 
            this.dateCre.AutoSize = true;
            this.dateCre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateCre.Location = new System.Drawing.Point(80, 273);
            this.dateCre.Name = "dateCre";
            this.dateCre.Size = new System.Drawing.Size(58, 21);
            this.dateCre.TabIndex = 31;
            this.dateCre.Text = "Сумма";
            // 
            // sim
            // 
            this.sim.AutoSize = true;
            this.sim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sim.Location = new System.Drawing.Point(80, 225);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(37, 21);
            this.sim.TabIndex = 29;
            this.sim.Text = "Sim";
            // 
            // tarif
            // 
            this.tarif.AutoSize = true;
            this.tarif.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarif.Location = new System.Drawing.Point(80, 178);
            this.tarif.Name = "tarif";
            this.tarif.Size = new System.Drawing.Size(55, 21);
            this.tarif.TabIndex = 27;
            this.tarif.Text = "Тариф";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number.Location = new System.Drawing.Point(80, 129);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(58, 21);
            this.number.TabIndex = 25;
            this.number.Text = "Номер";
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client.Location = new System.Drawing.Point(80, 77);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(60, 21);
            this.client.TabIndex = 23;
            this.client.Text = "Клиент";
            // 
            // clientBox
            // 
            this.clientBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(179, 74);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(233, 29);
            this.clientBox.TabIndex = 40;
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberBox.FormattingEnabled = true;
            this.numberBox.Location = new System.Drawing.Point(179, 126);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(233, 29);
            this.numberBox.TabIndex = 41;
            // 
            // tarifBox
            // 
            this.tarifBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarifBox.FormattingEnabled = true;
            this.tarifBox.Location = new System.Drawing.Point(179, 175);
            this.tarifBox.Name = "tarifBox";
            this.tarifBox.Size = new System.Drawing.Size(233, 29);
            this.tarifBox.TabIndex = 42;
            // 
            // simBox
            // 
            this.simBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simBox.FormattingEnabled = true;
            this.simBox.Location = new System.Drawing.Point(179, 222);
            this.simBox.Name = "simBox";
            this.simBox.Size = new System.Drawing.Size(233, 29);
            this.simBox.TabIndex = 43;
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 603);
            this.Controls.Add(this.simBox);
            this.Controls.Add(this.tarifBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.dateCre);
            this.Controls.Add(this.sim);
            this.Controls.Add(this.tarif);
            this.Controls.Add(this.number);
            this.Controls.Add(this.client);
            this.Name = "AddContractForm";
            this.Text = "Добавление контракта";
            this.Load += new System.EventHandler(this.AddContractForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label dateCre;
        private System.Windows.Forms.Label sim;
        private System.Windows.Forms.Label tarif;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.ComboBox numberBox;
        private System.Windows.Forms.ComboBox tarifBox;
        private System.Windows.Forms.ComboBox simBox;
    }
}