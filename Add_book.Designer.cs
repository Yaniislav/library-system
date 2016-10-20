namespace LibrarySystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.nameb = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.place_pub = new System.Windows.Forms.TextBox();
            this.name_iz = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Book_add = new System.Windows.Forms.Button();
            this.errorBname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNamePub = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPlacePub = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorBname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamePub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPlacePub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameb
            // 
            this.nameb.Location = new System.Drawing.Point(15, 25);
            this.nameb.Name = "nameb";
            this.nameb.Size = new System.Drawing.Size(163, 20);
            this.nameb.TabIndex = 0;
            this.nameb.TextChanged += new System.EventHandler(this.nameb_TextChanged);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(15, 63);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(163, 20);
            this.author.TabIndex = 1;
            this.author.TextChanged += new System.EventHandler(this.author_TextChanged);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(15, 114);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(163, 20);
            this.code.TabIndex = 2;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(15, 164);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(163, 20);
            this.year.TabIndex = 3;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // place_pub
            // 
            this.place_pub.Location = new System.Drawing.Point(15, 264);
            this.place_pub.Name = "place_pub";
            this.place_pub.Size = new System.Drawing.Size(163, 20);
            this.place_pub.TabIndex = 4;
            this.place_pub.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // name_iz
            // 
            this.name_iz.Location = new System.Drawing.Point(17, 214);
            this.name_iz.Name = "name_iz";
            this.name_iz.Size = new System.Drawing.Size(163, 20);
            this.name_iz.TabIndex = 5;
            this.name_iz.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(15, 314);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(74, 20);
            this.num.TabIndex = 6;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название книги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Автор :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Библиотечный шифр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Год издательства:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Место издательства:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Название издательства:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Количество:";
            // 
            // Book_add
            // 
            this.Book_add.Location = new System.Drawing.Point(421, 281);
            this.Book_add.Name = "Book_add";
            this.Book_add.Size = new System.Drawing.Size(187, 80);
            this.Book_add.TabIndex = 14;
            this.Book_add.Text = "Добавить";
            this.Book_add.UseVisualStyleBackColor = true;
            this.Book_add.Click += new System.EventHandler(this.Book_add_Click);
            // 
            // errorBname
            // 
            this.errorBname.ContainerControl = this;
            // 
            // errorAuthor
            // 
            this.errorAuthor.ContainerControl = this;
            // 
            // errorCode
            // 
            this.errorCode.ContainerControl = this;
            // 
            // errorYear
            // 
            this.errorYear.ContainerControl = this;
            // 
            // errorNamePub
            // 
            this.errorNamePub.ContainerControl = this;
            // 
            // errorPlacePub
            // 
            this.errorPlacePub.ContainerControl = this;
            // 
            // errorNumber
            // 
            this.errorNumber.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(270, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 80);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(421, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 149);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 373);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Book_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.name_iz);
            this.Controls.Add(this.place_pub);
            this.Controls.Add(this.year);
            this.Controls.Add(this.code);
            this.Controls.Add(this.author);
            this.Controls.Add(this.nameb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить книгу";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorBname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNamePub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPlacePub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameb;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox place_pub;
        private System.Windows.Forms.TextBox name_iz;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Book_add;
        private System.Windows.Forms.ErrorProvider errorBname;
        private System.Windows.Forms.ErrorProvider errorAuthor;
        private System.Windows.Forms.ErrorProvider errorCode;
        private System.Windows.Forms.ErrorProvider errorYear;
        private System.Windows.Forms.ErrorProvider errorNamePub;
        private System.Windows.Forms.ErrorProvider errorPlacePub;
        private System.Windows.Forms.ErrorProvider errorNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}