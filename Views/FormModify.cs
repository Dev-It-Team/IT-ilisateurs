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
    public partial class FormModify: Form
    {
        
        public FormModify()
        {
            InitializeComponent();
        }
        public void ModifyUser(string Name,string FirstName,string Email,string Password,string Birthdate,string Address,string UserFlag)
        {
            Model.UpdateUser(Name, FirstName, Email, Password, Birthdate, Address, UserFlag);
        }
        
    }
}