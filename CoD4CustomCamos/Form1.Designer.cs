namespace CoD4CustomCamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the CoD4 Custom Camo Organizer!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "!IMPORTANT! Place this EXE in your Call of Duty 4/main folder, \r\notherwise this w" +
    "ill not work!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "THIS WILL NOT INSTALL YOUR CAMOS FOR YOU\r\nYOU MUST DO THAT MANUALLY\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "If you want to apply custom camos into CoD4, click this.\r\nThis will change all th" +
    "e files needed to install custom camos\r\nTHIS WILL NOT INSTALL YOUR CAMOS FOR YOU" +
    ".";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "How to install custom camos?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CoD4 Organiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}

