namespace RealestateSE
{
    partial class Form2
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.topLbl = new System.Windows.Forms.Label();
            this.Agentbtn = new System.Windows.Forms.Button();
            this.Mbtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.topPanel.Controls.Add(this.topLbl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 23);
            this.topPanel.TabIndex = 5;
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topLbl.Location = new System.Drawing.Point(257, 2);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(242, 16);
            this.topLbl.TabIndex = 0;
            this.topLbl.Text = "Abhishek housing management system";
            // 
            // Agentbtn
            // 
            this.Agentbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Agentbtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agentbtn.Location = new System.Drawing.Point(314, 110);
            this.Agentbtn.Name = "Agentbtn";
            this.Agentbtn.Size = new System.Drawing.Size(210, 72);
            this.Agentbtn.TabIndex = 6;
            this.Agentbtn.Text = "EMPLOYEE";
            this.Agentbtn.UseVisualStyleBackColor = false;
            this.Agentbtn.Click += new System.EventHandler(this.Agentbtn_Click);
            // 
            // Mbtn
            // 
            this.Mbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Mbtn.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbtn.Location = new System.Drawing.Point(314, 250);
            this.Mbtn.Name = "Mbtn";
            this.Mbtn.Size = new System.Drawing.Size(210, 71);
            this.Mbtn.TabIndex = 7;
            this.Mbtn.Text = "USER SIGN IN";
            this.Mbtn.UseVisualStyleBackColor = false;
            this.Mbtn.Click += new System.EventHandler(this.Mbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mbtn);
            this.Controls.Add(this.Agentbtn);
            this.Controls.Add(this.topPanel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Button Agentbtn;
        private System.Windows.Forms.Button Mbtn;
    }
}