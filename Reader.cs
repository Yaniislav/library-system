using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    [Serializable]
    public class Reader:Person
    {
        
        private int number_readticket;
        private DateTime date_get_ticket;

        public Reader(): base(){  }
        public Reader(DateTime date_get, int num_ticket, string namep, string pname, string surnam):base(namep,pname,surnam)
        {
            
            
            number_readticket = num_ticket;
            date_get_ticket = date_get;

        }
        

        public int Number_readticket
        {
            get
            {
                return number_readticket;
            }

            set
            {
                number_readticket = value;
            }
        }

        public DateTime Date_get
        {
            get
            {
                return date_get_ticket;
            }

            set
            {
                date_get_ticket = value;
            }
        }
        
  
     
        public override string ToString()
        {
            return Name_Person + " " + Patronymic_Name + " " +Surname +"\n number of ticket: "+number_readticket+"\n Date get ticket: "+date_get_ticket;
        }
    }
}