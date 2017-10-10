namespace ColleagueWebApiTester
{
    partial class FormMain
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApiUrl = new System.Windows.Forms.TextBox();
            this.textBoxServiceEndpoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxResponse = new System.Windows.Forms.RichTextBox();
            this.textBoxSessionToken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSendRequest = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPostData = new System.Windows.Forms.TextBox();
            this.checkBoxPost = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.Upload.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "API URL";
            // 
            // textBoxApiUrl
            // 
            this.textBoxApiUrl.Location = new System.Drawing.Point(15, 26);
            this.textBoxApiUrl.Name = "textBoxApiUrl";
            this.textBoxApiUrl.Size = new System.Drawing.Size(277, 20);
            this.textBoxApiUrl.TabIndex = 1;
            // 
            // textBoxServiceEndpoint
            // 
            this.textBoxServiceEndpoint.Location = new System.Drawing.Point(298, 26);
            this.textBoxServiceEndpoint.Name = "textBoxServiceEndpoint";
            this.textBoxServiceEndpoint.Size = new System.Drawing.Size(175, 20);
            this.textBoxServiceEndpoint.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Endpoint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(15, 69);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(175, 20);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(196, 69);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(175, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(377, 66);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(96, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxResponse);
            this.groupBox1.Controls.Add(this.textBoxSessionToken);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(18, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 199);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // richTextBoxResponse
            // 
            this.richTextBoxResponse.Location = new System.Drawing.Point(6, 76);
            this.richTextBoxResponse.Name = "richTextBoxResponse";
            this.richTextBoxResponse.Size = new System.Drawing.Size(443, 117);
            this.richTextBoxResponse.TabIndex = 4;
            this.richTextBoxResponse.Text = "";
            // 
            // textBoxSessionToken
            // 
            this.textBoxSessionToken.Location = new System.Drawing.Point(6, 37);
            this.textBoxSessionToken.Name = "textBoxSessionToken";
            this.textBoxSessionToken.ReadOnly = true;
            this.textBoxSessionToken.Size = new System.Drawing.Size(443, 20);
            this.textBoxSessionToken.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Response";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Session Token";
            // 
            // buttonSendRequest
            // 
            this.buttonSendRequest.Location = new System.Drawing.Point(360, 500);
            this.buttonSendRequest.Name = "buttonSendRequest";
            this.buttonSendRequest.Size = new System.Drawing.Size(113, 23);
            this.buttonSendRequest.TabIndex = 10;
            this.buttonSendRequest.Text = "Send Request";
            this.buttonSendRequest.UseVisualStyleBackColor = true;
            this.buttonSendRequest.Click += new System.EventHandler(this.buttonSendRequest_Click);
            // 
            // Upload
            // 
            this.Upload.Controls.Add(this.checkBoxPost);
            this.Upload.Controls.Add(this.textBoxPostData);
            this.Upload.Controls.Add(this.label9);
            this.Upload.Location = new System.Drawing.Point(18, 96);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(455, 193);
            this.Upload.TabIndex = 11;
            this.Upload.TabStop = false;
            this.Upload.Text = "Upload";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Post";
            // 
            // textBoxPostData
            // 
            this.textBoxPostData.Location = new System.Drawing.Point(10, 37);
            this.textBoxPostData.Multiline = true;
            this.textBoxPostData.Name = "textBoxPostData";
            this.textBoxPostData.Size = new System.Drawing.Size(439, 150);
            this.textBoxPostData.TabIndex = 1;
            // 
            // checkBoxPost
            // 
            this.checkBoxPost.AutoSize = true;
            this.checkBoxPost.Location = new System.Drawing.Point(380, 16);
            this.checkBoxPost.Name = "checkBoxPost";
            this.checkBoxPost.Size = new System.Drawing.Size(69, 17);
            this.checkBoxPost.TabIndex = 2;
            this.checkBoxPost.Text = "Use Post";
            this.checkBoxPost.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(485, 535);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.buttonSendRequest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxServiceEndpoint);
            this.Controls.Add(this.textBoxApiUrl);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(501, 574);
            this.MinimumSize = new System.Drawing.Size(501, 574);
            this.Name = "FormMain";
            this.Text = "Colleague Web API Tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Upload.ResumeLayout(false);
            this.Upload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApiUrl;
        private System.Windows.Forms.TextBox textBoxServiceEndpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSendRequest;
        private System.Windows.Forms.TextBox textBoxSessionToken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxResponse;
        private System.Windows.Forms.GroupBox Upload;
        private System.Windows.Forms.CheckBox checkBoxPost;
        private System.Windows.Forms.TextBox textBoxPostData;
        private System.Windows.Forms.Label label9;
    }
}

