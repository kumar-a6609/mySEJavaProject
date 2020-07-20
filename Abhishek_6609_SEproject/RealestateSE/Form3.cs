using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealestateSE
{
    public partial class Form3 : Form, validt
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            validateUser();
        }

        private void HmBtn_Click(object sender, EventArgs e)
        {
            Form1 obj12 = new Form1();
            obj12.Show();

        }
        protected void validateUser()
        {
             if (userTB.Text == "01" && passTB.Text == "1125")
            {
                tpPnl.Hide();
                tpLbl.Hide();
                Form4 obj3 = new Form4();
                obj3.Show();

            }
            else
            {
                tpPnl.Show();
                tpLbl.Show();
            }
        }

        void validt.validateUser()
        {
            throw new NotImplementedException();
        }
    }
}
