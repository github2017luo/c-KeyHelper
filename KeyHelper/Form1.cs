using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyHelper
{
    public partial class keyhelper : Form
    {
        Boolean button_status = true;
        int button_flag = 0;
        int num=0;
        public keyhelper()
        {
            InitializeComponent();
        }

        [Flags]
        enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000,
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr ext);
        [DllImport("user32 ")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32 ")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        //左键单击开始
        private void left_start_Click(object sender, EventArgs e)
        {
            //标记按键事件
            button_flag = 1;
            //初始化延时开始定时器
            ready_delay_timer();
        }
        //左键双击开始
        private void left_double_start_Click(object sender, EventArgs e)
        {
            button_flag = 2;
            ready_delay_timer();
        }
        //右键开始
        private void right_start_Click(object sender, EventArgs e)
        {
            button_flag = 3;
            ready_delay_timer();
        }
        //结束按钮
        private void stop_Click(object sender, EventArgs e)
        {
            timer_count.Stop();
            timer_delay_start.Stop();
            time_delay_click.Stop();
            button_status = false;
            set_button();
            button_flag = 0;
            time_number.Text = "0";
            time_next.Text = "0";
            button_flag = 0;
            num = 0;
        }
        //初始化延时开始的定时器
        public void ready_delay_timer()
        {
            set_button();
            time_number.Text = time_num.Text;
            //设置 textbox里设定的延时开始的时间
            timer_delay_start.Interval = Convert.ToInt32(time_delay.Text.ToString());
            timer_delay_start.Start();
            time_next.Text = "ready";
        }

        //鼠标右键双击
        public void mouse_right_one_click()
        {
            mouse_event(MouseEventFlag.RightDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.RightUp, 0, 0, 0, UIntPtr.Zero);
        }

        //鼠标单击左键
        public void mouse_left_one_click()
        {
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }
        //鼠标双击左键
        public void mouse_left_double_click()
        {
            mouse_left_one_click();
            mouse_left_one_click();
        }
        //使能或禁止输入
        public void set_button()
        {
            if (button_status)
            {
                left_start.Enabled = false;
                left_double_start.Enabled = false;
                right_start.Enabled = false;
                time_space.Enabled = false;
                time_delay.Enabled = false;
                time_num.Enabled = false;
                button_status = false;
            }
            else
            {
                left_start.Enabled = true;
                left_double_start.Enabled = true;
                right_start.Enabled = true;
                time_space.Enabled = true;
                time_delay.Enabled = true;
                time_num.Enabled = true;
                button_status = true;
            }

        }

        //延时开始，定时器
        private void timer_delay_start_Tick(object sender, EventArgs e)
        {
            //把自己定时器关掉
            timer_delay_start.Stop();
           
            //开启定时器2   间断定时器
            time_delay_click.Interval = Convert.ToInt32(time_space.Text.ToString());
            time_delay_click.Start();

            //显示time2 剩余的时间
            timer_count.Start();
        }


        private void time_delay_click_Tick(object sender, EventArgs e)
        {
            switch (button_flag)
            {
                case 1:
                    mouse_left_one_click();
                    break;
                case 2:
                    mouse_left_double_click();
                    break;
                case 3:
                    mouse_right_one_click();
                    break;
                default:
                    break;
            }
            time_number.Text = (Convert.ToInt32(time_number.Text.ToString()) - 1).ToString();
            if (time_number.Text.ToString()=="0")
            {
                //已经达到次数，把自己关掉
                stop_Click( sender,  e);
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow(); //获得本窗体的句柄
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);//设置此窗体为活动窗体
        private void timer_count_Tick(object sender, EventArgs e)
        {
            num =num +15;
            time_next.Text = (Convert.ToInt32(time_space.Text.ToString()) - num).ToString();
            if (num >Convert.ToInt32(time_space.Text.ToString()))
            {
                num = 0;
                time_next.Text = num.ToString();
            }
            if (Handle1 != GetForegroundWindow()) //持续使该窗体置为最前,屏蔽该行则单次置顶
            {
                SetForegroundWindow(Handle1);
            }
        }

        public IntPtr Handle1; 
        private void GUOQIJUN_Load(object sender, EventArgs e)
        {
            IntPtr hDeskTop = FindWindow("Progman ", "Program   Manager ");
            SetParent(this.Handle, hDeskTop);
            Handle1 = this.Handle;
        }

    }
}