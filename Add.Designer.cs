namespace LibrarySystem
{
    partial class AddReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReader));
            this.name = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.number_of_ticket = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nam = new System.Windows.Forms.Label();
            this.otch = new System.Windows.Forms.Label();
            this.sur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dat = new System.Windows.Forms.Label();
            this.Addbook = new System.Windows.Forms.Button();
            this.er1 = new System.Windows.Forms.Label();
            this.er2 = new System.Windows.Forms.Label();
            this.er3 = new System.Windows.Forms.Label();
            this.er4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorOtches = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOtches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Otchestvo
            // 
            this.Otchestvo.Location = new System.Drawing.Point(12, 71);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(135, 20);
            this.Otchestvo.TabIndex = 1;
            this.Otchestvo.TextChanged += new System.EventHandler(this.Otchestvo_TextChanged);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(12, 121);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(135, 20);
            this.surname.TabIndex = 2;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // number_of_ticket
            // 
            this.number_of_ticket.Location = new System.Drawing.Point(12, 175);
            this.number_of_ticket.Name = "number_of_ticket";
            this.number_of_ticket.Size = new System.Drawing.Size(135, 20);
            this.number_of_ticket.TabIndex = 3;
            this.number_of_ticket.TextChanged += new System.EventHandler(this.number_of_ticket_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(13, 9);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(32, 13);
            this.nam.TabIndex = 5;
            this.nam.Text = "Имя:";
            // 
            // otch
            // 
            this.otch.AutoSize = true;
            this.otch.Location = new System.Drawing.Point(12, 52);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(54, 13);
            this.otch.TabIndex = 6;
            this.otch.Text = "Отчество";
            // 
            // sur
            // 
            this.sur.AutoSize = true;
            this.sur.Location = new System.Drawing.Point(13, 102);
            this.sur.Name = "sur";
            this.sur.Size = new System.Drawing.Size(59, 13);
            this.sur.TabIndex = 7;
            this.sur.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер читательского билета:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dat
            // 
            this.dat.AutoSize = true;
            this.dat.Location = new System.Drawing.Point(12, 214);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(76, 13);
            this.dat.TabIndex = 9;
            this.dat.Text = "Дата выдачи:";
            // 
            // Addbook
            // 
            this.Addbook.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Addbook.Cursor = System.Windows.Forms.Cursors.Default;
            this.Addbook.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Addbook.Location = new System.Drawing.Point(301, 260);
            this.Addbook.Name = "Addbook";
            this.Addbook.Size = new System.Drawing.Size(165, 71);
            this.Addbook.TabIndex = 10;
            this.Addbook.Text = "AddReader";
            this.Addbook.UseVisualStyleBackColor = false;
            this.Addbook.Click += new System.EventHandler(this.Addbook_Click);
            // 
            // er1
            // 
            this.er1.AutoSize = true;
            this.er1.Location = new System.Drawing.Point(153, 31);
            this.er1.Name = "er1";
            this.er1.Size = new System.Drawing.Size(0, 13);
            this.er1.TabIndex = 11;
            // 
            // er2
            // 
            this.er2.AutoSize = true;
            this.er2.Location = new System.Drawing.Point(153, 74);
            this.er2.Name = "er2";
            this.er2.Size = new System.Drawing.Size(0, 13);
            this.er2.TabIndex = 12;
            // 
            // er3
            // 
            this.er3.AutoSize = true;
            this.er3.Location = new System.Drawing.Point(153, 124);
            this.er3.Name = "er3";
            this.er3.Size = new System.Drawing.Size(0, 13);
            this.er3.TabIndex = 13;
            // 
            // er4
            // 
            this.er4.AutoSize = true;
            this.er4.Location = new System.Drawing.Point(153, 175);
            this.er4.Name = "er4";
            this.er4.Size = new System.Drawing.Size(0, 13);
            this.er4.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(193, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 74);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // errorNumber
            // 
            this.errorNumber.ContainerControl = this;
            // 
            // errorOtches
            // 
            this.errorOtches.ContainerControl = this;
            // 
            // errorSurname
            // 
            this.errorSurname.ContainerControl = this;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(301, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 126);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 346);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.er4);
            this.Controls.Add(this.er3);
            this.Controls.Add(this.er2);
            this.Controls.Add(this.er1);
            this.Controls.Add(this.Addbook);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sur);
            this.Controls.Add(this.otch);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.number_of_ticket);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить читателя";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorOtches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox number_of_ticket;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label nam;
        private System.Windows.Forms.Label otch;
        private System.Windows.Forms.Label sur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dat;
        private System.Windows.Forms.Button Addbook;
        private System.Windows.Forms.Label er1;
        private System.Windows.Forms.Label er2;
        private System.Windows.Forms.Label er3;
        private System.Windows.Forms.Label er4;
        private System.Windows.Forms.ErrorProvider errorNumber;
        private System.Windows.Forms.ErrorProvider errorOtches;
        private System.Windows.Forms.ErrorProvider errorSurname;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}