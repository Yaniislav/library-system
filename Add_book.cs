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
    public partial class AddBook : Form
    {
       
        public AddBook()
        {
            InitializeComponent();
        }
        public bool contains;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (contains || nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0|| !Int32.TryParse(num.Text, out n)|| !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (name_iz.TextLength == 0) errorNamePub.SetError(name_iz, "Поле 'Название издательства' не заполнено !");
            else { errorNamePub.Clear(); pictureBox1.Visible = false; }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (contains || nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0 || !Int32.TryParse(num.Text, out n) || !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (place_pub.TextLength == 0) errorPlacePub.SetError(place_pub, "Поле 'Место издательства' не заполнено !");
            else { errorPlacePub.Clear(); pictureBox1.Visible = false; }
        }

        private void Book_add_Click(object sender, EventArgs e)
        {
            if (code.Text.Split(';').Count() == Convert.ToInt32(num.Text))
            {
                string Surname_author = "Surname";
                if (author.Text.Split(' ').Count() > 1)
                    Surname_author = author.Text.Split(' ')[1];
              
                    Form1 main = this.Owner as Form1;
                    Book b = new Book(new List<Person>(), Convert.ToInt32(year.Text), nameb.Text, name_iz.Text, place_pub.Text, code.Text);
                    b.Authors_book.Add(new Person(author.Text.Split(' ')[0], "author", Surname_author));
                    List<string> buff = new List<string>();
                    buff.AddRange(code.Text.Split(';'));
                    b.Libray_code = buff[0];
                    main.L.Codes.AddRange(buff);

                    if (main.L.In_catalog(nameb.Text) && main.L.Search_book_by_name(nameb.Text).BookL[0].Authors_book[0].Surname == Surname_author)
                    {
                        BookInLibrary lib = main.L.Search_book_by_name(nameb.Text);
                        //lib.BookL.Add(lib.);
                        int i = lib.Total_number_copies;
                        int index = i;
                        lib.Total_number_copies += Convert.ToInt32(num.Text);
                        lib.Number_of_available_copies += Convert.ToInt32(num.Text);
                        lib.Add_Books(i);
                        while (i < lib.Total_number_copies)
                        {
                            lib.BookL[i].Libray_code = buff[i - index];
                            i++;
                        }
                    }
                    else
                    {
                        main.L.Catalog.Add(new BookInLibrary(Convert.ToInt32(num.Text)));
                        main.L.Catalog[main.L.Catalog.Count - 1].BookL.Add(b);
                        main.L.Catalog[main.L.Catalog.Count - 1].Add_Books(1);
                        int i = 1;
                        while (i < Convert.ToInt32(num.Text))
                        {
                            main.L.Catalog[main.L.Catalog.Count - 1].BookL[i].Libray_code = buff[i];
                            i++;
                        }
                    }
                    num.Clear();
                    nameb.Clear();
                    author.Clear();
                    name_iz.Clear();
                    place_pub.Clear();
                    code.Clear();
                    year.Clear();
                    pictureBox1.Visible = true;
                
               
            }
            else MessageBox.Show("Количество библиотечных шифров не совпадает с количеством книг!");
            
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (contains || nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0 || !Int32.TryParse(num.Text, out n) || !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (num.TextLength == 0) errorNumber.SetError(num, "Поле 'Номер читательского билета' не заполнено !");
            else
            {
                pictureBox1.Visible = false;
                if (!Int32.TryParse(num.Text, out n))
                    errorNumber.SetError(num, "Введены буквы !");
                else errorNumber.Clear();
            }
        }

        private void nameb_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (contains || nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0 || !Int32.TryParse(num.Text, out n) || !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (nameb.TextLength == 0) errorBname.SetError(nameb, "Поле 'Название книги' не заполнено !");
            else { errorBname.Clear(); pictureBox1.Visible = false; }
            }

        private void author_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (contains || nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0 || !Int32.TryParse(num.Text, out n) || !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (author.TextLength == 0) errorAuthor.SetError(author, "Поле 'Автор' не заполнено !");
            else { errorAuthor.Clear(); pictureBox1.Visible = false; }
            }

        private void code_TextChanged(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            contains = false;
            foreach (string s in code.Text.Split(';')) if (main.L.Codes.Contains(s)) contains = true;
            int n;
            if (contains||nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0 || !Int32.TryParse(num.Text, out n) || !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (code.TextLength == 0) errorCode.SetError(code, "Поле 'Библиотечный шифр' не заполнено !");
            else {
                if(contains) errorCode.SetError(code, "Такой шифр уже существует!");
               else errorCode.Clear(); pictureBox1.Visible = false; }
            }

        private void year_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (contains || nameb.TextLength == 0 || author.TextLength == 0 || code.TextLength == 0 || year.TextLength == 0 || num.TextLength == 0 || name_iz.TextLength == 0 || place_pub.TextLength == 0 || !Int32.TryParse(num.Text, out n) || !Int32.TryParse(year.Text, out n))
                Book_add.Enabled = false;
            else Book_add.Enabled = true;
            if (year.TextLength == 0) errorYear.SetError(year, "Поле 'Год издательства' не заполнено !");
            else
            {
                pictureBox1.Visible = false;
                if (!Int32.TryParse(year.Text, out n))
                    errorYear.SetError(year, "Введены буквы !");
                else errorYear.Clear();
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            Book_add.Enabled = false;
            errorNamePub.SetError(name_iz, "Поле 'Название издательства' не заполнено !");
            errorPlacePub.SetError(place_pub, "Поле 'Место издательства' не заполнено !");
            errorNumber.SetError(num, "Поле 'Номер читательского билета' не заполнено !");
            errorBname.SetError(nameb, "Поле 'Название книги' не заполнено !");
            errorAuthor.SetError(author, "Поле 'Автор' не заполнено !");
            errorCode.SetError(code, "Поле 'Библиотечный шифр' не заполнено !");
            errorYear.SetError(year, "Поле 'Год издательства' не заполнено !");
            pictureBox2.Load("logo.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load("Checkmark.svg_.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = false;
           

        }
       
    }
}
