namespace Vehicle_Automation
{
    partial class Delete_Staff
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
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl28 = new System.Windows.Forms.Label();
            this.labl6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmb7 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(86, 107);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(38, 18);
            this.lbl8.TabIndex = 21;
            this.lbl8.Text = "Code";
            // 
            // lbl28
            // 
            this.lbl28.AutoSize = true;
            this.lbl28.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl28.Location = new System.Drawing.Point(47, 60);
            this.lbl28.Name = "lbl28";
            this.lbl28.Size = new System.Drawing.Size(77, 18);
            this.lbl28.TabIndex = 20;
            this.lbl28.Text = "Department";
            // 
            // labl6
            // 
            this.labl6.AutoSize = true;
            this.labl6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl6.Location = new System.Drawing.Point(102, 9);
            this.labl6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labl6.Name = "labl6";
            this.labl6.Size = new System.Drawing.Size(134, 27);
            this.labl6.TabIndex = 19;
            this.labl6.Text = "Delete Staff";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 23);
            this.comboBox1.TabIndex = 23;
            // 
            // cmb7
            // 
            this.cmb7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb7.FormattingEnabled = true;
            this.cmb7.Items.AddRange(new object[] {
            "Driving",
            "Inspection",
            "Management ",
            "Mechanic Section",
            "Operator Section"});
            this.cmb7.Location = new System.Drawing.Point(146, 59);
            this.cmb7.Name = "cmb7";
            this.cmb7.Size = new System.Drawing.Size(130, 23);
            this.cmb7.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmb7);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl28);
            this.Controls.Add(this.labl6);
            this.Name = "Delete_Staff";
            this.Text = "Delete_Staff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_Staff_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl28;
        private System.Windows.Forms.Label labl6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmb7;
        private System.Windows.Forms.Button button1;
    }
}