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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }
        //Create the instant variable
        MySqlConnection mysqlCon;
        MySqlDataAdapter mysqlAdapt;
        MySqlDataReader mysqlRead;
        MySqlCommand mysqlComm;
        DataSet dsStud;

        //Create the Memory Variable
        String qry;
        private void Issue_Books_Load(object sender, EventArgs e)
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
                mysqlCon = new MySqlConnection(qry);

            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show("Couldn't connect :" + ex.Message, "Issue Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //Check the StID Textbox
                if (txtbkid1.Text != "")
                {
                    //Set the Sql Statement
                    qry = "SELECT * FROM book WHERE BKID='" + txtbkid1.Text + "'";
                    //Open the connection
                    mysqlCon.Open();
                    //Set thwe statement in Command control
                    mysqlComm = new MySqlCommand(qry, mysqlCon);
                    //Read the command
                    mysqlRead = mysqlComm.ExecuteReader();
                   
                        //Assigning the values in TextBoxes using while loop
                        while (mysqlRead.Read())
                        {
                            txtbkname1.Text = mysqlRead[1].ToString();
                            txtbkauthor1.Text = mysqlRead[2].ToString();
                            txtbkedi1.Text = mysqlRead[3].ToString();
                            txtbkprice1.Text = mysqlRead[4].ToString();
                            txtbkquanti1.Text = mysqlRead[5].ToString();
                        }
                 
                }
                else
                {
                    //Set the Focus in stID Textbox
                    txtbkid1.Focus();
                    //Call Clear Procedure
                    clear();
                }
            }
            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't Search : " + ex.Message, "Store Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlCon.Close();
            }
        }
        private void clear()
        {
            //Reset the all controls
            txtbkauthor1.ResetText();
            txtbkedi1.ResetText();
            txtbkid1.ResetText();
            txtbkname1.ResetText();
            txtbkprice1.ResetText();
            txtbkquanti1.ResetText();
            txtstId.ResetText();
            txtstname.ResetText();
            txttel.ResetText();
            txtmail.ResetText();
            dtm2.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //Check the StID Textbox
                if (txtstId.Text != "")
                {
                    //Set the Sql Statement
                    qry = "SELECT * FROM stud WHERE STID='" + txtstId.Text + "'";
                    //Open the connection
                    mysqlCon.Open();
                    //Set thwe statement in Command control
                    mysqlComm = new MySqlCommand(qry, mysqlCon);
                    //Read the command
                    mysqlRead = mysqlComm.ExecuteReader();
                    //Using Error Handler Tool
                    
                        //Assigning the values in TextBoxes using while loop
                        while (mysqlRead.Read())
                        {
                            txtstname.Text = mysqlRead[1].ToString();
                            txttel.Text = mysqlRead[3].ToString();
                            txtmail.Text = mysqlRead[5].ToString();
                        }
                    

                }
                else
                {

                    //Set the Focus in stID Textbox
                    txtstId.Focus();
                    //Call Clear Procedure
                    clear();
                }
            }
            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't Search : " + ex.Message, "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlCon.Close();
            }
        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            //using the error handler tool
            try
            {
                //checking the stid field
                if (txtstId.Text != "" && txtbkid1.Text != "")
                {
                    //Set the sql statement
                    qry = "INSERT INTO issue(STID,STName,TElNO,EMAIL,BKID,BKNAME,ISSUEDATE,Quantity)VALUES('" + txtstId.Text + "','" + txtstname.Text + "','" + txttel.Text + "','" + txtmail.Text + "','" + txtbkid1.Text + "','" + txtbkname1.Text + "','" + dtm2.Text + "','" + txtbkquanti1.Text + "')";
                    //Open the connection
                    mysqlCon.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlCon);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();
                    String msg = "Issued Book Succefully";
                    lblStatus.Text = msg;
                    clear();
                }
                else
                {
                    //Display Message
                    MessageBox.Show("Please Inset the student ID OR Book ID Correctly", "Issue Books", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Set the Focus in stID Textbox
                    txtstId.Focus();
                    //Call Clear Procedure
                    clear();
                    String msg1 = "Please insert the student ID or Book ID Correctly";
                    lblStatus.Text = msg1;
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't insert : " + ex.Message, "Issue Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlCon.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            String msg5 = "Cleared details Successfully";
            lblStatus.Text = msg5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHome fa = new frmHome();
            fa.Show();
            this.Dispose(false);
        }

        private void txtbkid1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
