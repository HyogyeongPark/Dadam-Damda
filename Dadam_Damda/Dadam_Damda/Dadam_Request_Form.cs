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
    public partial class Dadam_Request_Form : Form
    {
        public Dadam_Request_Form()
        {
            InitializeComponent();
            // 불러 올 때, 신청 일자에 대한 Text 박스에 현재 날짜를 넣는다.
            this.Label_Request_DateTime.Text = DateTime.Now.ToShortDateString();

            //  불러 올 때, 제작 희망 기간에 대한 Date Time Picker의 디폴트값은 현재로부터 7일 후이다.
            DateTimePicker_Request_Item_Date.Value = DateTime.Now.AddDays(7);



            // 외부 데이터베이스의 정보를 받아와, 현재의 신청 번호를 찾아낸다.
            string selectQuery = "SELECT COUNT(*) AS cnt FROM request_all"; //쿼리문
            MySqlCommand command1 = new MySqlCommand(selectQuery, connection);  // DB 연결

            string readRequestId = "";
            int currentRequestID = 0;

            connection.Open();
            // DB를 읽어 전체 행의 개수를 구한 후, 그 개수에 1을 더하여 현재 신청서 번호를 구한다.
            try
            {
                MySqlDataReader reader = command1.ExecuteReader();
                while (reader.Read() == true)
                {
                    readRequestId = reader.GetString(0);
                    currentRequestID = Convert.ToUInt16(readRequestId) + 1;
                    Label_Request_Id.Text = Convert.ToString(currentRequestID);
                }
                reader.Close();
                connection.Close(); // DB 연동 해제
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Control의 부모에게 전달할 Event Delegate
        public delegate int delEvent(object sender, string strText); // delegate 선언
        public event delEvent eventdelSender;   // delegate event 선언

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

      
        /********   UserInfo에 해당하는 부분을 DB로 넘기기 ********/
        // 소속 학부 정보 리스트 박스 이벤트
        private void ListBox_Request_User_Major_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_User_Major.SelectedItem != null)
            {
                RequestInfo.strMajor = ListBox_Request_User_Major.SelectedItem.ToString();
            }
        }

        // 신분 정보 리스트 박스 이벤트
        private void ListBox_Request_User_Position_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_User_Position.SelectedItem != null)
            {
                RequestInfo.strPosition = ListBox_Request_User_Position.SelectedItem.ToString();
            }
        }

        // 사용 장비 리스트 박스 이벤트
        private void ListBox_Request_Equipment_Name_SelectedIndexChanged_1(object sender, EventArgs e)
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
        private void ListBox_Request_UseCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 리스트 아이템 중 선택된 아이템 SelectedItem을 .ToString()을 사용하여 string으로 캐스팅 후 변수에 저장
            if (ListBox_Request_UseCategory.SelectedItem != null)
            {
                RequestInfo.strRequestCategory = ListBox_Request_UseCategory.SelectedItem.ToString();
            }
        }

        // 가공 제작 희망 일자 Date Time Picker의 내용이 변경되었을 경우

        private void DateTimePicker_Request_Item_Date_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime dt1 = DateTimePicker_Request_Item_Date.Value;
            string dt = dt1.ToString("yyyy.MM.dd. (dddd)");
        }

        // 신청 완료 버튼 눌렀을 때 이벤트
        private void Button_Request_Add_Click_1(object sender, EventArgs e)
        {
            // 칼럼에 추가하는 커리문 insertQuery
            // user 테이블의 항목들의 값을 추가한다, 이때 값은 TextBox, ListBox로부터 온 것이다. (Text박스는 따로 변수 추가x)
            string insertQueryUserInfo = "INSERT INTO user(user_id, user_name, user_phone, user_major, user_position) " +
                "VALUES('" + TextBox_Request_User_Id.Text + "','" + TextBox_Request_User_Name.Text + "','" + TextBox_Request_User_PhoneNum.Text + "','" +
                RequestInfo.strMajor + "','" + RequestInfo.strPosition + "')\n";

            string insertQueryEquipmentInfo = "INSERT INTO equipment(equipment_name) " +
                "VALUES('" + RequestInfo.strEquipmentName + "')\n";

            string insertQueryItemInfo = "INSERT INTO item(item_material, item_num, item_piece, item_own) " +
                "VALUES('" + RichTextBox_Request_Item_Material.Text + "','" + TextBox_Request_Item_Num.Text + "','" +
                TextBox_Request_Item_Piece.Text + "','" + RequestInfo.strMaterialOwn + "')\n";

            string insertQueryRequestInfo = "INSERT INTO request(request_date, request_category, request_purpose, request_hopeDate, request_ps) " +
                "VALUES('" + Label_Request_DateTime.Text + "','" + RequestInfo.strRequestCategory + "','" + RichTextBox_Request_UsePurpose.Text + "','" +
                DateTimePicker_Request_Item_Date.Text + "','" + RichTextBox_Request_Item_PSText.Text + "')\n";


            string insertQuery = "INSERT INTO request_all " +
                "(request_id, request_date, request_category, request_purpose, request_hopeDate,request_ps, " +
                "equipment_name, " +
                "item_material, item_own, item_num, item_piece, " +
                "user_id, user_name, user_phone, user_major, user_position )" +
                "VALUES" +
                "('" + Label_Request_Id.Text + "','" + Label_Request_DateTime.Text + "','" + RequestInfo.strRequestCategory + "','" + RichTextBox_Request_UsePurpose.Text + "','" + DateTimePicker_Request_Item_Date.Text + "','" + RichTextBox_Request_Item_PSText.Text
                + "','" + RequestInfo.strEquipmentName
                + "','" + RichTextBox_Request_Item_Material.Text + "','" + RequestInfo.strMaterialOwn + "','" + TextBox_Request_Item_Num.Text + "','" + TextBox_Request_Item_Piece.Text
                + "','" + TextBox_Request_User_Id.Text + "','" + TextBox_Request_User_Name.Text + "','" + TextBox_Request_User_PhoneNum.Text + "','" + RequestInfo.strMajor + "','" + RequestInfo.strPosition + "')";

            /*string inserQuery = "INSERT ALL" +
                "INTO user(user_id, user_name, user_phone, user_major, user_position) " +
                "VALUES('" + this.TextBox_Request_User_Id.Text + "','" + this.TextBox_Request_User_Name.Text + "','" + this.TextBox_Request_User_PhoneNum.Text + "','" + RequestInfo.strMajor + "','" + RequestInfo.strPosition + "')" +
                "INTO equipment(equipment_name) " +
                "VALUES('" + RequestInfo.strEquipmentName + "')" +
                "INTO item(item_material, item_num, item_piece, item_own) " +
                "VALUES('" + this.RichTextBox_Request_Item_Material.Text + "','" + this.TextBox_Request_Item_Num.Text + "','" + this.TextBox_Request_Item_Piece.Text + "','" + RequestInfo.strMaterialOwn + "')" +
                "INTO request(request_date, request_category, request_purpose, request_hopeDate, request_ps) " +
                "VALUES('" + this.Label_Request_DateTime.Text + "','" + RequestInfo.strRequestCategory + "','" + this.RichTextBox_Request_UsePurpose.Text + "','" +
                this.DateTimePicker_Request_Item_Date.Text + "','" + this.RichTextBox_Request_Item_PSText.Text + "')";
            */
            //            string inserQuery = insertQueryUserInfo + insertQueryEquipmentInfo + insertQueryItemInfo + insertQueryRequestInfo;




            // DB와 연결하여 데이터 전송
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            /*MySqlCommand command1 = new MySqlCommand(insertQueryUserInfo, connection);
            MySqlCommand command2 = new MySqlCommand(insertQueryEquipmentInfo, connection);
            MySqlCommand command3 = new MySqlCommand(insertQueryItemInfo, connection);
            MySqlCommand command4 = new MySqlCommand(insertQueryRequestInfo, connection);
            */
            //예외처리
            try
            {
                // 만약 내가 처리한 MySQL에 정상적으로 입력됐다면, 메시지 출력
                if (command.ExecuteNonQuery() == 1) { MessageBox.Show("접수되었습니다."); }
                else { MessageBox.Show("접수되지 않았습니다."); }

                /*               if (command1.ExecuteNonQuery() == 1) { MessageBox.Show("접수되었습니다.");}
                               else {  MessageBox.Show("접수되지 않았습니다."); }

                               if (command2.ExecuteNonQuery() == 1) { MessageBox.Show("접수되었습니다."); }
                               else { MessageBox.Show("접수되지 않았습니다."); }

                               if (command3.ExecuteNonQuery() == 1) { MessageBox.Show("접수되었습니다."); }
                               else { MessageBox.Show("접수되지 않았습니다."); }

                               if (command4.ExecuteNonQuery() == 1) { MessageBox.Show("접수되었습니다."); }
                               else { MessageBox.Show("접수되지 않았습니다."); }
               */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }
    }
}
