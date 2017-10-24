using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neyðarsimi
{
    public partial class Form7 : Form
    {
        #region "Classes"
        trial clsTrial = new trial();
        #endregion

        #region "Variable"
        private Form1 fm1;
        public int nr;
        #endregion

        #region "Form7"
        public Form7(Form1 form)
        {
            InitializeComponent();
            fm1 = form; 
        }
        #endregion

        #region "Form load"
        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = clsTrial.getDagur();
        }
        #endregion

        #region "Button"
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            fm1.Close(); 
        }
        #endregion 
    }
}
