
namespace Biblioteka
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblUserData = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.rBLibrary1 = new System.Windows.Forms.RadioButton();
            this.rBLibrary2 = new System.Windows.Forms.RadioButton();
            this.lblChooseLibrary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(124, 143);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(121, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Hasło";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(189, 143);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(95, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ZALOGUJ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(216, 262);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(125, 23);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "ZAREJESTRUJ SIĘ";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblUserData
            // 
            this.lblUserData.AutoSize = true;
            this.lblUserData.Location = new System.Drawing.Point(186, 105);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(75, 13);
            this.lblUserData.TabIndex = 8;
            this.lblUserData.Text = "PODAJ DANE";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(95, 262);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 9;
            this.btnSaveUser.Text = "ZAPISZ";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Visible = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // rBLibrary1
            // 
            this.rBLibrary1.AutoSize = true;
            this.rBLibrary1.Location = new System.Drawing.Point(189, 144);
            this.rBLibrary1.Name = "rBLibrary1";
            this.rBLibrary1.Size = new System.Drawing.Size(92, 17);
            this.rBLibrary1.TabIndex = 10;
            this.rBLibrary1.TabStop = true;
            this.rBLibrary1.Text = "Biblioteka nr 1";
            this.rBLibrary1.UseVisualStyleBackColor = true;
            this.rBLibrary1.Visible = false;
            this.rBLibrary1.CheckedChanged += new System.EventHandler(this.rBLibrary1_CheckedChanged);
            // 
            // rBLibrary2
            // 
            this.rBLibrary2.AutoSize = true;
            this.rBLibrary2.Location = new System.Drawing.Point(189, 194);
            this.rBLibrary2.Name = "rBLibrary2";
            this.rBLibrary2.Size = new System.Drawing.Size(92, 17);
            this.rBLibrary2.TabIndex = 11;
            this.rBLibrary2.TabStop = true;
            this.rBLibrary2.Text = "Biblioteka nr 2";
            this.rBLibrary2.UseVisualStyleBackColor = true;
            this.rBLibrary2.Visible = false;
            this.rBLibrary2.CheckedChanged += new System.EventHandler(this.rBLibrary2_CheckedChanged);
            // 
            // lblChooseLibrary
            // 
            this.lblChooseLibrary.AutoSize = true;
            this.lblChooseLibrary.Location = new System.Drawing.Point(186, 92);
            this.lblChooseLibrary.Name = "lblChooseLibrary";
            this.lblChooseLibrary.Size = new System.Drawing.Size(122, 13);
            this.lblChooseLibrary.TabIndex = 12;
            this.lblChooseLibrary.Text = "WYBIERZ BIBLIOTEKĘ";
            this.lblChooseLibrary.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 421);
            this.Controls.Add(this.lblChooseLibrary);
            this.Controls.Add(this.rBLibrary2);
            this.Controls.Add(this.rBLibrary1);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.lblUserData);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Name = "Form3";
            this.Text = "BIBLIOTEKA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.RadioButton rBLibrary1;
        private System.Windows.Forms.RadioButton rBLibrary2;
        private System.Windows.Forms.Label lblChooseLibrary;
    }
}