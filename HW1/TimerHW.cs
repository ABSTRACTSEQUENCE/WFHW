using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class TimerHW : Form
    {
        
        Timer timer = new Timer();
        
        public TimerHW()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
             progressBar1.PerformStep();
            
            if (progressBar1.Value >= progressBar1.Maximum)
                Timer_finish();
        }
        private void Timer_finish()
        {
            
            start.Enabled = true;
            timer.Stop();
            timer.Enabled = false;
            MessageBox.Show("Время прошло");
        }

        private void start_Click(object sender, EventArgs e)
        {
            
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Нулевое или отрицательное значение недопустимо");
                return;
            }
            if (progressBar1.Value != progressBar1.Minimum)
                progressBar1.Value = progressBar1.Minimum;
                start.Enabled = false;
                timer.Interval = 1000;
                timer.Enabled = true;
                timer.Start();
                progressBar1.Maximum = Convert.ToInt32(numericUpDown1.Value);
                

            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();
            else 
                MessageBox.Show("Таймер уже выключен");
            start.Enabled = true;
        }
    }
}
