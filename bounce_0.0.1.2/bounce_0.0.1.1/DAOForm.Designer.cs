namespace bounce_0._0._1._1
{
    partial class DAOForm
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
            this.loginLogin = new System.Windows.Forms.TextBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlertLoginLabel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.regpass = new System.Windows.Forms.TextBox();
            this.reglogin = new System.Windows.Forms.TextBox();
            this.confirmRegist = new System.Windows.Forms.Button();
            this.regpanel = new System.Windows.Forms.Panel();
            this.AlertRegisterLabel = new System.Windows.Forms.Label();
            this.regpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLogin
            // 
            this.loginLogin.Location = new System.Drawing.Point(73, 40);
            this.loginLogin.Name = "loginLogin";
            this.loginLogin.Size = new System.Drawing.Size(134, 20);
            this.loginLogin.TabIndex = 0;
            this.loginLogin.Text = "Логін";
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(73, 66);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(134, 20);
            this.passwordLogin.TabIndex = 1;
            this.passwordLogin.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть дані , щоб уввійти";
            // 
            // AlertLoginLabel
            // 
            this.AlertLoginLabel.AutoSize = true;
            this.AlertLoginLabel.Location = new System.Drawing.Point(70, 118);
            this.AlertLoginLabel.Name = "AlertLoginLabel";
            this.AlertLoginLabel.Size = new System.Drawing.Size(0, 13);
            this.AlertLoginLabel.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(73, 92);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(134, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Увійти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(73, 183);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(134, 23);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Зареєструватися";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // regpass
            // 
            this.regpass.Location = new System.Drawing.Point(0, 36);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(134, 20);
            this.regpass.TabIndex = 8;
            this.regpass.Text = "Пароль";
            // 
            // reglogin
            // 
            this.reglogin.Location = new System.Drawing.Point(0, 10);
            this.reglogin.Name = "reglogin";
            this.reglogin.Size = new System.Drawing.Size(134, 20);
            this.reglogin.TabIndex = 7;
            this.reglogin.Text = "Логін";
            this.reglogin.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // confirmRegist
            // 
            this.confirmRegist.Location = new System.Drawing.Point(0, 61);
            this.confirmRegist.Name = "confirmRegist";
            this.confirmRegist.Size = new System.Drawing.Size(134, 23);
            this.confirmRegist.TabIndex = 9;
            this.confirmRegist.Text = "Підтвердити";
            this.confirmRegist.UseVisualStyleBackColor = true;
            this.confirmRegist.Click += new System.EventHandler(this.confirmRegist_Click);
            // 
            // regpanel
            // 
            this.regpanel.Controls.Add(this.reglogin);
            this.regpanel.Controls.Add(this.confirmRegist);
            this.regpanel.Controls.Add(this.regpass);
            this.regpanel.Location = new System.Drawing.Point(73, 212);
            this.regpanel.Name = "regpanel";
            this.regpanel.Size = new System.Drawing.Size(134, 93);
            this.regpanel.TabIndex = 10;
            this.regpanel.Visible = false;
            // 
            // AlertRegisterLabel
            // 
            this.AlertRegisterLabel.AutoSize = true;
            this.AlertRegisterLabel.Location = new System.Drawing.Point(70, 317);
            this.AlertRegisterLabel.Name = "AlertRegisterLabel";
            this.AlertRegisterLabel.Size = new System.Drawing.Size(0, 13);
            this.AlertRegisterLabel.TabIndex = 11;
            // 
            // DAOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 359);
            this.Controls.Add(this.AlertRegisterLabel);
            this.Controls.Add(this.regpanel);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.AlertLoginLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.loginLogin);
            this.Name = "DAOForm";
            this.Text = "DAOForm";
            this.Load += new System.EventHandler(this.DAOForm_Load);
            this.regpanel.ResumeLayout(false);
            this.regpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginLogin;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AlertLoginLabel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.TextBox reglogin;
        private System.Windows.Forms.Button confirmRegist;
        private System.Windows.Forms.Panel regpanel;
        private System.Windows.Forms.Label AlertRegisterLabel;
    }
}