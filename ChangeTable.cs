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
    public partial class ChangeTable : Form
    {
        public ChangeTable()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
           
        }

        private void ChangeTable_Load(object sender, EventArgs e)
        {
            Change main =this.Owner as Change;
            if(main.flag==Change_or_delete.change_book)
            Save_button.Click += main.SaveBook;
            if (main.flag == Change_or_delete.change_reader)
                Save_button.Click += main.SaveReader;
            if (main.flag == Change_or_delete.remove_reader)
            {
                Save_button.Text = "Удалить";
                Save_button.Click += main.RemoveReader;
            }
            if (main.flag == Change_or_delete.remove_book)
            {
                Save_button.Text = "Удалить";
                Save_button.Click += main.RemoveBook;
            }
        }
    }
}
