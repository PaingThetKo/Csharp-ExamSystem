using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_system
{
    public partial class frm_ques3 : Form
    {
        public frm_ques3()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                picStatus.Image = Image.FromFile(@"true.png");
            }
            else
            {
                picStatus.Image = Image.FromFile(@"false.png");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
