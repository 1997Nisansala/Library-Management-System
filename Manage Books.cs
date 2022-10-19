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
    public partial class Managebooks : Form
    {
        public Managebooks()
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
        private void Managebooks_Load(object sender, EventArgs e)
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
                MessageBox.Show("Couldn't connect :" + ex.Message, "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            //Reset the all controls
            txtbkauthor.ResetText();
            txtbkedi.ResetText();
            txtbkid.ResetText();
            txtbkname.ResetText();
            txtbkprice.ResetText();
            txtbkquanti.ResetText();
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            //Using Error Handler tool
            try
            {
                //Check the StID Textbox
                if (txtbkid.Text != "")
                {
                    //Set the Sql Statement
                    qry = "SELECT * FROM book WHERE BKID='" + txtbkid.Text + "'";
                    //Open the connection
                    mysqlConn.Open();
                    //Set thwe statement in Command control
                    mysqlComm = new MySqlCommand(qry, mysqlConn);
                    //Read the command
                    mysqlRead = mysqlComm.ExecuteReader();
                    //Using Error Handler Tool

                    //Assigning the values in TextBoxes using while loop
                    while (mysqlRead.Read())
                    {
                        txtbkname.Text = mysqlRead[1].ToString();
                        txtbkauthor.Text = mysqlRead[2].ToString();
                        txtbkedi.Text = mysqlRead[3].ToString();
                        txtbkprice.Text = mysqlRead[4].ToString();
                        txtbkquanti.Text = mysqlRead[5].ToString();

                        String msg2 = "This is the book details";
                        lblStatus.Text = msg2;
                    }

                }

                else
                {

                    //Set the Focus in stID Textbox
                    txtbkid.Focus();
                    //Call Clear Procedure
                    clear();
                }
            }
            catch (Exception ex)
            {
                String msg1 = "Couldn't find book";
                lblStatus.Text = msg1;
                MessageBox.Show("Couldn't Search : " + ex.Message, "Store Books", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                if (txtbkid.Text != "")
                {
                    //Set the sql statement
                    qry = "INSERT INTO book(BKID,BKName,Author,Edition,Price,Quantity)VALUES('" + txtbkid.Text + "','" + txtbkname.Text + "','" + txtbkauthor.Text + "','" + txtbkedi.Text + "','" + txtbkprice.Text + "','" + txtbkquanti.Text + "')";
                    //Open the connection
                    mysqlConn.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlConn);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();

                    String msg3 = "Add new book Successfully";
                    lblStatus.Text = msg3;

                    clear();
                }
                else
                {
                    //Display Message
                    MessageBox.Show("Please Inset the Book ID", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Set the Focus in stID Textbox
                    txtbkid.Focus();
                    //Call Clear Procedure
                    clear();
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't insert : " + ex.Message, "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                String msg4 = "Couldn't insert book!!";
                lblStatus.Text = msg4;
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
                qry = "UPDATE book SET BKName='" + txtbkname.Text + "',Author='" + txtbkauthor.Text + "',Edition='" + txtbkedi.Text + "',Price='" + txtbkprice.Text + "',Quantity='" + txtbkquanti.Text + "'WHERE BKID='" + txtbkid.Text + "'";
                //open the connection
                mysqlConn.Open();
                //Set the statement in command control
                mysqlComm = new MySqlCommand(qry, mysqlConn);
                //Execute the statement
                mysqlComm.ExecuteNonQuery();
                String msg5 = "Update the book details Successfully";
                lblStatus.Text = msg5;
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show("Couldn't Connect : " + ex.Message, "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                String msg6 = "Couldn't update book details!!";
                lblStatus.Text = msg6;
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
                res = MessageBox.Show("Do you  Want to delete this record ?", "Manage Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Check the Response
                if (res == DialogResult.Yes)
                {
                    //set the sql command
                    qry = "DELETE FROM book Where BKID='" + txtbkid.Text + "'";
                    //Open the connection
                    mysqlConn.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlConn);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();
                    String msg7 = "Delete records Successfully";
                    lblStatus.Text = msg7;
                }
                else
                {
                    MessageBox.Show("Action Terminated", "Manage Books",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Check the book ID : " + ex.Message, "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
                String msg8 = "Couldn't delete Records!!";
                lblStatus.Text = msg8;
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
            String msg9 = "Clear book details Successfully";
            lblStatus.Text = msg9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome far = new frmHome();
            far.Show();
            this.Dispose();
        }
    }
}
    