using System.IO;

namespace SciencesStudies
{
    partial class FormSignIn
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
            this.tbxSignInUsername = new System.Windows.Forms.TextBox();
            this.pnlSignInUsername = new System.Windows.Forms.Panel();
            this.pnlSignInPassword = new System.Windows.Forms.Panel();
            this.tbxSignInPassword = new System.Windows.Forms.TextBox();
            this.btnSignInLogo = new System.Windows.Forms.Button();
            this.lblSearchUs = new System.Windows.Forms.Label();
            this.gbxUsersStatus = new System.Windows.Forms.GroupBox();
            this.radioBtnForeignMember = new System.Windows.Forms.RadioButton();
            this.radioBtnCollegeStudent = new System.Windows.Forms.RadioButton();
            this.radioBtnTeacher = new System.Windows.Forms.RadioButton();
            this.radioBtnResearcher = new System.Windows.Forms.RadioButton();
            this.radioBtnAcademician = new System.Windows.Forms.RadioButton();
            this.radioBtnManager = new System.Windows.Forms.RadioButton();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pictureBoxToggle = new System.Windows.Forms.PictureBox();
            this.pbxGitHubLogo = new System.Windows.Forms.PictureBox();
            this.pbxGoogleLogo = new System.Windows.Forms.PictureBox();
            this.pbxSignInLogo = new System.Windows.Forms.PictureBox();
            this.pbxPasswordLogo = new System.Windows.Forms.PictureBox();
            this.pbxUsernameLogo = new System.Windows.Forms.PictureBox();
            this.gbxUsersStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGitHubLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGoogleLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignInLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPasswordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsernameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSignInUsername
            // 
            this.tbxSignInUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbxSignInUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSignInUsername.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSignInUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tbxSignInUsername.Location = new System.Drawing.Point(102, 128);
            this.tbxSignInUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSignInUsername.Name = "tbxSignInUsername";
            this.tbxSignInUsername.Size = new System.Drawing.Size(171, 16);
            this.tbxSignInUsername.TabIndex = 1;
            this.tbxSignInUsername.Text = "User Name";
            this.tbxSignInUsername.Click += new System.EventHandler(this.tbxSignInUsername_Click);
            this.tbxSignInUsername.Enter += new System.EventHandler(this.tbxSignInUsername_Enter);
            this.tbxSignInUsername.Leave += new System.EventHandler(this.tbxSignInUsername_Leave);
            // 
            // pnlSignInUsername
            // 
            this.pnlSignInUsername.BackColor = System.Drawing.Color.White;
            this.pnlSignInUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSignInUsername.Location = new System.Drawing.Point(102, 147);
            this.pnlSignInUsername.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSignInUsername.Name = "pnlSignInUsername";
            this.pnlSignInUsername.Size = new System.Drawing.Size(167, 1);
            this.pnlSignInUsername.TabIndex = 2;
            // 
            // pnlSignInPassword
            // 
            this.pnlSignInPassword.BackColor = System.Drawing.Color.White;
            this.pnlSignInPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSignInPassword.Location = new System.Drawing.Point(102, 193);
            this.pnlSignInPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSignInPassword.Name = "pnlSignInPassword";
            this.pnlSignInPassword.Size = new System.Drawing.Size(167, 1);
            this.pnlSignInPassword.TabIndex = 4;
            // 
            // tbxSignInPassword
            // 
            this.tbxSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbxSignInPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSignInPassword.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSignInPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tbxSignInPassword.Location = new System.Drawing.Point(102, 174);
            this.tbxSignInPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSignInPassword.Name = "tbxSignInPassword";
            this.tbxSignInPassword.Size = new System.Drawing.Size(171, 16);
            this.tbxSignInPassword.TabIndex = 3;
            this.tbxSignInPassword.Text = "Password";
            this.tbxSignInPassword.Click += new System.EventHandler(this.tbxSignInPassword_Click);
            this.tbxSignInPassword.Enter += new System.EventHandler(this.tbxSignInPassword_Enter);
            this.tbxSignInPassword.Leave += new System.EventHandler(this.tbxSignInPassword_Leave);
            // 
            // btnSignInLogo
            // 
            this.btnSignInLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSignInLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignInLogo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignInLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignInLogo.Location = new System.Drawing.Point(57, 420);
            this.btnSignInLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignInLogo.Name = "btnSignInLogo";
            this.btnSignInLogo.Size = new System.Drawing.Size(250, 32);
            this.btnSignInLogo.TabIndex = 7;
            this.btnSignInLogo.Text = "Sign In";
            this.btnSignInLogo.UseVisualStyleBackColor = false;
            this.btnSignInLogo.Click += new System.EventHandler(this.btnSignInLogo_Click);
            // 
            // lblSearchUs
            // 
            this.lblSearchUs.AutoSize = true;
            this.lblSearchUs.ForeColor = System.Drawing.Color.White;
            this.lblSearchUs.Location = new System.Drawing.Point(139, 332);
            this.lblSearchUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchUs.Name = "lblSearchUs";
            this.lblSearchUs.Size = new System.Drawing.Size(76, 13);
            this.lblSearchUs.TabIndex = 10;
            this.lblSearchUs.Text = "search us from";
            // 
            // gbxUsersStatus
            // 
            this.gbxUsersStatus.Controls.Add(this.radioBtnForeignMember);
            this.gbxUsersStatus.Controls.Add(this.radioBtnCollegeStudent);
            this.gbxUsersStatus.Controls.Add(this.radioBtnTeacher);
            this.gbxUsersStatus.Controls.Add(this.radioBtnResearcher);
            this.gbxUsersStatus.Controls.Add(this.radioBtnAcademician);
            this.gbxUsersStatus.Controls.Add(this.radioBtnManager);
            this.gbxUsersStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUsersStatus.ForeColor = System.Drawing.Color.White;
            this.gbxUsersStatus.Location = new System.Drawing.Point(20, 214);
            this.gbxUsersStatus.Margin = new System.Windows.Forms.Padding(2);
            this.gbxUsersStatus.Name = "gbxUsersStatus";
            this.gbxUsersStatus.Padding = new System.Windows.Forms.Padding(2);
            this.gbxUsersStatus.Size = new System.Drawing.Size(353, 108);
            this.gbxUsersStatus.TabIndex = 13;
            this.gbxUsersStatus.TabStop = false;
            this.gbxUsersStatus.Text = "Choose who you are";
            // 
            // radioBtnForeignMember
            // 
            this.radioBtnForeignMember.AutoSize = true;
            this.radioBtnForeignMember.Location = new System.Drawing.Point(235, 71);
            this.radioBtnForeignMember.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnForeignMember.Name = "radioBtnForeignMember";
            this.radioBtnForeignMember.Size = new System.Drawing.Size(115, 19);
            this.radioBtnForeignMember.TabIndex = 5;
            this.radioBtnForeignMember.TabStop = true;
            this.radioBtnForeignMember.Text = "Foreign Member";
            this.radioBtnForeignMember.UseVisualStyleBackColor = true;
            // 
            // radioBtnCollegeStudent
            // 
            this.radioBtnCollegeStudent.AutoSize = true;
            this.radioBtnCollegeStudent.Location = new System.Drawing.Point(110, 71);
            this.radioBtnCollegeStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnCollegeStudent.Name = "radioBtnCollegeStudent";
            this.radioBtnCollegeStudent.Size = new System.Drawing.Size(113, 19);
            this.radioBtnCollegeStudent.TabIndex = 4;
            this.radioBtnCollegeStudent.TabStop = true;
            this.radioBtnCollegeStudent.Text = "College Student";
            this.radioBtnCollegeStudent.UseVisualStyleBackColor = true;
            // 
            // radioBtnTeacher
            // 
            this.radioBtnTeacher.AutoSize = true;
            this.radioBtnTeacher.Location = new System.Drawing.Point(21, 71);
            this.radioBtnTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnTeacher.Name = "radioBtnTeacher";
            this.radioBtnTeacher.Size = new System.Drawing.Size(69, 19);
            this.radioBtnTeacher.TabIndex = 3;
            this.radioBtnTeacher.TabStop = true;
            this.radioBtnTeacher.Text = "Teacher";
            this.radioBtnTeacher.UseVisualStyleBackColor = true;
            // 
            // radioBtnResearcher
            // 
            this.radioBtnResearcher.AutoSize = true;
            this.radioBtnResearcher.Location = new System.Drawing.Point(235, 34);
            this.radioBtnResearcher.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnResearcher.Name = "radioBtnResearcher";
            this.radioBtnResearcher.Size = new System.Drawing.Size(90, 19);
            this.radioBtnResearcher.TabIndex = 2;
            this.radioBtnResearcher.TabStop = true;
            this.radioBtnResearcher.Text = "Researcher";
            this.radioBtnResearcher.UseVisualStyleBackColor = true;
            // 
            // radioBtnAcademician
            // 
            this.radioBtnAcademician.AutoSize = true;
            this.radioBtnAcademician.Location = new System.Drawing.Point(117, 34);
            this.radioBtnAcademician.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnAcademician.Name = "radioBtnAcademician";
            this.radioBtnAcademician.Size = new System.Drawing.Size(96, 19);
            this.radioBtnAcademician.TabIndex = 1;
            this.radioBtnAcademician.TabStop = true;
            this.radioBtnAcademician.Text = "Academician";
            this.radioBtnAcademician.UseVisualStyleBackColor = true;
            // 
            // radioBtnManager
            // 
            this.radioBtnManager.AutoSize = true;
            this.radioBtnManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.radioBtnManager.Checked = true;
            this.radioBtnManager.Location = new System.Drawing.Point(21, 34);
            this.radioBtnManager.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnManager.Name = "radioBtnManager";
            this.radioBtnManager.Size = new System.Drawing.Size(73, 19);
            this.radioBtnManager.TabIndex = 0;
            this.radioBtnManager.TabStop = true;
            this.radioBtnManager.Text = "Manager";
            this.radioBtnManager.UseVisualStyleBackColor = false;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSignIn.Location = new System.Drawing.Point(17, 94);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(52, 18);
            this.lblSignIn.TabIndex = 14;
            this.lblSignIn.Text = "Sign In";
            // 
            // pictureBoxToggle
            // 
            this.pictureBoxToggle.Image = global::SciencesStudies.Properties.Resources.toggleImageWhite;
            this.pictureBoxToggle.Location = new System.Drawing.Point(274, 171);
            this.pictureBoxToggle.Name = "pictureBoxToggle";
            this.pictureBoxToggle.Size = new System.Drawing.Size(33, 26);
            this.pictureBoxToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxToggle.TabIndex = 15;
            this.pictureBoxToggle.TabStop = false;
            this.pictureBoxToggle.Click += new System.EventHandler(this.pictureBoxToggle_Click);
            // 
            // pbxGitHubLogo
            // 
            this.pbxGitHubLogo.Image = global::SciencesStudies.Properties.Resources.github_updated;
            this.pbxGitHubLogo.Location = new System.Drawing.Point(194, 357);
            this.pbxGitHubLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxGitHubLogo.Name = "pbxGitHubLogo";
            this.pbxGitHubLogo.Size = new System.Drawing.Size(53, 52);
            this.pbxGitHubLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGitHubLogo.TabIndex = 9;
            this.pbxGitHubLogo.TabStop = false;
            // 
            // pbxGoogleLogo
            // 
            this.pbxGoogleLogo.Image = global::SciencesStudies.Properties.Resources.google_icon1;
            this.pbxGoogleLogo.Location = new System.Drawing.Point(99, 357);
            this.pbxGoogleLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxGoogleLogo.Name = "pbxGoogleLogo";
            this.pbxGoogleLogo.Size = new System.Drawing.Size(53, 52);
            this.pbxGoogleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGoogleLogo.TabIndex = 8;
            this.pbxGoogleLogo.TabStop = false;
            // 
            // pbxSignInLogo
            // 
            this.pbxSignInLogo.Image = global::SciencesStudies.Properties.Resources.sign_in_picture11;
            this.pbxSignInLogo.Location = new System.Drawing.Point(141, 8);
            this.pbxSignInLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSignInLogo.Name = "pbxSignInLogo";
            this.pbxSignInLogo.Size = new System.Drawing.Size(106, 103);
            this.pbxSignInLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSignInLogo.TabIndex = 6;
            this.pbxSignInLogo.TabStop = false;
            // 
            // pbxPasswordLogo
            // 
            this.pbxPasswordLogo.Image = global::SciencesStudies.Properties.Resources.lock_up_12;
            this.pbxPasswordLogo.Location = new System.Drawing.Point(79, 171);
            this.pbxPasswordLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPasswordLogo.Name = "pbxPasswordLogo";
            this.pbxPasswordLogo.Size = new System.Drawing.Size(19, 18);
            this.pbxPasswordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPasswordLogo.TabIndex = 5;
            this.pbxPasswordLogo.TabStop = false;
            // 
            // pbxUsernameLogo
            // 
            this.pbxUsernameLogo.Image = global::SciencesStudies.Properties.Resources.sign_in_picture11;
            this.pbxUsernameLogo.Location = new System.Drawing.Point(79, 128);
            this.pbxUsernameLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxUsernameLogo.Name = "pbxUsernameLogo";
            this.pbxUsernameLogo.Size = new System.Drawing.Size(19, 18);
            this.pbxUsernameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsernameLogo.TabIndex = 0;
            this.pbxUsernameLogo.TabStop = false;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(394, 471);
            this.Controls.Add(this.pictureBoxToggle);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.gbxUsersStatus);
            this.Controls.Add(this.lblSearchUs);
            this.Controls.Add(this.pbxGitHubLogo);
            this.Controls.Add(this.pbxGoogleLogo);
            this.Controls.Add(this.btnSignInLogo);
            this.Controls.Add(this.pbxSignInLogo);
            this.Controls.Add(this.pbxPasswordLogo);
            this.Controls.Add(this.pnlSignInPassword);
            this.Controls.Add(this.tbxSignInPassword);
            this.Controls.Add(this.pnlSignInUsername);
            this.Controls.Add(this.tbxSignInUsername);
            this.Controls.Add(this.pbxUsernameLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignIn";
            this.TopMost = true;
            this.gbxUsersStatus.ResumeLayout(false);
            this.gbxUsersStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGitHubLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGoogleLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignInLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPasswordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsernameLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUsernameLogo;
        private System.Windows.Forms.TextBox tbxSignInUsername;
        private System.Windows.Forms.Panel pnlSignInUsername;
        private System.Windows.Forms.Panel pnlSignInPassword;
        private System.Windows.Forms.TextBox tbxSignInPassword;
        private System.Windows.Forms.PictureBox pbxPasswordLogo;
        private System.Windows.Forms.PictureBox pbxSignInLogo;
        private System.Windows.Forms.Button btnSignInLogo;
        private System.Windows.Forms.PictureBox pbxGoogleLogo;
        private System.Windows.Forms.PictureBox pbxGitHubLogo;
        private System.Windows.Forms.Label lblSearchUs;
        private System.Windows.Forms.GroupBox gbxUsersStatus;
        private System.Windows.Forms.RadioButton radioBtnForeignMember;
        private System.Windows.Forms.RadioButton radioBtnCollegeStudent;
        private System.Windows.Forms.RadioButton radioBtnTeacher;
        private System.Windows.Forms.RadioButton radioBtnResearcher;
        private System.Windows.Forms.RadioButton radioBtnAcademician;
        private System.Windows.Forms.RadioButton radioBtnManager;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.PictureBox pictureBoxToggle;
    }
}