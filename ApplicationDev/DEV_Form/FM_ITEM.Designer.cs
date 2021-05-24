
namespace DEV_Form
{
    partial class FM_ITEM
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItemDesc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNameOnly = new System.Windows.Forms.CheckBox();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoEnd = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPicSave = new System.Windows.Forms.Button();
            this.btnPicDelete = new System.Windows.Forms.Button();
            this.LoadPrc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목 코드";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(103, 38);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(183, 25);
            this.txtItemCode.TabIndex = 1;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(355, 37);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(185, 25);
            this.txtItemName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "품목 명";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(624, 37);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(149, 25);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(803, 37);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(146, 25);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "출시 일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // cboItemDesc
            // 
            this.cboItemDesc.FormattingEnabled = true;
            this.cboItemDesc.Items.AddRange(new object[] {
            "롤링 싱글 카메라",
            "롤링 듀얼 카메라",
            "글로벌 듀얼 카메라",
            "글로벌 싱글 카메라",
            "글로벌 듀얼 카메라",
            "발열체크 열화상 스탠드"});
            this.cboItemDesc.Location = new System.Drawing.Point(102, 114);
            this.cboItemDesc.Name = "cboItemDesc";
            this.cboItemDesc.Size = new System.Drawing.Size(184, 23);
            this.cboItemDesc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "품목 상세";
            // 
            // chkNameOnly
            // 
            this.chkNameOnly.AutoSize = true;
            this.chkNameOnly.Location = new System.Drawing.Point(292, 116);
            this.chkNameOnly.Name = "chkNameOnly";
            this.chkNameOnly.Size = new System.Drawing.Size(139, 19);
            this.chkNameOnly.TabIndex = 9;
            this.chkNameOnly.Text = "이름으로만 검색";
            this.chkNameOnly.UseVisualStyleBackColor = true;
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(6, 24);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(58, 19);
            this.rdoProduct.TabIndex = 10;
            this.rdoProduct.Text = "생산";
            this.rdoProduct.UseVisualStyleBackColor = true;
            // 
            // rdoEnd
            // 
            this.rdoEnd.AutoSize = true;
            this.rdoEnd.Checked = true;
            this.rdoEnd.Location = new System.Drawing.Point(78, 24);
            this.rdoEnd.Name = "rdoEnd";
            this.rdoEnd.Size = new System.Drawing.Size(58, 19);
            this.rdoEnd.TabIndex = 10;
            this.rdoEnd.TabStop = true;
            this.rdoEnd.Text = "단종";
            this.rdoEnd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(626, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 45);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkNameOnly);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.cboItemDesc);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조회";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoProduct);
            this.groupBox2.Controls.Add(this.rdoEnd);
            this.groupBox2.Location = new System.Drawing.Point(450, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 58);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "단종 여부";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGrid);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1071, 285);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "품목 정보";
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGrid.Location = new System.Drawing.Point(3, 84);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 51;
            this.dgvGrid.RowTemplate.Height = 27;
            this.dgvGrid.Size = new System.Drawing.Size(1065, 198);
            this.dgvGrid.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 45);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 45);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPicSave);
            this.groupBox4.Controls.Add(this.btnPicDelete);
            this.groupBox4.Controls.Add(this.LoadPrc);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 469);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1071, 280);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "품목 이미지 관리";
            // 
            // btnPicSave
            // 
            this.btnPicSave.Location = new System.Drawing.Point(154, 217);
            this.btnPicSave.Name = "btnPicSave";
            this.btnPicSave.Size = new System.Drawing.Size(101, 35);
            this.btnPicSave.TabIndex = 20;
            this.btnPicSave.Text = "저장";
            this.btnPicSave.UseVisualStyleBackColor = true;
            // 
            // btnPicDelete
            // 
            this.btnPicDelete.Location = new System.Drawing.Point(261, 217);
            this.btnPicDelete.Name = "btnPicDelete";
            this.btnPicDelete.Size = new System.Drawing.Size(90, 35);
            this.btnPicDelete.TabIndex = 19;
            this.btnPicDelete.Text = "삭제";
            this.btnPicDelete.UseVisualStyleBackColor = true;
            // 
            // LoadPrc
            // 
            this.LoadPrc.Location = new System.Drawing.Point(12, 217);
            this.LoadPrc.Name = "LoadPrc";
            this.LoadPrc.Size = new System.Drawing.Size(136, 35);
            this.LoadPrc.TabIndex = 18;
            this.LoadPrc.Text = "이미지 불러오기";
            this.LoadPrc.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 187);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FM_ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_ITEM";
            this.Text = "FM_ITEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_ITEM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboItemDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNameOnly;
        private System.Windows.Forms.RadioButton rdoProduct;
        private System.Windows.Forms.RadioButton rdoEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPicSave;
        private System.Windows.Forms.Button btnPicDelete;
        private System.Windows.Forms.Button LoadPrc;
    }
}