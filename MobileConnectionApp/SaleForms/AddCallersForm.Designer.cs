namespace MobileConnectionApp.SaleForms
{
    partial class AddCallersForm
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
            this.balanceText = new System.Windows.Forms.TextBox();
            this.addSurname = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // balanceText
            // 
            this.balanceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceText.Location = new System.Drawing.Point(177, 119);
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(233, 29);
            this.balanceText.TabIndex = 25;
            // 
            // addSurname
            // 
            this.addSurname.AutoSize = true;
            this.addSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSurname.Location = new System.Drawing.Point(35, 122);
            this.addSurname.Name = "addSurname";
            this.addSurname.Size = new System.Drawing.Size(59, 21);
            this.addSurname.TabIndex = 24;
            this.addSurname.Text = "Баланс";
            // 
            // addName
            // 
            this.addName.AutoSize = true;
            this.addName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addName.Location = new System.Drawing.Point(12, 70);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(159, 21);
            this.addName.TabIndex = 22;
            this.addName.Text = "Контракт по клиенту";
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(177, 264);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(125, 37);
            this.addClient.TabIndex = 26;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // clientBox
            // 
            this.clientBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(177, 67);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(233, 29);
            this.clientBox.TabIndex = 42;
            // 
            // AddCallersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 393);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.balanceText);
            this.Controls.Add(this.addSurname);
            this.Controls.Add(this.addName);
            this.Name = "AddCallersForm";
            this.Text = "Добавление абонента";
            this.Load += new System.EventHandler(this.AddCallersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.Label addSurname;
        private System.Windows.Forms.Label addName;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.ComboBox clientBox;
    }
}