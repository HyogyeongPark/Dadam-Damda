namespace Dadam_Damda
{
    partial class Dadam_Lookup_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dadam_Lookup_Form));
            this.Panel_MainMenuButton = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dadam_requestDataSet = new Dadam_Damda.dadam_requestDataSet();
            this.requestallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.request_allTableAdapter = new Dadam_Damda.dadam_requestDataSetTableAdapters.request_allTableAdapter();
            this.requestallBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Button_Request_SearchAll = new System.Windows.Forms.Button();
            this.Panel_MainMenuButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadam_requestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestallBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_MainMenuButton
            // 
            this.Panel_MainMenuButton.AutoScroll = true;
            this.Panel_MainMenuButton.BackColor = System.Drawing.Color.White;
            this.Panel_MainMenuButton.Controls.Add(this.Button_Request_SearchAll);
            this.Panel_MainMenuButton.Controls.Add(this.dataGridView2);
            this.Panel_MainMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainMenuButton.Location = new System.Drawing.Point(0, 0);
            this.Panel_MainMenuButton.Name = "Panel_MainMenuButton";
            this.Panel_MainMenuButton.Size = new System.Drawing.Size(1264, 979);
            this.Panel_MainMenuButton.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(39, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1147, 693);
            this.dataGridView2.TabIndex = 8;
            // 
            // dadam_requestDataSet
            // 
            this.dadam_requestDataSet.DataSetName = "dadam_requestDataSet";
            this.dadam_requestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestallBindingSource
            // 
            this.requestallBindingSource.DataMember = "request_all";
            this.requestallBindingSource.DataSource = this.dadam_requestDataSet;
            // 
            // request_allTableAdapter
            // 
            this.request_allTableAdapter.ClearBeforeFill = true;
            // 
            // requestallBindingSource1
            // 
            this.requestallBindingSource1.DataMember = "request_all";
            this.requestallBindingSource1.DataSource = this.dadam_requestDataSet;
            // 
            // Button_Request_SearchAll
            // 
            this.Button_Request_SearchAll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Button_Request_SearchAll.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Button_Request_SearchAll.FlatAppearance.BorderSize = 0;
            this.Button_Request_SearchAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Request_SearchAll.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Request_SearchAll.ForeColor = System.Drawing.Color.White;
            this.Button_Request_SearchAll.Image = global::Dadam_Damda.Properties.Resources.add_white251;
            this.Button_Request_SearchAll.Location = new System.Drawing.Point(1075, 39);
            this.Button_Request_SearchAll.Name = "Button_Request_SearchAll";
            this.Button_Request_SearchAll.Size = new System.Drawing.Size(111, 46);
            this.Button_Request_SearchAll.TabIndex = 9;
            this.Button_Request_SearchAll.Text = "전체조회";
            this.Button_Request_SearchAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button_Request_SearchAll.UseVisualStyleBackColor = false;
            this.Button_Request_SearchAll.Click += new System.EventHandler(this.Button_Request_SearchAll_Click);
            // 
            // Dadam_Lookup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 979);
            this.Controls.Add(this.Panel_MainMenuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 1047);
            this.MinimumSize = new System.Drawing.Size(1280, 961);
            this.Name = "Dadam_Lookup_Form";
            this.Text = "Dadam을 담다 조회";
            this.Load += new System.EventHandler(this.Dadam_Lookup_Form_Load);
            this.Panel_MainMenuButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadam_requestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestallBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_MainMenuButton;
        private dadam_requestDataSet dadam_requestDataSet;
        private System.Windows.Forms.BindingSource requestallBindingSource;
        private dadam_requestDataSetTableAdapters.request_allTableAdapter request_allTableAdapter;
        private System.Windows.Forms.BindingSource requestallBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Button_Request_SearchAll;
    }
}