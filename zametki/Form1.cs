using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zametki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dobavit_Click(object sender, EventArgs e)
        {
            TextBox dobav = new TextBox();
            this.Controls.Add(dobav);
            dobav.Location = new Point(100, 200);
            dobav.MouseMove += TextBox1_MouseMove;
            dobav.MouseHover += TextBox1_MouseHover;
            


        }

        private void TextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox textBox1 = new TextBox();
            Control dobav = sender as Control;




            dobav.Cursor = System.Windows.Forms.Cursors.SizeAll;
            if (e.Button == MouseButtons.Left)
            {
                dobav.Location = this.PointToClient(Control.MousePosition);
            }

        }

        private void TextBox1_MouseHover(object sender, EventArgs e)
        {
            Control dobav = sender as Control;
            ToolTip t = new ToolTip();
            t.SetToolTip(dobav, "Подсказка для TextBox");
            
        }

    }
}
