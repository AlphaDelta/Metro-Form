namespace Metro
{
    partial class TestForm
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
            this.metroButton1 = new Metro.Controls.MetroButton();
            this.metroButtonToggle1 = new Metro.Controls.MetroButtonToggle();
            this.metroCheckBox1 = new Metro.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "MetroButton";
            this.metroButton1.UseVisualStyleBackColor = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonToggle1
            // 
            this.metroButtonToggle1.Location = new System.Drawing.Point(120, 41);
            this.metroButtonToggle1.Name = "metroButtonToggle1";
            this.metroButtonToggle1.Size = new System.Drawing.Size(102, 23);
            this.metroButtonToggle1.TabIndex = 2;
            this.metroButtonToggle1.Text = "MetroButtonToggle";
            this.metroButtonToggle1.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.Location = new System.Drawing.Point(12, 70);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(436, 17);
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "MetroCheckBox";
            this.metroCheckBox1.UseVisualStyleBackColor = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 253);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroButtonToggle1);
            this.Controls.Add(this.metroButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestForm";
            this.Text = "Test form with long title";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MetroButton metroButton1;
        private Controls.MetroButtonToggle metroButtonToggle1;
        private Controls.MetroCheckBox metroCheckBox1;


    }
}

