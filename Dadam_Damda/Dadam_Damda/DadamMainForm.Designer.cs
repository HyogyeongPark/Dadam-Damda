
namespace Dadam_Damda
{
    partial class DadamMainForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
       
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadamMainForm));
            this.Panel_MainMenu = new System.Windows.Forms.Panel();
            this.Panel_MainMenuButton = new System.Windows.Forms.Panel();
            this.Panel_DadamLogo = new System.Windows.Forms.Panel();
            this.Panel_MainLogo = new System.Windows.Forms.Panel();
            this.Label_Dadam2 = new System.Windows.Forms.Label();
            this.Label_Dadam1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Main_Request = new System.Windows.Forms.Button();
            this.Button_Main_Lookup = new System.Windows.Forms.Button();
            this.Button_Main_Home = new System.Windows.Forms.Button();
            this.PictureBox_DadamLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl_DadamRequest1 = new Dadam_Damda.UserControl_DadamRequest();
            this.Panel_MainMenu.SuspendLayout();
            this.Panel_MainMenuButton.SuspendLayout();
            this.Panel_DadamLogo.SuspendLayout();
            this.Panel_MainLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_DadamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_MainMenu
            // 
            this.Panel_MainMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Panel_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_MainMenu.Controls.Add(this.Panel_MainMenuButton);
            this.Panel_MainMenu.Controls.Add(this.Panel_MainLogo);
            this.Panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_MainMenu.Name = "Panel_MainMenu";
            this.Panel_MainMenu.Size = new System.Drawing.Size(178, 1008);
            this.Panel_MainMenu.TabIndex = 1;
            // 
            // Panel_MainMenuButton
            // 
            this.Panel_MainMenuButton.Controls.Add(this.Button_Main_Request);
            this.Panel_MainMenuButton.Controls.Add(this.Button_Main_Lookup);
            this.Panel_MainMenuButton.Controls.Add(this.Button_Main_Home);
            this.Panel_MainMenuButton.Controls.Add(this.Panel_DadamLogo);
            this.Panel_MainMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainMenuButton.Location = new System.Drawing.Point(0, 143);
            this.Panel_MainMenuButton.Name = "Panel_MainMenuButton";
            this.Panel_MainMenuButton.Size = new System.Drawing.Size(178, 865);
            this.Panel_MainMenuButton.TabIndex = 1;
            // 
            // Panel_DadamLogo
            // 
            this.Panel_DadamLogo.BackColor = System.Drawing.Color.White;
            this.Panel_DadamLogo.Controls.Add(this.PictureBox_DadamLogo);
            this.Panel_DadamLogo.Location = new System.Drawing.Point(0, 811);
            this.Panel_DadamLogo.Name = "Panel_DadamLogo";
            this.Panel_DadamLogo.Size = new System.Drawing.Size(178, 56);
            this.Panel_DadamLogo.TabIndex = 2;
            this.Panel_DadamLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_DadamLogo_Paint);
            // 
            // Panel_MainLogo
            // 
            this.Panel_MainLogo.BackColor = System.Drawing.Color.White;
            this.Panel_MainLogo.Controls.Add(this.pictureBox1);
            this.Panel_MainLogo.Controls.Add(this.Label_Dadam2);
            this.Panel_MainLogo.Controls.Add(this.Label_Dadam1);
            this.Panel_MainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_MainLogo.Location = new System.Drawing.Point(0, 0);
            this.Panel_MainLogo.Name = "Panel_MainLogo";
            this.Panel_MainLogo.Size = new System.Drawing.Size(178, 143);
            this.Panel_MainLogo.TabIndex = 0;
            // 
            // Label_Dadam2
            // 
            this.Label_Dadam2.AutoSize = true;
            this.Label_Dadam2.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Dadam2.ForeColor = System.Drawing.Color.Black;
            this.Label_Dadam2.Location = new System.Drawing.Point(97, 102);
            this.Label_Dadam2.Name = "Label_Dadam2";
            this.Label_Dadam2.Size = new System.Drawing.Size(72, 23);
            this.Label_Dadam2.TabIndex = 1;
            this.Label_Dadam2.Text = "을 담다";
            // 
            // Label_Dadam1
            // 
            this.Label_Dadam1.AutoSize = true;
            this.Label_Dadam1.BackColor = System.Drawing.Color.Transparent;
            this.Label_Dadam1.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Dadam1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label_Dadam1.Location = new System.Drawing.Point(11, 102);
            this.Label_Dadam1.Name = "Label_Dadam1";
            this.Label_Dadam1.Size = new System.Drawing.Size(86, 23);
            this.Label_Dadam1.TabIndex = 0;
            this.Label_Dadam1.Text = "DADAM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl_DadamRequest1);
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 1010);
            this.panel1.TabIndex = 2;
            // 
            // Button_Main_Request
            // 
            this.Button_Main_Request.FlatAppearance.BorderSize = 0;
            this.Button_Main_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Main_Request.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Main_Request.ForeColor = System.Drawing.Color.White;
            this.Button_Main_Request.Image = global::Dadam_Damda.Properties.Resources.user_white25;
            this.Button_Main_Request.Location = new System.Drawing.Point(0, 376);
            this.Button_Main_Request.Name = "Button_Main_Request";
            this.Button_Main_Request.Size = new System.Drawing.Size(178, 114);
            this.Button_Main_Request.TabIndex = 5;
            this.Button_Main_Request.Text = "REQUEST";
            this.Button_Main_Request.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Main_Request.UseVisualStyleBackColor = true;
            // 
            // Button_Main_Lookup
            // 
            this.Button_Main_Lookup.FlatAppearance.BorderSize = 0;
            this.Button_Main_Lookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Main_Lookup.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Main_Lookup.ForeColor = System.Drawing.Color.White;
            this.Button_Main_Lookup.Image = global::Dadam_Damda.Properties.Resources.receipt_white25;
            this.Button_Main_Lookup.Location = new System.Drawing.Point(0, 207);
            this.Button_Main_Lookup.Name = "Button_Main_Lookup";
            this.Button_Main_Lookup.Size = new System.Drawing.Size(178, 114);
            this.Button_Main_Lookup.TabIndex = 4;
            this.Button_Main_Lookup.Text = "LOOK UP";
            this.Button_Main_Lookup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Main_Lookup.UseVisualStyleBackColor = true;
            // 
            // Button_Main_Home
            // 
            this.Button_Main_Home.FlatAppearance.BorderSize = 0;
            this.Button_Main_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Main_Home.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Main_Home.ForeColor = System.Drawing.Color.White;
            this.Button_Main_Home.Image = global::Dadam_Damda.Properties.Resources.home_white25;
            this.Button_Main_Home.Location = new System.Drawing.Point(0, 36);
            this.Button_Main_Home.Name = "Button_Main_Home";
            this.Button_Main_Home.Size = new System.Drawing.Size(178, 114);
            this.Button_Main_Home.TabIndex = 3;
            this.Button_Main_Home.Text = "HOME";
            this.Button_Main_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Main_Home.UseVisualStyleBackColor = true;
            // 
            // PictureBox_DadamLogo
            // 
            this.PictureBox_DadamLogo.BackColor = System.Drawing.Color.White;
            this.PictureBox_DadamLogo.BackgroundImage = global::Dadam_Damda.Properties.Resources.다담창의센터_로고_175px;
            this.PictureBox_DadamLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox_DadamLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_DadamLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_DadamLogo.Name = "PictureBox_DadamLogo";
            this.PictureBox_DadamLogo.Size = new System.Drawing.Size(178, 56);
            this.PictureBox_DadamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_DadamLogo.TabIndex = 2;
            this.PictureBox_DadamLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dadam_Damda.Properties.Resources.Koryong_face_png2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::Dadam_Damda.Properties.Resources.Koryong_face_png2;
            this.pictureBox1.InitialImage = global::Dadam_Damda.Properties.Resources.Koryong_face_png2;
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 77);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userControl_DadamRequest1
            // 
            this.userControl_DadamRequest1.BackColor = System.Drawing.Color.White;
            this.userControl_DadamRequest1.Location = new System.Drawing.Point(0, -2);
            this.userControl_DadamRequest1.Name = "userControl_DadamRequest1";
            this.userControl_DadamRequest1.Size = new System.Drawing.Size(1090, 1010);
            this.userControl_DadamRequest1.TabIndex = 0;
            this.userControl_DadamRequest1.Load += new System.EventHandler(this.userControl_DadamRequest1_Load);
            // 
            // DadamMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 1008);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DadamMainForm";
            this.Text = "DADAM을 담다";
            this.Panel_MainMenu.ResumeLayout(false);
            this.Panel_MainMenuButton.ResumeLayout(false);
            this.Panel_DadamLogo.ResumeLayout(false);
            this.Panel_MainLogo.ResumeLayout(false);
            this.Panel_MainLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_DadamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MainMenu;
        private System.Windows.Forms.Panel Panel_MainLogo;
        private System.Windows.Forms.Label Label_Dadam2;
        private System.Windows.Forms.Label Label_Dadam1;
        private System.Windows.Forms.Panel Panel_MainMenuButton;
        private System.Windows.Forms.Button Button_Main_Request;
        private System.Windows.Forms.Button Button_Main_Lookup;
        private System.Windows.Forms.Button Button_Main_Home;
        private System.Windows.Forms.Panel Panel_DadamLogo;
        private System.Windows.Forms.PictureBox PictureBox_DadamLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private UserControl_DadamRequest userControl_DadamRequest1;
    }
}
