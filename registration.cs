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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public bool flag;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            Book b = main.L.Search_book_by_code(textBox2.Text);
            int m = main.L.Search_book_by_name(textBox3.Text).BookL.Count;
            int n, i = main.L.Search_book_by_code(textBox2.Text).Authors_book.Count;
            if (textBox1.TextLength == 0 || m == 0 || textBox2.TextLength == 0 || !Int32.TryParse(textBox1.Text, out n) || i == 0 || textBox2.TextLength == 0)
                zaregat.Enabled = false;
            else if ((!flag && b.tr != TakesorReturns.Returned && main.L.Books_of_current_reader(Convert.ToInt32(textBox1.Text)).Contains(b)) || (flag && b.tr != TakesorReturns.Taken)) zaregat.Enabled = true;
            else zaregat.Enabled = false;
            if (textBox1.TextLength == 0)
                error_ticket.SetError(textBox1, "Поле 'Номер читательского билета ' не заполнено!");
            else
            {
                pictureBox1.Visible = false;
                if (!Int32.TryParse(textBox1.Text, out n))
                    error_ticket.SetError(textBox1, "Введены буквы !");
                else
                    if(!main.L.Contain_reader(Convert.ToInt32(textBox1.Text)))error_ticket.SetError(textBox1, "Такого читательского билета не существует !");
               else if(!flag&&!main.L.Books_of_current_reader(Convert.ToInt32(textBox1.Text)).Contains(b)&&textBox2.TextLength!=0) error_ticket.SetError(textBox1, "У данного читателя нет такой книги!");
                else /*if(!flag&&b.Account.Last().Date_takes>dateTimePicker1.Value) error_ticket.SetError(textBox1, "Дата выдачи книги больше,чем дата возврата !");*/
               /* else*/ error_ticket.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            int m = main.L.Search_book_by_name(textBox3.Text).BookL.Count;
            int n;
            Book i = main.L.Search_book_by_code(textBox2.Text);
            if (textBox1.TextLength == 0 || m == 0 || textBox2.TextLength == 0 || !Int32.TryParse(textBox1.Text, out n) || i.Authors_book.Count == 0 || textBox3.TextLength == 0)
                zaregat.Enabled = false;
            else if((!flag&& i.tr != TakesorReturns.Returned&&main.L.Books_of_current_reader(Convert.ToInt32(textBox1.Text)).Contains(i) )||(flag && i.tr != TakesorReturns.Taken))zaregat.Enabled = true;
            else zaregat.Enabled = false;
            if (textBox2.TextLength == 0)
                error_code.SetError(textBox2, "Поле 'Библиотсечный шифр ' не заполнено!");
            else
            {
                pictureBox1.Visible = false;
                if (flag && (i.Authors_book.Count == 0 || i.tr == TakesorReturns.Taken)) error_code.SetError(textBox2, "Такой книги нет наличии!");
                else if (!flag&&i.tr == TakesorReturns.Returned) error_code.SetError(textBox2, "Такая книга уже имеется наличии!");
                else error_code.Clear();

            }
        }

        private void zaregat_Click(object sender, EventArgs e)
        {
                Form1 main = this.Owner as Form1;
            if (dateTimePicker1.Value.Year>=main.L.Search_book_by_code(textBox2.Text).Date_publishing)
            {

                if (flag) main.L.Registration_taken_book(Convert.ToInt32(textBox1.Text), textBox2.Text, dateTimePicker1.Value);
                else  main.L.Registration_returned_book(Convert.ToInt32(textBox1.Text), textBox2.Text, dateTimePicker1.Value);
                pictureBox1.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

            else MessageBox.Show("Дата выдачи не может быть меньше,чем дата публикации книги !");
        }

        private void registration_Load(object sender, EventArgs e)
        {
            zaregat.Enabled = false;
            error_ticket.SetError(textBox1, "Поле 'Номер читательского билета ' не заполнено!");
            error_code.SetError(textBox2, "Поле 'Библиотсечный шифр ' не заполнено!");
            error_name.SetError(textBox3, "Поле 'Название книги ' не заполнено!");
            pictureBox2.Load("logo.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load("Checkmark.svg_.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            Form1 main = this.Owner as Form1;
            Book b = main.L.Search_book_by_code(textBox2.Text);
            int n, i = main.L.Search_book_by_code(textBox2.Text).Authors_book.Count;
            int m = main.L.Search_book_by_name(textBox3.Text).BookL.Count;
            if (textBox1.TextLength == 0 || m == 0 || textBox2.TextLength == 0 || !Int32.TryParse(textBox1.Text, out n) || i == 0|| textBox2.TextLength == 0)
                zaregat.Enabled = false;
            else if ((!flag && b.tr != TakesorReturns.Returned && main.L.Books_of_current_reader(Convert.ToInt32(textBox1.Text)).Contains(b)) || (flag && b.tr != TakesorReturns.Taken)) zaregat.Enabled = true;
            else zaregat.Enabled = false;
            if (textBox3.TextLength == 0)
                error_name.SetError(textBox3, "Поле 'Название книги ' не заполнено!");
            else
            {
                pictureBox1.Visible = false;
                if (m == 0 || main.L.Search_book_by_name(textBox3.Text).Number_of_available_copies == 0) error_name.SetError(textBox3, "Такой книги нет наличии!");
                else error_name.Clear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
