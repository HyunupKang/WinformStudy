
namespace ApplicationDev
{
    partial class FM_Main
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
            this.Menustrip = new System.Windows.Forms.MenuStrip();
            this.M_SYSTEM = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_TEST = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI_TEST2 = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_ITEM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.stbSearch = new System.Windows.Forms.ToolStripButton();
            this.stbInsert = new System.Windows.Forms.ToolStripButton();
            this.stbDelete = new System.Windows.Forms.ToolStripButton();
            this.stbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stbClose = new System.Windows.Forms.ToolStripButton();
            this.stbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FM_CUST = new System.Windows.Forms.ToolStripMenuItem();
            this.myTabControl1 = new ApplicationDev.MyTabControl();
            this.Menustrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menustrip
            // 
            this.Menustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_SYSTEM});
            this.Menustrip.Location = new System.Drawing.Point(0, 0);
            this.Menustrip.Name = "Menustrip";
            this.Menustrip.Size = new System.Drawing.Size(922, 28);
            this.Menustrip.TabIndex = 0;
            // 
            // M_SYSTEM
            // 
            this.M_SYSTEM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MDI_TEST,
            this.MDI_TEST2,
            this.FM_ITEM,
            this.FM_CUST});
            this.M_SYSTEM.Name = "M_SYSTEM";
            this.M_SYSTEM.Size = new System.Drawing.Size(98, 24);
            this.M_SYSTEM.Text = "시스템관리";
            this.M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MDI_TEST_DropDownItemClicked);
            // 
            // MDI_TEST
            // 
            this.MDI_TEST.Name = "MDI_TEST";
            this.MDI_TEST.Size = new System.Drawing.Size(175, 26);
            this.MDI_TEST.Text = "테스트 화면";
            // 
            // MDI_TEST2
            // 
            this.MDI_TEST2.Name = "MDI_TEST2";
            this.MDI_TEST2.Size = new System.Drawing.Size(175, 26);
            this.MDI_TEST2.Text = "테스트화면2";
            // 
            // FM_ITEM
            // 
            this.FM_ITEM.Name = "FM_ITEM";
            this.FM_ITEM.Size = new System.Drawing.Size(175, 26);
            this.FM_ITEM.Text = "품목 관리";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbSearch,
            this.stbInsert,
            this.stbDelete,
            this.stbSave,
            this.toolStripSeparator1,
            this.stbClose,
            this.stbExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(922, 102);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // stbSearch
            // 
            this.stbSearch.Image = global::ApplicationDev.Properties.Resources.BtnSearch;
            this.stbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbSearch.Name = "stbSearch";
            this.stbSearch.Size = new System.Drawing.Size(54, 99);
            this.stbSearch.Text = "조회";
            this.stbSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbInsert
            // 
            this.stbInsert.Image = global::ApplicationDev.Properties.Resources.BtnAdd;
            this.stbInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbInsert.Name = "stbInsert";
            this.stbInsert.Size = new System.Drawing.Size(54, 99);
            this.stbInsert.Text = "추가";
            this.stbInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbDelete
            // 
            this.stbDelete.Image = global::ApplicationDev.Properties.Resources.BtnDelete;
            this.stbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbDelete.Name = "stbDelete";
            this.stbDelete.Size = new System.Drawing.Size(54, 99);
            this.stbDelete.Text = "삭제";
            this.stbDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stbSave
            // 
            this.stbSave.Image = global::ApplicationDev.Properties.Resources.BtnSaveB;
            this.stbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbSave.Name = "stbSave";
            this.stbSave.Size = new System.Drawing.Size(54, 99);
            this.stbSave.Text = "저장";
            this.stbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 102);
            // 
            // stbClose
            // 
            this.stbClose.Image = global::ApplicationDev.Properties.Resources.BtnClose;
            this.stbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbClose.Name = "stbClose";
            this.stbClose.Size = new System.Drawing.Size(54, 99);
            this.stbClose.Text = "닫기";
            this.stbClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbClose.Click += new System.EventHandler(this.stbClose_Click);
            // 
            // stbExit
            // 
            this.stbExit.Image = global::ApplicationDev.Properties.Resources.BtcExit;
            this.stbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbExit.Name = "stbExit";
            this.stbExit.Size = new System.Drawing.Size(54, 99);
            this.stbExit.Text = "종료";
            this.stbExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stbExit.Click += new System.EventHandler(this.stbExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSpace,
            this.tssUserName,
            this.tssNowDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(922, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // tssSpace
            // 
            this.tssSpace.AutoSize = false;
            this.tssSpace.Name = "tssSpace";
            this.tssSpace.Size = new System.Drawing.Size(1, 20);
            this.tssSpace.Text = "       ";
            // 
            // tssUserName
            // 
            this.tssUserName.AutoSize = false;
            this.tssUserName.Name = "tssUserName";
            this.tssUserName.Size = new System.Drawing.Size(300, 20);
            this.tssUserName.Text = "toolStripStatusLabel2";
            // 
            // tssNowDate
            // 
            this.tssNowDate.AutoSize = false;
            this.tssNowDate.Name = "tssNowDate";
            this.tssNowDate.Size = new System.Drawing.Size(300, 20);
            this.tssNowDate.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FM_CUST
            // 
            this.FM_CUST.Name = "FM_CUST";
            this.FM_CUST.Size = new System.Drawing.Size(175, 26);
            this.FM_CUST.Text = "고객사 관리";
            // 
            // myTabControl1
            // 
            this.myTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabControl1.Location = new System.Drawing.Point(0, 130);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(922, 369);
            this.myTabControl1.TabIndex = 4;
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 525);
            this.Controls.Add(this.myTabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.Menustrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menustrip;
            this.Name = "FM_Main";
            this.Text = "FM_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menustrip.ResumeLayout(false);
            this.Menustrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menustrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem M_SYSTEM;
        private System.Windows.Forms.ToolStripMenuItem MDI_TEST;
        private System.Windows.Forms.ToolStripButton stbSearch;
        private System.Windows.Forms.ToolStripButton stbInsert;
        private System.Windows.Forms.ToolStripButton stbDelete;
        private System.Windows.Forms.ToolStripButton stbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton stbClose;
        private System.Windows.Forms.ToolStripButton stbExit;
        private System.Windows.Forms.ToolStripStatusLabel tssSpace;
        private System.Windows.Forms.ToolStripStatusLabel tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssNowDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem MDI_TEST2;
        private MyTabControl myTabControl1;
        private System.Windows.Forms.ToolStripMenuItem FM_ITEM;
        private System.Windows.Forms.ToolStripMenuItem FM_CUST;
        // private UserControl1 userControl11;
    }
}