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
   public enum By
    {
        returned,taken,reader
    }
    public partial class Book_by_times : Form
    {
        public By flag;
        public Book_by_times()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void book_by_times_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("logo.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.None)));
            table.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            if (flag==By.reader)
            {
            button1.Enabled = false;
                textBox1.Visible = true;
                dateT.Visible = false;
                label2.Visible = false;
                label1.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form1 main = this.Owner as Form1;
            table.Visible = true;
            textBox1.Visible = false;
            dateT.Visible = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
                table.Rows.Clear();
                table.Columns.Clear();
                table.Visible = true;
                table.Columns.Add("book", "Название книги");
                table.Columns.Add("Authors", "Авторы");
                table.Columns.Add("pub", "Издательство");
                table.Columns.Add("year", "Год издания");
                table.Columns.Add("place", "Место издания");
                table.Columns.Add("total_num", "В наличии");
                table.Columns.Add("aviable_num", "Библиотечный шифр");
                    List<Book> buff = new List<Book>();
            if (flag != By.reader)
            {
                this.Text = "После " + dateT.Value;
                if (flag == By.returned)
                        buff.AddRange(main.L.Search_returned_books_bydate(dateT.Value));
                    else buff.AddRange(main.L.Search_taken_books_bydate(dateT.Value));
            }
            else
            {
                int number = Convert.ToInt32(textBox1.Text);
                buff.AddRange(main.L.Books_of_current_reader(Convert.ToInt32(textBox1.Text)));
                this.Text = "Номер билета:" + number;
                if (buff[0].Authors_book.Count == 0) buff.Clear();
                else if(main.L.Contain_reader(Convert.ToInt32(number))) this.Text = main.L.Search_reader(number).Name_Person+ " "+ main.L.Search_reader(number).Surname;             
            }
      try {
                int i = 0;
            foreach (Book b in buff)
            {
                    if (b.Authors_book.Count != 0&&b.Libray_code!="00")
                    {
                        table.Rows.Add();
                        table.Rows[i].Cells[0].Value = b.Name_book;
                        table.Rows[i].Cells[1].Value = b.Authors_to_string();
                        table.Rows[i].Cells[2].Value = b.Name_publisher;
                        table.Rows[i].Cells[3].Value = b.Date_publishing;
                        table.Rows[i].Cells[4].Value = b.Place_of_publishing;
                        if (b.tr == TakesorReturns.Returned)
                            table.Rows[i].Cells[5].Value = "Да";
                        else table.Rows[i].Cells[5].Value = "Нет";
                        table.Rows[i].Cells[6].Value = b.Libray_code;
                        i++;
                    }
            }
            }
            catch (Exception) { }
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (textBox1.TextLength == 0 || !Int32.TryParse(textBox1.Text, out n)) button1.Enabled = false;
            else button1.Enabled = true;
            if (textBox1.TextLength == 0) errorProvider1.SetError(textBox1, "Поле пустое");
            else if (!Int32.TryParse(textBox1.Text, out n)) errorProvider1.SetError(textBox1, "Введены буквы");
            else errorProvider1.Clear();
        }
    }
}
