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
    public partial class Managestud : Form
    {
        public Managestud()
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
        private void Managestud_Load(object sender, EventArgs e)
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
                MessageBox.Show("Couldn't connect :" + ex.Message, "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnfind_Click(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //Check the StID Textbox
                if (txtstId.Text != "")
                {
                    //Set the Sql Statement
                    qry = "SELECT * FROM stud WHERE StID='" + txtstId.Text + "'";
                    //Open the connection
                    mysqlConn.Open();
                    //Set thwe statement in Command control
                    mysqlComm = new MySqlCommand(qry, mysqlConn);
                    //Read the command
                    mysqlRead = mysqlComm.ExecuteReader();
                    //Using Error Handler Tool
                    try
                    {
                        //Assigning the values in TextBoxes using while loop
                        while (mysqlRead.Read())
                        {
                            txtstname.Text = mysqlRead[1].ToString();
                            txtaddress.Text = mysqlRead[2].ToString();
                            dtm.Text = mysqlRead[4].ToString();
                            txttel.Text = mysqlRead[3].ToString();
                            txtmail.Text = mysqlRead[5].ToString();
                            String msg1 = "This is " + txtstname.Text + "'s details";
                            lblStatus.Text = msg1;
                        }
                    }
                    catch (Exception ex)
                    {
                        //Display Error Message
                        MessageBox.Show("Couldn't search :" + ex.Message, "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Set the Focus in stID Textbox
                    txtstId.Focus();
                    //Call Clear Procedure
                    clear();
                    String msg2 = "Please enter valid ID number";
                    lblStatus.Text = msg2;
                }
            }
            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't Search : " + ex.Message, "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlConn.Close();
            }
        }

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

                    String msg2 = "Insert " + txtstname.Text + "'s details successfully ";
                    lblStatus.Text = msg2;
                    clear();
                }
                else
                {
                    //Display Message
                    MessageBox.Show("Please Inset the student ID", "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Set the Focus in stID Textbox
                    txtstId.Focus();
                    //Call Clear Procedure
                    clear();
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't insert : " + ex.Message, "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlConn.Close();

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //Using error handler tool
            try
            {
                //set the sql command
                qry = "UPDATE stud SET STName='" + txtstname.Text + "',Address='" + txtaddress.Text + "',TElNO='" + txttel.Text + "',REGDATE='" + dtm.Text + "',Email='" + txtmail.Text + "'WHERE STID='" + txtstId.Text + "'";
                //open the connection
                mysqlConn.Open();
                //Set the statement in command control
                mysqlComm = new MySqlCommand(qry, mysqlConn);
                //Execute the statement
                mysqlComm.ExecuteNonQuery();
                String msg3 = "Update " + txtstname.Text + "'s details successfully ";
                lblStatus.Text = msg3;


            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show("Couldn't Connect : " + ex.Message, "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                //close the connection
                mysqlConn.Close();


                clear();

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //using error handler tool
            try
            {
                //Create the Response Variable
                DialogResult res;
                //Assigning the response Message
                res = MessageBox.Show("Do you  Want to delete this record ?", "Manage studentss", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Check the Response
                if (res == DialogResult.Yes)
                {
                    //set the sql command
                    qry = "DELETE FROM stud Where STID='" + txtstId.Text + "'";
                    //Open the connection
                    mysqlConn.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlConn);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();
                    String msg3 = "Delete details successfully ";
                    lblStatus.Text = msg3;

                }
                else
                {
                    String msge = "Action Terminated";
                    lblStatus.Text = msge;
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Check the student ID : " + ex.Message, "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlConn.Close();

                //call the clear method
                clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHome fa = new frmHome();
            fa.Show();
            this.Dispose();
        }
    }
}
