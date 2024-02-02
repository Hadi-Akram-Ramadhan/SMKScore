using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype2._0
{
    public partial class MSubject : Form
    {
        public MSubject()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();

            this.Close();
        }
    }
}
