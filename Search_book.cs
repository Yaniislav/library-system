using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
  public  enum Search
    {
        book_by_name,book_by_code,reader_by_ticket,reader_by_name
    };
    public partial class Search_book : Form
    {
        public Search flag;
        
        public Search_book()
        {
            InitializeComponent();
        }

        private void Search_book_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("logo.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.None)));
            search_table.Visible = false;
            button1.Text = "Поиск";
            if (flag == Search.book_by_name)
            {
                label2.Visible = false;
                textBox2.Visible = false;
                label1.Text = "Название книги:";
            }
            if (flag == Search.book_by_code)
            {
                label2.Visible = false;
                textBox2.Visible = false;
                label1.Text = "Библиотечный шифр:";
            }
            if (flag == Search.reader_by_name)
            {
                label2.Text = "Фамилия";              
                label1.Text = "Имя";
            }
            if (flag == Search.reader_by_ticket)
            {
                label2.Visible = false;
                textBox2.Visible = false;
                label1.Text = "Номер читательского билета";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Готово";
                search_table.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                pictureBox1.Visible = false;
                Form1 main = this.Owner as Form1;
                if (flag == Search.book_by_name)
                {

                    search_table.Rows.Clear();
                    search_table.Columns.Clear();
                    search_table.Visible = true;
                    search_table.Columns.Add("book", "Название книги");
                    search_table.Columns.Add("Authors", "Авторы");
                    search_table.Columns.Add("pub", "Издательство");
                    search_table.Columns.Add("year", "Год издания");
                    search_table.Columns.Add("place", "Место издания");
                    search_table.Columns.Add("total_num", "В наличии");
                    search_table.Columns.Add("aviable_num", "Библиотечный шифр");
                    BookInLibrary buff = main.L.Search_book_by_name(textBox1.Text);
                    int i = 0;
                    foreach (var b in buff.BookL)
                    {
                    if (b.Libray_code != "00")
                    {
                        search_table.Rows.Add();
                        search_table.Rows[i].Cells[0].Value = b.Name_book;
                        search_table.Rows[i].Cells[1].Value = b.Authors_to_string();
                        search_table.Rows[i].Cells[2].Value = b.Name_publisher;
                        search_table.Rows[i].Cells[3].Value = b.Date_publishing;
                        search_table.Rows[i].Cells[4].Value = b.Place_of_publishing;
                        if (b.tr == TakesorReturns.Returned)
                            search_table.Rows[i].Cells[5].Value = "Да";
                        else search_table.Rows[i].Cells[5].Value = "Нет";
                        search_table.Rows[i].Cells[6].Value = b.Libray_code;
                        i++;
                    }
                    }
                }
            if (flag == Search.book_by_code)
            {
                search_table.Rows.Clear();
                search_table.Columns.Clear();
                search_table.Visible = true;
                search_table.Columns.Add("book", "Название книги");
                search_table.Columns.Add("Authors", "Авторы");
                search_table.Columns.Add("pub", "Издательство");
                search_table.Columns.Add("year", "Год издания");
                search_table.Columns.Add("place", "Место издания");
                search_table.Columns.Add("total_num", "В наличии");
                search_table.Columns.Add("aviable_num", "Библиотечный шифр");
                Book buff = main.L.Search_book_by_code(textBox1.Text);
                if (buff.Authors_book.Count != 0&&buff.Libray_code!="00")
                {
                    search_table.Rows.Add();
                    search_table.Rows[0].Cells[0].Value = buff.Name_book;
                    search_table.Rows[0].Cells[1].Value = buff.Authors_to_string();
                    search_table.Rows[0].Cells[2].Value = buff.Name_publisher;
                    search_table.Rows[0].Cells[3].Value = buff.Date_publishing;
                    search_table.Rows[0].Cells[4].Value = buff.Place_of_publishing;
                    if (buff.tr == TakesorReturns.Returned)
                        search_table.Rows[0].Cells[5].Value = "Да";
                    else search_table.Rows[0].Cells[5].Value = "Нет";
                    search_table.Rows[0].Cells[6].Value = buff.Libray_code;
                }                              
            }
            if(flag==Search.reader_by_name)
            {
                search_table.Rows.Clear();
                search_table.Columns.Clear();
                search_table.Visible = true;
                search_table.Columns.Add("book", "Имя ");
                search_table.Columns.Add("Authors", "Отчество");
                search_table.Columns.Add("Authors", "Фамилия");
                search_table.Columns.Add("pub", "Дата полученя чит.билета");
                search_table.Columns.Add("year", "Номер чит.билета");
                int i = 0;
                foreach(var r in main.L.Current_info_of_reader(textBox1.Text,textBox2.Text))
                {
                    search_table.Rows.Add();
                    search_table.Rows[i].Cells[0].Value = r.Name_Person;
                    search_table.Rows[i].Cells[1].Value = r.Patronymic_Name;
                    search_table.Rows[i].Cells[2].Value = r.Surname;
                    search_table.Rows[i].Cells[3].Value = r.Date_get;
                    search_table.Rows[i].Cells[4].Value = r.Number_readticket;
                    i++;
                }
            }
            if(flag==Search.reader_by_ticket)
            {
                search_table.Rows.Clear();
                search_table.Columns.Clear();
                search_table.Visible = true;
                search_table.Columns.Add("book", "Имя ");
                search_table.Columns.Add("Authors", "Отчество");
                search_table.Columns.Add("Authors", "Фамилия");
                search_table.Columns.Add("pub", "Дата полученя чит.билета");
                search_table.Columns.Add("year", "Номер чит.билета");
                try {
                    Reader r = main.L.Search_reader(Convert.ToInt32(textBox1.Text));
                    search_table.Rows.Add();
                    int i = 0;
                    search_table.Rows[i].Cells[0].Value = r.Name_Person;
                    search_table.Rows[i].Cells[1].Value = r.Patronymic_Name;
                    search_table.Rows[i].Cells[2].Value = r.Surname;
                    search_table.Rows[i].Cells[3].Value = r.Date_get;
                    search_table.Rows[i].Cells[4].Value = r.Number_readticket;
                }
                catch(Exception ) { }
            }
                button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Search_book f = new Search_book();
            f.Owner = this.Owner;
            f.flag = this.flag;
            f.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (flag == Search.reader_by_ticket && !Int32.TryParse(textBox1.Text, out n))
            {
                errorProvider1.SetError(textBox1, "Введены буквы");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                button1.Enabled = true;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (flag == Search.reader_by_ticket && !Int32.TryParse(textBox1.Text, out n))
            {
                errorProvider1.SetError(textBox1, "Введены буквы");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                button1.Enabled = true;
            }
        }

        private void search_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
