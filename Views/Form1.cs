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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

            public void InitiateConnexion(string login, string password)
        {
            if(Model.Authenticate(login, password))
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            };
        }
    }
}
