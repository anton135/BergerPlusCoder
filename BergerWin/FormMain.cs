using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BergerPlusLib;

namespace BergerWin
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (tbBinaryIn.Text != "")
            {
                BergerPCoder bc = new BergerPCoder();
                tbBinaryOut.Text = bc.CodeBinaryStringBlock(tbBinaryIn.Text);
                lbK.Text = "K=" + bc.LenthOfInfo;
                lbMu.Text = "Mu=" + bc.Mu;
                lbR.Text = "R=" + bc.R;

                tbWeights.Text = "";
                foreach (var item in bc.GenerateWeightedCombination(tbBinaryIn.Text))
                {
                    
                    tbWeights.Text += item.Value + " - " + item.Key + Environment.NewLine;
                }
            }
        }
    }
}
