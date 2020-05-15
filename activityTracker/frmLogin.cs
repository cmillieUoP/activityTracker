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

namespace activityTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // FIRST WAY OF LOGGING IN
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TNSKO0U\SQLEXPRESS01;Initial Catalog=activityTracker;Integrated Security=True");
            string query = "Select * from tblUser Where username = '" + textBoxUserName.Text.Trim() + "' and password = '" + textBoxPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frmMain objFrmMain = new frmMain();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
            /*ALTERNATE WAY OF LOGGING IN, COULD NOT GET TO FUNCTION
             try
            {
                string myConnection = "Data Source=DESKTOP-TNSKO0U\\SQLEXPRESS01;Initial Catalog=activityTracker;Integrated Security=True";
                SqlConnection myCon = new SqlConnection(myConnection);
                CODE TO SHOW CONNECTION OF DATABASE
                SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = new SqlCommand("select * from database.activityTracker", myCon);
                SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
                myCon.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected");
                myCon.Close();
                
                SqlCommand SelectCommand = new SqlCommand("select * from activityTracker.tblUser where username='" + this.textBoxUserName.Text + "' and password='" + this.textBoxPassword.Text + "' ;", myCon);

                SqlDataReader myReader;
                myCon.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and password is correct");
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password...Access Denied");
                }
                else MessageBox.Show("Check username and password");
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
            */



        }
    }
}


