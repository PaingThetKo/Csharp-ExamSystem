namespace exam_system
{
    public partial class frm_ques1 : Form
    {
        public frm_ques1()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
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
            this.Hide();
            frm_ques2 frm_Ques2 = new frm_ques2();
            frm_Ques2.Show();
        }
    }
}
