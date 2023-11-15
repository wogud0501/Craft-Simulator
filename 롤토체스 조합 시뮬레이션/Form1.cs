// All Requirement Module
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Linq.Expressions;
using static System.Net.WebClient;
using static System.Net.WebRequest;
using static System.Net.WebException;
using static System.Net.WebRequestMethods.Http;
using static System.Net.Http.HttpClient;
using System.Net;
using System.Net.Http;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace 롤토체스_조합_시뮬레이션
{
    public partial class MF : Form
    {
        private string _server = "";
        private int _port = 3306;
        private string _database = "mysql";
        private string _id = "";
        private string _pw = "";
        private string _connectionAddress = "";

        public MF()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = _server,
                Database = _database,
                UserID = _id,
                Password = _pw,
                Port = (uint)_port 
            };

            _connectionAddress = builder.ConnectionString;
        }


        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string enteredID = id.Text;
            string enteredPassword = pwd.Text;

            using (MySqlConnection connection = new MySqlConnection(_connectionAddress))
            {
                connection.Open();

                string query = "SELECT *  FROM users WHERE ID = ID AND Password = Password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", enteredID);
                    command.Parameters.AddWithValue("@Password", enteredPassword);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("로그인이 성공하였습니다.");
                        }
                        else
                        {
                            MessageBox.Show("등록되지 않은 사용자 입니다. 관리자에게 등록을 요청하세요.");
                            Application.Exit();
                        }
                    }
                }
            }
       
        }
        private void MF_Load(object sender, EventArgs e)
        {

        }

    }
}
