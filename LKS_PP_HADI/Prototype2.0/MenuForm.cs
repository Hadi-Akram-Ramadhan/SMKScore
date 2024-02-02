using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototype2._0
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Srch_Btn_Click(object sender, EventArgs e)
        {
            

        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterTeach masterTeach = new MasterTeach();    
            masterTeach.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MStudent student = new MStudent();  
            student.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MSubject subject = new MSubject();  
            subject.Show(); 

            this.Hide();
        }
    }
}
