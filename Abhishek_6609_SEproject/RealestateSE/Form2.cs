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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Agentbtn_Click(object sender, EventArgs e)
        {
            Form3 OBJ1 = new Form3();
            OBJ1.Show();
        }

        private void Mbtn_Click(object sender, EventArgs e)
        {
            Form3 OBJ2 = new Form3();
            OBJ2.Show();
        }
    }
}
