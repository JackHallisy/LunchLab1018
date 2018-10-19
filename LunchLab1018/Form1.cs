using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace LunchLab1018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btWriteDTF_Click(object sender, EventArgs e)
        {
            try
            {
                //string LoopCount = ConfigurationManager.AppSettings["LoopCount"];
                StreamWriter sw = new StreamWriter(@"C:\CC6\Output.text", true);
                sw.WriteLine(System.DateTime.Now.ToString());                                         
                sw.Close();              
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\CC6\Output.text", true);
                
                    string Line = sr.ReadLine();
                    while (Line != null)
                    {
                        tbResults.Text += Line;
                        Line = sr.ReadLine();                                           
                    }
                sr.Close();
            }
            catch (Exception)
            {        
                throw;
            }
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            tbResults.Text = string.Empty;
          
        }
    }
}
                
