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
        Shannon decode;
        public int b;
        public Dictionary<byte, string> finalCodedList = new Dictionary<byte, string>();
        public Dictionary<byte, string> flux = new Dictionary<byte, string>();
        public string strFileName;
        public string strFileNameIn;
        public Form1()
        {
            
            InitializeComponent();
            checkBoxCoder.Checked = false;
            panelCoder.Hide();
            checkBox1.Checked = false;
            panel1.Hide();
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
            encode = new Shannon(contentOfBytes, strFileName);
             b = 1;
            encode.EncodeShannon(contentOfBytes,b,out finalCodedList);
            
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

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog loadFileCoder1 = new OpenFileDialog();
            loadFileCoder1.Filter =
                "Shannon|*.SF";
            try
            {
                if (loadFileCoder1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                  

                    strFileNameIn = loadFileCoder1.FileName;
                    label3.Text = strFileNameIn;
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not read file from disk");
            }
        }

        private void shannonOutputTet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("You forgot the path!!!");

            }
           // List<byte> listOfBytes = new List<byte>();
           // byte[] contentOfBytes = File.ReadAllBytes(strFileName);
            decode = new Shannon(strFileNameIn);

            decode.DecodeShannon(strFileNameIn,out flux);

           var lines = flux.Select(kvp => kvp.Key + ": " + kvp.Value);
            textBox3.Text = string.Join(Environment.NewLine, lines);
            if (checkBox1.Checked)
            {
                panel1.Show();
            }
            else
            {
                panel1.Hide();
            }
        }

        private void inputEncodeText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void encodeInputTextBtn_Click(object sender, EventArgs e)
        {

           
  
           
            string read = inputEncodeText.Text;
            string temp = read.Replace("\r\n", "");
            List<byte> listOfBytes = new List<byte>();
            
            for (int i = 0; i < temp.Length; i++)
            {
                char a = (char)temp[i];
                listOfBytes.Add((byte)a);
            }

            byte[] content = new byte[listOfBytes.Count];
            for (int j = 0; j < listOfBytes.Count(); j++)
            {
                content[j] = listOfBytes[j]; 
            }

             b = 0;
            encode = new Shannon(content, strFileName);
             encode.EncodeShannon(content,b, out finalCodedList);

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
