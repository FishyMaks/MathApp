using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            maskedTextBoxTop.KeyPress += new KeyPressEventHandler(maskedTextBox_KeyPress);
            maskedTextBoxTop.KeyDown += new KeyEventHandler(maskedTextBox_KeyDown);
            
            maskedTextBoxBottom.KeyPress += new KeyPressEventHandler(maskedTextBox_KeyPress);
            maskedTextBoxBottom.KeyDown += new KeyEventHandler(maskedTextBox_KeyDown);
        }

        private void btnAdd_Click(object sender, EventArgs e) //add
        {
            double top, bottom;
            if (CanParse(out top, out bottom))
            Output.Text = ($"{top} added by {bottom} = {top + bottom}");
        }

        private void btnSubtract_Click(object sender, EventArgs e) //subtract
        {
            double top, bottom;
            if (CanParse(out top, out bottom))
                Output.Text = ($"{top} subtracted by {bottom} = {top - bottom}");
        }

        private void btnMultiply_Click(object sender, EventArgs e) //multiply
        {
            double top, bottom;
            if (CanParse(out top, out bottom))
                Output.Text = ($"{top} multiplied by {bottom} = {top * bottom}");
        }

        private void btnDivide_Click(object sender, EventArgs e) //divide
        {
            double top, bottom;
            if (CanParse(out top, out bottom, true))
            Output.Text = ($"{top} divided by {bottom} = {top / bottom}");
        }

        private void Exit_Click(object sender, EventArgs e) //exit
        {
            Exit exit = new Exit();
            DialogResult dialogResult = exit.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }else if (dialogResult == DialogResult.Cancel)
            {
                exit.Dispose();
            }
        }

        private bool CanParse(out double numTop, out double numBottom, bool isDivision = false)
        {
            bool top = true;
            bool bottom = true;
            numTop = 0;
            if (!double.TryParse(maskedTextBoxTop.Text, out numTop))
            {
                toolTipTop.ToolTipTitle = "Error";
                toolTipTop.Show("Not a valid number.", maskedTextBoxTop);
                top = false;
            }
            if (!double.TryParse(maskedTextBoxBottom.Text, out numBottom))
            {
                toolTipBottom.ToolTipTitle = "Error";
                toolTipBottom.Show("Not a valid number.", maskedTextBoxBottom);
                bottom = false;
            }
            if (isDivision == true && bottom == true && numBottom == 0)
            {
                toolTipBottom.ToolTipTitle = "Error";
                toolTipBottom.Show("You can't divide by zero.", maskedTextBoxBottom);
                bottom = false;
            }
            return top && bottom;
        }


        private bool nonNumberEntered = false;
        private void maskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            toolTipTop.Hide(maskedTextBoxTop);
            toolTipBottom.Hide(maskedTextBoxBottom);

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift) { nonNumberEntered = true; }
        }
        private void maskedTextBox_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
            nonNumberEntered = false;
        }
    }
}
