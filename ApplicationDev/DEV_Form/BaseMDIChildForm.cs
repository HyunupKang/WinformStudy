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
    public partial class BaseMDIChildForm : Form, ChildInterface
    {
        public BaseMDIChildForm()
        {
            InitializeComponent();
        }

        public virtual void Delete()  // virtual : 오버라이드 기능을 구현할 수 있게 해주는
        {
            
        }

        public virtual void DoNew()
        {
            
        }

        public virtual void inquire()
        {
            
        }

        public virtual void Save()
        {
            
        }
    }
}
