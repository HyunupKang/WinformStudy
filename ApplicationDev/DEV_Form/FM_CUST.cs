using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDev;

namespace DEV_Form
{
    public partial class FM_CUST : Form, ChildInterface
    {
        #region connettion Init
        private SqlConnection Connect = null; // 접속 정보 객체
        private string strCon = Common.db;//"Data Source = 222.235.141.8; Initial Catalog = AppDev; USER ID = kfqs1; Password = 1234"; // 접속주소 
        #endregion
        public FM_CUST()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                #region Connection open
                Connect = new SqlConnection(strCon);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다");
                    return;
                }
                #endregion

                #region variable Init
                string sCustCode = txtCustCode.Text;
                string sCustName = txtCustName.Text;
                string sCustSartDate = dtpCustStart.Text;
                string sCusEndDate = dtpCustEnd.Text;
                string sCustType = "";    // "" 과 null은 각 다른 데이터값으로 들어간다. 그래서 조회를 할때 조건을 다르게 해야한다. 그리고 ""은 문자열!! 문자열이 없다는 뜻
                string sCustRdo = "";

                //  고객사만 검색
                if (chkCusOnly.Checked == true) sCustType = "C";

                //  라디오 버튼에 따른 상태값 구분                
                if (rdoCVProduct.Checked == true) sCustRdo = "상용차 부품";
                else if (rdoVProduct.Checked == true) sCustRdo = "자동차부품";
                else if (rdoCutProduct.Checked == true) sCustRdo = "절삭가공";
                else if (rdoPumpProduct.Checked == true) sCustRdo = "펌프압축기";
                #endregion

                #region Fill data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CUSTCODE,  " +
                                                            "       case when CUSTTYPE = 'c' then '거래처' else '협력사' end as CUSTTYPE,  " +
                                                            "       CUSTNAME,  " +
                                                            "       BIZCLASS,  " +
                                                            "       BIZTYPE,  " +
                                                            "       CASE WHEN USEFLAG = 'Y' THEN '사용' ELSE '미사용' END AS USEFLAG,  " +
                                                            "       FIRSTDATE,  " +
                                                            "       MAKEDATE,  " +
                                                            "       MAKER,  " +
                                                            "       EDITDATE,  " +
                                                            "       EDITOR  " +
                                                            "  FROM TB_CUST_KHU WITH(NOLOCK) " +
                                                            " WHERE CUSTTYPE LIKE '%" + sCustType + "%' " +
                                                            "   AND CUSTNAME LIKE '%" + sCustName + "%' " + // 만약 '%' '' '%'으로 하면 모든 데이터 조회다
                                                            "   AND CUSTCODE LIKE '%" + sCustCode + "%' " +
                                                            "   AND BIZTYPE LIKE '%" + sCustRdo + "%' " +
                                                            "   AND FIRSTDATE BETWEEN '" + sCustSartDate + "' AND '" + sCusEndDate + "'", Connect);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);
                #endregion

                #region Show DataGrid
                if (dtTemp.Rows.Count == 0)
                {
                    dgvCGrid.DataSource = null;
                    return;
                }
                dgvCGrid.DataSource = dtTemp; // 데이터 그리드 뷰에 데이터 테이블 등록
                #endregion

                #region Colums Set
                // 그리드뷰의 헤더 명칭 선언
                dgvCGrid.Columns["CUSTCODE"].HeaderText = "거래처 코드";
                dgvCGrid.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                dgvCGrid.Columns["CUSTNAME"].HeaderText = "거래처 명";
                dgvCGrid.Columns["BIZCLASS"].HeaderText = "업태";
                dgvCGrid.Columns["BIZTYPE"].HeaderText = "종목";
                dgvCGrid.Columns["USEFLAG"].HeaderText = "사용여부";
                dgvCGrid.Columns["FIRSTDATE"].HeaderText = "거래일자";
                dgvCGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dgvCGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvCGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvCGrid.Columns["EDITOR"].HeaderText = "수정자";

                // 그리드 뷰의 폭 지정
                dgvCGrid.Columns[0].Width = 100;
                dgvCGrid.Columns[1].Width = 200;
                dgvCGrid.Columns[2].Width = 200;
                dgvCGrid.Columns[3].Width = 200;
                dgvCGrid.Columns[4].Width = 100;

                // 칼럼의 수정 여부를 지정한다.
                dgvCGrid.Columns["CUSTCODE"].ReadOnly = true;
                dgvCGrid.Columns["CUSTTYPE"].ReadOnly = true;
                dgvCGrid.Columns["MAKER"].ReadOnly = true;          
                dgvCGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvCGrid.Columns["EDITOR"].ReadOnly = true;
                dgvCGrid.Columns["EDITDATE"].ReadOnly = true;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            if (dgvCGrid.DataSource == null)
            {
                MessageBox.Show("조회를 누르시오");
                return;
            }
            // 데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvCGrid.DataSource).NewRow();  // dgvGrid와 같은 형태를 datatale로 변환하고, 새로운 row 생성
            ((DataTable)dgvCGrid.DataSource).Rows.Add(dr);           // 빈 테이블 dr에 값 넣음
            dgvCGrid.Columns["CUSTCODE"].ReadOnly = false;           // 키값을 추가를 해야할 경우 false로,
            dgvCGrid.Columns["CUSTTYPE"].ReadOnly = false;           // 키값을 추가를 해야할 경우 false로,

            // 추가된 행 전체 선택
            int Maxrow = dgvCGrid.Rows.Count - 1;
            dgvCGrid.Rows[Maxrow].Selected = true;
            dgvCGrid.CurrentCell = dgvCGrid.Rows[Maxrow].Cells[0];
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            //선택된 행을 삭제 한다.
            if (this.dgvCGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strCon);
            Connect.Open();

            // 트랜잭션 관리를 위한 권한 위임
            tran = Connect.BeginTransaction("TranStart");
            cmd.Transaction = tran;
            cmd.Connection = Connect;

            try
            {
                string CustCode = dgvCGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_CUST_KHU WHERE CUSTCODE = '" + CustCode + "'";
                cmd.ExecuteNonQuery();

                // 성공 시 DB commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제 하였습니다.");
                btnSearch_Click(null, null); // 데이터 재조회
            }
            catch (Exception)
            {
                tran.Rollback();
                MessageBox.Show("데이터 삭제에 실패했습니다");
            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnCSave_Click(object sender, EventArgs e)
        {
            // 선택된 행 데이터 저장
            if (dgvCGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 등록 하시겠습니까?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string sCustCode = dgvCGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
            string sCustType = dgvCGrid.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
            string sCustName = dgvCGrid.CurrentRow.Cells["CUSTNAME"].Value.ToString();
            string sBIZCLASS = dgvCGrid.CurrentRow.Cells["BIZCLASS"].Value.ToString();
            string sBIZTYPE = dgvCGrid.CurrentRow.Cells["BIZTYPE"].Value.ToString();
            string sFIRSTDATE = dgvCGrid.CurrentRow.Cells["FIRSTDATE"].Value.ToString();
            string sUSEFLAG = dgvCGrid.CurrentRow.Cells["USEFLAG"].Value.ToString();

            if (    (sCustCode.ToString() == "") || (sCustType.ToString() == "") || (sFIRSTDATE.ToString() == "")  )
            {
                MessageBox.Show("전부 기입 하시오");
                return;
            }

            if (sCustType == "고객사") sCustType = "C";
            else if (sCustType == "협력사") sCustType = "V";
            else sCustType = "C";

            if (sUSEFLAG == "사용") sUSEFLAG = "Y";
            else if (sUSEFLAG == "미사용") sUSEFLAG = "N";
            else sUSEFLAG = "Y";

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strCon);
            Connect.Open();

            //트랜잭션 설정
            Tran = Connect.BeginTransaction("CUSTTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;
            cmd.CommandText = "UPDATE TB_CUST_KHU                                " +            // 코드와 타입은 업데이트하면 안되니 SET에서 지움. 그리고 where에 작성
                              "    SET CUSTNAME         = '" + sCustName + "',    " +
                              "        BIZCLASS         = '" + sBIZCLASS + "',    " +
                              "        BIZTYPE         = '" + sBIZTYPE + "',    " +
                              "        USEFLAG         = '" + sUSEFLAG + "',    " +
                              "        FIRSTDATE         = '" + sFIRSTDATE + "',    " +
                              "        EDITOR = '" + Common.LoginID + "',  " +
                              "        EDITDATE = GETDATE()                          " +
                              "  WHERE CUSTCODE = '" + sCustCode + "'" +
                              "    AND CUSTTYPE = '" + sCustType + "'" + 
                              " IF (@@ROWCOUNT =0) " +
                              "INSERT INTO TB_CUST_KHU(CUSTCODE,           CUSTTYPE,            CUSTNAME,           BIZCLASS,          BIZTYPE,           USEFLAG,      FIRSTDATE,     MAKEDATE,   MAKER) " +
                              "VALUES('" + sCustCode + "','" + sCustType + "','" + sCustName + "','" + sBIZCLASS + "', '" + sBIZTYPE + "', '" + sUSEFLAG + "','" + sFIRSTDATE + "',GETDATE(),'" + Common.LoginID + "')";                           

            cmd.ExecuteNonQuery();

            //  성공 시 DB COMMIT
            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Connect.Close();
        }

        private void FM_CUST_Load(object sender, EventArgs e)
        {
            dtpCustStart.Text = string.Format("{0:2010-MM-01}", DateTime.Now); // 출시일자의 시작 날짜 지정
        }

        private void txtCustCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        public void inquire()
        {
            btnSearch_Click(null, null);
        }

        public void DoNew()
        {
            btnCAdd_Click(null, null);
        }

        public void Delete()
        {
            btnCDelete_Click(null, null);
        }

        public void Save()
        {
            btnCSave_Click(null, null);
        }
    }
}
