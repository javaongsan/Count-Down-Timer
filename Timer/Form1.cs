using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int StartTime=0;
        private string subKey="SOFTWARE\\"+Application.ProductName;
        private RegistryKey baseRegistryKey=Registry.LocalMachine;
        private bool TimerStarted=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTime=getreg("StartTime");
        }

        public string ConvertToTime(long tickCount)
        {
            // tickcount is in seconds, convert to a minutes: seconds string
            long seconds=tickCount;
            string val=(seconds/60/60).ToString("00")+":"+((seconds/60)%60).ToString("00")+":"+(seconds%60).ToString("00");
            return val;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Decrement the time
            StartTime--;
            // Repaint the screen
            lblTimer.Text=ConvertToTime(StartTime);
            if (this.WindowState==FormWindowState.Minimized)
                lblTitle.Text=lblTimer.Text;
            else
                lblTitle.Text="Timer";

            // Has the time decremented to zero?
            if (StartTime==0)
            {
                // Stop the timer
                timer1.Stop();
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
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

            if (StartTime>0)
                timer1.Start();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(cbHr.Text)||Convert.ToInt32(cbHr.Text)>24)
            {
                MessageBox.Show("Input a valid hour!");
                cbHr.Focus();
                return;
            }

            if (!IsNumeric(cbMin.Text)||Convert.ToInt32(cbMin.Text)>60)
            {
                MessageBox.Show("Input a valid minute!");
                cbMin.Focus();
                return;
            }

            if (!IsNumeric(cbSS.Text)||Convert.ToInt32(cbSS.Text)>60)
            {
                MessageBox.Show("Input a valid second!");
                cbSS.Focus();
                return;
            }

            StartTime=(Convert.ToInt32(cbHr.Text)*60*60)+(Convert.ToInt32(cbMin.Text)*60)+(Convert.ToInt32(cbSS.Text));
            setreg("StartTime", StartTime);
        }

        // IsNumeric Function
        static bool IsNumeric(object Expression)
        {
            // Variable to collect the Return value of the TryParse method.
            bool isNum;
            // Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
            double retNum;
            // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
            // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
            isNum=Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private int getreg(string KeyName)
        {
            // Opening the registry key
            RegistryKey rk=baseRegistryKey;
            // Open a subKey as read-only
            RegistryKey sk1=rk.OpenSubKey(subKey);
            // If the RegistrySubKey doesn't exist -> (null)
            if (sk1==null)
                return 0;

            // If the RegistryKey exists I get its value
            // or null is returned.
            return (int)sk1.GetValue(KeyName.ToUpper());
        }

        private void setreg(string KeyName, object Value)
        {
            // Setting
            RegistryKey rk=baseRegistryKey;
            // I have to use CreateSubKey 
            // (create or open it if already exits), 
            // 'cause OpenSubKey open a subKey as read-only
            RegistryKey sk1=rk.CreateSubKey(subKey);
            // Save the value
            sk1.SetValue(KeyName.ToUpper(), Value);
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            TimerStarted=false;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (StartTime>0)
            {
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