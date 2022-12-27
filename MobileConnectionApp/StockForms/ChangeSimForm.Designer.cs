namespace MobileConnectionApp.StockForms
{
    partial class ChangeSimForm
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
            this.simState = new System.Windows.Forms.Label();
            this.simNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberSim = new System.Windows.Forms.Label();
            this.addSimBtn = new System.Windows.Forms.Button();
            this.changeSimBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // simState
            // 
            this.simState.AutoSize = true;
            this.simState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simState.Location = new System.Drawing.Point(12, 136);
            this.simState.Name = "simState";
            this.simState.Size = new System.Drawing.Size(57, 21);
            this.simState.TabIndex = 6;
            this.simState.Text = "Статус";
            // 
            // simNumberTextBox
            // 
            this.simNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simNumberTextBox.Location = new System.Drawing.Point(111, 81);
            this.simNumberTextBox.Name = "simNumberTextBox";
            this.simNumberTextBox.Size = new System.Drawing.Size(233, 29);
            this.simNumberTextBox.TabIndex = 5;
            // 
            // numberSim
            // 
            this.numberSim.AutoSize = true;
            this.numberSim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberSim.Location = new System.Drawing.Point(12, 84);
            this.numberSim.Name = "numberSim";
            this.numberSim.Size = new System.Drawing.Size(58, 21);
            this.numberSim.TabIndex = 4;
            this.numberSim.Text = "Номер";
            // 
            // addSimBtn
            // 
            this.addSimBtn.Location = new System.Drawing.Point(111, 240);
            this.addSimBtn.Name = "addSimBtn";
            this.addSimBtn.Size = new System.Drawing.Size(125, 37);
            this.addSimBtn.TabIndex = 18;
            this.addSimBtn.Text = "Добавить";
            this.addSimBtn.UseVisualStyleBackColor = true;
            this.addSimBtn.Click += new System.EventHandler(this.addSimBtn_Click);
            // 
            // changeSimBox
            // 
            this.changeSimBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeSimBox.FormattingEnabled = true;
            this.changeSimBox.Location = new System.Drawing.Point(111, 136);
            this.changeSimBox.Name = "changeSimBox";
            this.changeSimBox.Size = new System.Drawing.Size(233, 29);
            this.changeSimBox.TabIndex = 19;
            // 
            // ChangeSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 301);
            this.Controls.Add(this.changeSimBox);
            this.Controls.Add(this.addSimBtn);
            this.Controls.Add(this.simState);
            this.Controls.Add(this.simNumberTextBox);
            this.Controls.Add(this.numberSim);
            this.Name = "ChangeSimForm";
            this.Text = "Добавление Sim карты";
            this.Load += new System.EventHandler(this.ChangeSimForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label simState;
        private System.Windows.Forms.TextBox simNumberTextBox;
        private System.Windows.Forms.Label numberSim;
        private System.Windows.Forms.Button addSimBtn;
        private System.Windows.Forms.ComboBox changeSimBox;
    }
}