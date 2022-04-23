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
	public partial class Product : Form
	{
		public Product()
		{
			InitializeComponent();
		}
		private void bt_add_Click(object sender, EventArgs e)
		{
			Prod prod = new Prod();
			Product_editor pe = new Product_editor(ref prod);
			pe.ShowDialog();
			if (!pe.cancel)
			{
				listBox1.Items.Add(prod);
				listBox1.Text = prod.ToString();
			}
		}

        private void bt_del_Click(object sender, EventArgs e)
        {
			if (listBox1.SelectedIndex < 0) { }
			else
			{
				if (MessageBox.Show(
					$"Вы действительно хотите удалить {listBox1.Text}?",
					"Внимание",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					listBox1.Items.RemoveAt(listBox1.SelectedIndex);
				}
			}
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
			if (listBox1.SelectedIndex <= -1) { }
			else
			{
				Prod prod = (Prod)listBox1.SelectedItem;
				new Product_editor(ref prod).ShowDialog();
				listBox1.Items[listBox1.SelectedIndex] = prod;
			}
		
			

		}

        private void bt_clear_Click(object sender, EventArgs e)
        {
			listBox1.Items.Clear();
        }
    }
}
