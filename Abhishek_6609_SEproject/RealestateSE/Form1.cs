using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public interface callFuct
{
    void LinkFt();
}
namespace RealestateSE
{
    public partial class Form1 : Form,callFuct
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void topLbl_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mLabel_Click(object sender, EventArgs e)
        {

        }

        private void UBtn_Click(object sender, EventArgs e)
        {
            Form2 aw = new Form2();
            aw.Show();
        }
        public void LinkFt()
        {

        }
    }
}
