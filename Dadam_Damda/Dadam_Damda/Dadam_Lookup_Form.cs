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

namespace Dadam_Damda
{
    public partial class Dadam_Lookup_Form : Form{
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        public Dadam_Lookup_Form()
        {
            InitializeComponent();
            //SQL DB와 연결
            connection = new MySqlConnection();   
            command = new MySqlCommand();

            connection.ConnectionString = "Server = localhost; Port = 3306;Database = dadam_request; Uid = root; Pwd = 0000; ";// 서버, DB이름, 유저이름, 비밀번호
            connection.Open();
            command.Connection = connection;
          //  connection.Open();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 행 전제 선택

            this.Load += Dadam_Lookup_Form_Load; // 폼 로드 시 실행할 메소드
        }

        private void Dadam_Lookup_Form_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dadam_requestDataSet.request_all' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            Button_Request_SearchAll_Click(null, null); // 전체 조회 이벤트

        }

        private void Button_Request_Lookup_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Button_Request_SearchAll_Click(object sender, EventArgs e)
        {
           // this.dataGridView2.DataSource = null;
            // validation check : 잘못 입력한 경우

            
            // SQL 명령어
            // 외부 데이터베이스의 정보를 받아오기 위한 쿼리.
            string selectQuery = "SELECT * FROM request_all"; //쿼리문
            command = new MySqlCommand(selectQuery, connection);  // DB 연결
            

            // Ddata Adapter와 DataSet으로 DB table 불러오기
            MySqlDataAdapter da = new MySqlDataAdapter(selectQuery,connection);    // selcet 쿼리 구문이 들어감
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            dt = new DataTable();
//            DataSet ds = new DataSet();
            da.Fill(dt);

            //dataGridView에 DB에서 가져온 데이터 입력, 그리드 데이터 소스에 부음
            dataGridView2.DataSource = dt;
       //     dataGridView2.DataMember = "reqeust_all";

            DataGridViewColumn column = dataGridView2.Columns[0]; // ID 칼럼
            column.HeaderText = "의뢰 번호";                  // 가공의뢰 번호 
            column = dataGridView2.Columns[1];                    // 가공의뢰 일자
            column.HeaderText = "의뢰 일자";
            column = dataGridView2.Columns[2];                    // 학번
            column.HeaderText = "학번";
            column = dataGridView2.Columns[3];                    // 이름
            column.HeaderText = "이름";
            column = dataGridView2.Columns[4];                    // 연락처
            column.HeaderText = "연락처";
            column = dataGridView2.Columns[5];                    // 학부
            column.HeaderText = "학부";
            column = dataGridView2.Columns[6];                    // 신분
            column.HeaderText = "신분";
            column = dataGridView2.Columns[7];                    // 사용장비명
            column.HeaderText = "사용 장비";
            column = dataGridView2.Columns[8];                    // 사용 분류
            column.HeaderText = "사용 분류";
            column = dataGridView2.Columns[9];                    // 사용 목적
            column.HeaderText = "사용 목적";
            column = dataGridView2.Columns[10];                    // 사용 재료
            column.HeaderText = "사용 재료";
            column = dataGridView2.Columns[11];                    // 본인재료유무
            column.HeaderText = "재료 구비";
            column = dataGridView2.Columns[12];                    // 가공의뢰 작품 종류 수
            column.HeaderText = "작품 종류수";
            column = dataGridView2.Columns[13];                    // 가공의뢰 작품 총 개수
            column.HeaderText = "작품 총 수";
            column = dataGridView2.Columns[14];                    // 가공의뢰 작품 희망기한
            column.HeaderText = "희망기한";
            column = dataGridView2.Columns[15];                    // 가공의뢰 작품 특이사항
            column.HeaderText = "특이사항";

            connection.Close();

        }
    }
}
