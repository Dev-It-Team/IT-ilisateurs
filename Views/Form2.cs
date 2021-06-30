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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        public void OpenDeleteForm(object sender, EventArgs e)
        {
            Form DeleteForm = new FormDelete();
            DeleteForm.ShowDialog();
        }
        public void OpenCreateForm(object sender, EventArgs e)
        {
            Form CreateForm = new FormCreate();
            CreateForm.ShowDialog();
        }
    }
}