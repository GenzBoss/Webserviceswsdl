namespace Solution4and5
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.num1textbox = new System.Windows.Forms.TextBox();
            this.num2textbox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.anslab = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.labeltoenctxt = new System.Windows.Forms.Label();
            this.encrypted = new System.Windows.Forms.Label();
            this.plaintxt = new System.Windows.Forms.TextBox();
            this.encytnow = new System.Windows.Forms.Button();
            this.sndtoreciver = new System.Windows.Forms.Button();
            this.ciphertxt = new System.Windows.Forms.TextBox();
            this.decyttxtmesg = new System.Windows.Forms.Label();
            this.plaintxtdecrypted = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1333, 578);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(694, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(740, 16);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 31);
            this.Go.TabIndex = 2;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Go);
            this.groupBox1.Location = new System.Drawing.Point(107, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // num1textbox
            // 
            this.num1textbox.Location = new System.Drawing.Point(123, 402);
            this.num1textbox.Name = "num1textbox";
            this.num1textbox.Size = new System.Drawing.Size(100, 26);
            this.num1textbox.TabIndex = 8;
            // 
            // num2textbox
            // 
            this.num2textbox.Location = new System.Drawing.Point(245, 402);
            this.num2textbox.Name = "num2textbox";
            this.num2textbox.Size = new System.Drawing.Size(100, 26);
            this.num2textbox.TabIndex = 9;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(132, 457);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 28);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(190, 457);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(33, 28);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(245, 457);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(30, 28);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(296, 457);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(32, 28);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // anslab
            // 
            this.anslab.AutoSize = true;
            this.anslab.Location = new System.Drawing.Point(302, 515);
            this.anslab.Name = "anslab";
            this.anslab.Size = new System.Drawing.Size(14, 20);
            this.anslab.TabIndex = 15;
            this.anslab.Text = "-";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(165, 515);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(110, 20);
            this.result.TabIndex = 16;
            this.result.Text = "Show result ->";
            // 
            // labeltoenctxt
            // 
            this.labeltoenctxt.AutoSize = true;
            this.labeltoenctxt.Location = new System.Drawing.Point(563, 294);
            this.labeltoenctxt.Name = "labeltoenctxt";
            this.labeltoenctxt.Size = new System.Drawing.Size(314, 20);
            this.labeltoenctxt.TabIndex = 17;
            this.labeltoenctxt.Text = "Please Type Your Message in the Text Box:";
            // 
            // encrypted
            // 
            this.encrypted.AutoSize = true;
            this.encrypted.Location = new System.Drawing.Point(563, 431);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(18, 20);
            this.encrypted.TabIndex = 18;
            this.encrypted.Text = ":-";
            // 
            // plaintxt
            // 
            this.plaintxt.Location = new System.Drawing.Point(567, 338);
            this.plaintxt.Name = "plaintxt";
            this.plaintxt.Size = new System.Drawing.Size(337, 26);
            this.plaintxt.TabIndex = 19;
            // 
            // encytnow
            // 
            this.encytnow.Location = new System.Drawing.Point(567, 384);
            this.encytnow.Name = "encytnow";
            this.encytnow.Size = new System.Drawing.Size(161, 29);
            this.encytnow.TabIndex = 20;
            this.encytnow.Text = "Encrypt Now";
            this.encytnow.UseVisualStyleBackColor = true;
            this.encytnow.Click += new System.EventHandler(this.encytnow_Click);
            // 
            // sndtoreciver
            // 
            this.sndtoreciver.Location = new System.Drawing.Point(967, 386);
            this.sndtoreciver.Name = "sndtoreciver";
            this.sndtoreciver.Size = new System.Drawing.Size(251, 27);
            this.sndtoreciver.TabIndex = 21;
            this.sndtoreciver.Text = "Send To Reciever";
            this.sndtoreciver.UseVisualStyleBackColor = true;
            this.sndtoreciver.Click += new System.EventHandler(this.sndtoreciver_Click);
            // 
            // ciphertxt
            // 
            this.ciphertxt.Location = new System.Drawing.Point(967, 338);
            this.ciphertxt.Name = "ciphertxt";
            this.ciphertxt.Size = new System.Drawing.Size(306, 26);
            this.ciphertxt.TabIndex = 22;
            // 
            // decyttxtmesg
            // 
            this.decyttxtmesg.AutoSize = true;
            this.decyttxtmesg.Location = new System.Drawing.Point(972, 294);
            this.decyttxtmesg.Name = "decyttxtmesg";
            this.decyttxtmesg.Size = new System.Drawing.Size(144, 20);
            this.decyttxtmesg.TabIndex = 24;
            this.decyttxtmesg.Text = "add text to decrypt:";
            // 
            // plaintxtdecrypted
            // 
            this.plaintxtdecrypted.AutoSize = true;
            this.plaintxtdecrypted.Location = new System.Drawing.Point(967, 431);
            this.plaintxtdecrypted.Name = "plaintxtdecrypted";
            this.plaintxtdecrypted.Size = new System.Drawing.Size(18, 20);
            this.plaintxtdecrypted.TabIndex = 25;
            this.plaintxtdecrypted.Text = ":-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 578);
            this.Controls.Add(this.plaintxtdecrypted);
            this.Controls.Add(this.decyttxtmesg);
            this.Controls.Add(this.ciphertxt);
            this.Controls.Add(this.sndtoreciver);
            this.Controls.Add(this.encytnow);
            this.Controls.Add(this.plaintxt);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.labeltoenctxt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.anslab);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num2textbox);
            this.Controls.Add(this.num1textbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox num1textbox;
        private System.Windows.Forms.TextBox num2textbox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label anslab;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label labeltoenctxt;
        private System.Windows.Forms.Label encrypted;
        private System.Windows.Forms.TextBox plaintxt;
        private System.Windows.Forms.Button encytnow;
        private System.Windows.Forms.Button sndtoreciver;
        private System.Windows.Forms.TextBox ciphertxt;
        private System.Windows.Forms.Label decyttxtmesg;
        private System.Windows.Forms.Label plaintxtdecrypted;
    }
}

