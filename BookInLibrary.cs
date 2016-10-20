using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    [Serializable]
    public class BookInLibrary
    {
        private List<Book> book;
        private int total_number_of_copies;
        private int number_of_available_copies;
        
        public BookInLibrary() { book = new List<Book>(); }
        public BookInLibrary(  int totalnum)
        {
           
            total_number_of_copies = totalnum;
            number_of_available_copies = totalnum;
            book = new List<Book>();
           
        }
        public int Total_number_copies
        {
            get
            {
                return total_number_of_copies;
            }

            set
            {
                total_number_of_copies = value;
            }
        }
        public int Number_of_available_copies
        {
            get
            {
                return number_of_available_copies;
            }

            set
            {
                number_of_available_copies = value;
            }
        }
        public void Add_Books(int b)
        {
            int i = b;
            while (i < total_number_of_copies)
            {
                book.Add(new Book(book[0]));
                i++;
            }

        }
        public List<Book> BookL
        {
            get { return book; }
            set { book = value; }
        }
        //public override string ToString()
        //{
        //    return book.ToString() + "\nОбщее количество копий: " + total_number_of_copies + "\n Количество доступных копий:" + number_of_available_copies + "Библиотечный шифр:" + library_code;
        //}
    }
}
