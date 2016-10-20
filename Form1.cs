using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LibrarySystem
{


    public partial class Form1 : Form
    {
        public Library L = new Library();

        public Form1()
        {
            InitializeComponent();
            BinaryFormatter bf = new BinaryFormatter();
            using (var fStream = File.Open("Library.dat", FileMode.OpenOrCreate))
            {
                L = (Library)bf.Deserialize(fStream);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            picture_main.Load("logo.gif");
            picture_main.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.None)));
            table.Visible = false;
            Add_reader.Click += Add_reader_Click;
            Add_book.Click += Add_book_Click;
            Menu_from_file.Click += Menu_from_file_Click;
            Show_all_catalog.Click += Show_all_catalog_Click;
            Close_catalog.Click += Close_catalog_Click;
            Registr_takes.Click += Registr_takes_Click;
            Register_returns.Click += Register_returns_Click;
            search_by_name.Click += Search_by_name_Click;
            search_by_code.Click += Search_by_code_Click;
            search_by_namer.Click += Search_by_namer_Click;
            search_by_ticket.Click += Search_by_ticket_Click1;
            All_readers.Click += All_readers_Click;
            takes_book.Click += Takes_book_Click;
            returns_books.Click += Returns_books_Click;
            books_of_reader.Click += Books_of_reader_Click;
            change_book.Click += Change_book_Click;
            change_reader.Click += Change_reader_Click;
            remove_reader.Click += Remove_reader_Click;
            remove_book.Click += Remove_book_Click;
            save_as.Click += Save_as_Click;
            History_of_book.Click += History_of_book_Click;
            save.Click += Save_Click;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var fStream = new FileStream("Library.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fStream, L);
            }
        }

        private void History_of_book_Click(object sender, EventArgs e)
        {
            HistoryBook form = new HistoryBook();
            form.Owner = this;
            form.Show();
        }

        private void Save_as_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(sf.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    L.Save_books_to_exel(ObjWorkBook);
                    L.Save_readers_to_exel((Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[3]);

                    MessageBox.Show("Каталог успешно сохранен");

                    ObjExcel.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Файл не найден :" + ex.Message);
                }
            }
        }

        private void Remove_book_Click(object sender, EventArgs e)
        {
            Change form = new Change();
            form.Owner = this;
            form.flag = Change_or_delete.remove_book;
            form.Show();
        }

        private void Remove_reader_Click(object sender, EventArgs e)
        {
            Change form = new Change();
            form.Owner = this;
            form.flag = Change_or_delete.remove_reader;
            form.Show();
        }

        private void Change_reader_Click(object sender, EventArgs e)
        {
            Change form = new Change();
            form.Owner = this;
            form.flag = Change_or_delete.change_reader;
            form.Show();
        }

        private void Change_book_Click(object sender, EventArgs e)
        {
            Change form = new Change();
            form.Owner = this;
            form.flag = Change_or_delete.change_book;
            form.Show();
        }

        private void Books_of_reader_Click(object sender, EventArgs e)
        {
            Book_by_times form = new Book_by_times();
            form.Owner = this;
            form.flag = By.reader;
            form.Show();
        }

        private void Returns_books_Click(object sender, EventArgs e)
        {
            Book_by_times form = new Book_by_times();
            form.Owner = this;
            form.flag = By.returned;
            form.Show();
        }
        private void Takes_book_Click(object sender, EventArgs e)
        {
            Book_by_times form = new Book_by_times();
            form.Owner = this;
            form.flag = By.taken;
            form.Show();
        }

        private void All_readers_Click(object sender, EventArgs e)
        {
            picture_main.Visible = false;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Visible = true;
            table.Columns.Add("book", "Имя");
            table.Columns.Add("Authors", "Отчество");
            table.Columns.Add("pub", "Фамилия");
            table.Columns.Add("year", "Дата получения билета");
            table.Columns.Add("place", "Номер чит. билета");

            int i = 0;
            foreach (Reader r in L.Readers)
            {
                table.Rows.Add();
                table.Rows[i].Cells[0].Value = r.Name_Person;
                table.Rows[i].Cells[1].Value = r.Patronymic_Name;
                table.Rows[i].Cells[2].Value = r.Surname;
                table.Rows[i].Cells[3].Value = r.Date_get;
                table.Rows[i].Cells[4].Value = r.Number_readticket;
                i++;
            }
        }

        private void Search_by_ticket_Click1(object sender, EventArgs e)
        {
            Search_book form = new Search_book();
            form.Owner = this;
            form.flag = Search.reader_by_ticket;
            form.Show();
        }

        private void Search_by_namer_Click(object sender, EventArgs e)
        {
            Search_book form = new Search_book();
            form.Owner = this;
            form.flag = Search.reader_by_name;
            form.Show();
        }

        private void Search_by_code_Click(object sender, EventArgs e)
        {
            Search_book form = new Search_book();
            form.Owner = this;
            form.flag = Search.book_by_code;
            form.Show();
        }

        private void Search_by_name_Click(object sender, EventArgs e)
        {

            Search_book form = new Search_book();
            form.Owner = this;
            form.flag = Search.book_by_name;
            form.Show();
        }

        private void Register_returns_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Owner = this;
            form.flag = false;
            form.Show();
        }

        private void Registr_takes_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Owner = this;
            form.flag = true;
            form.Show();
        }

        private void Close_catalog_Click(object sender, EventArgs e)
        {

            picture_main.Visible = true;
            table.Visible = false;
        }

        private void Show_all_catalog_Click(object sender, EventArgs e)
        {
            picture_main.Visible = false;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Visible = true;
            table.Columns.Add("book", "Название книги");
            table.Columns.Add("Authors", "Авторы");
            table.Columns.Add("pub", "Издательство");
            table.Columns.Add("year", "Год издания");
            table.Columns.Add("place", "Место издания");
            table.Columns.Add("total_num", "Общее кол-во копий");
            table.Columns.Add("aviable_num", "Доступное кол-во копий");
            int i = 0;
            foreach (BookInLibrary b in L.Catalog)
            {
                int j = 0;
                while (j < b.BookL.Count && b.BookL[0].Libray_code == "00") j++;
                if (j != b.BookL.Count)
                {
                    table.Rows.Add();
                    table.Rows[i].Cells[0].Value = b.BookL[j].Name_book;
                    table.Rows[i].Cells[1].Value = b.BookL[j].Authors_to_string();
                    table.Rows[i].Cells[2].Value = b.BookL[j].Name_publisher;
                    table.Rows[i].Cells[3].Value = b.BookL[j].Date_publishing;
                    table.Rows[i].Cells[4].Value = b.BookL[j].Place_of_publishing;
                    table.Rows[i].Cells[5].Value = b.Total_number_copies;
                    table.Rows[i].Cells[6].Value = b.Number_of_available_copies;
                    i++;
                }
            }
        }
        private void Anime(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Menu_from_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "d:\\";
            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(of.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
                    ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
                    L.Read_from_exel((Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1]);
                    L.Read_info_of_book((Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[2]);
                    L.Read_info_of_readers((Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[3]);
                    MessageBox.Show("Каталог успешно добален");
                    ObjWorkBook.Close();
                    ObjExcel.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Файл не найден :" + ex.Message);

                }
            }

        }

        private void Add_book_Click(object sender, EventArgs e)
        {
            AddBook form = new AddBook();
            form.Owner = this;
            form.Show();
        }

        private void Add_reader_Click(object sender, EventArgs e)
        {
            AddReader form = new AddReader();
            form.Owner = this;
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Form = new Add();
            //Form.Show();
        }

        private void какиеКнигиБылиВыданыОтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void save_as_Click_1(object sender, EventArgs e)
        {

        }
    }
}
