using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Add your custom closing logic here
            DialogResult result = MessageBox.Show("Do you really want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)

            {
                e.Cancel = true; // Cancel the form closing
            }
            // If you want to allow the form to close without any confirmation, just remove the 'if' block.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Calculate new sizes and positions of controls
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Update control properties
            foreach (Control control in this.Controls)
            {
                // Skip the form itself
                if (control == this)
                    continue;

                // Calculate new position and size based on the form's new size
                int newX = (int)Math.Round((double)control.Location.X / this.ClientSize.Width * newWidth);
                int newY = (int)Math.Round((double)control.Location.Y / this.ClientSize.Height * newHeight);
                int newControlWidth = (int)Math.Round((double)control.Width / this.ClientSize.Width * newWidth);
                int newControlHeight = (int)Math.Round((double)control.Height / this.ClientSize.Height * newHeight);

                // Update control's position and size
                control.Location = new System.Drawing.Point(newX, newY);
                control.Size = new System.Drawing.Size(newControlWidth, newControlHeight);
            }
        }
    }
}
