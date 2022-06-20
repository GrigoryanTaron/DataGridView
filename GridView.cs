using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class GridView : Form
    {

        private string _FirstName;
        private string _LastName;
        private string _Age;
        private string _Id;


        public GridView()
        {
            InitializeComponent();
            PersonManager manager = new PersonManager();
            IEnumerable<Person> person = manager.Create(15, 16);
           Handler(person);

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void GridView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        public void Handler(IEnumerable<Person> person)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) {
                dataGridView2.Rows.Clear();
                var res = person.Where(x => x.FirstName.Contains(textBox1.Text) && checkBox1.Checked ||
                x.LastName.Contains(textBox2.Text) && checkBox2.Checked ||
               x.Age.ToString().Contains(textBox3.Text) && checkBox3.Checked);
                foreach (var _person in res)
                {
                    dataGridView2.Rows.Clear();
                    dataGridView2.Rows.Add(_person.Id.ToString(), _person.FirstName, _person.LastName, _person.Age.ToString());
                }
            }
            else
            {
                foreach (var item in person)
                {
                    dataGridView2.Rows.Add(
                        item.Id.ToString(),
                        item.FirstName,
                        item.LastName,
                        item.Age.ToString());
                }
            }
            

        }
    }
}
