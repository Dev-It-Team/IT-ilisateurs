using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_ilisateurs
{
    public partial class FormDelete : Form
    {
        
        public FormDelete()
        {
            InitializeComponent();
        }

        public void DeleteUser(string Email)
        {
            Model.DeleteUser(Email);
        }
    }
}