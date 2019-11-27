using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shannon
{
    public partial class Form1 : Form
    {
        
        Shannon encode;
        public Dictionary<byte, string> finalCodedList = new Dictionary<byte, string>();
        public string strFileName;
        public Form1()
        {
            
            InitializeComponent();
            checkBoxCoder.Checked = false;
            panelCoder.Hide();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileCoder = new OpenFileDialog();
            try
            {
                if (loadFileCoder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    strFileName = loadFileCoder.FileName;
                    labelFileNameCoder.Text = strFileName;
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not read file from disk");
            }


        } 

        private void encodeFile_Click(object sender, EventArgs e)
        {

            if (labelFileNameCoder.Text=="")
            {
                MessageBox.Show("You forgot the path!!!");

            }
            List<byte> listOfBytes = new List<byte>();
            byte[] contentOfBytes = File.ReadAllBytes(strFileName);
            encode = new Shannon(contentOfBytes);
            encode.EncodeShannon(contentOfBytes,out finalCodedList);
            
             var lines = finalCodedList.Select(kvp => kvp.Key + ": " + kvp.Value);
            shannonOutputTet.Text = string.Join(Environment.NewLine, lines);
            if (checkBoxCoder.Checked)
            {
                panelCoder.Show();
            }
            else
            {
                panelCoder.Hide();
            }
        }



    }
}
