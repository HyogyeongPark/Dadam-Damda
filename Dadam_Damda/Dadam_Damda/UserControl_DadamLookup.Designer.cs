namespace Dadam_Damda
{
    partial class UserControl_DadamLookup
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Request_Lookup = new System.Windows.Forms.Button();
            this.dadam_requestDataSet = new Dadam_Damda.dadam_requestDataSet();
            this.dadamrequestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.request_allTableAdapter = new Dadam_Damda.dadam_requestDataSetTableAdapters.request_allTableAdapter();
            this.requestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestpurposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requesthopeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadam_requestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadamrequestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestidDataGridViewTextBoxColumn,
            this.requestdateDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userphoneDataGridViewTextBoxColumn,
            this.usermajorDataGridViewTextBoxColumn,
            this.userpositionDataGridViewTextBoxColumn,
            this.equipmentnameDataGridViewTextBoxColumn,
            this.requestcategoryDataGridViewTextBoxColumn,
            this.requestpurposeDataGridViewTextBoxColumn,
            this.itemmaterialDataGridViewTextBoxColumn,
            this.itemownDataGridViewTextBoxColumn,
            this.itemnumDataGridViewTextBoxColumn,
            this.itempieceDataGridViewTextBoxColumn,
            this.requesthopeDateDataGridViewTextBoxColumn,
            this.requestpsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 877);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Look up page";
            // 
            // Button_Request_Lookup
            // 
            this.Button_Request_Lookup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Button_Request_Lookup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_Request_Lookup.FlatAppearance.BorderSize = 0;
            this.Button_Request_Lookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Request_Lookup.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Request_Lookup.ForeColor = System.Drawing.Color.White;
            this.Button_Request_Lookup.Image = global::Dadam_Damda.Properties.Resources.add_white251;
            this.Button_Request_Lookup.Location = new System.Drawing.Point(954, 20);
            this.Button_Request_Lookup.Name = "Button_Request_Lookup";
            this.Button_Request_Lookup.Size = new System.Drawing.Size(111, 46);
            this.Button_Request_Lookup.TabIndex = 5;
            this.Button_Request_Lookup.Text = "조회";
            this.Button_Request_Lookup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button_Request_Lookup.UseVisualStyleBackColor = false;
            this.Button_Request_Lookup.Click += new System.EventHandler(this.Button_Request_Lookup_Click);
            // 
            // dadam_requestDataSet
            // 
            this.dadam_requestDataSet.DataSetName = "dadam_requestDataSet";
            this.dadam_requestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadamrequestDataSetBindingSource
            // 
            this.dadamrequestDataSetBindingSource.DataSource = this.dadam_requestDataSet;
            this.dadamrequestDataSetBindingSource.Position = 0;
            // 
            // requestallBindingSource
            // 
            this.requestallBindingSource.DataMember = "request_all";
            this.requestallBindingSource.DataSource = this.dadamrequestDataSetBindingSource;
            // 
            // request_allTableAdapter
            // 
            this.request_allTableAdapter.ClearBeforeFill = true;
            // 
            // requestidDataGridViewTextBoxColumn
            // 
            this.requestidDataGridViewTextBoxColumn.DataPropertyName = "request_id";
            this.requestidDataGridViewTextBoxColumn.HeaderText = "request_id";
            this.requestidDataGridViewTextBoxColumn.Name = "requestidDataGridViewTextBoxColumn";
            // 
            // requestdateDataGridViewTextBoxColumn
            // 
            this.requestdateDataGridViewTextBoxColumn.DataPropertyName = "request_date";
            this.requestdateDataGridViewTextBoxColumn.HeaderText = "request_date";
            this.requestdateDataGridViewTextBoxColumn.Name = "requestdateDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // userphoneDataGridViewTextBoxColumn
            // 
            this.userphoneDataGridViewTextBoxColumn.DataPropertyName = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.HeaderText = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.Name = "userphoneDataGridViewTextBoxColumn";
            // 
            // usermajorDataGridViewTextBoxColumn
            // 
            this.usermajorDataGridViewTextBoxColumn.DataPropertyName = "user_major";
            this.usermajorDataGridViewTextBoxColumn.HeaderText = "user_major";
            this.usermajorDataGridViewTextBoxColumn.Name = "usermajorDataGridViewTextBoxColumn";
            // 
            // userpositionDataGridViewTextBoxColumn
            // 
            this.userpositionDataGridViewTextBoxColumn.DataPropertyName = "user_position";
            this.userpositionDataGridViewTextBoxColumn.HeaderText = "user_position";
            this.userpositionDataGridViewTextBoxColumn.Name = "userpositionDataGridViewTextBoxColumn";
            // 
            // equipmentnameDataGridViewTextBoxColumn
            // 
            this.equipmentnameDataGridViewTextBoxColumn.DataPropertyName = "equipment_name";
            this.equipmentnameDataGridViewTextBoxColumn.HeaderText = "equipment_name";
            this.equipmentnameDataGridViewTextBoxColumn.Name = "equipmentnameDataGridViewTextBoxColumn";
            // 
            // requestcategoryDataGridViewTextBoxColumn
            // 
            this.requestcategoryDataGridViewTextBoxColumn.DataPropertyName = "request_category";
            this.requestcategoryDataGridViewTextBoxColumn.HeaderText = "request_category";
            this.requestcategoryDataGridViewTextBoxColumn.Name = "requestcategoryDataGridViewTextBoxColumn";
            // 
            // requestpurposeDataGridViewTextBoxColumn
            // 
            this.requestpurposeDataGridViewTextBoxColumn.DataPropertyName = "request_purpose";
            this.requestpurposeDataGridViewTextBoxColumn.HeaderText = "request_purpose";
            this.requestpurposeDataGridViewTextBoxColumn.Name = "requestpurposeDataGridViewTextBoxColumn";
            // 
            // itemmaterialDataGridViewTextBoxColumn
            // 
            this.itemmaterialDataGridViewTextBoxColumn.DataPropertyName = "item_material";
            this.itemmaterialDataGridViewTextBoxColumn.HeaderText = "item_material";
            this.itemmaterialDataGridViewTextBoxColumn.Name = "itemmaterialDataGridViewTextBoxColumn";
            // 
            // itemownDataGridViewTextBoxColumn
            // 
            this.itemownDataGridViewTextBoxColumn.DataPropertyName = "item_own";
            this.itemownDataGridViewTextBoxColumn.HeaderText = "item_own";
            this.itemownDataGridViewTextBoxColumn.Name = "itemownDataGridViewTextBoxColumn";
            // 
            // itemnumDataGridViewTextBoxColumn
            // 
            this.itemnumDataGridViewTextBoxColumn.DataPropertyName = "item_num";
            this.itemnumDataGridViewTextBoxColumn.HeaderText = "item_num";
            this.itemnumDataGridViewTextBoxColumn.Name = "itemnumDataGridViewTextBoxColumn";
            // 
            // itempieceDataGridViewTextBoxColumn
            // 
            this.itempieceDataGridViewTextBoxColumn.DataPropertyName = "item_piece";
            this.itempieceDataGridViewTextBoxColumn.HeaderText = "item_piece";
            this.itempieceDataGridViewTextBoxColumn.Name = "itempieceDataGridViewTextBoxColumn";
            // 
            // requesthopeDateDataGridViewTextBoxColumn
            // 
            this.requesthopeDateDataGridViewTextBoxColumn.DataPropertyName = "request_hopeDate";
            this.requesthopeDateDataGridViewTextBoxColumn.HeaderText = "request_hopeDate";
            this.requesthopeDateDataGridViewTextBoxColumn.Name = "requesthopeDateDataGridViewTextBoxColumn";
            // 
            // requestpsDataGridViewTextBoxColumn
            // 
            this.requestpsDataGridViewTextBoxColumn.DataPropertyName = "request_ps";
            this.requestpsDataGridViewTextBoxColumn.HeaderText = "request_ps";
            this.requestpsDataGridViewTextBoxColumn.Name = "requestpsDataGridViewTextBoxColumn";
            // 
            // UserControl_DadamLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Button_Request_Lookup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl_DadamLookup";
            this.Size = new System.Drawing.Size(1090, 1010);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadam_requestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadamrequestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Request_Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usermajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestpurposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requesthopeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestpsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource requestallBindingSource;
        private System.Windows.Forms.BindingSource dadamrequestDataSetBindingSource;
        private dadam_requestDataSet dadam_requestDataSet;
        private dadam_requestDataSetTableAdapters.request_allTableAdapter request_allTableAdapter;
    }
}
