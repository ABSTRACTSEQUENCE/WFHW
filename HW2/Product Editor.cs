using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
	public partial class Product_editor : Form
	{
		Prod prod;
		public bool cancel;
		public Product_editor(ref Prod prod)
		{
			InitializeComponent();
			this.prod = prod;
			tb_name.Text = prod.name;
			n_price.Maximum = 9999999999999;
			if ((decimal)prod.price > n_price.Maximum)
			{
				if (MessageBox.Show(
					$"Максимально допустимое значение - {n_price.Maximum}" +
					$"\nЗадать данное значение?", "Внимание",
					MessageBoxButtons.YesNo)
					== DialogResult.Yes)
					prod.price = (double)n_price.Maximum;
				else
					n_price.Value = n_price.Minimum;
				
			}

			n_price.Value = (decimal)prod.price;
		}
		private void bt_done_Click(object sender, EventArgs e)
		{
			prod.name = tb_name.Text;
			prod.price = (double)n_price.Value;
			cancel = false;
			Close();
		}
        private void bt_cancel_Click(object sender, EventArgs e)
        {
			cancel = true;
			Close();
        }
    }
}
