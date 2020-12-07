namespace Dadam_Damda
{
    partial class UserControl_DadamRequest
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
            this.TextBox_RequestNum = new System.Windows.Forms.TextBox();
            this.Panel_Request_Num = new System.Windows.Forms.Panel();
            this.Label_RequestNum = new System.Windows.Forms.Label();
            this.Label_RequestDate = new System.Windows.Forms.Label();
            this.TextBox_RequestDate = new System.Windows.Forms.TextBox();
            this.GroupBox_Request_PersonInfo = new System.Windows.Forms.GroupBox();
            this.GroupBox_Request_EquipmentInfo = new System.Windows.Forms.GroupBox();
            this.GroupBox_Request_ItemInfo = new System.Windows.Forms.GroupBox();
            this.Label_Request_PersonName = new System.Windows.Forms.Label();
            this.TableLayoutPanel_Request_Person = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_Request_PersonName = new System.Windows.Forms.TextBox();
            this.Label_Request_PersonPhoneNum = new System.Windows.Forms.Label();
            this.TextBox_Request_PersonPhoneNum = new System.Windows.Forms.TextBox();
            this.Label_Request_PersonMajor = new System.Windows.Forms.Label();
            this.ListBox_Request_PersonMajor = new System.Windows.Forms.ListBox();
            this.Label_Request_PersonPosition = new System.Windows.Forms.Label();
            this.ListBox_Request_PersonPosition = new System.Windows.Forms.ListBox();
            this.TableLayoutPanel_Request_Equipment = new System.Windows.Forms.TableLayoutPanel();
            this.ListBox_Request_EquipmentName = new System.Windows.Forms.ListBox();
            this.Label_Request_EquipmentName = new System.Windows.Forms.Label();
            this.ListBox_Request_UseCategory = new System.Windows.Forms.ListBox();
            this.Label_Request_UseCategory = new System.Windows.Forms.Label();
            this.Label_Request_UsePurpose = new System.Windows.Forms.Label();
            this.RichTextBox_Request_UsePurpose = new System.Windows.Forms.RichTextBox();
            this.TableLayoutPanel_Request_ItemInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Request_Item_Num = new System.Windows.Forms.Label();
            this.Label_Request_Item_OX = new System.Windows.Forms.Label();
            this.ListBox_Request_Item_OX = new System.Windows.Forms.ListBox();
            this.Label_Request_Item_Material = new System.Windows.Forms.Label();
            this.RichTextBox_Request_Item_Material = new System.Windows.Forms.RichTextBox();
            this.Label_Request_Item_Date = new System.Windows.Forms.Label();
            this.Label_Request_Item_PSText = new System.Windows.Forms.Label();
            this.Panel_Request_Item_Num = new System.Windows.Forms.Panel();
            this.TextBox_Request_Item_Num = new System.Windows.Forms.TextBox();
            this.Label_Request_Item_Nums = new System.Windows.Forms.Label();
            this.Label_Request_Item_Piece = new System.Windows.Forms.Label();
            this.TextBox_Request_Item_Piece = new System.Windows.Forms.TextBox();
            this.DateTimePicker_Request_Item_Date = new System.Windows.Forms.DateTimePicker();
            this.RichTextBox_Request_Item_PSText = new System.Windows.Forms.RichTextBox();
            this.Panel_Request_Num.SuspendLayout();
            this.GroupBox_Request_PersonInfo.SuspendLayout();
            this.GroupBox_Request_EquipmentInfo.SuspendLayout();
            this.GroupBox_Request_ItemInfo.SuspendLayout();
            this.TableLayoutPanel_Request_Person.SuspendLayout();
            this.TableLayoutPanel_Request_Equipment.SuspendLayout();
            this.TableLayoutPanel_Request_ItemInfo.SuspendLayout();
            this.Panel_Request_Item_Num.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_RequestNum
            // 
            this.TextBox_RequestNum.BackColor = System.Drawing.Color.White;
            this.TextBox_RequestNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_RequestNum.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_RequestNum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox_RequestNum.Location = new System.Drawing.Point(113, 13);
            this.TextBox_RequestNum.Name = "TextBox_RequestNum";
            this.TextBox_RequestNum.Size = new System.Drawing.Size(100, 22);
            this.TextBox_RequestNum.TabIndex = 0;
            this.TextBox_RequestNum.Text = "123";
            // 
            // Panel_Request_Num
            // 
            this.Panel_Request_Num.Controls.Add(this.TextBox_RequestDate);
            this.Panel_Request_Num.Controls.Add(this.Label_RequestDate);
            this.Panel_Request_Num.Controls.Add(this.Label_RequestNum);
            this.Panel_Request_Num.Controls.Add(this.TextBox_RequestNum);
            this.Panel_Request_Num.Location = new System.Drawing.Point(295, 30);
            this.Panel_Request_Num.Name = "Panel_Request_Num";
            this.Panel_Request_Num.Size = new System.Drawing.Size(477, 46);
            this.Panel_Request_Num.TabIndex = 1;
            // 
            // Label_RequestNum
            // 
            this.Label_RequestNum.AutoSize = true;
            this.Label_RequestNum.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_RequestNum.Location = new System.Drawing.Point(12, 13);
            this.Label_RequestNum.Name = "Label_RequestNum";
            this.Label_RequestNum.Size = new System.Drawing.Size(96, 21);
            this.Label_RequestNum.TabIndex = 1;
            this.Label_RequestNum.Text = "신청번호 : ";
            // 
            // Label_RequestDate
            // 
            this.Label_RequestDate.AutoSize = true;
            this.Label_RequestDate.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_RequestDate.Location = new System.Drawing.Point(243, 12);
            this.Label_RequestDate.Name = "Label_RequestDate";
            this.Label_RequestDate.Size = new System.Drawing.Size(96, 21);
            this.Label_RequestDate.TabIndex = 3;
            this.Label_RequestDate.Text = "신청일자 : ";
            // 
            // TextBox_RequestDate
            // 
            this.TextBox_RequestDate.BackColor = System.Drawing.Color.White;
            this.TextBox_RequestDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_RequestDate.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_RequestDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox_RequestDate.Location = new System.Drawing.Point(344, 12);
            this.TextBox_RequestDate.Name = "TextBox_RequestDate";
            this.TextBox_RequestDate.Size = new System.Drawing.Size(128, 22);
            this.TextBox_RequestDate.TabIndex = 4;
            this.TextBox_RequestDate.Text = "2020-12-08";
            // 
            // GroupBox_Request_PersonInfo
            // 
            this.GroupBox_Request_PersonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox_Request_PersonInfo.Controls.Add(this.TableLayoutPanel_Request_Person);
            this.GroupBox_Request_PersonInfo.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox_Request_PersonInfo.Location = new System.Drawing.Point(46, 112);
            this.GroupBox_Request_PersonInfo.Name = "GroupBox_Request_PersonInfo";
            this.GroupBox_Request_PersonInfo.Size = new System.Drawing.Size(282, 860);
            this.GroupBox_Request_PersonInfo.TabIndex = 2;
            this.GroupBox_Request_PersonInfo.TabStop = false;
            this.GroupBox_Request_PersonInfo.Text = "신청자 정보";
            this.GroupBox_Request_PersonInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GroupBox_Request_EquipmentInfo
            // 
            this.GroupBox_Request_EquipmentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox_Request_EquipmentInfo.Controls.Add(this.TableLayoutPanel_Request_Equipment);
            this.GroupBox_Request_EquipmentInfo.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox_Request_EquipmentInfo.Location = new System.Drawing.Point(406, 112);
            this.GroupBox_Request_EquipmentInfo.Name = "GroupBox_Request_EquipmentInfo";
            this.GroupBox_Request_EquipmentInfo.Size = new System.Drawing.Size(282, 860);
            this.GroupBox_Request_EquipmentInfo.TabIndex = 3;
            this.GroupBox_Request_EquipmentInfo.TabStop = false;
            this.GroupBox_Request_EquipmentInfo.Text = "사용장비 및 목적";
            this.GroupBox_Request_EquipmentInfo.Enter += new System.EventHandler(this.GroupBox_Request_EquipmentInfo_Enter);
            // 
            // GroupBox_Request_ItemInfo
            // 
            this.GroupBox_Request_ItemInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupBox_Request_ItemInfo.Controls.Add(this.TableLayoutPanel_Request_ItemInfo);
            this.GroupBox_Request_ItemInfo.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox_Request_ItemInfo.Location = new System.Drawing.Point(757, 112);
            this.GroupBox_Request_ItemInfo.Name = "GroupBox_Request_ItemInfo";
            this.GroupBox_Request_ItemInfo.Size = new System.Drawing.Size(282, 860);
            this.GroupBox_Request_ItemInfo.TabIndex = 3;
            this.GroupBox_Request_ItemInfo.TabStop = false;
            this.GroupBox_Request_ItemInfo.Text = "작품 정보";
            this.GroupBox_Request_ItemInfo.Enter += new System.EventHandler(this.GroupBox_Request_ItemInfo_Enter);
            // 
            // Label_Request_PersonName
            // 
            this.Label_Request_PersonName.AutoSize = true;
            this.Label_Request_PersonName.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_PersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_PersonName.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_PersonName.Location = new System.Drawing.Point(3, 0);
            this.Label_Request_PersonName.Name = "Label_Request_PersonName";
            this.Label_Request_PersonName.Size = new System.Drawing.Size(53, 41);
            this.Label_Request_PersonName.TabIndex = 0;
            this.Label_Request_PersonName.Text = "이름";
            this.Label_Request_PersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel_Request_Person
            // 
            this.TableLayoutPanel_Request_Person.ColumnCount = 2;
            this.TableLayoutPanel_Request_Person.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel_Request_Person.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TableLayoutPanel_Request_Person.Controls.Add(this.Label_Request_PersonPosition, 0, 3);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.ListBox_Request_PersonPosition, 1, 3);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.Label_Request_PersonMajor, 0, 2);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.Label_Request_PersonPhoneNum, 0, 1);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.TextBox_Request_PersonPhoneNum, 1, 1);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.Label_Request_PersonName, 0, 0);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.TextBox_Request_PersonName, 1, 0);
            this.TableLayoutPanel_Request_Person.Controls.Add(this.ListBox_Request_PersonMajor, 1, 2);
            this.TableLayoutPanel_Request_Person.Location = new System.Drawing.Point(16, 68);
            this.TableLayoutPanel_Request_Person.Name = "TableLayoutPanel_Request_Person";
            this.TableLayoutPanel_Request_Person.RowCount = 4;
            this.TableLayoutPanel_Request_Person.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TableLayoutPanel_Request_Person.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Request_Person.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.TableLayoutPanel_Request_Person.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.TableLayoutPanel_Request_Person.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel_Request_Person.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel_Request_Person.Size = new System.Drawing.Size(247, 775);
            this.TableLayoutPanel_Request_Person.TabIndex = 1;
            this.TableLayoutPanel_Request_Person.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel_Request_Person_Paint);
            // 
            // TextBox_Request_PersonName
            // 
            this.TextBox_Request_PersonName.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Request_PersonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Request_PersonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Request_PersonName.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Request_PersonName.Location = new System.Drawing.Point(62, 3);
            this.TextBox_Request_PersonName.Name = "TextBox_Request_PersonName";
            this.TextBox_Request_PersonName.Size = new System.Drawing.Size(182, 26);
            this.TextBox_Request_PersonName.TabIndex = 1;
            // 
            // Label_Request_PersonPhoneNum
            // 
            this.Label_Request_PersonPhoneNum.AutoSize = true;
            this.Label_Request_PersonPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_PersonPhoneNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_PersonPhoneNum.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_PersonPhoneNum.Location = new System.Drawing.Point(3, 41);
            this.Label_Request_PersonPhoneNum.Name = "Label_Request_PersonPhoneNum";
            this.Label_Request_PersonPhoneNum.Size = new System.Drawing.Size(53, 42);
            this.Label_Request_PersonPhoneNum.TabIndex = 2;
            this.Label_Request_PersonPhoneNum.Text = "연락처";
            this.Label_Request_PersonPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Request_PersonPhoneNum
            // 
            this.TextBox_Request_PersonPhoneNum.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_Request_PersonPhoneNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Request_PersonPhoneNum.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Request_PersonPhoneNum.Location = new System.Drawing.Point(62, 44);
            this.TextBox_Request_PersonPhoneNum.Name = "TextBox_Request_PersonPhoneNum";
            this.TextBox_Request_PersonPhoneNum.Size = new System.Drawing.Size(182, 26);
            this.TextBox_Request_PersonPhoneNum.TabIndex = 3;
            // 
            // Label_Request_PersonMajor
            // 
            this.Label_Request_PersonMajor.AutoSize = true;
            this.Label_Request_PersonMajor.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_PersonMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_PersonMajor.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_PersonMajor.Location = new System.Drawing.Point(3, 83);
            this.Label_Request_PersonMajor.Name = "Label_Request_PersonMajor";
            this.Label_Request_PersonMajor.Size = new System.Drawing.Size(53, 341);
            this.Label_Request_PersonMajor.TabIndex = 4;
            this.Label_Request_PersonMajor.Text = "학부";
            this.Label_Request_PersonMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox_Request_PersonMajor
            // 
            this.ListBox_Request_PersonMajor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Request_PersonMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Request_PersonMajor.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox_Request_PersonMajor.ForeColor = System.Drawing.Color.Black;
            this.ListBox_Request_PersonMajor.FormattingEnabled = true;
            this.ListBox_Request_PersonMajor.ItemHeight = 18;
            this.ListBox_Request_PersonMajor.Location = new System.Drawing.Point(62, 86);
            this.ListBox_Request_PersonMajor.Name = "ListBox_Request_PersonMajor";
            this.ListBox_Request_PersonMajor.Size = new System.Drawing.Size(182, 335);
            this.ListBox_Request_PersonMajor.TabIndex = 5;
            // 
            // Label_Request_PersonPosition
            // 
            this.Label_Request_PersonPosition.AutoSize = true;
            this.Label_Request_PersonPosition.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_PersonPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_PersonPosition.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_PersonPosition.Location = new System.Drawing.Point(3, 424);
            this.Label_Request_PersonPosition.Name = "Label_Request_PersonPosition";
            this.Label_Request_PersonPosition.Size = new System.Drawing.Size(53, 351);
            this.Label_Request_PersonPosition.TabIndex = 6;
            this.Label_Request_PersonPosition.Text = "신분";
            this.Label_Request_PersonPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox_Request_PersonPosition
            // 
            this.ListBox_Request_PersonPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Request_PersonPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Request_PersonPosition.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox_Request_PersonPosition.ForeColor = System.Drawing.Color.Black;
            this.ListBox_Request_PersonPosition.FormattingEnabled = true;
            this.ListBox_Request_PersonPosition.ItemHeight = 18;
            this.ListBox_Request_PersonPosition.Location = new System.Drawing.Point(62, 427);
            this.ListBox_Request_PersonPosition.Name = "ListBox_Request_PersonPosition";
            this.ListBox_Request_PersonPosition.Size = new System.Drawing.Size(182, 345);
            this.ListBox_Request_PersonPosition.TabIndex = 7;
            // 
            // TableLayoutPanel_Request_Equipment
            // 
            this.TableLayoutPanel_Request_Equipment.ColumnCount = 1;
            this.TableLayoutPanel_Request_Equipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel_Request_Equipment.Controls.Add(this.Label_Request_UsePurpose, 0, 4);
            this.TableLayoutPanel_Request_Equipment.Controls.Add(this.Label_Request_UseCategory, 0, 2);
            this.TableLayoutPanel_Request_Equipment.Controls.Add(this.ListBox_Request_UseCategory, 0, 3);
            this.TableLayoutPanel_Request_Equipment.Controls.Add(this.Label_Request_EquipmentName, 0, 0);
            this.TableLayoutPanel_Request_Equipment.Controls.Add(this.ListBox_Request_EquipmentName, 0, 1);
            this.TableLayoutPanel_Request_Equipment.Controls.Add(this.RichTextBox_Request_UsePurpose, 0, 5);
            this.TableLayoutPanel_Request_Equipment.Location = new System.Drawing.Point(17, 71);
            this.TableLayoutPanel_Request_Equipment.Name = "TableLayoutPanel_Request_Equipment";
            this.TableLayoutPanel_Request_Equipment.RowCount = 6;
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.TableLayoutPanel_Request_Equipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel_Request_Equipment.Size = new System.Drawing.Size(247, 769);
            this.TableLayoutPanel_Request_Equipment.TabIndex = 6;
            // 
            // ListBox_Request_EquipmentName
            // 
            this.ListBox_Request_EquipmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Request_EquipmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Request_EquipmentName.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox_Request_EquipmentName.ForeColor = System.Drawing.Color.Black;
            this.ListBox_Request_EquipmentName.FormattingEnabled = true;
            this.ListBox_Request_EquipmentName.ItemHeight = 18;
            this.ListBox_Request_EquipmentName.Location = new System.Drawing.Point(3, 27);
            this.ListBox_Request_EquipmentName.Name = "ListBox_Request_EquipmentName";
            this.ListBox_Request_EquipmentName.Size = new System.Drawing.Size(241, 337);
            this.ListBox_Request_EquipmentName.TabIndex = 5;
            // 
            // Label_Request_EquipmentName
            // 
            this.Label_Request_EquipmentName.AutoSize = true;
            this.Label_Request_EquipmentName.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_EquipmentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_EquipmentName.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_EquipmentName.Location = new System.Drawing.Point(3, 0);
            this.Label_Request_EquipmentName.Name = "Label_Request_EquipmentName";
            this.Label_Request_EquipmentName.Size = new System.Drawing.Size(241, 24);
            this.Label_Request_EquipmentName.TabIndex = 0;
            this.Label_Request_EquipmentName.Text = "사용장비";
            this.Label_Request_EquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox_Request_UseCategory
            // 
            this.ListBox_Request_UseCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Request_UseCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Request_UseCategory.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox_Request_UseCategory.ForeColor = System.Drawing.Color.Black;
            this.ListBox_Request_UseCategory.FormattingEnabled = true;
            this.ListBox_Request_UseCategory.ItemHeight = 18;
            this.ListBox_Request_UseCategory.Location = new System.Drawing.Point(3, 393);
            this.ListBox_Request_UseCategory.Name = "ListBox_Request_UseCategory";
            this.ListBox_Request_UseCategory.Size = new System.Drawing.Size(241, 218);
            this.ListBox_Request_UseCategory.TabIndex = 7;
            // 
            // Label_Request_UseCategory
            // 
            this.Label_Request_UseCategory.AutoSize = true;
            this.Label_Request_UseCategory.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_UseCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_UseCategory.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_UseCategory.Location = new System.Drawing.Point(3, 367);
            this.Label_Request_UseCategory.Name = "Label_Request_UseCategory";
            this.Label_Request_UseCategory.Size = new System.Drawing.Size(241, 23);
            this.Label_Request_UseCategory.TabIndex = 4;
            this.Label_Request_UseCategory.Text = "사용분류";
            this.Label_Request_UseCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Request_UsePurpose
            // 
            this.Label_Request_UsePurpose.AutoSize = true;
            this.Label_Request_UsePurpose.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_UsePurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_UsePurpose.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_UsePurpose.Location = new System.Drawing.Point(3, 614);
            this.Label_Request_UsePurpose.Name = "Label_Request_UsePurpose";
            this.Label_Request_UsePurpose.Size = new System.Drawing.Size(241, 29);
            this.Label_Request_UsePurpose.TabIndex = 6;
            this.Label_Request_UsePurpose.Text = "사용목적";
            this.Label_Request_UsePurpose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RichTextBox_Request_UsePurpose
            // 
            this.RichTextBox_Request_UsePurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_Request_UsePurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Request_UsePurpose.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RichTextBox_Request_UsePurpose.Location = new System.Drawing.Point(3, 646);
            this.RichTextBox_Request_UsePurpose.Name = "RichTextBox_Request_UsePurpose";
            this.RichTextBox_Request_UsePurpose.Size = new System.Drawing.Size(241, 120);
            this.RichTextBox_Request_UsePurpose.TabIndex = 8;
            this.RichTextBox_Request_UsePurpose.Text = "";
            // 
            // TableLayoutPanel_Request_ItemInfo
            // 
            this.TableLayoutPanel_Request_ItemInfo.ColumnCount = 1;
            this.TableLayoutPanel_Request_ItemInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.Label_Request_Item_Num, 0, 4);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.Label_Request_Item_OX, 0, 2);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.ListBox_Request_Item_OX, 0, 3);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.Label_Request_Item_Material, 0, 0);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.RichTextBox_Request_Item_Material, 0, 1);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.Label_Request_Item_Date, 0, 6);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.Label_Request_Item_PSText, 0, 8);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.Panel_Request_Item_Num, 0, 5);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.DateTimePicker_Request_Item_Date, 0, 7);
            this.TableLayoutPanel_Request_ItemInfo.Controls.Add(this.RichTextBox_Request_Item_PSText, 0, 9);
            this.TableLayoutPanel_Request_ItemInfo.Location = new System.Drawing.Point(17, 71);
            this.TableLayoutPanel_Request_ItemInfo.Name = "TableLayoutPanel_Request_ItemInfo";
            this.TableLayoutPanel_Request_ItemInfo.RowCount = 10;
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.TableLayoutPanel_Request_ItemInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel_Request_ItemInfo.Size = new System.Drawing.Size(247, 769);
            this.TableLayoutPanel_Request_ItemInfo.TabIndex = 7;
            // 
            // Label_Request_Item_Num
            // 
            this.Label_Request_Item_Num.AutoSize = true;
            this.Label_Request_Item_Num.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_Item_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_Item_Num.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_Num.Location = new System.Drawing.Point(3, 348);
            this.Label_Request_Item_Num.Name = "Label_Request_Item_Num";
            this.Label_Request_Item_Num.Size = new System.Drawing.Size(244, 32);
            this.Label_Request_Item_Num.TabIndex = 6;
            this.Label_Request_Item_Num.Text = "가공의뢰 작품 수";
            this.Label_Request_Item_Num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Request_Item_OX
            // 
            this.Label_Request_Item_OX.AutoSize = true;
            this.Label_Request_Item_OX.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_Item_OX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_Item_OX.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_OX.Location = new System.Drawing.Point(3, 256);
            this.Label_Request_Item_OX.Name = "Label_Request_Item_OX";
            this.Label_Request_Item_OX.Size = new System.Drawing.Size(244, 26);
            this.Label_Request_Item_OX.TabIndex = 4;
            this.Label_Request_Item_OX.Text = "본인재료유무";
            this.Label_Request_Item_OX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox_Request_Item_OX
            // 
            this.ListBox_Request_Item_OX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Request_Item_OX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Request_Item_OX.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox_Request_Item_OX.ForeColor = System.Drawing.Color.Black;
            this.ListBox_Request_Item_OX.FormattingEnabled = true;
            this.ListBox_Request_Item_OX.ItemHeight = 18;
            this.ListBox_Request_Item_OX.Location = new System.Drawing.Point(3, 285);
            this.ListBox_Request_Item_OX.Name = "ListBox_Request_Item_OX";
            this.ListBox_Request_Item_OX.Size = new System.Drawing.Size(244, 60);
            this.ListBox_Request_Item_OX.TabIndex = 7;
            // 
            // Label_Request_Item_Material
            // 
            this.Label_Request_Item_Material.AutoSize = true;
            this.Label_Request_Item_Material.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_Item_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_Item_Material.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_Material.Location = new System.Drawing.Point(3, 0);
            this.Label_Request_Item_Material.Name = "Label_Request_Item_Material";
            this.Label_Request_Item_Material.Size = new System.Drawing.Size(244, 24);
            this.Label_Request_Item_Material.TabIndex = 0;
            this.Label_Request_Item_Material.Text = "사용재료";
            this.Label_Request_Item_Material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RichTextBox_Request_Item_Material
            // 
            this.RichTextBox_Request_Item_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_Request_Item_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Request_Item_Material.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RichTextBox_Request_Item_Material.Location = new System.Drawing.Point(3, 27);
            this.RichTextBox_Request_Item_Material.Name = "RichTextBox_Request_Item_Material";
            this.RichTextBox_Request_Item_Material.Size = new System.Drawing.Size(244, 226);
            this.RichTextBox_Request_Item_Material.TabIndex = 8;
            this.RichTextBox_Request_Item_Material.Text = "";
            // 
            // Label_Request_Item_Date
            // 
            this.Label_Request_Item_Date.AutoSize = true;
            this.Label_Request_Item_Date.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_Item_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_Item_Date.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_Date.Location = new System.Drawing.Point(3, 431);
            this.Label_Request_Item_Date.Name = "Label_Request_Item_Date";
            this.Label_Request_Item_Date.Size = new System.Drawing.Size(244, 39);
            this.Label_Request_Item_Date.TabIndex = 9;
            this.Label_Request_Item_Date.Text = "제작 희망 기한";
            this.Label_Request_Item_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Request_Item_PSText
            // 
            this.Label_Request_Item_PSText.AutoSize = true;
            this.Label_Request_Item_PSText.BackColor = System.Drawing.Color.Transparent;
            this.Label_Request_Item_PSText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Request_Item_PSText.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_PSText.Location = new System.Drawing.Point(3, 643);
            this.Label_Request_Item_PSText.Name = "Label_Request_Item_PSText";
            this.Label_Request_Item_PSText.Size = new System.Drawing.Size(244, 32);
            this.Label_Request_Item_PSText.TabIndex = 10;
            this.Label_Request_Item_PSText.Text = "특이사항";
            this.Label_Request_Item_PSText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Request_Item_Num
            // 
            this.Panel_Request_Item_Num.Controls.Add(this.Label_Request_Item_Piece);
            this.Panel_Request_Item_Num.Controls.Add(this.TextBox_Request_Item_Piece);
            this.Panel_Request_Item_Num.Controls.Add(this.Label_Request_Item_Nums);
            this.Panel_Request_Item_Num.Controls.Add(this.TextBox_Request_Item_Num);
            this.Panel_Request_Item_Num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Request_Item_Num.Location = new System.Drawing.Point(3, 383);
            this.Panel_Request_Item_Num.Name = "Panel_Request_Item_Num";
            this.Panel_Request_Item_Num.Size = new System.Drawing.Size(244, 45);
            this.Panel_Request_Item_Num.TabIndex = 11;
            // 
            // TextBox_Request_Item_Num
            // 
            this.TextBox_Request_Item_Num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Request_Item_Num.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Request_Item_Num.Location = new System.Drawing.Point(7, 7);
            this.TextBox_Request_Item_Num.Name = "TextBox_Request_Item_Num";
            this.TextBox_Request_Item_Num.Size = new System.Drawing.Size(84, 26);
            this.TextBox_Request_Item_Num.TabIndex = 0;
            // 
            // Label_Request_Item_Nums
            // 
            this.Label_Request_Item_Nums.AutoSize = true;
            this.Label_Request_Item_Nums.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_Nums.Location = new System.Drawing.Point(97, 12);
            this.Label_Request_Item_Nums.Name = "Label_Request_Item_Nums";
            this.Label_Request_Item_Nums.Size = new System.Drawing.Size(22, 17);
            this.Label_Request_Item_Nums.TabIndex = 1;
            this.Label_Request_Item_Nums.Text = "종";
            // 
            // Label_Request_Item_Piece
            // 
            this.Label_Request_Item_Piece.AutoSize = true;
            this.Label_Request_Item_Piece.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Request_Item_Piece.Location = new System.Drawing.Point(214, 12);
            this.Label_Request_Item_Piece.Name = "Label_Request_Item_Piece";
            this.Label_Request_Item_Piece.Size = new System.Drawing.Size(22, 17);
            this.Label_Request_Item_Piece.TabIndex = 3;
            this.Label_Request_Item_Piece.Text = "점";
            // 
            // TextBox_Request_Item_Piece
            // 
            this.TextBox_Request_Item_Piece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Request_Item_Piece.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Request_Item_Piece.Location = new System.Drawing.Point(124, 7);
            this.TextBox_Request_Item_Piece.Name = "TextBox_Request_Item_Piece";
            this.TextBox_Request_Item_Piece.Size = new System.Drawing.Size(84, 26);
            this.TextBox_Request_Item_Piece.TabIndex = 2;
            // 
            // DateTimePicker_Request_Item_Date
            // 
            this.DateTimePicker_Request_Item_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTimePicker_Request_Item_Date.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DateTimePicker_Request_Item_Date.Location = new System.Drawing.Point(5, 473);
            this.DateTimePicker_Request_Item_Date.Name = "DateTimePicker_Request_Item_Date";
            this.DateTimePicker_Request_Item_Date.Size = new System.Drawing.Size(240, 26);
            this.DateTimePicker_Request_Item_Date.TabIndex = 12;
            // 
            // RichTextBox_Request_Item_PSText
            // 
            this.RichTextBox_Request_Item_PSText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_Request_Item_PSText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Request_Item_PSText.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RichTextBox_Request_Item_PSText.Location = new System.Drawing.Point(3, 678);
            this.RichTextBox_Request_Item_PSText.Name = "RichTextBox_Request_Item_PSText";
            this.RichTextBox_Request_Item_PSText.Size = new System.Drawing.Size(244, 88);
            this.RichTextBox_Request_Item_PSText.TabIndex = 13;
            this.RichTextBox_Request_Item_PSText.Text = "";
            // 
            // UserControl_DadamRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBox_Request_ItemInfo);
            this.Controls.Add(this.GroupBox_Request_EquipmentInfo);
            this.Controls.Add(this.GroupBox_Request_PersonInfo);
            this.Controls.Add(this.Panel_Request_Num);
            this.Name = "UserControl_DadamRequest";
            this.Size = new System.Drawing.Size(1090, 1182);
            this.Panel_Request_Num.ResumeLayout(false);
            this.Panel_Request_Num.PerformLayout();
            this.GroupBox_Request_PersonInfo.ResumeLayout(false);
            this.GroupBox_Request_EquipmentInfo.ResumeLayout(false);
            this.GroupBox_Request_ItemInfo.ResumeLayout(false);
            this.TableLayoutPanel_Request_Person.ResumeLayout(false);
            this.TableLayoutPanel_Request_Person.PerformLayout();
            this.TableLayoutPanel_Request_Equipment.ResumeLayout(false);
            this.TableLayoutPanel_Request_Equipment.PerformLayout();
            this.TableLayoutPanel_Request_ItemInfo.ResumeLayout(false);
            this.TableLayoutPanel_Request_ItemInfo.PerformLayout();
            this.Panel_Request_Item_Num.ResumeLayout(false);
            this.Panel_Request_Item_Num.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_RequestNum;
        private System.Windows.Forms.Panel Panel_Request_Num;
        private System.Windows.Forms.Label Label_RequestDate;
        private System.Windows.Forms.Label Label_RequestNum;
        private System.Windows.Forms.TextBox TextBox_RequestDate;
        private System.Windows.Forms.GroupBox GroupBox_Request_PersonInfo;
        private System.Windows.Forms.GroupBox GroupBox_Request_EquipmentInfo;
        private System.Windows.Forms.GroupBox GroupBox_Request_ItemInfo;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Request_Person;
        private System.Windows.Forms.Label Label_Request_PersonName;
        private System.Windows.Forms.TextBox TextBox_Request_PersonName;
        private System.Windows.Forms.Label Label_Request_PersonMajor;
        private System.Windows.Forms.Label Label_Request_PersonPhoneNum;
        private System.Windows.Forms.TextBox TextBox_Request_PersonPhoneNum;
        private System.Windows.Forms.ListBox ListBox_Request_PersonMajor;
        private System.Windows.Forms.Label Label_Request_PersonPosition;
        private System.Windows.Forms.ListBox ListBox_Request_PersonPosition;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Request_Equipment;
        private System.Windows.Forms.Label Label_Request_UsePurpose;
        private System.Windows.Forms.Label Label_Request_UseCategory;
        private System.Windows.Forms.ListBox ListBox_Request_UseCategory;
        private System.Windows.Forms.Label Label_Request_EquipmentName;
        private System.Windows.Forms.ListBox ListBox_Request_EquipmentName;
        private System.Windows.Forms.RichTextBox RichTextBox_Request_UsePurpose;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Request_ItemInfo;
        private System.Windows.Forms.Label Label_Request_Item_Num;
        private System.Windows.Forms.Label Label_Request_Item_OX;
        private System.Windows.Forms.ListBox ListBox_Request_Item_OX;
        private System.Windows.Forms.Label Label_Request_Item_Material;
        private System.Windows.Forms.RichTextBox RichTextBox_Request_Item_Material;
        private System.Windows.Forms.Label Label_Request_Item_Date;
        private System.Windows.Forms.Label Label_Request_Item_PSText;
        private System.Windows.Forms.Panel Panel_Request_Item_Num;
        private System.Windows.Forms.Label Label_Request_Item_Piece;
        private System.Windows.Forms.TextBox TextBox_Request_Item_Piece;
        private System.Windows.Forms.Label Label_Request_Item_Nums;
        private System.Windows.Forms.TextBox TextBox_Request_Item_Num;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Request_Item_Date;
        private System.Windows.Forms.RichTextBox RichTextBox_Request_Item_PSText;
    }
}
