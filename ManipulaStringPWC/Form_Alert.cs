using ManipulaStringPWC.Properties;
namespace CustomAlertBoxDemo
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }
        public enum EnmAction
        {
            wait,
            start,
            close
        }
        public enum EnmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private Form_Alert.EnmAction action;
        private int x, y;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case EnmAction.wait:
                    timer1.Interval = 5000;
                    action = EnmAction.close;
                    break;
                case Form_Alert.EnmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.EnmAction.wait;
                        }
                    }
                    break;
                case EnmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = EnmAction.close;
        }
        public void MostrarNotificacao(string msg, EnmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case EnmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case EnmType.Error:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.DarkRed;
                    break;
                case EnmType.Info:
                    this.pictureBox1.Image = Resources.paperbranco;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case EnmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }
            this.lblMsg.Text = msg;
            this.Show();
            this.action = EnmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
