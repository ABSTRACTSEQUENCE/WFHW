using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
	public partial class Calc : Form
	{
		int a, b, sum;
		string action;
		char ch;
		public Calc()
		{
			InitializeComponent();
			a = b = sum = 0;
		}
	  
		private void input(string number)
		{
			if(output.Text != "")
			if (output.Text.Contains("+") ||
				output.Text.Contains("-") ||
				output.Text.Contains("*") ||
				output.Text.Contains("/")) 
			{
				equals.Enabled = true;
			}
			

			if (number == "+" || number == "-"
			 || number == "*" || number == "/")
			{
				plus.Enabled = false;
				minus.Enabled = false;
				//mult.Enabled = false;
				//div.Enabled = false;
				output.Text += number;
				ch = number.ToCharArray()[0];
				action += number;
			}
			else
			{
				output.Text += number;
				action += number;
				a = Convert.ToInt32(action.Split(ch)[0]);
				b = Convert.ToInt32(action.Split(ch)[1]);
				if (ch == '+')
					output.Text = (a + b).ToString();
				else if (ch == '-')
					output.Text = (a - b).ToString();
				action = "";
				action = output.Text;
				plus.Enabled = true; minus.Enabled = true;
			}
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			input("1");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			input("2");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			input("3");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			input("4");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			input("5");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			input("6");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			input("7");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			input("8");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			input("9");
		}

		private void button0_Click(object sender, EventArgs e)
		{
			input("0");
		}

		private void plus_Click(object sender, EventArgs e)
		{
			input("+");
		}

		private void minus_Click(object sender, EventArgs e)
		{
			input("-");
		}

		private void equals_Click(object sender, EventArgs e)
		{
			
			equals.Enabled = false;
		}
	}
}
