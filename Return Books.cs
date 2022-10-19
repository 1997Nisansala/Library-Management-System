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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
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
        private void Return_Books_Load(object sender, EventArgs e)
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
                MessageBox.Show("Couldn't connect :" + ex.Message, "Return Books", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    qry = "SELECT * FROM issue WHERE BKID='" + txtbkid1.Text + "'";
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
                            txtbkquanti1.Text = mysqlRead[2].ToString();
                            txtstId.Text = mysqlRead[3].ToString();
                            txtstname.Text = mysqlRead[4].ToString();
                            txttel.Text = mysqlRead[5].ToString();
                            txtmail.Text = mysqlRead[6].ToString();
                            dtm2.Text = mysqlRead[7].ToString();
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
            txtbkid1.ResetText();
            txtbkname1.ResetText();
            dateTimePicker1.ResetText();
            txtbkquanti1.ResetText();
            txtstId.ResetText();
            txtstname.ResetText();
            txttel.ResetText();
            txtmail.ResetText();
            dtm2.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using the error handler tool
            try
            {
                //checking the stid field
                if (txtstId.Text != "" && txtbkid1.Text != "")
                {
                    //Set the sql statement
                    qry = "INSERT INTO return2(STID,STNAME,TElNO,EMAIL,BKID,BKNAME,ISSUEDATE,RETURNDATE,Quantity)VALUES('" + txtstId.Text + "','" + txtstname.Text + "','" + txttel.Text + "','" + txtmail.Text + "','" + txtbkid1.Text + "','" + txtbkname1.Text + "','" + dtm2.Text + "','" + dateTimePicker1.Text + "','" + txtbkquanti1.Text + "')";
                    //Open the connection
                    mysqlCon.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlCon);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();
                }
                else
                {
                    //Display Message
                    MessageBox.Show("Please Inset the student ID OR Book ID Correctly", "Return book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Set the Focus in stID Textbox
                    txtstId.Focus();
                    //Call Clear Procedure
                }
            }
            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't insert : " + ex.Message, "Return book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //close the connection
                mysqlCon.Close();
            }
            //using error handler tool
            try
            {
                //Create the Response Variable
                DialogResult res;
                //Assigning the response Message
                res = MessageBox.Show("Is the book returned ?", "Return Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Check the Response
                if (res == DialogResult.Yes)
                {
                    //set the sql command
                    qry = "DELETE FROM issue Where BKID='" + txtbkid1.Text + "'";
                    //Open the connection
                    mysqlCon.Open();
                    //Set the statement in command control
                    mysqlComm = new MySqlCommand(qry, mysqlCon);
                    //Execute the statement
                    mysqlComm.ExecuteNonQuery();
                    String msg = "Restored book Successfully";
                    lblStatus.Text = msg;
                }
            }

            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Check the Book ID : " + ex.Message, "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                String msg2 = "Please check the Book ID";
                lblStatus.Text = msg2;
            }
            finally
            {
                //close the connection
                mysqlCon.Close();
                //call the clear method
                clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmHome far = new frmHome();
            far.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear2()
        {
            txtday.ResetText();
            txtfday.ResetText();
            txttotal.ResetText();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try {
                int m, n, y;
                String x;
                m = Convert.ToInt32(txtday.Text);
                n = Convert.ToInt32(txtfday.Text);
                y = m * n;
                x = Convert.ToString(y);
                txttotal.Text = x;
            }
            catch (Exception ex)
            {
                //Display error Message
                MessageBox.Show("Couldn't calculate : " + ex.Message, "Return book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear2();
        }
    }
 }

