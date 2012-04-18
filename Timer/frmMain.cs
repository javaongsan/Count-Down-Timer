using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class frmMain : Form
    {
        private Ticker tick;
        private bool TimerStarted=false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tick=new Ticker();
            tick.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String Time=tick.Tick();
            Display(Time);

            // Has the time decremented to zero?
            if (tick.CurrentTime==0)
            {
                // Stop the timer
                timer1.Stop();
            }
        }

        private void Display(String Time)
        {
            lblTimer.Text=Time;
            if (this.WindowState==FormWindowState.Minimized)
                lblTitle.Text=lblTimer.Text;
            else
                lblTitle.Text="Timer";
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            if (TimerStarted)
            {
                MessageBox.Show("Stop the timer first!");
                return;
            }

            lblTimer.Text="";
            timer1.Stop();

            int i=0;
            for (i=0; i<25; i++)
                cbHr.Items.Add(i);

            for (i=0; i<61; i++)
            {
                cbMin.Items.Add(i);
                cbSS.Items.Add(i);
            }

            pnSetting.Visible=true;
            pnSetting.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnSetting.Visible=false;
            pnSetting.SendToBack();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!Common.IsNumeric(cbHr.Text)||Convert.ToInt32(cbHr.Text)>24)
            {
                MessageBox.Show("Input a valid hour!");
                cbHr.Focus();
                return;
            }

            if (!Common.IsNumeric(cbMin.Text)||Convert.ToInt32(cbMin.Text)>60)
            {
                MessageBox.Show("Input a valid minute!");
                cbMin.Focus();
                return;
            }

            if (!Common.IsNumeric(cbSS.Text)||Convert.ToInt32(cbSS.Text)>60)
            {
                MessageBox.Show("Input a valid second!");
                cbSS.Focus();
                return;
            }

            object StartTime=(Convert.ToInt32(cbHr.Text)*60*60)+(Convert.ToInt32(cbMin.Text)*60)+(Convert.ToInt32(cbSS.Text));
            Registries.setreg("StartTime", StartTime);
            tick.Start();
            String Time=tick.ConvertToTime();
            Display(Time);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.btnPlay.Image=global::Timer.Properties.Resources.Play;
            TimerStarted=false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tick.CurrentTime>0)
                tick.Start();

            if (TimerStarted)
            {
                timer1.Stop();
                this.btnPlay.Image=global::Timer.Properties.Resources.Play;
                TimerStarted=false;
            }
            else
            {
                timer1.Start();
                this.btnPlay.Image=global::Timer.Properties.Resources.Pause;
                TimerStarted=true;
            }
        }

        private void lbllink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process=new System.Diagnostics.Process();
            process.StartInfo.FileName="http://www.wizcodersolution.com";
            process.Start();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }
    }
}