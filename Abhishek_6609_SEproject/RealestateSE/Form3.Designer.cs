namespace RealestateSE
{
    partial class Form3
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
            this.tpPnl = new System.Windows.Forms.Panel();
            this.tpLbl = new System.Windows.Forms.Label();
            this.panelbody = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.userTB = new System.Windows.Forms.TextBox();
            this.HmBtn = new System.Windows.Forms.Button();
            this.tpPnl.SuspendLayout();
            this.panelbody.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpPnl
            // 
            this.tpPnl.BackColor = System.Drawing.Color.ForestGreen;
            this.tpPnl.Controls.Add(this.tpLbl);
            this.tpPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpPnl.Location = new System.Drawing.Point(0, 0);
            this.tpPnl.Name = "tpPnl";
            this.tpPnl.Size = new System.Drawing.Size(800, 26);
            this.tpPnl.TabIndex = 6;
            this.tpPnl.Visible = false;
            // 
            // tpLbl
            // 
            this.tpLbl.AutoSize = true;
            this.tpLbl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tpLbl.Location = new System.Drawing.Point(264, 4);
            this.tpLbl.Name = "tpLbl";
            this.tpLbl.Size = new System.Drawing.Size(235, 20);
            this.tpLbl.TabIndex = 0;
            this.tpLbl.Text = "The User id and Password Did not match";
            this.tpLbl.Visible = false;
            // 
            // panelbody
            // 
            this.panelbody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelbody.Controls.Add(this.HmBtn);
            this.panelbody.Controls.Add(this.loginBtn);
            this.panelbody.Controls.Add(this.passLabel);
            this.panelbody.Controls.Add(this.userLabel);
            this.panelbody.Controls.Add(this.passTB);
            this.panelbody.Controls.Add(this.userTB);
            this.panelbody.Location = new System.Drawing.Point(90, 51);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(620, 348);
            this.panelbody.TabIndex = 7;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(232, 205);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(101, 30);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(131, 144);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(68, 16);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(146, 74);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 16);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "User ID";
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTB.Location = new System.Drawing.Point(220, 137);
            this.passTB.Multiline = true;
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(174, 30);
            this.passTB.TabIndex = 6;
            // 
            // userTB
            // 
            this.userTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTB.Location = new System.Drawing.Point(219, 71);
            this.userTB.Multiline = true;
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(174, 30);
            this.userTB.TabIndex = 5;
            // 
            // HmBtn
            // 
            this.HmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HmBtn.Location = new System.Drawing.Point(362, 205);
            this.HmBtn.Name = "HmBtn";
            this.HmBtn.Size = new System.Drawing.Size(101, 30);
            this.HmBtn.TabIndex = 10;
            this.HmBtn.Text = "HOME";
            this.HmBtn.UseVisualStyleBackColor = true;
            this.HmBtn.Click += new System.EventHandler(this.HmBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.tpPnl);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tpPnl.ResumeLayout(false);
            this.tpPnl.PerformLayout();
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tpPnl;
        private System.Windows.Forms.Label tpLbl;
        private System.Windows.Forms.Panel panelbody;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Button HmBtn;
    }
}