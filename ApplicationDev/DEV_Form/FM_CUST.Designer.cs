
namespace DEV_Form
{
    partial class FM_CUST
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoCutProduct = new System.Windows.Forms.RadioButton();
            this.rdoVProduct = new System.Windows.Forms.RadioButton();
            this.rdoCVProduct = new System.Windows.Forms.RadioButton();
            this.rdoPumpProduct = new System.Windows.Forms.RadioButton();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCusOnly = new System.Windows.Forms.CheckBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.dtpCustStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCustEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCSave = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCGrid = new System.Windows.Forms.DataGridView();
            this.rboAll = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rboAll);
            this.groupBox2.Controls.Add(this.rdoCutProduct);
            this.groupBox2.Controls.Add(this.rdoVProduct);
            this.groupBox2.Controls.Add(this.rdoCVProduct);
            this.groupBox2.Controls.Add(this.rdoPumpProduct);
            this.groupBox2.Location = new System.Drawing.Point(229, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 70);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "종목";
            // 
            // rdoCutProduct
            // 
            this.rdoCutProduct.AutoSize = true;
            this.rdoCutProduct.Location = new System.Drawing.Point(247, 36);
            this.rdoCutProduct.Name = "rdoCutProduct";
            this.rdoCutProduct.Size = new System.Drawing.Size(88, 19);
            this.rdoCutProduct.TabIndex = 12;
            this.rdoCutProduct.Text = "절삭가공";
            this.rdoCutProduct.UseVisualStyleBackColor = true;
            // 
            // rdoVProduct
            // 
            this.rdoVProduct.AutoSize = true;
            this.rdoVProduct.Location = new System.Drawing.Point(133, 36);
            this.rdoVProduct.Name = "rdoVProduct";
            this.rdoVProduct.Size = new System.Drawing.Size(108, 19);
            this.rdoVProduct.TabIndex = 11;
            this.rdoVProduct.Text = "자동차 부품";
            this.rdoVProduct.UseVisualStyleBackColor = true;
            // 
            // rdoCVProduct
            // 
            this.rdoCVProduct.AutoSize = true;
            this.rdoCVProduct.Location = new System.Drawing.Point(19, 39);
            this.rdoCVProduct.Name = "rdoCVProduct";
            this.rdoCVProduct.Size = new System.Drawing.Size(108, 19);
            this.rdoCVProduct.TabIndex = 10;
            this.rdoCVProduct.Text = "상용차 부품";
            this.rdoCVProduct.UseVisualStyleBackColor = true;
            // 
            // rdoPumpProduct
            // 
            this.rdoPumpProduct.AutoSize = true;
            this.rdoPumpProduct.Checked = true;
            this.rdoPumpProduct.Location = new System.Drawing.Point(345, 36);
            this.rdoPumpProduct.Name = "rdoPumpProduct";
            this.rdoPumpProduct.Size = new System.Drawing.Size(103, 19);
            this.rdoPumpProduct.TabIndex = 10;
            this.rdoPumpProduct.Text = "펌프압축기";
            this.rdoPumpProduct.UseVisualStyleBackColor = true;
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(115, 55);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(183, 25);
            this.txtCustCode.TabIndex = 16;
            this.txtCustCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustCode_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(847, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 45);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "거래처 코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "거래처 명";
            // 
            // chkCusOnly
            // 
            this.chkCusOnly.AutoSize = true;
            this.chkCusOnly.Location = new System.Drawing.Point(85, 109);
            this.chkCusOnly.Name = "chkCusOnly";
            this.chkCusOnly.Size = new System.Drawing.Size(124, 19);
            this.chkCusOnly.TabIndex = 24;
            this.chkCusOnly.Text = "고객사만 검색";
            this.chkCusOnly.UseVisualStyleBackColor = true;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(385, 55);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(185, 25);
            this.txtCustName.TabIndex = 18;
            this.txtCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustName_KeyDown);
            // 
            // dtpCustStart
            // 
            this.dtpCustStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustStart.Location = new System.Drawing.Point(713, 56);
            this.dtpCustStart.Name = "dtpCustStart";
            this.dtpCustStart.Size = new System.Drawing.Size(149, 25);
            this.dtpCustStart.TabIndex = 19;
            this.dtpCustStart.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "~";
            // 
            // dtpCustEnd
            // 
            this.dtpCustEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustEnd.Location = new System.Drawing.Point(892, 56);
            this.dtpCustEnd.Name = "dtpCustEnd";
            this.dtpCustEnd.Size = new System.Drawing.Size(146, 25);
            this.dtpCustEnd.TabIndex = 20;
            this.dtpCustEnd.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "거래 일자";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustCode);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpCustEnd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpCustStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.chkCusOnly);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1428, 194);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "거래처 조회";
            // 
            // btnCSave
            // 
            this.btnCSave.Location = new System.Drawing.Point(222, 24);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(107, 45);
            this.btnCSave.TabIndex = 30;
            this.btnCSave.Text = "저장";
            this.btnCSave.UseVisualStyleBackColor = true;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.Location = new System.Drawing.Point(335, 24);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(107, 45);
            this.btnCDelete.TabIndex = 29;
            this.btnCDelete.Text = "삭제";
            this.btnCDelete.UseVisualStyleBackColor = true;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(109, 24);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(107, 45);
            this.btnCAdd.TabIndex = 28;
            this.btnCAdd.Text = "추가";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCAdd);
            this.groupBox3.Controls.Add(this.btnCSave);
            this.groupBox3.Controls.Add(this.btnCDelete);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1428, 87);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "거래처 정보";
            // 
            // dgvCGrid
            // 
            this.dgvCGrid.AllowUserToAddRows = false;
            this.dgvCGrid.AllowUserToDeleteRows = false;
            this.dgvCGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCGrid.Location = new System.Drawing.Point(0, 281);
            this.dgvCGrid.Name = "dgvCGrid";
            this.dgvCGrid.RowHeadersWidth = 51;
            this.dgvCGrid.RowTemplate.Height = 27;
            this.dgvCGrid.Size = new System.Drawing.Size(1428, 467);
            this.dgvCGrid.TabIndex = 32;
            // 
            // rboAll
            // 
            this.rboAll.AutoSize = true;
            this.rboAll.Location = new System.Drawing.Point(454, 36);
            this.rboAll.Name = "rboAll";
            this.rboAll.Size = new System.Drawing.Size(58, 19);
            this.rboAll.TabIndex = 13;
            this.rboAll.Text = "전체";
            this.rboAll.UseVisualStyleBackColor = true;
            // 
            // FM_CUST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 748);
            this.Controls.Add(this.dgvCGrid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_CUST";
            this.Text = "FM_CUST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_CUST_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoCVProduct;
        private System.Windows.Forms.RadioButton rdoPumpProduct;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCusOnly;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.DateTimePicker dtpCustStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCustEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoCutProduct;
        private System.Windows.Forms.RadioButton rdoVProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCSave;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCGrid;
        private System.Windows.Forms.RadioButton rboAll;
    }
}