using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibrarySystem
{
    [Serializable]
    public class Library
    {
        private List<Reader> readers;
        private List<BookInLibrary> catalog;
        private List<string> codes;
        public Library()
        {
            readers = new List<Reader>();
            catalog = new List<BookInLibrary>();
            codes = new List<string>();
            //Read_catalog_from_file();
        }      
        public void Read_info_of_readers(Microsoft.Office.Interop.Excel.Worksheet workshhet)
        {
            int i = 2,n,j;
            
            while (workshhet.Cells[i, 1].Value != null)
            {
                if (Int32.TryParse(Convert.ToString(workshhet.Cells[i, 4].Value), out n) && !Contain_reader(n))
                {
                    readers.Add(new Reader());
                    j = readers.Count - 1;
                    readers[j].Name_Person = workshhet.Cells[i, 1].Value;
                    readers[j].Patronymic_Name = workshhet.Cells[i, 2].Value;
                    readers[j].Surname = workshhet.Cells[i, 3].Value;
                    readers[j].Number_readticket = n;
                    readers[j].Date_get = (DateTime)workshhet.Cells[i, 5].Value;
                }
                i++;
            }
        }
        public void Read_info_of_book(Microsoft.Office.Interop.Excel.Worksheet workshhet)
        {
            int i = 2,n;
            Book b;
            AccountBook ac;
            while (workshhet.Cells[i, 1].Value != null)
            {
                b = Search_book_by_code(workshhet.Cells[i, 1].Value);
                
                    if (Int32.TryParse(workshhet.Cells[i,2].Text, out n))
                    {
                        ac=new AccountBook((DateTime)workshhet.Cells[i, 4].Value, n);
                    if (workshhet.Cells[i, 5].Text == "-")
                    {
                        b.tr = TakesorReturns.Taken;
                        ac.Date_returns = new DateTime();
                    }
                    else
                    {
                        b.tr = TakesorReturns.Returned;
                        ac.Date_returns = (DateTime)workshhet.Cells[i, 5].Value;
                    }
                            b.Account.Add(ac);                                                   
                    }
                i++;
            }
        }
        public void Read_from_exel(Microsoft.Office.Interop.Excel.Worksheet workshhet)
        {
            int n,j;
            int i = 2;
            List<string> buff_authors = new List<string>();
            BookInLibrary b;
            while (workshhet.Cells[i,1].Value != null)
            {
                if (In_catalog(Convert.ToString(workshhet.Cells[i, 1].Value)))
                {
                    b = Search_book_by_name(workshhet.Cells[i, 1].Value);
                    b.BookL.Add(new Book());
                    j = b.BookL.Count - 1;
                   
                    if (workshhet.Cells[i, 7].Text != "Нет") { b.Number_of_available_copies++; b.BookL[j].tr = TakesorReturns.Returned; }
                    else
                    {
                        b.BookL[j].tr = TakesorReturns.Taken;
                    }
                    
                    b.Total_number_copies++;
                }
                else {

                    b = new BookInLibrary();j = 0;
                    b.BookL.Add(new Book());
                    if (workshhet.Cells[i, 7].Value != "Нет")
                    {
                        b.Number_of_available_copies = 1;
                        b.BookL[j].tr = TakesorReturns.Returned;
                    }
                    else
                    {
                        b.Number_of_available_copies = 0;
                        b.BookL[j].tr = TakesorReturns.Taken;
                    }
                    b.Total_number_copies=1;
                    catalog.Add(b);
                }
                
                b.BookL[j].Name_book = workshhet.Cells[i, 1].Value;
                buff_authors.AddRange(workshhet.Cells[i, 2].Value.Split(','));
                foreach (string s in buff_authors)
                {
                    if (s.Split(' ').Count() == 1) b.BookL[j].Authors_book.Add(new Person(s, "", "Surname"));
                    else b.BookL[j].Authors_book.Add(new Person(s.Split(' ')[0], "", s.Split(' ')[1]));
                }
                if (Int32.TryParse(Convert.ToString(workshhet.Cells[i, 3].Value), out n)) b.BookL[j].Date_publishing = n;
                else b.BookL[j].Date_publishing = 2014;
                b.BookL[j].Place_of_publishing = workshhet.Cells[i, 4].Value;
                b.BookL[j].Name_publisher= workshhet.Cells[i,5].Value;
                b.BookL[j].Libray_code = workshhet.Cells[i, 6].Value;
                codes.Add(b.BookL[j].Libray_code);
                i++;
                buff_authors.Clear();
            }

        }
        public void Save_readers_to_exel(Microsoft.Office.Interop.Excel.Worksheet workshhet)
        {
            workshhet.Cells[1, 1] = "Имя";
            workshhet.Cells[1, 2] = "Отчество";
            workshhet.Cells[1, 3] = "Фамилия";
            workshhet.Cells[1, 4] = "Номер читательского билета";
            workshhet.Cells[1, 5] = "Дата выдачи";
            int i = 2;
            foreach(Reader r in readers)
            {
                workshhet.Cells[i, 1] = r.Name_Person;
                workshhet.Cells[i, 2] = r.Patronymic_Name;
                workshhet.Cells[i,3] = r.Surname;
                workshhet.Cells[i, 4] = r.Number_readticket;
                workshhet.Cells[i, 5] = r.Date_get;
                i++;
            }
        }
        public void Save_books_to_exel(Microsoft.Office.Interop.Excel.Workbook worksbook)
        {
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)worksbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet2 = (Microsoft.Office.Interop.Excel.Worksheet)worksbook.Sheets[2];
            int i = 2;
            WorkSheet1.Cells[1, 1] = "Название книги";
            WorkSheet1.Cells[1, 2] = "Авторы";
            WorkSheet1.Cells[1, 3] = "Год издания";
            WorkSheet1.Cells[1, 4] = "Место издания";
            WorkSheet1.Cells[1, 5] = "Издательство";
            WorkSheet1.Cells[1, 6] = "Биб.шифр";
            WorkSheet1.Cells[1, 7] = "В наличии";
            int j = 2;
            WorkSheet2.Cells[1, 1] = "Библиотечный шифр";
            WorkSheet2.Cells[1, 2] = "Номер чит.билета";
            WorkSheet2.Cells[1, 3] = "В наличии у данного читателя";
            WorkSheet2.Cells[1, 4] = "Дата пользования";
            WorkSheet2.Cells[1, 5] = "Дата возврата";
            foreach (BookInLibrary bl in catalog)
            {
                foreach(Book b in bl.BookL)
                {
                    WorkSheet1.Cells[i, 1] = b.Name_book;
                    foreach(Person p in b.Authors_book)
                        WorkSheet1.Cells[i, 2] = p.Name_Person+" "+p.Surname+",";
                    WorkSheet1.Cells[i, 3] = b.Date_publishing;
                    WorkSheet1.Cells[i, 4] = b.Place_of_publishing;
                    WorkSheet1.Cells[i, 5] = b.Name_publisher;
                    WorkSheet1.Cells[i, 6] = b.Libray_code;
                    if (b.tr == TakesorReturns.Taken) WorkSheet1.Cells[i, 7] = "Нет";
                    else
                        WorkSheet1.Cells[i, 7] = "Да";
                   
                   foreach(AccountBook ac in b.Account)
                    {
                    WorkSheet2.Cells[j, 1] = b.Libray_code;
                        WorkSheet2.Cells[j, 2] = ac.Name_destination;
                        if (ac.TakesorReturns == TakesorReturns.Taken)
                            WorkSheet2.Cells[j, 3] = "Да";
                        else WorkSheet2.Cells[j, 3] = "Нет";
                        WorkSheet2.Cells[j, 4] = ac.Date_takes;
                        if (ac.Date_returns == new DateTime())
                            WorkSheet2.Cells[j, 5] = "-";
                        else
                            WorkSheet2.Cells[j, 5] = ac.Date_returns;
                        j++;
                    }

                    i++;
                }
            }
        }
        public List<BookInLibrary> Catalog
        {
            get
            {
                return catalog;
            }

            set
            {
                catalog = value;
            }
        }
        public List<string> Codes
        {
            get { return codes; }
            set { codes = value; }
        }
        public List<Reader> Readers
        {
            get
            {
                return readers;
            }

            set
            {
                readers = value;
            }
        }
     

        public void Add_reader(Reader reader)
        {
            readers.Add(reader);
        }


        public IEnumerable<Reader> Current_info_of_reader(string name,string surname)
        {
            var zapros = readers.Where(item => item.Name_Person==name&&item.Surname==surname).Select(i => i);
            return zapros;
          
        }///ready

        public bool Delete_reader(int numberticket)
        {
          foreach(Reader r in readers)
            {
                if(r.Number_readticket==numberticket)
                {
                    readers.Remove(r);
                    return true;
                }
            }
            return false;
        }//ready
      
        public Book Search_book_by_code(string code)//ready
        {
           
           foreach(BookInLibrary zapros in catalog)
           foreach(Book b in zapros.BookL)
                {
                    if (b.Libray_code == code) return b;
                }
            return new Book(); 
        }

        public BookInLibrary Search_book_by_name(string name)
        {
            var zapros = catalog.Where(item => item.BookL[0].Name_book == name).Select(i => i);
            foreach (var item in zapros)
            {
                return item;
            }
            return new BookInLibrary();
        }//ready

        public void Registration_taken_book(int number_ticket,string code,DateTime date)
        {
           
            Book buff = Search_book_by_code(code);
            buff.Account.Add(new AccountBook(date, number_ticket));
            buff.tr = TakesorReturns.Taken;
            Search_book_by_name(buff.Name_book).Number_of_available_copies--;
        }//ready

        public void Registration_returned_book(int number_ticket, string code, DateTime date)
        {
           
            Book buff = Search_book_by_code(code);
            buff.tr = TakesorReturns.Returned;
            buff.Account[buff.Account.Count - 1].TakesorReturns = TakesorReturns.Returned;
            buff.Account[buff.Account.Count - 1].Date_returns = date;
            Search_book_by_name(buff.Name_book).Number_of_available_copies++;
        }//ready

        public IEnumerable<Book> Books_of_current_reader(int number_ticket)
        {
            
            foreach (BookInLibrary b in catalog)
            {
                foreach(Book book in b.BookL)
                {
                    if (book.Account.Count != 0) 
                    if (book.tr==TakesorReturns.Taken&&book.Account[book.Account.Count - 1].Name_destination == number_ticket) yield return book;
                }
            }

            yield return new Book();
        }//ready
        public IEnumerable<Book> Search_taken_books_bydate(DateTime time)
        {
         
           foreach(var n in catalog)
            {
                foreach(var b in n.BookL)
                {
                    foreach (var ac in b.Account)
                        if (ac.Date_takes > time) yield return b;
                }
            }       
        }//ready

        public IEnumerable<Book> Search_returned_books_bydate(DateTime time)
        {
            // return account.Where(item => item.Date_returns > time&&item.TakesorReturns==TakesorReturns.Returned).Select(i => i.BookA);
            foreach (var n in catalog)
            {
                foreach (var b in n.BookL)
                {
                    foreach (var ac in b.Account)
                        if (ac.Date_returns > time) yield return b;
                }
            }
        }//ready

        public Reader Search_reader(int number_t)//ready
        {
            return readers.Find(item => item.Number_readticket == number_t);
        }
        public bool Contain_reader(int number)//ready
        {
            foreach(Reader r in readers)
            {
                if (r.Number_readticket == number) return true;
            }
            return false;
        }
        public bool In_stock(string name_book)
        {
            foreach(BookInLibrary b in catalog)
            {
                if (b.BookL[0].Name_book == name_book&&b.Number_of_available_copies!=0) return true;
            }
            return false;
        }   //ready
        
        public bool In_catalog(string name_book)
        {
            foreach (BookInLibrary b in catalog)
                if (b.BookL[0].Name_book == name_book) return true;
            return false;
        }//ready
        public void Change_reader_ticket(int ticket,int new_ticket)
        {
            foreach(BookInLibrary blib in catalog)
            {
                foreach (Book b in blib.BookL )
                {
                    foreach (AccountBook ac in b.Account)
                        if (ac.Name_destination == ticket) ac.Name_destination = new_ticket;
                }
            }
        }
    }
}