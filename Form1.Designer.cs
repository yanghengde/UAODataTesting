namespace OdataTesting
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
            this.txtParams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.token = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtBaseURL = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtParams
            // 
            this.txtParams.Location = new System.Drawing.Point(75, 193);
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(868, 20);
            this.txtParams.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " Params";
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResponse.Location = new System.Drawing.Point(0, 252);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(1168, 413);
            this.txtResponse.TabIndex = 3;
            // 
            // token
            // 
            this.token.AutoSize = true;
            this.token.Location = new System.Drawing.Point(24, 84);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(38, 13);
            this.token.TabIndex = 4;
            this.token.Text = "Token";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(981, 160);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(175, 49);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "  TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(75, 59);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(868, 128);
            this.txtToken.TabIndex = 6;
            // 
            // txtBaseURL
            // 
            this.txtBaseURL.Location = new System.Drawing.Point(75, 21);
            this.txtBaseURL.Name = "txtBaseURL";
            this.txtBaseURL.Size = new System.Drawing.Size(184, 20);
            this.txtBaseURL.TabIndex = 7;
            this.txtBaseURL.Text = "http://CNNDM1VTDM01//";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(303, 21);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 20);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Text = "CNNDM1VTDM01\\admin ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(542, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "SwqaMe$1";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(759, 21);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(184, 20);
            this.txtDomain.TabIndex = 10;
            this.txtDomain.Text = "CNNDM1VTDM01";
            // 
            // btnGetToken
            // 
            this.btnGetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetToken.Location = new System.Drawing.Point(981, 59);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(175, 49);
            this.btnGetToken.TabIndex = 11;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Method";
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.Window;
            this.txtMethod.Location = new System.Drawing.Point(75, 226);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(868, 20);
            this.txtMethod.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.btnGetToken);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtBaseURL);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.token);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParams);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label token;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtBaseURL;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMethod;
    }
}

