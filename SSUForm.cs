using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU_Kotova
{
    public partial class SSUForm : Form
    {
        public SSUForm ()
        {
            InitializeComponent ();
            ButtonStandardColor = searchButton.BackColor;
        }

        private Color ButtonStandardColor { get; set; }
        private Point LastPointWindow { get; set; }

        private void question_TextChanged (object sender, EventArgs e)
        {
            string[] question = this.question.Lines;
        }

        private void searchButton_Click (object sender, EventArgs e)
        {

        }

        private void searchButton_MouseEnter (object sender, EventArgs e)
        {
            searchButton.BackColor = Color.Green;
        }

        private void searchButton_MouseLeave (object sender, EventArgs e)
        {
            searchButton.BackColor = ButtonStandardColor;
        }

        private void SSUForm_MouseMove (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPointWindow.X;
                this.Top += e.Y - LastPointWindow.Y;
            }
        }

        private void SSUForm_MouseDown (object sender, MouseEventArgs e)
        {
            LastPointWindow = new Point (e.X, e.Y);
        }
    }
}
