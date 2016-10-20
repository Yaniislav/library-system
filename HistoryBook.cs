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
    public partial class HistoryBook : Form
    {
        public HistoryBook()
        {
            InitializeComponent();
        }
        private Book buff;
        private void HistoryBook_Load(object sender, EventArgs e)
        {
            errorbook.SetError(textBox1, "Поле не заполнено !");
            button1.Enabled = false;
            history_table.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            textBox1.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            history_table.Visible = true;
            history_table.Columns.Add("book", "Имя");
            history_table.Columns.Add("Authors", "Отчество");
            history_table.Columns.Add("pub", "Фамилия");
            history_table.Columns.Add("place", "Номер чит. билета");
            history_table.Columns.Add("place", "Дата выдачи книги");
            history_table.Columns.Add("place", "Дата возврата книги");
            int i = 0;
            foreach(var ac in buff.Account)
            {
                Reader r = main.L.Search_reader(ac.Name_destination);
                history_table.Rows.Add();
                history_table.Rows[i].Cells[0].Value = r.Name_Person;
                history_table.Rows[i].Cells[1].Value = r.Patronymic_Name;
                history_table.Rows[i].Cells[2].Value = r.Surname;
                history_table.Rows[i].Cells[3].Value = r.Number_readticket;
                history_table.Rows[i].Cells[4].Value = ac.Date_takes;
                if (ac.Date_returns != new DateTime())
                    history_table.Rows[i].Cells[5].Value = ac.Date_returns;
                else
                    history_table.Rows[i].Cells[5].Value = "-";
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;

            if (textBox1.TextLength == 0)
            {
                errorbook.SetError(textBox1, "Поле не заполнено !");
                button1.Enabled = false;
            }
            else
            {
               Book buffer = main.L.Search_book_by_code(textBox1.Text);
                if (buffer.Authors_book.Count == 0)
                {
                    errorbook.SetError(textBox1, "Такой книги нет в наличии!");
                    button1.Enabled = false;
                }
                else
                {
                    errorbook.Clear();
                    button1.Enabled = true;
                    buff = buffer;
                }
            }
        }
    }
}
