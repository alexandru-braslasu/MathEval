using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathEval
{
    public partial class MathEval : Form
    {
        public MathEval()
        {
            InitializeComponent();
        }

        private void generator_Click(object sender, EventArgs e)
        {

        }

        private void succes_Click_1(object sender, EventArgs e)
        {
            var window = new test();
            window.Show();
        }

        private void MathEval_Load(object sender, EventArgs e)
        {

        }
    }
}
