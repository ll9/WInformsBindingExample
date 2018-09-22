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
    public partial class Form1 : Form
    {
        public BindingList<People> PeopleList { get; set; } = new BindingList<People>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = PeopleList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.UpdateRecord += Form2_UpdateRecord;
            form2.ShowDialog();
        }

        private void Form2_UpdateRecord(object sender, People e)
        {
            PeopleList.Add(e);
        }
    }
}
