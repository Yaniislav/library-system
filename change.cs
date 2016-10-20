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
   public enum Change_or_delete
    {
        change_book,change_reader,remove_reader,remove_book
    }
    public partial class Change : Form
    {
        public Change_or_delete flag;
        ChangeTable form;

        public Change()
        {
            form = new ChangeTable();
            form.Owner = this;
            InitializeComponent();
        }

        private void change_Load(object sender, EventArgs e)
        {
            if (flag == Change_or_delete.change_book || flag == Change_or_delete.change_reader) button1.Text = "Изменить";
            if (flag == Change_or_delete.remove_book || flag == Change_or_delete.remove_reader) { button1.Text = "Удалить"; }
            if (flag == Change_or_delete.change_book||flag==Change_or_delete.remove_book) label1.Text = "Библиотечный щифр книги";
            else label1.Text = "Номер читательского билета";
            button1.Enabled = false;
            errorProvider1.SetError(textBox1, "Поле пустое");
        }
        public void RemoveBook(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            Book b = main.L.Search_book_by_code(textBox1.Text);
            BookInLibrary bl = main.L.Search_book_by_name(b.Name_book);
            b.tr = TakesorReturns.Taken;
            bl.Number_of_available_copies--;
            bl.Total_number_copies--;
            main.L.Codes.Remove(b.Libray_code);
            b.Libray_code = "00";
            form.Close();
            Close();
        }
        public void RemoveReader(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            form.Close();
            main.L.Delete_reader(Convert.ToInt32(textBox1.Text));
            form.Close();
            Close();
        }
        public void SaveReader(object sender, EventArgs e)
        {
            int n;
            Form1 main = this.Owner as Form1;
            Reader r = main.L.Search_reader(Convert.ToInt32(textBox1.Text));
            r.Name_Person = form.table.Rows[0].Cells[0].Value.ToString(); ;
            r.Patronymic_Name = form.table.Rows[0].Cells[1].Value.ToString();
            r.Surname = form.table.Rows[0].Cells[2].Value.ToString();
            int buf = r.Number_readticket;
            if (Int32.TryParse(form.table.Rows[0].Cells[4].Value.ToString(), out n)&&!main.L.Contain_reader(n))
            {
                main.L.Change_reader_ticket(buf, n);
                 r.Number_readticket= n ;
            }
            form.Close();
            Close();
        }

        public void SaveBook(object sender, EventArgs e)
        {
            int n;
            Form1 main = this.Owner as Form1;
            Book b = main.L.Search_book_by_code(textBox1.Text);
            b.Name_publisher = form.table.Rows[0].Cells[2].Value.ToString();
            if (Int32.TryParse(form.table.Rows[0].Cells[3].Value.ToString(), out n))
                b.Date_publishing = n;
            b.Place_of_publishing = form.table.Rows[0].Cells[4].Value.ToString();
            main.L.Codes.Remove(b.Libray_code);
            b.Libray_code = form.table.Rows[0].Cells[5].Value.ToString();
            main.L.Codes.Add(b.Libray_code);
            form.Close();
            Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            form.table.Rows.Clear();
            if (flag == Change_or_delete.change_book||flag==Change_or_delete.remove_book)
            {
                Book b = main.L.Search_book_by_code(textBox1.Text);
                form.table.Columns.Add("book", "Название книги");
                form.table.Columns.Add("Authors", "Авторы");
                form.table.Columns.Add("pub", "Издательство");
                form.table.Columns.Add("year", "Год издания");
                form.table.Columns.Add("place", "Место издания");
                form.table.Columns.Add("code", "Библиотечный шифр");
                form.table.Rows.Add();
                form.table.Rows[0].Cells[0].Value = b.Name_book;
                form.table.Rows[0].Cells[0].ReadOnly = true;
                form.table.Rows[0].Cells[1].Value = b.Authors_to_string();
                form.table.Rows[0].Cells[2].Value = b.Name_publisher;
                form.table.Rows[0].Cells[3].Value = b.Date_publishing;
                form.table.Rows[0].Cells[4].Value = b.Place_of_publishing;
                form.table.Rows[0].Cells[5].Value = b.Libray_code;
            }
            if (flag == Change_or_delete.change_reader||flag==Change_or_delete.remove_reader)
            {
                Reader r = main.L.Search_reader(Convert.ToInt32(textBox1.Text));
                form.table.Columns.Add("book", "Имя");
                form.table.Columns.Add("Authors", "Отчество");
                form.table.Columns.Add("pub", "Фамилия");
                form.table.Columns.Add("year", "Дата получения билета");
                form.table.Columns.Add("place", "Номер чит. билета");
                form.table.Rows.Add();
                form.table.Rows[0].Cells[0].Value = r.Name_Person;
                form.table.Rows[0].Cells[1].Value = r.Patronymic_Name;
                form.table.Rows[0].Cells[2].Value = r.Surname;
                form.table.Rows[0].Cells[3].Value = r.Date_get;
                form.table.Rows[0].Cells[3].ReadOnly = true;
                form.table.Rows[0].Cells[4].Value = r.Number_readticket;
            }
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            Form1 main = this.Owner as Form1;
            if (textBox1.TextLength == 0)
            {
                button1.Enabled = false;
                errorProvider1.SetError(textBox1, "Поле пустое");
            }
            else
            {

                if (textBox1.TextLength != 0)
                {
                    if (flag == Change_or_delete.change_book || flag == Change_or_delete.remove_book)
                        if (main.L.Codes.Contains(textBox1.Text)) { button1.Enabled = true; errorProvider1.Clear(); }
                        else { button1.Enabled = false; errorProvider1.SetError(textBox1, "Такой книги нет в каталоге"); }
                    else
                    {
                        if (Int32.TryParse(textBox1.Text, out n))
                        {
                            if (main.L.Contain_reader(n))
                            {
                                button1.Enabled = true;
                                errorProvider1.Clear();
                            }
                            else
                            {
                                errorProvider1.SetError(textBox1, "Такого читательского билета нет"); button1.Enabled = false;
                            }
                        }

                        else
                        {
                            errorProvider1.SetError(textBox1, "Введены буквы"); button1.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}
