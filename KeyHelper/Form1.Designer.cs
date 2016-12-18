namespace KeyHelper
{
    partial class keyhelper
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keyhelper));
            this.left_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.time_space = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_delay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.time_num = new System.Windows.Forms.TextBox();
            this.left_double_start = new System.Windows.Forms.Button();
            this.right_start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.time_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time_next = new System.Windows.Forms.Label();
            this.timer_delay_start = new System.Windows.Forms.Timer(this.components);
            this.time_delay_click = new System.Windows.Forms.Timer(this.components);
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // left_start
            // 
            this.left_start.Location = new System.Drawing.Point(2, 116);
            this.left_start.Name = "left_start";
            this.left_start.Size = new System.Drawing.Size(181, 33);
            this.left_start.TabIndex = 0;
            this.left_start.Text = "鼠标左键单击停不下来";
            this.left_start.UseVisualStyleBackColor = true;
            this.left_start.Click += new System.EventHandler(this.left_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "间隔时间(ms)";
            // 
            // time_space
            // 
            this.time_space.Location = new System.Drawing.Point(83, 19);
            this.time_space.MaxLength = 300000;
            this.time_space.Name = "time_space";
            this.time_space.Size = new System.Drawing.Size(100, 21);
            this.time_space.TabIndex = 2;
            this.time_space.Text = "1000";
            this.time_space.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "延时开始(ms)";
            // 
            // time_delay
            // 
            this.time_delay.Location = new System.Drawing.Point(83, 52);
            this.time_delay.Name = "time_delay";
            this.time_delay.Size = new System.Drawing.Size(100, 21);
            this.time_delay.TabIndex = 4;
            this.time_delay.Text = "3000";
            this.time_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "点击次数";
            // 
            // time_num
            // 
            this.time_num.Location = new System.Drawing.Point(83, 82);
            this.time_num.Name = "time_num";
            this.time_num.Size = new System.Drawing.Size(100, 21);
            this.time_num.TabIndex = 6;
            this.time_num.Text = "10";
            this.time_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // left_double_start
            // 
            this.left_double_start.Location = new System.Drawing.Point(2, 155);
            this.left_double_start.Name = "left_double_start";
            this.left_double_start.Size = new System.Drawing.Size(181, 33);
            this.left_double_start.TabIndex = 7;
            this.left_double_start.Text = "鼠标左键双击停不下来";
            this.left_double_start.UseVisualStyleBackColor = true;
            this.left_double_start.Click += new System.EventHandler(this.left_double_start_Click);
            // 
            // right_start
            // 
            this.right_start.Location = new System.Drawing.Point(2, 194);
            this.right_start.Name = "right_start";
            this.right_start.Size = new System.Drawing.Size(181, 30);
            this.right_start.TabIndex = 8;
            this.right_start.Text = "鼠标右键单击停不下来";
            this.right_start.UseVisualStyleBackColor = true;
            this.right_start.Click += new System.EventHandler(this.right_start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(2, 245);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(181, 32);
            this.stop.TabIndex = 9;
            this.stop.Text = "提前结束";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // time_number
            // 
            this.time_number.AutoSize = true;
            this.time_number.Location = new System.Drawing.Point(157, 230);
            this.time_number.Name = "time_number";
            this.time_number.Size = new System.Drawing.Size(11, 12);
            this.time_number.TabIndex = 11;
            this.time_number.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "剩余次数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "倒数时间";
            // 
            // time_next
            // 
            this.time_next.AutoSize = true;
            this.time_next.Location = new System.Drawing.Point(61, 230);
            this.time_next.Name = "time_next";
            this.time_next.Size = new System.Drawing.Size(11, 12);
            this.time_next.TabIndex = 14;
            this.time_next.Text = "0";
            // 
            // timer_delay_start
            // 
            this.timer_delay_start.Tick += new System.EventHandler(this.timer_delay_start_Tick);
            // 
            // time_delay_click
            // 
            this.time_delay_click.Tick += new System.EventHandler(this.time_delay_click_Tick);
            // 
            // timer_count
            // 
            this.timer_count.Interval = 15;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // keyhelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 284);
            this.Controls.Add(this.time_next);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time_number);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.right_start);
            this.Controls.Add(this.left_double_start);
            this.Controls.Add(this.time_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time_delay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time_space);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.left_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "keyhelper";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "按键助手";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.GUOQIJUN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button left_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox time_space;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_delay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox time_num;
        private System.Windows.Forms.Button left_double_start;
        private System.Windows.Forms.Button right_start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label time_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label time_next;
        private System.Windows.Forms.Timer timer_delay_start;
        private System.Windows.Forms.Timer time_delay_click;
        private System.Windows.Forms.Timer timer_count;
    }
}

