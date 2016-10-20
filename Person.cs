using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    [Serializable]
    public class Person
    {
        private string name_person;
        private string patronymic_name;
        private string surname;

        /// <summary>
        /// string name_p
        /// </summary>
        /// 
        public Person() { }
        public Person(string namep, string pname, string surnam)
        {
            name_person = namep;
            patronymic_name = pname;
            surname = surnam;
        }

        public string Name_Person
        {
            get
            {
                return name_person;
            }

            set
            {
                name_person = value;
            }
        }

        public string Patronymic_Name
        {
            get
            {
                return patronymic_name;
            }

            set
            {
                patronymic_name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
    }
}