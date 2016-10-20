using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibrarySystem
{
    [Serializable]
    public class AccountBook
    {
        private DateTime date_taken_book;
        private DateTime date_returns_book;
        private TakesorReturns take_or_returns;
        private int num_destination;
        public AccountBook( DateTime date_take,int namer)
        {
            date_returns_book = new DateTime();
            date_taken_book = date_take;
            //name_book = new Book(nameb.Authors_book, nameb.Date_publishing, nameb.Name_book, nameb.Name_publisher, nameb.Place_of_publishing,nameb.Libray_code);
            //name_destination = new Reader(namer.Date_get, namer.Number_readticket, namer.Person.Name_Person, namer.Person.Patronymic_Name, namer.Person.Surname);
            take_or_returns = TakesorReturns.Taken;
            num_destination = namer;
        }

        public DateTime Date_returns
        {
            get
            {
                return date_returns_book;
            }

            set
            {
                date_returns_book = value;
            }
        }

        public DateTime Date_takes
        {
            get
            {
                return date_taken_book;
            }

            set
            {
                date_taken_book = value;
            }
        }
       

        public int Name_destination
        {
            get
            {
                return num_destination;
            }

            set
            {
                num_destination = value;
            }
        }

      

        public TakesorReturns TakesorReturns
        {
            get
            {
                return take_or_returns;
            }

            set
            {
                take_or_returns = value;
            }
        }
    }
}