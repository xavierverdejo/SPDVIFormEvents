using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIFormEvents
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(780, 550);
            addLine("Main Form loaded.");
        }

        private void mainForm_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) { addLine("Left button of the mouse has been clicked over the main form."); }
            if (e.Button == MouseButtons.Left) { addLine("Right button of the mouse has been clicked over the main form."); ; }
        }

        void addLine(string line)
        {
            messagesTextBox.AppendText(line+"\r\n");
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            addLine("System has detected a Double Click on the label.");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            addLine("Numeric Up Down value changed to "+numericUpDown1.Value);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addLine("List Box Selected Index has changed to " + listBox1.SelectedIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            addLine("textBox1 has got the focus now.");
        }
        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            addLine("textBox1 has lost the focus.");
        }
        public char pressed;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            pressed = e.KeyChar;
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(!e.KeyData.ToString().Equals("Shift") && !e.KeyData.ToString().Equals("ShiftKey"))
                addLine("The key '" + pressed + "' has been pressed and released.");
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            addLine("The mouse pointer is inside the image.");
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            addLine("The mouse pointer is outside the image.");
        }
    }
}
