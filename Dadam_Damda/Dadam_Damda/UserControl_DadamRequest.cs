using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Dadam_Damda
{
    public partial class UserControl_DadamRequest : UserControl
    {
        MySqlConnection connection =
            new MySqlConnection("Server=localhost; Port=3306;" +
                "Database=dadam_request;" +
                "Uid=root;" +
                "Pwd=0000;");   // 서버, DB이름, 유저이름, 비밀번호

        public class RequestInfo
        {
            //UserInfo
            public static string strMajor = "";
            public static string strPosition = "";

            public static string strEquipmentName = "";
            public static string strMaterialOwn = "";
            public static string strRequestCategory = "";
        }

        public UserControl_DadamRequest()
        {
            InitializeComponent();
        }

        private void UserControl_DadamRequest_Load(object sender, EventArgs e)
        {
            // user control을 불러 올 때, 신청 일자에 대한 Text 박스에 현재 날짜를 넣는다.
            this.Label_Request_DateTime.Text = DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox_Request_EquipmentInfo_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox_Request_ItemInfo_Enter(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel_Request_Person_Paint(object sender, PaintEventArgs e)
        {

        }

        /********   UserInfo에 해당하는 부분을 DB로 넘기기 ********/
        // 소속 학부 정보 리스트 박스 이벤트
        private void ListBox_Request_User_Major_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_User_Major.SelectedItem != null)
            {
                RequestInfo.strMajor = ListBox_Request_User_Major.SelectedItem.ToString();
            }
        }

        // 신분 정보 리스트 박스 이벤트
        private void ListBox_Request_User_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_User_Position.SelectedItem != null)
            {
                RequestInfo.strPosition = ListBox_Request_User_Position.SelectedItem.ToString();
            }
        }

        // 사용 장비 리스트 박스 이벤트
        private void ListBox_Request_Equipment_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_Equipment_Name.SelectedItem != null)
            {
                RequestInfo.strEquipmentName = ListBox_Request_Equipment_Name.SelectedItem.ToString();
            }
        }

        // 본인 재료 유무 리스트 박스 이벤트
        private void ListBox_Request_Item_OX_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_Item_OX.SelectedItem != null)
            {
                RequestInfo.strMaterialOwn = ListBox_Request_Item_OX.SelectedItem.ToString();
            }
        }

        // 사용 분류에 대한 리스트 박스 이벤트
        private void ListBox_Request_UseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_UseCategory.SelectedItem != null)
            {
                RequestInfo.strRequestCategory = ListBox_Request_UseCategory.SelectedItem.ToString();
            }
        }

        // 가공 제작 희망 일자 Date Time Picker의 내용이 변경되었을 경우

        private void DateTimePicker_Request_Item_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        // 신청 완료 버튼 눌렀을 때 이벤트
        private void Button_Request_Add_Click(object sender, EventArgs e)
        {
            // 칼럼에 추가하는 커리문 insertQuery
            // user 테이블의 항목들의 값을 추가한다, 이때 값은 TextBox, ListBox로부터 온 것이다. (Text박스는 따로 변수 추가x)
            string insertQuery = "INSERT INTO user(user_id, user_name, user_phone, user_major, user_position) " +
                "VALUES('" + this.TextBox_Request_User_Id.Text + "','" + this.TextBox_Request_User_Name.Text + "','" + this.TextBox_Request_User_PhoneNum.Text + "','" +
                RequestInfo.strMajor + "','" + RequestInfo.strPosition + "')";

            string insertQuery_EquipmentInfo = "INSERT INTO equipment(equipment_name) " +
                "VALUES('" + RequestInfo.strEquipmentName + "')";
    
            string inserQuery_ItemInfo =  "INSERT INTO item(item_material, item_num, item_piece, item_own) " +
                "VALUES('" + this.RichTextBox_Request_Item_Material.Text + "','" + this.TextBox_Request_Item_Num.Text + "','" +
                this.TextBox_Request_Item_Piece.Text + "','" + RequestInfo.strMaterialOwn + "')";

            string inserQuery_RequestInfo = "INSERT INTO request(request_date, request_category, request_purpose, request_hopeDate, request_ps, request_user_id, request_equipment_id, reqeust_item_id) " +
                "VALUES('" + this.Label_Request_DateTime.Text + "','" + RequestInfo.strRequestCategory + "','" + this.RichTextBox_Request_UsePurpose.Text + "','" +
                this.DateTimePicker_Request_Item_Date.Text+ "','" +this.RichTextBox_Request_Item_PSText.Text + "','" + this.TextBox_Request_User_Id.Text+ "')";

            // DB와 연결하여 데이터 전송
            connection.Open();
            MySqlCommand command = new MySqlCommand(inserQuery_RequestInfo, connection);

            //예외처리
            try
            {
                // 만약 내가 처리한 MySQL에 정상적으로 입력됐다면, 메시지 출력
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("접수되었습니다.");
                }
                else
                {
                    MessageBox.Show("접수되지 않았습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

        }

       
    }
}
