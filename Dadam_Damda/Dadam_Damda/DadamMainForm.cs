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
        private Dadam_Lookup_Form mLookup_Form = null;
        private Dadam_Request_Form mReqeust_Form = null;

        MySqlConnection connection =
            new MySqlConnection("Server = localhost; Port=3306;" +
                "Database=dadam_request;" +
                "Uid=root;" +
                "Pwd=0000;");   // 서버, DB이름, 유저이름, 비밀번호

        // 자식 폼 객체로 선언


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
          //userControl_DadamHome1.Show();
          //  userControl_DadamHome1.BringToFront();

            // 나머지 페이지는 숨김
           // UserControl_DadamLookup.Hide();
           // userControl_DadamRequest1.Hide();

        }
        private void UserControl_DadamRequest_Load(object sender, EventArgs e)
        {
           
        }
      /*  private void Button_Main_Lookup_Click(object sender, EventArgs e)
        {
            // 다른 UserControl 가리기
            UserControl_DadamHome.Hide();
            UserControl_DadamRequest.Hide();

            // 현재 UserControl만 보여주기
            UserControl_DadamLookup.Show();
            UserControl_DadamLookup.BringToFront();
        }
      */
        private void Button_Main_Lookup_Click(object sender, EventArgs e)
        {

            panel1.Hide();
            // 다른 UserControl 가리기
            //UserControl_DadamHome.Hide();
            // UserControl_DadamLookup.Hide();

            // 현재 UserControl만 보여주기
            // UserControl_DadamRequest.Show();
            // UserControl_DadamRequest.BringToFront();

            if (ActiveMdiChild != null) // 자식 폼이 열려 있으면
                {
                    if (this.ActiveMdiChild != mLookup_Form)
                    {
                        ActiveMdiChild.Close(); // 현재 활성화된 창을 닫아라.
                    }
                    mLookup_Form = ShowActiveForm(mLookup_Form, typeof(Dadam_Lookup_Form)) as Dadam_Lookup_Form;
                }
                else
                {
                    mLookup_Form = ShowActiveForm(mLookup_Form, typeof(Dadam_Lookup_Form)) as Dadam_Lookup_Form;
                }
            }

        private void Button_Main_Home_Click(object sender, EventArgs e)
        {
            // 다른 UserControl 가리기
           // UserControl_DadamLookup.Hide();
           // UserControl_DadamRequest.Hide();

            // 현재 UserControl만 보여주기
           // UserControl_DadamHome.Show();
           // UserControl_DadamHome.BringToFront();
        }

        private Form ShowActiveForm(Form form, Type t)
        {
            if(form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                form.Activate();
            }
            return form;

        }
        private void Button_Main_Request_Click(object sender, EventArgs e)
        {
            panel1.Hide();
           //UserControl_DadamHome.Hide();
            //UserControl_DadamLookup.Hide();
            //UserControl_DadamRequest.Hide();

            if (ActiveMdiChild != null) // 자식 폼이 열려 있으면
            {
                if (this.ActiveMdiChild != mLookup_Form)
                {
                    ActiveMdiChild.Close(); // 현재 활성화된 창을 닫아라.
                }
                mReqeust_Form = ShowActiveForm(mReqeust_Form, typeof(Dadam_Request_Form)) as Dadam_Request_Form;
            } else
            {
                mReqeust_Form = ShowActiveForm(mReqeust_Form, typeof(Dadam_Request_Form)) as Dadam_Request_Form;
            }
         }
        private void Panel_MainLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dadam.koreatech.ac.kr/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://portal.koreatech.ac.kr/");
        }
    }
}