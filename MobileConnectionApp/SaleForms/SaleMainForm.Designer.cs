namespace MobileConnectionApp.SaleForms
{
    partial class SaleMainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.userLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptsBrn = new System.Windows.Forms.Button();
            this.contracrBtn = new System.Windows.Forms.Button();
            this.callersBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.changeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(1340, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 20);
            this.date.TabIndex = 9;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(1321, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 20);
            this.userName.TabIndex = 8;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(1205, 9);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(110, 20);
            this.user.TabIndex = 7;
            this.user.Text = "Пользователь:";
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRole.Location = new System.Drawing.Point(1256, 38);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(0, 20);
            this.userRole.TabIndex = 6;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.role.Location = new System.Drawing.Point(1205, 38);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(45, 20);
            this.role.TabIndex = 5;
            this.role.Text = "Роль:";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.Location = new System.Drawing.Point(1018, 9);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(72, 20);
            this.location.TabIndex = 10;
            this.location.Text = "Локация:";
            // 
            // userLocation
            // 
            this.userLocation.AutoSize = true;
            this.userLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLocation.Location = new System.Drawing.Point(1096, 9);
            this.userLocation.Name = "userLocation";
            this.userLocation.Size = new System.Drawing.Size(0, 20);
            this.userLocation.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.receiptsBrn);
            this.panel1.Controls.Add(this.contracrBtn);
            this.panel1.Controls.Add(this.callersBtn);
            this.panel1.Controls.Add(this.clientsBtn);
            this.panel1.Location = new System.Drawing.Point(1, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 465);
            this.panel1.TabIndex = 16;
            // 
            // receiptsBrn
            // 
            this.receiptsBrn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receiptsBrn.Location = new System.Drawing.Point(0, 205);
            this.receiptsBrn.Name = "receiptsBrn";
            this.receiptsBrn.Size = new System.Drawing.Size(286, 40);
            this.receiptsBrn.TabIndex = 3;
            this.receiptsBrn.Text = "Чеки";
            this.receiptsBrn.UseVisualStyleBackColor = true;
            this.receiptsBrn.Click += new System.EventHandler(this.receiptsBrn_Click);
            // 
            // contracrBtn
            // 
            this.contracrBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contracrBtn.Location = new System.Drawing.Point(0, 145);
            this.contracrBtn.Name = "contracrBtn";
            this.contracrBtn.Size = new System.Drawing.Size(286, 40);
            this.contracrBtn.TabIndex = 2;
            this.contracrBtn.Text = "Контракты";
            this.contracrBtn.UseVisualStyleBackColor = true;
            this.contracrBtn.Click += new System.EventHandler(this.contracrBtn_Click);
            // 
            // callersBtn
            // 
            this.callersBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callersBtn.Location = new System.Drawing.Point(0, 87);
            this.callersBtn.Name = "callersBtn";
            this.callersBtn.Size = new System.Drawing.Size(286, 40);
            this.callersBtn.TabIndex = 1;
            this.callersBtn.Text = "Абоненты";
            this.callersBtn.UseVisualStyleBackColor = true;
            this.callersBtn.Click += new System.EventHandler(this.callersBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientsBtn.Location = new System.Drawing.Point(0, 29);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(286, 40);
            this.clientsBtn.TabIndex = 0;
            this.clientsBtn.Text = "Клиенты";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(352, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 465);
            this.dataGridView1.TabIndex = 17;
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeBtn.Location = new System.Drawing.Point(517, 139);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(146, 41);
            this.changeBtn.TabIndex = 20;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(352, 139);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(141, 41);
            this.AddBtn.TabIndex = 19;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 767);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userLocation);
            this.Controls.Add(this.location);
            this.Controls.Add(this.date);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.user);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.role);
            this.Name = "SaleMainForm";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.SaleMainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label userLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button callersBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button receiptsBrn;
        private System.Windows.Forms.Button contracrBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}