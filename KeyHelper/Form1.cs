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
        //���������ʼ
        private void left_start_Click(object sender, EventArgs e)
        {
            //��ǰ����¼�
            button_flag = 1;
            //��ʼ����ʱ��ʼ��ʱ��
            ready_delay_timer();
        }
        //���˫����ʼ
        private void left_double_start_Click(object sender, EventArgs e)
        {
            button_flag = 2;
            ready_delay_timer();
        }
        //�Ҽ���ʼ
        private void right_start_Click(object sender, EventArgs e)
        {
            button_flag = 3;
            ready_delay_timer();
        }
        //������ť
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
        //��ʼ����ʱ��ʼ�Ķ�ʱ��
        public void ready_delay_timer()
        {
            set_button();
            time_number.Text = time_num.Text;
            //���� textbox���趨����ʱ��ʼ��ʱ��
            timer_delay_start.Interval = Convert.ToInt32(time_delay.Text.ToString());
            timer_delay_start.Start();
            time_next.Text = "ready";
        }

        //����Ҽ�˫��
        public void mouse_right_one_click()
        {
            mouse_event(MouseEventFlag.RightDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.RightUp, 0, 0, 0, UIntPtr.Zero);
        }

        //��굥�����
        public void mouse_left_one_click()
        {
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }
        //���˫�����
        public void mouse_left_double_click()
        {
            mouse_left_one_click();
            mouse_left_one_click();
        }
        //ʹ�ܻ��ֹ����
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

        //��ʱ��ʼ����ʱ��
        private void timer_delay_start_Tick(object sender, EventArgs e)
        {
            //���Լ���ʱ���ص�
            timer_delay_start.Stop();
           
            //������ʱ��2   ��϶�ʱ��
            time_delay_click.Interval = Convert.ToInt32(time_space.Text.ToString());
            time_delay_click.Start();

            //��ʾtime2 ʣ���ʱ��
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
                //�Ѿ��ﵽ���������Լ��ص�
                stop_Click( sender,  e);
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow(); //��ñ�����ľ��
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);//���ô˴���Ϊ�����
        private void timer_count_Tick(object sender, EventArgs e)
        {
            num =num +15;
            time_next.Text = (Convert.ToInt32(time_space.Text.ToString()) - num).ToString();
            if (num >Convert.ToInt32(time_space.Text.ToString()))
            {
                num = 0;
                time_next.Text = num.ToString();
            }
            if (Handle1 != GetForegroundWindow()) //����ʹ�ô�����Ϊ��ǰ,���θ����򵥴��ö�
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