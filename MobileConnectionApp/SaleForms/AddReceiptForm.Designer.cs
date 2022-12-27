namespace MobileConnectionApp.SaleForms
{
    partial class AddReceiptForm
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
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.deviceBox = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.Label();
            this.device = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.priceText = new System.Windows.Forms.TextBox();
            this.addDeviceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientBox
            // 
            this.clientBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(174, 44);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(233, 29);
            this.clientBox.TabIndex = 40;
            // 
            // deviceBox
            // 
            this.deviceBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.Location = new System.Drawing.Point(174, 88);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(233, 29);
            this.deviceBox.TabIndex = 39;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(75, 135);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(47, 21);
            this.price.TabIndex = 38;
            this.price.Text = "Цена";
            // 
            // device
            // 
            this.device.AutoSize = true;
            this.device.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.device.Location = new System.Drawing.Point(75, 91);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(91, 21);
            this.device.TabIndex = 37;
            this.device.Text = "Устройство";
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client.Location = new System.Drawing.Point(75, 44);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(60, 21);
            this.client.TabIndex = 36;
            this.client.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 29);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceText.Location = new System.Drawing.Point(174, 132);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(233, 29);
            this.priceText.TabIndex = 44;
            // 
            // addDeviceBtn
            // 
            this.addDeviceBtn.Location = new System.Drawing.Point(154, 318);
            this.addDeviceBtn.Name = "addDeviceBtn";
            this.addDeviceBtn.Size = new System.Drawing.Size(125, 37);
            this.addDeviceBtn.TabIndex = 45;
            this.addDeviceBtn.Text = "Добавить";
            this.addDeviceBtn.UseVisualStyleBackColor = true;
            this.addDeviceBtn.Click += new System.EventHandler(this.addDeviceBtn_Click);
            // 
            // AddReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 425);
            this.Controls.Add(this.addDeviceBtn);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.device);
            this.Controls.Add(this.client);
            this.Name = "AddReceiptForm";
            this.Text = "Добавление чека";
            this.Load += new System.EventHandler(this.AddReceiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.ComboBox deviceBox;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label device;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Button addDeviceBtn;
    }
}