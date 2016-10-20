using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    [Serializable]
    public class Book
    {
        private string name_book;
        private List<Person> authors_book;
        private string library_code;
        private int date_of_publishing;
        private string place_of_publishing;
        private string name_publisher;
        private TakesorReturns take_or_returns;
        private List<AccountBook> account;
        public Book()
        {
            authors_book = new List<Person>();
            account = new List<AccountBook>();
            take_or_returns = TakesorReturns.Returned;
        }
        public Book(Book b)
        {
            authors_book = new List<Person>();
            account = new List<AccountBook>();
            authors_book.AddRange(b.Authors_book);
            name_book = b.Name_book;
            date_of_publishing = b.Date_publishing;
            place_of_publishing = b.Place_of_publishing;
            name_publisher = b.Name_publisher;
            take_or_returns = TakesorReturns.Returned;
        }
        public Book(List<Person> authors, int datepub,  string nameb, string namep, string placepub,string lib_code)
        {
            authors_book = new List<Person>();
            account = new List<AccountBook>();
            name_book = nameb;
            authors_book.AddRange(authors);           
            date_of_publishing = datepub;
            place_of_publishing = placepub;
            name_publisher = namep;
            library_code = lib_code;
            take_or_returns = TakesorReturns.Returned;                        
        }
        

        public List<Person> Authors_book
        {
            get
            {
                return authors_book;
            }

            set
            {
                authors_book = value;
            }
        }

        public int Date_publishing
        {
            get
            {
                return date_of_publishing;
            }

            set
            {
                date_of_publishing = value;
            }
        }

        public string Name_book
        {
            get
            {
                return name_book;
            }

            set
            {
                name_book = value;
            }
        }

        public string Name_publisher
        {
            get
            {
                return name_publisher;
            }

            set
            {
                name_publisher = value;
            }
        }

        public string Libray_code
        {
            get
            {
                return library_code;
            }

            set
            {
                library_code = value;
            }
        }

        public string Place_of_publishing
        {
            get
            {
                return place_of_publishing;
            }

            set
            {
                place_of_publishing = value;
            }
        }
        public string Authors_to_string()
        {
            StringBuilder s = new StringBuilder();
            foreach (Person b in authors_book)
            {
                s.Append(b.Name_Person + " " + b.Surname + ",");
            }
            return s.ToString();
        }
        public List<AccountBook> Account
        {
            get { return account; }
            set { account = value; }
        }
        public TakesorReturns tr { get { return take_or_returns; } set { take_or_returns = value; } }
        public override string ToString()
        {
           
            return name_book + "(" + Authors_to_string() + ");";
        }


    }
}