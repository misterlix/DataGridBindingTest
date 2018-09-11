using DataGridBindingTest.DbManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridBindingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ctx = new Entities())
            {
                var list = ctx.Persons.ToList();
                bindingSource1.DataSource = list;
            }

        }
    }
}
