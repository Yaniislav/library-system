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
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();       
                
        }
        private Reader r;
        private void Addbook_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            r = new Reader(dateTimePicker1.Value, Convert.ToInt32(number_of_ticket.Text), name.Text, Otchestvo.Text, surname.Text);
            main.L.Add_reader(r);
            name.Clear();
            Otchestvo.Clear();
            surname.Clear();
            number_of_ticket.Clear();
            pictureBox1.Visible = true;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            Addbook.Enabled = false;
            errorNumber.SetError(number_of_ticket, "Поле 'Номер читательского билета' не заполнено  !");
             errorOtches.SetError(Otchestvo, "Поле 'Отчество' не заполнено!");
            errorName.SetError(name, "Поле 'Имя' не заполнено !");
            errorSurname.SetError(surname, "Поле 'Фамилия' не заполнено !");
            pictureBox2.Load("logo.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load("Checkmark.svg_.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = false;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            
            int n;
            if (name.TextLength == 0 || Otchestvo.TextLength == 0 || surname.TextLength == 0 || number_of_ticket.TextLength == 0 || Int32.TryParse(number_of_ticket.Text, out n) == false)           
                Addbook.Enabled = false;                           
            else                      
                if(!main.L.Contain_reader(Convert.ToInt32(number_of_ticket.Text)))Addbook.Enabled = true;
            else Addbook.Enabled = false;

            if (name.TextLength == 0)
            {
               
                errorName.SetError(name, "Поле 'Имя' не заполнено !");
            }
            else
            {
                pictureBox1.Visible = false;
                errorName.Clear();
            }
        }

        private void Otchestvo_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            
            int n;
            if (name.TextLength == 0 || Otchestvo.TextLength == 0 || surname.TextLength == 0 || number_of_ticket.TextLength == 0 || Int32.TryParse(number_of_ticket.Text, out n) == false) Addbook.Enabled = false;
            else
                if (!main.L.Contain_reader(Convert.ToInt32(number_of_ticket.Text))) Addbook.Enabled = true;
            else Addbook.Enabled = false;
            if (Otchestvo.TextLength == 0) errorOtches.SetError(Otchestvo, "Поле 'Отчество' не заполнено!");
            else
            {
                errorOtches.Clear();
                pictureBox1.Visible = false;
            }
            }

        private void surname_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
           
            int n;
            if (name.TextLength == 0 || Otchestvo.TextLength == 0 || surname.TextLength == 0 || number_of_ticket.TextLength == 0 || Int32.TryParse(number_of_ticket.Text, out n) == false) Addbook.Enabled = false;
            else
                if (!main.L.Contain_reader(Convert.ToInt32(number_of_ticket.Text))) Addbook.Enabled = true;
            else Addbook.Enabled = false;
            if (surname.TextLength == 0) errorSurname.SetError(surname, "Поле 'Фамилия' не заполнено !");
            else
            {
                errorSurname.Clear();
                pictureBox1.Visible = false;
            }
            }

        private void number_of_ticket_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
          
            int n;
            if ((name.TextLength == 0 ||  Otchestvo.TextLength == 0 || surname.TextLength == 0 || number_of_ticket.TextLength == 0)|| Int32.TryParse(number_of_ticket.Text,out n)==false) Addbook.Enabled = false;
            else
                if (!main.L.Contain_reader(Convert.ToInt32(number_of_ticket.Text))) Addbook.Enabled = true;
            else Addbook.Enabled = false;

            if (number_of_ticket.TextLength == 0)
            {
                errorNumber.SetError(number_of_ticket, "Поле 'Номер читательского билета' не заполнено  !");
            }
            else
            {
                pictureBox1.Visible = false;
                if (!Int32.TryParse(number_of_ticket.Text, out n))
                {

                    errorNumber.SetError(number_of_ticket, "Введены буквы !");
                }
                else if(main.L.Contain_reader(Convert.ToInt32(number_of_ticket.Text))) errorNumber.SetError(number_of_ticket, "Данный номер уже занят !");
                else { errorNumber.Clear(); }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
