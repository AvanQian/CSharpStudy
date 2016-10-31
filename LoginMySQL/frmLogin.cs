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
using System.Data.Odbc;


namespace LoginApp.forms
{
    public partial class frmLogin : Form
    {

        #region "Properties"

        private bool _Authenticated = false;

        public bool Authenticated
        {
            get { return _Authenticated; }
            set { _Authenticated = value; }
        }
        private string _Username = "";

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private MySqlConnection _mySqlConn;

        #endregion

        public frmLogin()
        {            
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ConnectionState.Open == _mySqlConn.State)
                _mySqlConn.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.ShowDialog();
            /*if (reg.Registered)
            {
                Authenticated = true;
                this.Close();
            }
            else
            {
                Authenticated = true;
                this.Close();
            }*/
        }


        private void Login()
        {
            _mySqlConn = this.Connect2MySql(0);
            List<List<string>> results = this.GetResults("select * from usersinformation.users where UserID like '" + this.tbUserid.Text + "';");
            bool bPass = false;
            for (int i = 0; i < results.Count; i++)//if results.Count==0, indicates that last query found nothing matched items 
            {
                //string userId = results[i][0];
                string password = results[i][2];
                if (password == this.tbPassword.Text)
                {
                    bPass = true;
                    break;
                }                    
            }
            if (bPass)
                _Authenticated = true;
                //MessageBox.Show("Login succeed!");
            else
            {
                if(results.Count == 0)
                    MessageBox.Show("Login failed! Userid is not existed in database, please register first!");
                else
                    MessageBox.Show("Login failed! Password is not matched with Userid in database!");
            }
            if (ConnectionState.Open == _mySqlConn.State)
                _mySqlConn.Close();

            //exit after login successed
            if (bPass)
                Application.Exit();

            /*
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=127.0.0.1;port=3306;database=usersinformation;username=MYSQL_Avan;password=zteAvanQ136250";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "select * from usersinformation.users where UserID like '" + this.tbUserid.Text + "';";//"' and Userpassword like '" + this.tbPassword.Text + "';" ;
                //string Query = "use usersinformation;";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //Throw exception if failed to opne DB with MyConnection2 string
                MyConn2.Open();
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;                
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                //MessageBox.Show("Login succeed!");
                while (MyReader2.Read())
                {
                    string userId = (string)MyReader2.GetValue(0);
                    string password = (string)MyReader2.GetValue(2);
                    if (userId == this.tbUserid.Text && password == this.tbPassword.Text)
                        MessageBox.Show("Login succeed!");
                    else
                        MessageBox.Show("Login failed!");
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            */
        }

        private MySqlConnection Connect2MySql(int connType)
        {
            string server = "server=127.0.0.1";
            string port = "port=3306";
            string database = "database=usersinformation";
            string username = "username=MYSQL_Avan";
            string password = "password=zteAvanQ136250";
            //This is my connection string i have assigned the database file address path
            //string MyConnection2 = "server=127.0.0.1;port=3306;database=usersinformation;username=MYSQL_Avan;password=zteAvanQ136250";
            string MyConnection2 = server + ";" + port + ";" + database + ";" + username + ";" + password;
            //Create an instance of MySqlConnection with default settings.
            MySqlConnection MyConn2 = new MySqlConnection();
            
            switch (connType)
            {
                case 0:
                    try
                    {
                        //Set ConnectionString and instance settings will be updated before open action
                        MyConn2.ConnectionString = MyConnection2;
                        //Throw exception when open database failed with MyConnection2 string
                        MyConn2.Open();                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 1:
                    try
                    {
                        OdbcConnection MyConn2Odbc = new OdbcConnection();
                        MyConnection2 += "DRIVER={MySQL ODBC 5.3 Driver};" + "OPTION=3";    
                        //Set ConnectionString and instance settings will be updated before open action
                        MyConn2Odbc.ConnectionString = MyConnection2;
                        //Throw exception when open database failed with MyConnection2 string
                        MyConn2Odbc.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                default:
                    break;
            }
            

            return MyConn2;
        }

        private List<List<string>> GetResults(string cmd)
        {
            MySqlCommand MyCommand2 = new MySqlCommand();
            MyCommand2.Connection = _mySqlConn;
            MyCommand2.CommandText = cmd;
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            List<List<string>> results = new List<List<string>>();
            while (MyReader2.Read())
            {
                List<string> lineString = new List<string>();
                for (int i = 0; i < MyReader2.FieldCount; i++)
                    lineString.Add((string)MyReader2.GetValue(i));
                results.Add(lineString);
            }
            return results;
        }
        
    }
}
