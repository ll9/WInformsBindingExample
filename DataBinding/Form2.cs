using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form2 : Form
    {
        public event EventHandler<People> UpdateRecord;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRecord.Invoke(this, new People(firstNameTextBox.Text, lastNameTextBox.Text));
        }
    }
}
