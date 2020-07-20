using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RealestateSE
{
    public partial class Form4 : Form, funct
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bTN1_Click(object sender, EventArgs e)
        {
            addEditAgent();
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            //Form5 obj5 = new Form5();
            //obj5.Show();
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            salesCatalog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void HmBtn_Click(object sender, EventArgs e)
        {
            Form1 ob11 = new Form1();
            ob11.Show();
        }
        protected void addEditAgent()
        {
            DisplayListBox.Show();
            try
            {
                using (StreamReader myInputStream
                    = new StreamReader("employees.txt"))
                {
                    DisplayListBox.Items.Clear();
                    DisplayListBox.Items.Add("\t\t\tAgents" + "   " + "Agent ID");
                    string eachLine;
                    while (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        eachLine.Trim('\r', '\n');
                        string[] Earray = eachLine.Split(',');
                        string empName = Earray[0];
                        string empNum = Earray[1];


                        DisplayListBox.Items.Add("\t\t\t" + empName + "\t" + empNum);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void salesCatalog()
        {
            DisplayListBox.Show();
            try
            {
                using (StreamReader myInputStream
                    = new StreamReader("Property.txt"))
                {
                    DisplayListBox.Items.Clear();
                    DisplayListBox.Items.Add("\t\t\t" + "SALES REPORT");
                    DisplayListBox.Items.Add("\t\t\tMonthly report  ");
                    DisplayListBox.Items.Add("\t" + "Property ID " + "\tHouse type" + " \t  " + "Sold Price" + "\t" + "Date Sold");
                    string eachLine;
                    while (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        eachLine.Trim('\r', '\n');
                        string[] Earray = eachLine.Split(',');
                        string PropID = Earray[0];
                        string PropName = Earray[1];
                        string PropPrice = Earray[2];
                        string PropDOS = Earray[3];


                        DisplayListBox.Items.Add("\t" + PropID + "\t\t" + PropName + "\t\t" + PropPrice + "\t\t" + PropDOS);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void funct.addEditAgent()
        {
            throw new NotImplementedException();
        }
    }
    
        
    
}
