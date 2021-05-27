using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ApplicationDev;
using System.IO;

namespace DEV_Form
{
    public partial class FM_ITEM : Form , ChildInterface
    {
        private SqlConnection Connect = null; // 접속 정보 객체
        private string strCon = "Data Source = 222.235.141.8; Initial Catalog = AppDev; USER ID = kfqs1; Password = 1234"; // 접속주소

        public FM_ITEM()
        {
            InitializeComponent();
        }
        public void inquire()
        {
            btnSearch_Click(null,null);
        }

        public void DoNew()
        {
            btnAdd_Click(null, null);
        }

        public void Delete()
        {
            btnDelete_Click(null, null);
        }

        public void Save()
        {
            btnSave_Click(null, null);
        }

        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            try
            {
                //  콤보박스 품목 상세 데이터 조회 및 추가
                //  접속 정보 커넥션에 등록 및 객체 선언
                Connect = new SqlConnection(strCon);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다");
                    return;
                }

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ITEMDESC FROM TB_TESTITEM_KHU", Connect);
                DataTable dtTemp       = new DataTable();
                adapter.Fill(dtTemp);

                cboItemDesc.DataSource    = dtTemp;
                cboItemDesc.DisplayMember = "ITEMDESC"; // 눈으로 보여줄 항목
                cboItemDesc.ValueMember   = "ITEMDESC"; // 실제 데이터를 처리할 코드 항목
                cboItemDesc.Text          = "";
                
                //원하는 날짜 픽스
                dtpStart.Text = string.Format("{0:2018-MM-01}", DateTime.Now); // 출시일자의 시작 날짜 지정

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close(); // 섹션을 종료해줘야 과부하가 안걸린다.
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(strCon);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다");
                    return;
                }

                //  조회를 위한 파라미터 설정
                string sItemCode  = txtItemCode.Text;   // 품목 코드
                string sItemName  = txtItemName.Text;   // 품목 명
                string sStartDate = dtpStart.Text;      // 출시 시작 일자
                string sEndDate   = dtpEnd.Text;        // 출시 종료 일자
                string sItemdesc  = cboItemDesc.Text;   // 품목 상세

                string sEndFlag = "N";
                if (rdoEnd.Checked == true) sEndFlag = "Y";         //  단종 여부
                if (chkNameOnly.Checked == true) sItemCode = "";    //  이름으로만 검색

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT ITEMCODE,  " +
                                                                            "       ITEMNAME,  " +
                                                                            "       ITEMDESC,  " +
                                                                            "       ITEMDESC2, " +
                                                                            "       CASE WHEN ENDFLAG = 'Y' THEN '단종' " +
                                                                            "       WHEN ENDFLAG = 'N' THEN '생산' END AS ENDFLAG, " +
                                                                            "       ENDFLAG,   " + 
                                                                            "       PRODDATE,  " +
                                                                            "       MAKEDATE,  " +
                                                                            "       MAKER,     " +
                                                                            "       EDITDATE,  " +
                                                                            "       EDITOR     " +
                                                                            "  FROM TB_TESTITEM_KHU WITH(NOLOCK) " +
                                                                            " WHERE ITEMCODE LIKE '%" + sItemCode + "%' " +
                                                                            "   AND ITEMNAME LIKE '%" + sItemName + "%' " +
                                                                            "   AND ITEMDESC LIKE '%" + sItemdesc + "%' " +
                                                                            "   AND ENDFLAG  = '" + sEndFlag + "'" +
                                                                            "   AND PRODDATE BETWEEN '"  + sStartDate + "' AND '" + sEndDate + "'"
                                                                            , Connect);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp); 

                if (dtTemp.Rows.Count == 0)
                {
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = dtTemp; // 데이터 그리드 뷰에 데이터 테이블 등록

                // 그리드뷰의 헤더 명칭 선언
                dgvGrid.Columns["ITEMCODE"].HeaderText  = "품목 코드";
                dgvGrid.Columns["ITEMNAME"].HeaderText  = "품목 명";
                dgvGrid.Columns["ITEMDESC"].HeaderText  = "품목 상세";
                dgvGrid.Columns["ITEMDESC2"].HeaderText = "품목 상세2";
                dgvGrid.Columns["ENDFLAG"].HeaderText   = "단종 여부";
                dgvGrid.Columns["MAKEDATE"].HeaderText  = "등록 일시";
                dgvGrid.Columns["MAKER"].HeaderText     = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText  = "수정 일시";
                dgvGrid.Columns["EDITOR"].HeaderText    = "수정자";

                // 그리드 뷰의 폭 지정
                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 200;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;

                // 칼럼의 수정 여부를 지정한다.
                dgvGrid.Columns["ITEMCODE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly    = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly   = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;                

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvGrid.DataSource == null)
            {
                MessageBox.Show("조회를 누르시오");
                return;
            }
            // 데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();  // dgvGrid와 같은 형태를 datatale로 변환하고, 새로운 row 생성
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);           // 빈 테이블 dr에 값 넣음
            dgvGrid.Columns["ITEMCODE"].ReadOnly = false;           // 키값을 추가를 해야할 경우 false로,
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //선택된 행을 삭제 한다.
            if (this.dgvGrid.Rows.Count == 0) return;
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
                string Itemcode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_TESTITEM_KHU WHERE ITEMCODE = '" + Itemcode + "'";
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

        // 저장버튼을 눌렀을때, 새로 추가된 내용인지 업데이트 해야될 내용인지 모호하다.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 선택된 행 데이터 저장
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 등록 하시겠습니까?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
            string sItemName = dgvGrid.CurrentRow.Cells["ITEMNAME"].Value.ToString();
            string sItemDesc = dgvGrid.CurrentRow.Cells["ITEMDESC"].Value.ToString();
            string sItemDesc2 = dgvGrid.CurrentRow.Cells["ITEMDESC2"].Value.ToString();
            string sItemEndFlag = dgvGrid.CurrentRow.Cells["ENDFLAG"].Value.ToString();
            string sProdDate = dgvGrid.CurrentRow.Cells["PRODDATE"].Value.ToString();

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strCon);
            Connect.Open();

            // region : if문으로 데이터가 있는 경우 UPDATE, 없는 경우 INSERT
            #region
            /*ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ*/
            //  2가지 방법중, 1번 방법
            //  데이터 조회 후 해당 데이터가 있는지 확인 후 UPDATE, INSERT 구문 분기
            /*            string sSql = "SELECT ITEMCODE FROM TB_TESTITEM_KHU WHERE ITEMCODE = '" + sItemCode + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);
                        DataTable dtTemp = new DataTable();
                        adapter.Fill(dtTemp);*/
            /*ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ*/
            #endregion

            //트랜잭션 설정
            Tran = Connect.BeginTransaction("TESTTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;

            // region : if문으로 데이터가 있는 경우 UPDATE, 없는 경우 INSERT
            #region
            /*ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ*/
            //  2가지 방법
            //  1. 데이터가 있는 경우 UPDATE, 없는 경우 INSERT
            /*            if(dtTemp.Rows.Count == 0)
                        {
                            //  데이터가 없으니 INSERT 해라
                            cmd.CommandText = "INSERT INTO TB_TESTITEM_KHU (ITEMCODE,       ITEMNAME,                 ITEMDESC,        ITEMDESC2,         ENDFLAG,                 PRODDATE,      MAKEDATE,   MAKER)" +
                                              "                      VALUES ('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + "N" + "','" + sProdDate + "',GETDATE(),'" + "" + "')";
                        }
                        else
                        {
                            //  데이터가 있으니 update해라
                            cmd.CommandText = "UPDATE TB_TESTITEM_KHU                               " +
                                              "    SET ITEMNAME = '"   + sItemName      + "',   " +
                                              "        ITEMDESC = '"   + sItemDesc      + "',   " +
                                              "        ITEMDESC2 = '"  + sItemDesc2     + "',   " +
                                              "        ENDFLAG = '"    + "N"   + "',   " +
                                              "        PRODDATE = '"   + sProdDate      + "',   " +
                                              "        EDITOR = '',  " +
                                              //"        EDITOR = '"    + Commoncs.LoginUserID + "',  " +
                                              "        EDITDATE = GETDATE() " +
                                              "  WHERE ITEMCODE = '" + sItemCode + "'";
                        }*/
            /*ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ*/
            #endregion  

            cmd.CommandText = "UPDATE TB_TESTITEM_KHU                                " +
                              "    SET ITEMNAME          = '" + sItemName   + "',    " +
                              "        ITEMDESC          = '" + sItemDesc   + "',    " +
                              "        ITEMDESC2         = '" + sItemDesc2  + "',    " +
                              "        ENDFLAG           = '" + "N"         + "',    " +
                              "        PRODDATE          = '" + sProdDate   + "',    " +
                              "        EDITOR = '"    + Common.LoginName + "',  " +
                              "        EDITDATE = GETDATE()                          " +
                              "  WHERE ITEMCODE = '" + sItemCode + "'" +
                              " IF (@@ROWCOUNT =0) " + // ROWCOUNT로 몇번 바뀌었는지 확인할 수 있음
                              "INSERT INTO TB_TESTITEM_KHU(ITEMCODE,           ITEMNAME,            ITEMDESC,           ITEMDESC2,          ENDFLAG,           PRODDATE,      MAKEDATE,     MAKER) " +
                              "VALUES('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + "N" + "','" + sProdDate + "',GETDATE(),'" + Common.LoginName + "')";

            cmd.ExecuteNonQuery();

            //  성공 시 DB COMMIT
            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Connect.Close();
        }

        private void cboItemDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPrc_Click(object sender, EventArgs e)
        {
            string sImageFile = string.Empty;

            //이미지 불러오기 및 저장, 파일 탐색기 호출
            OpenFileDialog Dialog = new OpenFileDialog();   

            if(Dialog.ShowDialog() == DialogResult.OK)    //    Dialog.showDialog() : 파일 탐색기를 열어 저장할 파일 선택하게 해줌
            {
                sImageFile = Dialog.FileName;   //  ex) "C:\\Users\\admin\\Desktop\\zzzzz.PNG"이 저장됨
                picItemImage.Tag = Dialog.FileName;

                // 저장된 파일에서 이미지를 만들어 픽쳐박스에 넣는다.
                picItemImage.Image = Bitmap.FromFile(sImageFile);
            }
        }

        private void picItemImage_Click(object sender, EventArgs e)
        {
            //  픽쳐박스 크기 최대화 및 이전 사이즈로
            if (this.picItemImage.Dock == System.Windows.Forms.DockStyle.Fill)
            {
                // 이미지가 가득채워져 있는 상태면 원상태로 바꿔라
                this.picItemImage.Dock = System.Windows.Forms.DockStyle.None;
            }
            else
            {                   
                picItemImage.Dock = System.Windows.Forms.DockStyle.Fill;
                // 이미지를 가장 앞으로 가져온다.
                picItemImage.BringToFront();
            }
        }

        private void btnPicSave_Click(object sender, EventArgs e)
        {
            // 픽쳐박스 이미지 저장

            // 사진이 있는지 확인
            if (dgvGrid.Rows.Count == 0) return;
            if (picItemImage.Image == null) return;
            if (picItemImage.Tag.ToString() == "") return; // 테그에 있는 이미지 정보가 없다면 리턴 

            if (MessageBox.Show("선택된 이미지로 등록하시겠습니까?", "이미지등록", MessageBoxButtons.YesNo) == DialogResult.No) return;

            Byte[] bImage = null;
            Connect = new SqlConnection(strCon);
            try
            {
                //  파일을 불러오기 위한 파일 경로 방법 지정
                FileStream stream = new FileStream(picItemImage.Tag.ToString(),
                                                   FileMode.Open,
                                                   FileAccess.Read);
                //  읽어들인 파일을 바이너리 코드로 변환
                BinaryReader reader = new BinaryReader(stream);
                //  만들어진 바이너리 코드 이미지를 Byte화 하여 저장.
                bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));
                reader.Close();
                stream.Close();
                //  바이너리 코드는 컴퓨터가 인식할 수 있는 0과 1로 구성된 이진코드
                //  바이트 코드는 CPU가 아닌 가상머신에서 이해할 수 있는 코드                

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connect;
                Connect.Open();

                string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString(); // ITEMCODE는 키값이라 값이 무조건 있음
                cmd.CommandText = "UPDATE TB_TESTITEM_KHU SET ITEMIMG = @IMAGE WHERE ITEMCODE = @ITEMCODE";
                cmd.Parameters.AddWithValue("@IMAGE", bImage);
                cmd.Parameters.AddWithValue("ITEMCODE", sItemCode);
                cmd.ExecuteNonQuery();
                Connect.Close();

                MessageBox.Show("이미지를 저장했습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택 시 해당품목 이미지 가져오기
            string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();

            Connect = new SqlConnection(strCon);
            Connect.Open();

            try
            {
                // 이미지 초기화
                picItemImage.Image = null;  // 이전에 있던 이미지가 있을 경우가 있으니
                string sSql = "SELECT ITEMIMG FROM TB_TESTITEM_KHU WHERE ITEMCODE = '" + sItemCode + "' AND ITEMIMG IS NOT NULL";
                SqlDataAdapter Adapter = new SqlDataAdapter(sSql, Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0) return;

                byte[] bImage = null;
                bImage = (byte[])dtTemp.Rows[0]["ITEMIMG"]; // 이미지를 byte화 한다.   Rows[0]["ITEMIMG"]에서 0인 이유는 해당 행이 1개니깐.
                if (bImage != null)
                {
                    picItemImage.Image = new Bitmap(new MemoryStream(bImage));
                    picItemImage.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnPicDelete_Click(object sender, EventArgs e)
        {
            // 품목에 저정된 이미지 삭제
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택한 이미지를 삭제하시겠습니까?", "이미지 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            Connect = new SqlConnection(strCon);
            Connect.Open();

            try
            {
                string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString(); 
                cmd.CommandText = "UPDATE TB_TESTITEM_KHU SET ITEMIMG = null WHERE ITEMCODE = '" + sItemCode + "'";
                cmd.Connection = Connect;
                cmd.ExecuteNonQuery();
                picItemImage.Image = null;
                MessageBox.Show("정상적으로 삭제 하였습니다");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}