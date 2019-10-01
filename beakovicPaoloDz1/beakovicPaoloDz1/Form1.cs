using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beakovicPaoloDz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (chksakri.chacked)
            {

            }
            else
            {
                txtPrikaz.Clear();
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Dorucak. ");
                }
                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Rucak. ");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Večeru. ");
                }
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
             
        }

        private void Chksakri_CheckedChanged(object sender, EventArgs e)
        {
          if(!chksakri.Checked)
            {
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Dorucak. ");
                }
                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Rucak. ");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste Večeru. ");
                }
               

            }

            else
            {
                txtPrikaz.Clear();

            }

        }
    }
}
