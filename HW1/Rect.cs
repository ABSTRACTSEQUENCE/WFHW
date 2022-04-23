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
    public partial class Rect : Form
    {
        public Rect()
        {
            InitializeComponent();
            
        }

       

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            ActiveForm.Text = ($"{Cursor.Position}");
        }

        private void Rect_MouseClick(object sender, MouseEventArgs e)
        {

            if (Control.ModifierKeys == Keys.Control)
                Close();
            if (e.Button == MouseButtons.Right)
            {
                ActiveForm.Text = ($"Ширина: {panel1.Width}, Высота: {panel1.Height}");
            }
            
             if (
                    panel1.Bottom + 23 == Cursor.Position.Y // 23 - размер заголовка окна
                    ||
                    panel1.Top + 23 == Cursor.Position.Y
                    ||
                    panel1.Left == Cursor.Position.X
                    ||
                    panel1.Right == Cursor.Position.X)
                    MessageBox.Show($"Нажатие ЛКМ зафиксировано на границе прямоугольника по координатам {MousePosition} ");
                else if (panel1.Bounds.Contains(Cursor.Position))
                    MessageBox.Show($"Нажатие ЛКМ зафиксировано внутри прямоугольника по координатам {MousePosition} ");

                else
                    MessageBox.Show($"Нажатие ЛКМ зафиксировано снаружи прямоугольника по координатам {MousePosition} ");
               
            

        }
        

        
    }
}
