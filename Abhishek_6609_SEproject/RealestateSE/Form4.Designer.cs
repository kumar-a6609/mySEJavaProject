namespace RealestateSE
{
    partial class Form4
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
            this.bTN1 = new System.Windows.Forms.Button();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.HmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bTN1
            // 
            this.bTN1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bTN1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTN1.Location = new System.Drawing.Point(206, 36);
            this.bTN1.Name = "bTN1";
            this.bTN1.Size = new System.Drawing.Size(151, 59);
            this.bTN1.TabIndex = 6;
            this.bTN1.Text = "Agent Profile";
            this.bTN1.UseVisualStyleBackColor = false;
            this.bTN1.Click += new System.EventHandler(this.bTN1_Click);
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.ItemHeight = 20;
            this.DisplayListBox.Location = new System.Drawing.Point(395, 36);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.ScrollAlwaysVisible = true;
            this.DisplayListBox.Size = new System.Drawing.Size(559, 384);
            this.DisplayListBox.TabIndex = 9;
            this.DisplayListBox.Visible = false;
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN2.Location = new System.Drawing.Point(201, 180);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(156, 57);
            this.BTN2.TabIndex = 10;
            this.BTN2.Text = "REPORT";
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN3
            // 
            this.BTN3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTN3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN3.Location = new System.Drawing.Point(201, 330);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(156, 57);
            this.BTN3.TabIndex = 11;
            this.BTN3.Text = "Sales Catalog";
            this.BTN3.UseVisualStyleBackColor = false;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // HmBtn
            // 
            this.HmBtn.Location = new System.Drawing.Point(12, 23);
            this.HmBtn.Name = "HmBtn";
            this.HmBtn.Size = new System.Drawing.Size(113, 32);
            this.HmBtn.TabIndex = 12;
            this.HmBtn.Text = "HOME";
            this.HmBtn.UseVisualStyleBackColor = true;
            this.HmBtn.Click += new System.EventHandler(this.HmBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.HmBtn);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.bTN1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTN1;
        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button HmBtn;
    }
}