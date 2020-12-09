using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace Dadam_Damda
{
    public partial class UserControl_DadamLookup : UserControl
    {
        public UserControl_DadamLookup()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Button_Request_Lookup_Click(object sender, EventArgs e)
        {
            //SQL DB와 연결
            MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306;" + "Database=dadam_request;" + "Uid=root;" + "Pwd=0000;");   // 서버, DB이름, 유저이름, 비밀번호

            // SQL 명령어
            // 외부 데이터베이스의 정보를 받아오기 위한 쿼리.
            string selectQuery = "SELECT * FROM request_all"; //쿼리문
            MySqlCommand command = new MySqlCommand(selectQuery, connection);  // DB 연결

            // Ddata Adapter와 DataSet으로 DB table 불러오기
            MySqlDataAdapter da = new MySqlDataAdapter(command);    // selcet 쿼리 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, "request_all");

            //dataGridView에 DB에서 가져온 데이터 입력
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "reqeust_all";
        }
    }
}
