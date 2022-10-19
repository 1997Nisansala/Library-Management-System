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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        //Create the instant variable
        MySqlConnection mysqlConn;
        MySqlDataAdapter mysqlAdapt;
        MySqlDataReader mysqlRead;
        MySqlCommand mysqlComm;
        DataSet dsStud;

        //Create the Memory Variable
        String qry;

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            //using the error handler tool
            try
            {
                //checking the stid field
                if (txtstId.Text != "")
                {
                    //Set the sql statement
                    qry = "INSERT INTO stud(STID,STName,Address,TElNO,REGDATE,Email)VALUES('" + txtstId.Text + "','" + txtstname.Text + "','" + txtaddress.Text + "','" + txttel.Text + "','" + dtm.Text + "','" + txtmail.Text + "')";
                    //Open the connection
                    mysqlConn.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlConn);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();
                    String msg = "Registered Successfully";
                    lblStatus.Text = msg;
                    clear();
                }
                else
                {
                    //Display Message
                    MessageBox.Show("Please Inset the student ID", "Add Students Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Set the Focus in stID Textbox
                    txtstId.Focus();
                    //Call Clear Procedure
                    clear();
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't insert : " + ex.Message, "Add Students Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlConn.Close();

            }
        }

        private void clear()
        {
            //Reset the all controls
            txtstId.ResetText();
            txtstname.ResetText();
            txtaddress.ResetText();
            dtm.ResetText();
            txttel.ResetText();
            txtmail.ResetText();

        }
        private void Signup_Load(object sender, EventArgs e)
        {
            //Using Error handler tool
            try
            {
                //Create the Memory Variable
                string srv, db, user, pass;
                //Assigning the values
                srv = "localhost"; db = "lms"; user = "root"; pass = "";
                //assigning the command
                qry = "SERVER=" + srv + ";" + "DATABASE=" + db + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
                mysqlConn = new MySqlConnection(qry);

            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show("Couldn't connect :" + ex.Message, "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Login fl = new Login();
            fl.Show();
            this.Dispose();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtstId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
