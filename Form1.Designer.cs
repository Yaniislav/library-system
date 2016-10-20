namespace LibrarySystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_book = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_from_file = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_catalog = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Registr_takes = new System.Windows.Forms.ToolStripMenuItem();
            this.Register_returns = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_all_catalog = new System.Windows.Forms.ToolStripMenuItem();
            this.All_readers = new System.Windows.Forms.ToolStripMenuItem();
            this.takes_book = new System.Windows.Forms.ToolStripMenuItem();
            this.returns_books = new System.Windows.Forms.ToolStripMenuItem();
            this.books_of_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.History_of_book = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.search_by_code = new System.Windows.Forms.ToolStripMenuItem();
            this.search_by_name = new System.Windows.Forms.ToolStripMenuItem();
            this.читателяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.search_by_namer = new System.Windows.Forms.ToolStripMenuItem();
            this.search_by_ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_book = new System.Windows.Forms.ToolStripMenuItem();
            this.change_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_book = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.picture_main = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.показатьToolStripMenuItem,
            this.поискToolStripMenuItem1,
            this.редактироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_book,
            this.Add_reader,
            this.Menu_from_file,
            this.save,
            this.save_as,
            this.Close_catalog});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.добавитьToolStripMenuItem.Text = "Файл";
            // 
            // Add_book
            // 
            this.Add_book.Name = "Add_book";
            this.Add_book.Size = new System.Drawing.Size(212, 22);
            this.Add_book.Text = "Добавить книгу";
            // 
            // Add_reader
            // 
            this.Add_reader.Name = "Add_reader";
            this.Add_reader.Size = new System.Drawing.Size(212, 22);
            this.Add_reader.Text = "Добавить читателя";
            // 
            // Menu_from_file
            // 
            this.Menu_from_file.Name = "Menu_from_file";
            this.Menu_from_file.Size = new System.Drawing.Size(212, 22);
            this.Menu_from_file.Text = "Добавить каталог с  Excel";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(212, 22);
            this.save.Text = "Сохранить";
            // 
            // save_as
            // 
            this.save_as.Name = "save_as";
            this.save_as.Size = new System.Drawing.Size(212, 22);
            this.save_as.Text = "Сохранить в Excel";
            this.save_as.Click += new System.EventHandler(this.save_as_Click_1);
            // 
            // Close_catalog
            // 
            this.Close_catalog.Name = "Close_catalog";
            this.Close_catalog.Size = new System.Drawing.Size(212, 22);
            this.Close_catalog.Text = "Закрыть таблицу";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Registr_takes,
            this.Register_returns});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.поискToolStripMenuItem.Text = "Зарегестрировать";
            // 
            // Registr_takes
            // 
            this.Registr_takes.Name = "Registr_takes";
            this.Registr_takes.Size = new System.Drawing.Size(152, 22);
            this.Registr_takes.Text = "Выдачу книги";
            // 
            // Register_returns
            // 
            this.Register_returns.Name = "Register_returns";
            this.Register_returns.Size = new System.Drawing.Size(152, 22);
            this.Register_returns.Text = "Возврат книги";
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Show_all_catalog,
            this.All_readers,
            this.takes_book,
            this.returns_books,
            this.books_of_reader,
            this.History_of_book});
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.показатьToolStripMenuItem.Text = "Показать";
            // 
            // Show_all_catalog
            // 
            this.Show_all_catalog.Name = "Show_all_catalog";
            this.Show_all_catalog.Size = new System.Drawing.Size(307, 22);
            this.Show_all_catalog.Text = "Показать весь каталог";
            // 
            // All_readers
            // 
            this.All_readers.Name = "All_readers";
            this.All_readers.Size = new System.Drawing.Size(307, 22);
            this.All_readers.Text = "Всех читателей";
            // 
            // takes_book
            // 
            this.takes_book.Name = "takes_book";
            this.takes_book.Size = new System.Drawing.Size(307, 22);
            this.takes_book.Text = "Какие книги были выданы от..";
            this.takes_book.Click += new System.EventHandler(this.какиеКнигиБылиВыданыОтToolStripMenuItem_Click);
            // 
            // returns_books
            // 
            this.returns_books.Name = "returns_books";
            this.returns_books.Size = new System.Drawing.Size(307, 22);
            this.returns_books.Text = "Какие книги были возвращены от..";
            // 
            // books_of_reader
            // 
            this.books_of_reader.Name = "books_of_reader";
            this.books_of_reader.Size = new System.Drawing.Size(307, 22);
            this.books_of_reader.Text = "Какие книги находятся у данного читателя";
            // 
            // History_of_book
            // 
            this.History_of_book.Name = "History_of_book";
            this.History_of_book.Size = new System.Drawing.Size(307, 22);
            this.History_of_book.Text = "Историю пользования книги";
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem1,
            this.читателяToolStripMenuItem1});
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem1.Text = "Поиск";
            // 
            // книгиToolStripMenuItem1
            // 
            this.книгиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_by_code,
            this.search_by_name});
            this.книгиToolStripMenuItem1.Name = "книгиToolStripMenuItem1";
            this.книгиToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.книгиToolStripMenuItem1.Text = "Книги";
            // 
            // search_by_code
            // 
            this.search_by_code.Name = "search_by_code";
            this.search_by_code.Size = new System.Drawing.Size(228, 22);
            this.search_by_code.Text = "За библиотечным шифром";
            // 
            // search_by_name
            // 
            this.search_by_name.Name = "search_by_name";
            this.search_by_name.Size = new System.Drawing.Size(228, 22);
            this.search_by_name.Text = "За названием книги";
            // 
            // читателяToolStripMenuItem1
            // 
            this.читателяToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_by_namer,
            this.search_by_ticket});
            this.читателяToolStripMenuItem1.Name = "читателяToolStripMenuItem1";
            this.читателяToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.читателяToolStripMenuItem1.Text = "Читателя";
            // 
            // search_by_namer
            // 
            this.search_by_namer.Name = "search_by_namer";
            this.search_by_namer.Size = new System.Drawing.Size(236, 22);
            this.search_by_namer.Text = "Имя и Фамилия";
            // 
            // search_by_ticket
            // 
            this.search_by_ticket.Name = "search_by_ticket";
            this.search_by_ticket.Size = new System.Drawing.Size(236, 22);
            this.search_by_ticket.Text = "Номер читательского билета";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_book,
            this.change_reader,
            this.remove_reader,
            this.remove_book});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // change_book
            // 
            this.change_book.Name = "change_book";
            this.change_book.Size = new System.Drawing.Size(226, 22);
            this.change_book.Text = "Данные про книгу";
            // 
            // change_reader
            // 
            this.change_reader.Name = "change_reader";
            this.change_reader.Size = new System.Drawing.Size(226, 22);
            this.change_reader.Text = "Данные читателя";
            // 
            // remove_reader
            // 
            this.remove_reader.Name = "remove_reader";
            this.remove_reader.Size = new System.Drawing.Size(226, 22);
            this.remove_reader.Text = "Удалить читателя из списка";
            // 
            // remove_book
            // 
            this.remove_book.Name = "remove_book";
            this.remove_book.Size = new System.Drawing.Size(226, 22);
            this.remove_book.Text = "Удалить книгу";
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 24);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(625, 331);
            this.table.TabIndex = 4;
            // 
            // picture_main
            // 
            this.picture_main.Location = new System.Drawing.Point(175, 73);
            this.picture_main.Name = "picture_main";
            this.picture_main.Size = new System.Drawing.Size(261, 196);
            this.picture_main.TabIndex = 3;
            this.picture_main.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(625, 355);
            this.Controls.Add(this.table);
            this.Controls.Add(this.picture_main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотечная система";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_book;
        private System.Windows.Forms.ToolStripMenuItem Add_reader;
        private System.Windows.Forms.ToolStripMenuItem Menu_from_file;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Registr_takes;
        private System.Windows.Forms.ToolStripMenuItem Register_returns;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem search_by_code;
        private System.Windows.Forms.ToolStripMenuItem search_by_name;
        private System.Windows.Forms.ToolStripMenuItem читателяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem change_reader;
        private System.Windows.Forms.PictureBox picture_main;
        private System.Windows.Forms.ToolStripMenuItem Close_catalog;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ToolStripMenuItem search_by_namer;
        private System.Windows.Forms.ToolStripMenuItem search_by_ticket;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Show_all_catalog;
        private System.Windows.Forms.ToolStripMenuItem All_readers;
        private System.Windows.Forms.ToolStripMenuItem takes_book;
        private System.Windows.Forms.ToolStripMenuItem returns_books;
        private System.Windows.Forms.ToolStripMenuItem books_of_reader;
        private System.Windows.Forms.ToolStripMenuItem remove_reader;
        private System.Windows.Forms.ToolStripMenuItem change_book;
        private System.Windows.Forms.ToolStripMenuItem remove_book;
        private System.Windows.Forms.ToolStripMenuItem save_as;
        private System.Windows.Forms.ToolStripMenuItem History_of_book;
        private System.Windows.Forms.ToolStripMenuItem save;
    }
}

