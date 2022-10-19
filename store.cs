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
    public partial class store : Form
    {
        public store()
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
        private void store_Load(object sender, EventArgs e)
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
                MessageBox.Show("Couldn't connect :" + ex.Message, "Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Call the Dataload Procedure
                dataLoad();
                dataLoad2();
                dataLoad3();
            }
        }
        private void dataLoad()
        {
            //Open the conection
            mysqlConn.Open();
            //Fill the records in adapter control
            mysqlAdapt = new MySqlDataAdapter("Select * From book", mysqlConn);
            //Fill the record in dataset control
            mysqlAdapt.Fill(dsStud = new DataSet(), "book");
            //Assigning the DAtaGrid control
            dataGridView2.DataSource = dsStud;
            dataGridView2.DataMember = "book";
            //close the connection
            mysqlConn.Close();

        }
        private void dataLoad2()
        {
            //Open the conection
            mysqlConn.Open();
            //Fill the records in adapter control
            mysqlAdapt = new MySqlDataAdapter("Select * From stud", mysqlConn);
            //Fill the record in dataset control
            mysqlAdapt.Fill(dsStud = new DataSet(), "stud");
            //Assigning the DAtaGrid control
            dataGridView1.DataSource = dsStud;
            dataGridView1.DataMember = "stud";
            //close the connection
            mysqlConn.Close();

        }
        private void dataLoad3()
        {
            //Open the conection
            mysqlConn.Open();
            //Fill the records in adapter control
            mysqlAdapt = new MySqlDataAdapter("Select * From issue", mysqlConn);
            //Fill the record in dataset control
            mysqlAdapt.Fill(dsStud = new DataSet(), "issue");
            //Assigning the DAtaGrid control
            dtm3.DataSource = dsStud;
            dtm3.DataMember = "issue";
            //close the connection
            mysqlConn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome ah = new frmHome();
            ah.Show();
            this.Dispose(false);
        }
    }
}
