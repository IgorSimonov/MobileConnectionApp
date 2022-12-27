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
            this.role = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date = new System.Windows.Forms.Label();
            this.userLocation = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simBtn = new System.Windows.Forms.Button();
            this.phonesBtn = new System.Windows.Forms.Button();
            this.AddDevice = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.role.Location = new System.Drawing.Point(1204, 38);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(45, 20);
            this.role.TabIndex = 0;
            this.role.Text = "Роль:";
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRole.Location = new System.Drawing.Point(1255, 38);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(0, 20);
            this.userRole.TabIndex = 1;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(1204, 9);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(110, 20);
            this.user.TabIndex = 2;
            this.user.Text = "Пользователь:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(1320, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 20);
            this.userName.TabIndex = 3;
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
            this.date.Location = new System.Drawing.Point(1339, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 20);
            this.date.TabIndex = 4;
            // 
            // userLocation
            // 
            this.userLocation.AutoSize = true;
            this.userLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLocation.Location = new System.Drawing.Point(1105, 9);
            this.userLocation.Name = "userLocation";
            this.userLocation.Size = new System.Drawing.Size(0, 20);
            this.userLocation.TabIndex = 13;
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.Location = new System.Drawing.Point(1027, 9);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(72, 20);
            this.location.TabIndex = 12;
            this.location.Text = "Локация:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(335, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 465);
            this.dataGridView1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.simBtn);
            this.panel1.Controls.Add(this.phonesBtn);
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 465);
            this.panel1.TabIndex = 15;
            // 
            // simBtn
            // 
            this.simBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simBtn.Location = new System.Drawing.Point(0, 87);
            this.simBtn.Name = "simBtn";
            this.simBtn.Size = new System.Drawing.Size(286, 40);
            this.simBtn.TabIndex = 1;
            this.simBtn.Text = "Sim карты";
            this.simBtn.UseVisualStyleBackColor = true;
            this.simBtn.Click += new System.EventHandler(this.simBtn_Click);
            // 
            // phonesBtn
            // 
            this.phonesBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonesBtn.Location = new System.Drawing.Point(0, 29);
            this.phonesBtn.Name = "phonesBtn";
            this.phonesBtn.Size = new System.Drawing.Size(286, 40);
            this.phonesBtn.TabIndex = 0;
            this.phonesBtn.Text = "Планшеты и телефоны";
            this.phonesBtn.UseVisualStyleBackColor = true;
            this.phonesBtn.Click += new System.EventHandler(this.phonesBtn_Click);
            // 
            // AddDevice
            // 
            this.AddDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDevice.Location = new System.Drawing.Point(335, 166);
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(141, 41);
            this.AddDevice.TabIndex = 17;
            this.AddDevice.Text = "Добавить";
            this.AddDevice.UseVisualStyleBackColor = true;
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeBtn.Location = new System.Drawing.Point(500, 166);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(146, 41);
            this.changeBtn.TabIndex = 18;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(716, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(639, 29);
            this.textBox1.TabIndex = 19;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(1361, 159);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(146, 41);
            this.searchBtn.TabIndex = 20;
            this.searchBtn.Text = "Найти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // MainStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 767);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.AddDevice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userLocation);
            this.Controls.Add(this.location);
            this.Controls.Add(this.date);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.user);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.role);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainStockForm";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.MainStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label userLocation;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button phonesBtn;
        private System.Windows.Forms.Button simBtn;
        private System.Windows.Forms.Button AddDevice;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchBtn;
    }
}