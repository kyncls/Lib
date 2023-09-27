using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibSys_IMDB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\Dumagpi - IMDBYSYS\\LibSys-IMDB\\thePassword.mdb");
            connect.Open();

            string query = "SELECT * FROM [username]";
            OleDbCommand access = new OleDbCommand(query, connect);

            OleDbDataReader reader = access.ExecuteReader();

            bool isAuthenticated = false;
            while (reader.Read())
            {
                string Username = reader.GetString(0);
                string Password = reader.GetString(1);
                if (Username == txtUser.Text && Password == txtPass.Text)
                {
                    isAuthenticated = true;
                    break;
                }
            }
            connect.Close();
            if (isAuthenticated)
            {
                frmMain frmM = new frmMain();
                frmM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }
    


