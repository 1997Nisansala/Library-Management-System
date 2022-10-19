using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System_New
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Create the instant variable
        MySqlConnection mysqlConn;
        MySqlDataAdapter mysqlAdapt;
        MySqlDataReader mysqlRead;
        MySqlCommand mysqlComm;

        //Create the Memory Variable
        String qry;

        private void btnlogin_Click(object sender, EventArgs e)
        {
            mysqlConn.Open();
            string qry = "SELECT * FROM `login` WHERE `Name` = '" + txtname.Text + "' and `Password` = '" + txtpassword.Text + "'";
            mysqlComm = new MySqlCommand(qry, mysqlConn);
            mysqlAdapt = new MySqlDataAdapter(mysqlComm);

            DataTable dt = new DataTable();

            mysqlAdapt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                frmHome ob = new frmHome();
                ob.Show();
                this.Dispose(false);
            }
            else
            {
                String msg = "Invalid Username or Password";
                lblsta.Text = msg;
                MessageBox.Show("Sorry,Please Enter Valid Username Or Password!");
                mysqlConn.Close();
                clear();
                txtname.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Using Error handler tool
            try
            {
                //Create the Memory Variable
                string srv, db, user, pass, msg1;
                //Assigning the values
                srv = "localhost"; db = "lms"; user = "root"; pass = "";
                //Assigning the command
                qry = "SERVER=" + srv + ";" + "DATABASE=" + db + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
                mysqlConn = new MySqlConnection(qry);
                msg1 = "Welcome to the Library Management System";
                lblsta.Text = msg1;
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show("Couldn't connect :" + ex.Message, "Login form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlConn.Close();
            }
        }
        private void clear()
        {
            txtpassword.ResetText();
            txtname.ResetText();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup fr = new Signup();
            fr.Show();
            this.Dispose(false);
        }
    }
}
