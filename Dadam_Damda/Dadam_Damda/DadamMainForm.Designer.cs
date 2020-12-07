
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
            this.panel_MainMenu = new System.Windows.Forms.Panel();
            this.panel_MainLogo = new System.Windows.Forms.Panel();
            this.pictureBox_KoryongLogo = new System.Windows.Forms.PictureBox();
            this.label_Dadam2 = new System.Windows.Forms.Label();
            this.label_Dadam1 = new System.Windows.Forms.Label();
            this.panel_MainMenuButton = new System.Windows.Forms.Panel();
            this.panel_DadamLogo = new System.Windows.Forms.Panel();
            this.button_Main_Home = new System.Windows.Forms.Button();
            this.button_Main_Lookup = new System.Windows.Forms.Button();
            this.button_Main_Request = new System.Windows.Forms.Button();
            this.pictureBox_DadamLogo = new System.Windows.Forms.PictureBox();
            this.panel_MainMenu.SuspendLayout();
            this.panel_MainLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KoryongLogo)).BeginInit();
            this.panel_MainMenuButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DadamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_MainMenu
            // 
            this.panel_MainMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_MainMenu.Controls.Add(this.pictureBox_DadamLogo);
            this.panel_MainMenu.Controls.Add(this.panel_MainMenuButton);
            this.panel_MainMenu.Controls.Add(this.panel_MainLogo);
            this.panel_MainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_MainMenu.Name = "panel_MainMenu";
            this.panel_MainMenu.Size = new System.Drawing.Size(178, 787);
            this.panel_MainMenu.TabIndex = 1;
            // 
            // panel_MainLogo
            // 
            this.panel_MainLogo.BackColor = System.Drawing.Color.White;
            this.panel_MainLogo.Controls.Add(this.pictureBox_KoryongLogo);
            this.panel_MainLogo.Controls.Add(this.label_Dadam2);
            this.panel_MainLogo.Controls.Add(this.label_Dadam1);
            this.panel_MainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MainLogo.Location = new System.Drawing.Point(0, 0);
            this.panel_MainLogo.Name = "panel_MainLogo";
            this.panel_MainLogo.Size = new System.Drawing.Size(178, 143);
            this.panel_MainLogo.TabIndex = 0;
            // 
            // pictureBox_KoryongLogo
            // 
            this.pictureBox_KoryongLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_KoryongLogo.BackgroundImage")));
            this.pictureBox_KoryongLogo.Location = new System.Drawing.Point(35, 12);
            this.pictureBox_KoryongLogo.Name = "pictureBox_KoryongLogo";
            this.pictureBox_KoryongLogo.Size = new System.Drawing.Size(102, 74);
            this.pictureBox_KoryongLogo.TabIndex = 3;
            this.pictureBox_KoryongLogo.TabStop = false;
            // 
            // label_Dadam2
            // 
            this.label_Dadam2.AutoSize = true;
            this.label_Dadam2.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Dadam2.ForeColor = System.Drawing.Color.Black;
            this.label_Dadam2.Location = new System.Drawing.Point(97, 102);
            this.label_Dadam2.Name = "label_Dadam2";
            this.label_Dadam2.Size = new System.Drawing.Size(72, 23);
            this.label_Dadam2.TabIndex = 1;
            this.label_Dadam2.Text = "을 담다";
            // 
            // label_Dadam1
            // 
            this.label_Dadam1.AutoSize = true;
            this.label_Dadam1.BackColor = System.Drawing.Color.Transparent;
            this.label_Dadam1.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Dadam1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_Dadam1.Location = new System.Drawing.Point(11, 102);
            this.label_Dadam1.Name = "label_Dadam1";
            this.label_Dadam1.Size = new System.Drawing.Size(86, 23);
            this.label_Dadam1.TabIndex = 0;
            this.label_Dadam1.Text = "DADAM";
            // 
            // panel_MainMenuButton
            // 
            this.panel_MainMenuButton.Controls.Add(this.button_Main_Request);
            this.panel_MainMenuButton.Controls.Add(this.button_Main_Lookup);
            this.panel_MainMenuButton.Controls.Add(this.button_Main_Home);
            this.panel_MainMenuButton.Controls.Add(this.panel_DadamLogo);
            this.panel_MainMenuButton.Location = new System.Drawing.Point(0, 141);
            this.panel_MainMenuButton.Name = "panel_MainMenuButton";
            this.panel_MainMenuButton.Size = new System.Drawing.Size(178, 591);
            this.panel_MainMenuButton.TabIndex = 1;
            // 
            // panel_DadamLogo
            // 
            this.panel_DadamLogo.Location = new System.Drawing.Point(0, 590);
            this.panel_DadamLogo.Name = "panel_DadamLogo";
            this.panel_DadamLogo.Size = new System.Drawing.Size(178, 56);
            this.panel_DadamLogo.TabIndex = 2;
            // 
            // button_Main_Home
            // 
            this.button_Main_Home.FlatAppearance.BorderSize = 0;
            this.button_Main_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Main_Home.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Main_Home.ForeColor = System.Drawing.Color.White;
            this.button_Main_Home.Image = ((System.Drawing.Image)(resources.GetObject("button_Main_Home.Image")));
            this.button_Main_Home.Location = new System.Drawing.Point(0, 36);
            this.button_Main_Home.Name = "button_Main_Home";
            this.button_Main_Home.Size = new System.Drawing.Size(178, 114);
            this.button_Main_Home.TabIndex = 3;
            this.button_Main_Home.Text = "HOME";
            this.button_Main_Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Main_Home.UseVisualStyleBackColor = true;
            // 
            // button_Main_Lookup
            // 
            this.button_Main_Lookup.FlatAppearance.BorderSize = 0;
            this.button_Main_Lookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Main_Lookup.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Main_Lookup.ForeColor = System.Drawing.Color.White;
            this.button_Main_Lookup.Image = ((System.Drawing.Image)(resources.GetObject("button_Main_Lookup.Image")));
            this.button_Main_Lookup.Location = new System.Drawing.Point(0, 207);
            this.button_Main_Lookup.Name = "button_Main_Lookup";
            this.button_Main_Lookup.Size = new System.Drawing.Size(178, 114);
            this.button_Main_Lookup.TabIndex = 4;
            this.button_Main_Lookup.Text = "LOOK UP";
            this.button_Main_Lookup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Main_Lookup.UseVisualStyleBackColor = true;
            // 
            // button_Main_Request
            // 
            this.button_Main_Request.FlatAppearance.BorderSize = 0;
            this.button_Main_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Main_Request.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Main_Request.ForeColor = System.Drawing.Color.White;
            this.button_Main_Request.Image = ((System.Drawing.Image)(resources.GetObject("button_Main_Request.Image")));
            this.button_Main_Request.Location = new System.Drawing.Point(0, 376);
            this.button_Main_Request.Name = "button_Main_Request";
            this.button_Main_Request.Size = new System.Drawing.Size(178, 114);
            this.button_Main_Request.TabIndex = 5;
            this.button_Main_Request.Text = "REQUEST";
            this.button_Main_Request.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Main_Request.UseVisualStyleBackColor = true;
            // 
            // pictureBox_DadamLogo
            // 
            this.pictureBox_DadamLogo.BackColor = System.Drawing.Color.White;
            this.pictureBox_DadamLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_DadamLogo.Image")));
            this.pictureBox_DadamLogo.Location = new System.Drawing.Point(0, 731);
            this.pictureBox_DadamLogo.Name = "pictureBox_DadamLogo";
            this.pictureBox_DadamLogo.Size = new System.Drawing.Size(178, 56);
            this.pictureBox_DadamLogo.TabIndex = 2;
            this.pictureBox_DadamLogo.TabStop = false;
            // 
            // DadamMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_MainMenu);
            this.Name = "DadamMainForm";
            this.Size = new System.Drawing.Size(1132, 787);
            this.panel_MainMenu.ResumeLayout(false);
            this.panel_MainLogo.ResumeLayout(false);
            this.panel_MainLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KoryongLogo)).EndInit();
            this.panel_MainMenuButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DadamLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MainMenu;
        private System.Windows.Forms.Panel panel_MainLogo;
        private System.Windows.Forms.PictureBox pictureBox_KoryongLogo;
        private System.Windows.Forms.Label label_Dadam2;
        private System.Windows.Forms.Label label_Dadam1;
        private System.Windows.Forms.Panel panel_MainMenuButton;
        private System.Windows.Forms.Button button_Main_Request;
        private System.Windows.Forms.Button button_Main_Lookup;
        private System.Windows.Forms.Button button_Main_Home;
        private System.Windows.Forms.Panel panel_DadamLogo;
        private System.Windows.Forms.PictureBox pictureBox_DadamLogo;
    }
}
