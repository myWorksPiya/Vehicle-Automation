namespace Vehicle_Automation
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
            this.tbcontrol1 = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.tbcontrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcontrol1
            // 
            this.tbcontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcontrol1.Controls.Add(this.tb1);
            this.tbcontrol1.Controls.Add(this.tb2);
            this.tbcontrol1.Controls.Add(this.tb3);
            this.tbcontrol1.Location = new System.Drawing.Point(175, 1);
            this.tbcontrol1.Name = "tbcontrol1";
            this.tbcontrol1.SelectedIndex = 0;
            this.tbcontrol1.Size = new System.Drawing.Size(604, 497);
            this.tbcontrol1.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(4, 22);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(596, 471);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Safety and Maintanence Details";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(4, 22);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(596, 471);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Vehicle Details";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(4, 22);
            this.tb3.Name = "tb3";
            this.tb3.Padding = new System.Windows.Forms.Padding(3);
            this.tb3.Size = new System.Drawing.Size(596, 471);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Staff Details";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 142);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(157, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Safety n Maintanence Details";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 171);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(157, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Vehicle Details";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 200);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(157, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Staff Details";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 229);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(157, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Update Safety Report";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(13, 258);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(156, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "Update Maintenance Log";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 496);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbcontrol1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Iden Solo Transport Services";
            this.tbcontrol1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcontrol1;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
    }
}

