using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient; // 참조로 추가한다.

namespace Dadam_Damda
{
    public partial class DadamMainForm : Form
    {
        MySqlConnection connection =
            new MySqlConnection("Server = localhost; Port=3306;" +
                "Database=dadam_request;" +
                "Uid=root;" +
                "Pwd=0000;");   // 서버, DB이름, 유저이름, 비밀번호

        public DadamMainForm()
        {
            InitializeComponent();
        }

        private void Panel_DadamLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        // 첫 시작 메인 폼에서 다른 폼이 보일 것인지 여부 결정
        private void DadamMainForm_Load(object sender, EventArgs e)
        {
            // 시작화면은 Home 화면을 기반
            UserControl_DadamHome.Show();
            UserControl_DadamHome.BringToFront();

            // 나머지 페이지는 숨김
            UserControl_DadamLookup.Hide();
            UserControl_DadamRequest.Hide();

        }
        private void UserControl_DadamRequest_Load(object sender, EventArgs e)
        {
        }
        private void Button_Main_Lookup_Click(object sender, EventArgs e)
        {
            // 다른 UserControl 가리기
            UserControl_DadamHome.Hide();
            UserControl_DadamRequest.Hide();

            // 현재 UserControl만 보여주기
            UserControl_DadamLookup.Show();
            UserControl_DadamLookup.BringToFront();
        }

        private void Button_Main_Request_Click(object sender, EventArgs e)
        {
            // 다른 UserControl 가리기
            UserControl_DadamHome.Hide();
            UserControl_DadamLookup.Hide();

            // 현재 UserControl만 보여주기
            UserControl_DadamRequest.Show();
            UserControl_DadamRequest.BringToFront();
        }

        private void Button_Main_Home_Click(object sender, EventArgs e)
        {
            // 다른 UserControl 가리기
            UserControl_DadamLookup.Hide();
            UserControl_DadamRequest.Hide();

            // 현재 UserControl만 보여주기
            UserControl_DadamHome.Show();
            UserControl_DadamHome.BringToFront();
        }
    }
}