using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASPS_2023
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel1.Left = 0;
            panel2.Width = this.Width;
            panel2.Left = 0;
            panel1.Height = this.Height / 2;
            panel2.Height = this.Height / 2;
            panel1.Top = 0;
            panel2.Top = panel1.Height;
            panel3.Top = this.Height / 2 - panel3.Height / 2;
            panel3.Left = this.Width / 2 - panel3.Width / 2;
            label_red_name.Top = (panel1.Height - label_red_name.Height) / 2;
            label_blue_name.Top = (panel2.Height - label_blue_name.Height) / 2;
            label_score_red.Top = label_red_name.Top;
            label_score_blue.Top = label_blue_name.Top;
            label_score_red.Left = panel1.Width - label_score_red.Width - 50;
            label_score_blue.Left = label_score_red.Left;

        }
    }
}
