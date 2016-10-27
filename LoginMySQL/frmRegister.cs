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

namespace LoginApp.forms
{
    public partial class frmRegister : Form
    {

        #region "Properties"

        private bool _Registered = false;

        public bool Registered
        {
            get { return _Registered; }
            set { _Registered = value; }
        }
        private string _Username = "";

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        #endregion

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Registered = false; // tell calling form the user DID NOT register
            this.Close(); // close the form
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
            this.tbPassword.Clear();
            this.tbConfirmPassword.Clear();
        }

        private void RegisterUser()
        {
            if(tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password must be SAME!");
                return;
            }
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=localhost;port=3306;database=usersinformation;username=root;password=zteAvanQ136250";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into usersinformation.users(UserID,Username,Userpassword) values('" + this.tbUserid.Text + "','" + this.tbUserid.Text + "','" + this.tbPassword.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Register succeed!");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


/*
        // Register the User
        private void RegisterUser()
        {
            if (tbUsername.Text.Length > 0) // You may want longer than 1 char minimum for usernames
            {
                if (tbPassword.Text != tbConfirmPassword.Text) { MessageBox.Show("Passwords do not match"); RegisterUser(); } // passwords do not match retry
                // ok passwords do match are they empty?
                if (tbPassword.Text.Length == 0) { MessageBox.Show("Passwords can not be empty"); RegisterUser(); } // empty passwords try again!
                // Ok username and passwords are valid.
                // register the user !
                usersTableAdapter.Insert(tbUsername.Text, tbPassword.Text);
                Registered = true;
                this.Close();
            }
            else // Fixed: Forgot the else clause !
            {
                MessageBox.Show("Username can not be empty");
                RegisterUser();
            }
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersInformationDataSet);
        }
        */
        private void frmRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersinformationDataSet.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.usersinformationDataSet.users);

        }
 
    }
}
