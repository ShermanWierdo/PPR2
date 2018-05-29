using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uppg33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal = double.Parse (tbxSiffra.Text) + 0.5;
            int avrundning = (int)tal;
            lblSvar.Text = avrundning.ToString();
        }
    }
}
