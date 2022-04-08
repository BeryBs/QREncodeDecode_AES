namespace QREncodeDecode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(70, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Decode";
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(570, 165);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(181, 23);
            this.txtEncode.TabIndex = 3;
            this.txtEncode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(571, 239);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(180, 23);
            this.txtDecode.TabIndex = 4;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(767, 158);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 35);
            this.btnEncode.TabIndex = 5;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(767, 231);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 37);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "ClipboardEncode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(868, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.txtEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtEncode;
        private TextBox txtDecode;
        private Button btnEncode;
        private Button btnDecode;
        private Button button1;
    }
}