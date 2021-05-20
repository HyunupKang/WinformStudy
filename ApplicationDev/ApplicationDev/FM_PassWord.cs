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
using System.Windows.Forms.VisualStyles;

namespace ApplicationDev
{
    public partial class FM_PassWord : Form
    {
        //pirvate는 지역변수다. FM_PassWord에서만 사용할 변수
        private SqlConnection Connect = null;       // 데이터 베이스 접속 정보
        private SqlTransaction Tran;                // 데이터 베이스 관리 권한
        private SqlCommand cmd = new SqlCommand();  // 데이터 베이스 명령 전달

        public FM_PassWord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //창 닫기
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // 비밀 번호를 변경한다.
            string strCon = "Data Source = 61.105.9.203; Initial Catalog = AppDev; USER ID = kfqs; Password = 1234"; // 접속주소
            Connect = new SqlConnection(strCon); // 접속 정보 관리 클래스에 접속주소를 입력
            Connect.Open();                      // 데이터 베이스에 접속한다.

            // DB 접속이 됮 않았을 경우 메세지 리턴 후 이벤트 종료
            if(Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터 베이스 연결에 실패하였습니다");
                return;
            }
            // 1. ID 존재 여부 확인
            string sLoginid = string.Empty; // 로그인 ID
            string sPerPw = string.Empty;   // 이전 비밀번호
            string sNewPw = string.Empty;   // 신규 비밀번호

            sLoginid = txtUserID.Text;
            sPerPw = txtPerPw.Text;
            sNewPw = txtChangePW.Text;

            // SQL 조회문을 실행시키기 위한 어댑터 
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_KHU WHERE USERID = '" + sLoginid + "'", Connect); // PW를 받아오는데, 로그인 아이디(아이디는 유니크함)를 조회한다. 없으면 결과 없다

            // 데이터를 담을 그릇
            DataTable DtTemp = new DataTable(); // DataTable : C#에서 제공하는 데이터 테이블

            // 어댑터 실행 후 그릇에 데이터 담기
            Adapter.Fill(DtTemp);

            // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
            if(DtTemp.Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사용자 입니다."); 
                return;
            }
            // 2. 이전 비밀번호 일치 확인
            if (DtTemp.Rows[0]["PW"].ToString() != sPerPw)  // row는 무조건 인덱스, 열은 문자열로 가능함  // DtTemp.Rows[0]["PW"]으로 하면 형이 Object인데 정확히 어떤 타입인지 명시 안해줘서 string과 비교하면 fale로 반환한다. 
            {
                MessageBox.Show("이전 비밀번호가 일치하지 않습니다.");
                return;
            }
            // 3. 바뀔 비밀번호로 등록
            else
            {
                // 메세지 박스 Y/N 선택후 N일경우 리턴
                if (MessageBox.Show("해당 비밀번호로 변경하시겠습니까?","비밀번호 변경",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                Tran = Connect.BeginTransaction("TESTTan");                         // 트랜잭션 선언
                cmd.Transaction = Tran;                                             // 커맨드에 트랜잭션 사용여부 등록
                cmd.Connection = Connect;                                           // 커맨드에 접속 정보 입력
                cmd.CommandText = "UPDATE TB_USER_KHU SET PW = '" + sNewPw + "' WHERE USERID = '" + sLoginid + "'"; // update where절에는 기본키가 입력되면 좋다.
                cmd.ExecuteNonQuery();                                              // C(create), U(update), D(delete) 실행 함수 실행

                Tran.Commit();                                                      // 변경 내용 승인

                // 4. 변경 여부 메세지 처리
                MessageBox.Show("정상적으로 변경 하였습니다.");
                this.Close();
            }
            
        }
    }
}