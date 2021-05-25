using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEV_Form;

namespace ApplicationDev
{
    public partial class FM_Main : Form  // Form : 유저 인터페이스를 만들어주는 클래스
    {
        public FM_Main()
        {
            InitializeComponent();
            //로그인 폼 호출
            FM_Login Login = new FM_Login();
            Login.ShowDialog();

            tssUserName.Text = Login.Tag.ToString(); // Tag를 배열처럼 사용할 수 없다. 두가지 이상이면 Liter를 사용, 로그인 안하고 창 끄면 에러뜸(Null값이라서인가?)

            //버튼이 클릭 안될때
            #region
            /*  ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ*/
            // 버튼에 이벤트 추가(버튼이 안눌릴 때)
            //this.stbExit.Click += new System.EventHandler(this.stbExit_Click);   만약 디자인에서 클릭이 안될때 이것 추가,
            //                                                                     그리고 private void stbExit_Click(object sender, EventArgs e){} 작성
            //                                                                     만약 클릭이 되면 Main 디자이너에 
            //                                                                     this.stbExit.Click += new System.EventHandler(this.stbExit_Click) 생성되있음

            // 메뉴 클릭 이벤트 추가(클릭이 안될 때)
            //this.M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MBI_TEST_DropDownItemClicked); // M_SYSTEM : 메인창의 MenuStrip 이름, 이걸 클릭했을 때 이벤트 발생
            /*  ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ*/
            #endregion

            if (tssUserName.Text == "FAIL")  // USERNAME이 FAIL이면 성립 안함
            {
                //Application.ExitThread();   // 동작하고 있는 모든 쓰레드를 닫아라
                //Application.Exit();

                System.Environment.Exit(0); // 위 코드와 같은 기능임
            }
        }

        private void stbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void stbClose_Click(object sender, EventArgs e)
        {
            //  열려있는 화면이 있는지 확인
            if (myTabControl1.TabPages.Count == 0) return;
            
            // 선택된 탭페이지를 닫는다.
            myTabControl1.SelectedTab.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e) 
        {
            tssNowDate.Text = DateTime.Now.ToString();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDI_TEST_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) 
        {
            // 1. 단순히 폼을 호출하는 경우
            /*            DEV_Form.MDI_TEST Form = new MDI_TEST();  // DEV_Form2가 있고 여기에도 Form1이 있을 수 있다. 그래서 DEV_Form.으로 DEV_Form에 있는 Form1을 이용한다 라는 뜻
                        Form.MdiParent = this; // MDI : FORM들을 부모 자식으로 연결해줌        Form1의 부모는 메인 Form
                        Form.Show();*/

            // 2. 프로그램을 호출 (MenuStrip의 이름을 이용하여 호출)
            Assembly assemb = Assembly.LoadFrom(Application.StartupPath + @"\" + "DEV_Form.DLL"); // \ : 폴더 이동, 그 폴더에 있는 DEV_Form.DLL을 참조해라, 그 파일에 있는 어셈빌리를 assemb에 저장
            Type typeForm = assemb.GetType("DEV_Form." + e.ClickedItem.Name.ToString(), true);  // 버튼을 클릭했을 때 받아오는 e 값의 Name을(테스트 화면의 이름인 MDI_TEST) Type형의 typeForm에 저장
            Form ShowForm = (Form)Activator.CreateInstance(typeForm);  // 윗줄에서 저장한 이름과 똑같은 이름의 파일 FORM을 열어라

            // 해당되는 폼이 이미 오픈되어 있는지 확인 후, 활성화 또는 신규 오픈 한다.
            for (int i = 0; i < myTabControl1.TabPages.Count; i++)
            {
                if (myTabControl1.TabPages[i].Name == e.ClickedItem.Name.ToString())
                {
                    myTabControl1.SelectedTab = myTabControl1.TabPages[i];
                    return;
                }
            }
            /*            ShowForm.MdiParent = this;
                        ShowForm.Show();*/

            myTabControl1.AddForm(ShowForm); // 탭페이지에 폼을 추가한다.myTabControl1은 MyTabControl의 이름이다.
        }
    }

    public partial class MDIForm : TabPage  //  TabPage를 MIDForm이란 이름으 로 쓰려고 partial class를 작성한거임
    { }
    public partial class MyTabControl : TabControl  // partial : 파생 클래스, TabControl 기능을 가져오면서, MyTabControl에서 사용할 기능을 추가 정의 하겠다
    {
        public void AddForm(Form NewForm)
        {
            if (NewForm == null) return;    //  벨리데이션 코드임(코드 실행 조건), 인자로 받은 폼이 없을 경우 실행 중지
            NewForm.TopLevel = false;       //  인자로 받은 폼이 최상위 개체가 아님을 선언(디폴트로 true임)
            MDIForm page = new MDIForm();   //  탭 페이지 객체 생성, 탭컨트롤안에 탭 페이지가 있다.
            page.Controls.Clear();          //  페이지 초기화
            page.Controls.Add(NewForm);     //  페이지에 폼 추가
            page.Text = NewForm.Text;       //  각 탭 페이지의 이름은 폼에서 지정한 이름으로 설정
            page.Name = NewForm.Name;       //  폼에서 설정한 이름으로 탭 페이지 설정
            base.TabPages.Add(page);        //  base : 부모 클래스에 있는 함수를 호출, 내가 만든 page를 추가한다->어디에? TabPages(탭 컨트롤)에
            NewForm.Show();                 //  인자를 받은 폼을 보여준다
            base.SelectedTab = page;        //  현재 선택된 페이지를 호출한 폼의 페이지로 실행
        }
    }
}