﻿namespace Shannon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LoadFile = new System.Windows.Forms.Button();
            this.labelFileNameCoder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.encodeFile = new System.Windows.Forms.Button();
            this.inputEncodeText = new System.Windows.Forms.TextBox();
            this.encodeInputTextBtn = new System.Windows.Forms.Button();
            this.checkBoxCoder = new System.Windows.Forms.CheckBox();
            this.panelCoder = new System.Windows.Forms.Panel();
            this.shannonOutputTet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCoder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(505, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 546);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Coder";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(532, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 32);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Decoder";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(395, 78);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(90, 26);
            this.LoadFile.TabIndex = 3;
            this.LoadFile.Text = "Load File";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // labelFileNameCoder
            // 
            this.labelFileNameCoder.BackColor = System.Drawing.Color.White;
            this.labelFileNameCoder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFileNameCoder.Location = new System.Drawing.Point(11, 78);
            this.labelFileNameCoder.Margin = new System.Windows.Forms.Padding(2);
            this.labelFileNameCoder.Name = "labelFileNameCoder";
            this.labelFileNameCoder.Size = new System.Drawing.Size(352, 26);
            this.labelFileNameCoder.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(532, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(919, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encodeFile
            // 
            this.encodeFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.encodeFile.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeFile.Location = new System.Drawing.Point(140, 124);
            this.encodeFile.Name = "encodeFile";
            this.encodeFile.Size = new System.Drawing.Size(148, 28);
            this.encodeFile.TabIndex = 7;
            this.encodeFile.Text = "Encode File";
            this.encodeFile.UseVisualStyleBackColor = false;
            this.encodeFile.Click += new System.EventHandler(this.encodeFile_Click);
            // 
            // inputEncodeText
            // 
            this.inputEncodeText.Location = new System.Drawing.Point(12, 171);
            this.inputEncodeText.Multiline = true;
            this.inputEncodeText.Name = "inputEncodeText";
            this.inputEncodeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputEncodeText.Size = new System.Drawing.Size(180, 234);
            this.inputEncodeText.TabIndex = 8;
            this.inputEncodeText.TextChanged += new System.EventHandler(this.inputEncodeText_TextChanged);
            // 
            // encodeInputTextBtn
            // 
            this.encodeInputTextBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.encodeInputTextBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeInputTextBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.encodeInputTextBtn.Location = new System.Drawing.Point(12, 424);
            this.encodeInputTextBtn.Margin = new System.Windows.Forms.Padding(5);
            this.encodeInputTextBtn.Name = "encodeInputTextBtn";
            this.encodeInputTextBtn.Size = new System.Drawing.Size(178, 27);
            this.encodeInputTextBtn.TabIndex = 9;
            this.encodeInputTextBtn.Text = "Encode input text";
            this.encodeInputTextBtn.UseVisualStyleBackColor = false;
            this.encodeInputTextBtn.Click += new System.EventHandler(this.encodeInputTextBtn_Click);
            // 
            // checkBoxCoder
            // 
            this.checkBoxCoder.AutoSize = true;
            this.checkBoxCoder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.checkBoxCoder.Location = new System.Drawing.Point(217, 227);
            this.checkBoxCoder.Name = "checkBoxCoder";
            this.checkBoxCoder.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCoder.TabIndex = 10;
            this.checkBoxCoder.Text = "Show codes";
            this.checkBoxCoder.UseVisualStyleBackColor = true;
            // 
            // panelCoder
            // 
            this.panelCoder.Controls.Add(this.shannonOutputTet);
            this.panelCoder.Location = new System.Drawing.Point(308, 171);
            this.panelCoder.Name = "panelCoder";
            this.panelCoder.Size = new System.Drawing.Size(176, 233);
            this.panelCoder.TabIndex = 11;
            // 
            // shannonOutputTet
            // 
            this.shannonOutputTet.Location = new System.Drawing.Point(5, 8);
            this.shannonOutputTet.Multiline = true;
            this.shannonOutputTet.Name = "shannonOutputTet";
            this.shannonOutputTet.Size = new System.Drawing.Size(158, 208);
            this.shannonOutputTet.TabIndex = 0;
            this.shannonOutputTet.TextChanged += new System.EventHandler(this.shannonOutputTet_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(604, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 233);
            this.panel1.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 8);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 208);
            this.textBox3.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.checkBox1.Location = new System.Drawing.Point(885, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show codes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(536, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 26);
            this.label3.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(636, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Decode File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCoder);
            this.Controls.Add(this.checkBoxCoder);
            this.Controls.Add(this.encodeInputTextBtn);
            this.Controls.Add(this.inputEncodeText);
            this.Controls.Add(this.encodeFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFileNameCoder);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCoder.ResumeLayout(false);
            this.panelCoder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Label labelFileNameCoder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button encodeFile;
        private System.Windows.Forms.TextBox inputEncodeText;
        private System.Windows.Forms.Button encodeInputTextBtn;
        private System.Windows.Forms.CheckBox checkBoxCoder;
        private System.Windows.Forms.Panel panelCoder;
        private System.Windows.Forms.TextBox shannonOutputTet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

