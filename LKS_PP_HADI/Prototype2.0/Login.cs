using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prototype2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update the connection string to connect to SMKScore database
            string connectionString = "Data Source=HADI-PC;Initial Catalog=SMKScore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Update the select query to use TeacherName instead of Password
                    string selectQuery = "SELECT COUNT(*) FROM Teacher WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("Email", Id_TxtB.Text);
                        selectCmd.Parameters.AddWithValue("@Password", Name_TxtB.Text);

                        int count = (int)selectCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MenuForm form2 = new MenuForm();
                            form2.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ID atau Nama Guru salah. Silakan coba lagi.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan");
            }
        }

        private void Id_TxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
