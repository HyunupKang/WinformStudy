using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_Form
{
    public partial class FM_USER : BaseMDIChildForm
    {
        public FM_USER()
        {
            InitializeComponent();
        }
        public override void inquire()
        {
            base.inquire();

            // DBHelper 선언
            DBHelper helper = new DBHelper(false);  // 조회할때는 Transection이 필요 없으니까 false

            try
            {
                string sUserId = txtUserID.Text;
                string sUserName = txtUserName.Text;
                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_USER_KHU_S1", CommandType.StoredProcedure, helper.CreateParameter("USERID",sUserId),helper.CreateParameter("USERNAME", sUserName));

                if(dtTemp.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("조회할 데이터가 없습니다");
                }
                else
                {
                    // 그리드 뷰에 데이터 삽입.
                    dataGridView1.DataSource = dtTemp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }
        public override void Delete()
        {
            base.Delete();
            if (dataGridView1.Rows.Count == 0) return;
            int iSelectIndex = dataGridView1.CurrentCell.RowIndex;
            DataTable dtTemp = (DataTable)dataGridView1.DataSource; // DataSource는 연동하는 개념임. 데이터소스에 데이터 넣고 땡이 아니라 연동
            dtTemp.Rows[iSelectIndex].Delete();
        }
        public override void DoNew()
        {
            base.DoNew();
            DataRow dr = ((DataTable)dataGridView1.DataSource).NewRow();
            ((DataTable)dataGridView1.DataSource).Rows.Add(dr);
        }
    }
}
