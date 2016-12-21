namespace ReView
{
    partial class frmLogin
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtLoginID = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.benSignUp = new Telerik.WinControls.UI.RadButton();
            this.chbRememberLogin = new Telerik.WinControls.UI.RadCheckBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRememberLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(191, 59);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Login ID :";
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(253, 59);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(100, 20);
            this.txtLoginID.TabIndex = 0;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(191, 103);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(59, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(253, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(165, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 24);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // benSignUp
            // 
            this.benSignUp.Location = new System.Drawing.Point(301, 159);
            this.benSignUp.Name = "benSignUp";
            this.benSignUp.Size = new System.Drawing.Size(110, 24);
            this.benSignUp.TabIndex = 3;
            this.benSignUp.Text = "Sign Up";
            // 
            // chbRememberLogin
            // 
            this.chbRememberLogin.Location = new System.Drawing.Point(239, 199);
            this.chbRememberLogin.Name = "chbRememberLogin";
            this.chbRememberLogin.Size = new System.Drawing.Size(94, 18);
            this.chbRememberLogin.TabIndex = 4;
            this.chbRememberLogin.Text = "Remember Me";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(254, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 302);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chbRememberLogin);
            this.Controls.Add(this.benSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.radLabel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbRememberLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtLoginID;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadButton benSignUp;
        private Telerik.WinControls.UI.RadCheckBox chbRememberLogin;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}