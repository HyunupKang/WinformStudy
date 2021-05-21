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
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
            FM_Login Login = new FM_Login();
            Login.ShowDialog();
            tssUserName.Text = Login.Tag.ToString(); // Tag를 배열처럼 사용할 수 없다. 두가지 이상이면 Liter를 사용, 로그인 안하고 창 끄면 에러뜸(Null값이라서인가?)

            // 버튼에 이벤트 추가(버튼이 안눌릴 때)
            //this.stbExit.Click += new System.EventHandler(this.stbExit_Click);   만약 디자인에서 클릭이 안될때 이것 추가,
            //                                                                     그리고 private void stbExit_Click(object sender, EventArgs e){} 작성
            //                                                                     만약 클릭이 되면 Main 디자이너에 
            //                                                                     this.stbExit.Click += new System.EventHandler(this.stbExit_Click) 생성되있음

            // 메뉴 클릭 이벤트 추가(클릭이 안될 때)
            //this.M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MBI_TEST_DropDownItemClicked); // M_SYSTEM : 메인창의 MenuStrip 이름, 이걸 클릭했을 때 이벤트 발생

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

            ShowForm.MdiParent = this;
            ShowForm.Show();

        }

        private void M_SYSTEM_Click(object sender, EventArgs e)
        {
            
        }

    }
}