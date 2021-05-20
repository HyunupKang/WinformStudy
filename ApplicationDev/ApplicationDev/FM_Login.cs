using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;


namespace ApplicationDev // namespace : 클래스들의 모음, 프로젝트를 생성하면 namespace가 생성되는데 namespace마다 실행 파일이 있지만, 라이브러리화 하면 참조형식으로 설정할 수 있다
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect_Log = null;       // 데이터 베이스 접속 정보
        private SqlCommand cmd = new SqlCommand();  // 데이터 베이스 명령 전달

        public FM_Login()
        {
            InitializeComponent();
        }

        private void btnPWChange_Click(object sender, EventArgs e)
        {
            //비밀번호 변경 화면 팝업을 호출한다.
            this.Visible = false; // 로그인 화면을 보이지 않게 한다.
            FM_PassWord FmPassWord = new FM_PassWord(); // 객체를 선언하면, 램에 올려서 사용할 준비를 한다
            FmPassWord.ShowDialog();  // 비밀번호 창을 띄우면 로그인 창에서 작업 불가능
            //FmPassWord.Show(); // 비밀번호 창을 띄워도 로그인 창에서 작업이 가능하다
            this.Visible = true; // 비밀번호 변경 창을 끄면 다시 로그인 창 띄움
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string strCon = "Data Source = 61.105.9.203; Initial Catalog = AppDev; USER ID = kfqs; Password = 1234"; // 접속주소
            Connect_Log = new SqlConnection(strCon);                                                                 // 접속 정보 관리 클래스에 접속주소를 입력
            Connect_Log.Open();                                                                                      // 데이터 베이스에 접속한다.

            // DB 접속이 됮 않았을 경우 메세지 리턴 후 이벤트 종료
            if (Connect_Log.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터 베이스 연결에 실패하였습니다");
                return;
            }
            // 1. ID 존재 여부 확인
            string sLoginid_login = string.Empty; 
            string sPw = string.Empty;

            sLoginid_login = txtID.Text;
            sPw = txtPassword.Text;

            // SQL 조회문을 실행하여 아이디에 따른 pw 값 객체 생성
            SqlDataAdapter Adapter_Login = new SqlDataAdapter("SELECT PW FROM TB_USER_KHU WHERE USERID = '" + sLoginid_login + "'", Connect_Log); 

            // 객체 데이터를 담을 그릇
            DataTable DtTemp_Login = new DataTable(); // DataTable : C#에서 제공하는 데이터 테이블

            // 어댑터 실행 후 그릇에 객체 데이터 담기
            Adapter_Login.Fill(DtTemp_Login);

            // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
            if (DtTemp_Login.Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사용자 입니다.");
                return;
            }
            // 비밀번호 일치 여부
            if (DtTemp_Login.Rows[0]["PW"].ToString() != sPw)  
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }
            else
            {
                MessageBox.Show("로그인 하셨습니다.");
                return;
            }
        }
    }
}
