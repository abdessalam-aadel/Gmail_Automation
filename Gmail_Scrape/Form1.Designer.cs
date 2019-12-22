namespace Gmail_Scrape
{
    partial class frm_Gmail
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.rtxtBox2 = new System.Windows.Forms.RichTextBox();
            this.btnAbout = new System.Windows.Forms.Label();
            this.btnDeletSpecific = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Label();
            this.btnShow2 = new System.Windows.Forms.Label();
            this.AboutHover1 = new System.Windows.Forms.Label();
            this.labelHide = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LightGray;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(12, 118);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(231, 50);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(12, 174);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(231, 28);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete Message view";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(12, 240);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(231, 23);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtBox_User
            // 
            this.txtBox_User.Location = new System.Drawing.Point(16, 29);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(227, 20);
            this.txtBox_User.TabIndex = 1;
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Pass.Location = new System.Drawing.Point(15, 82);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '▪';
            this.txtBox_Pass.Size = new System.Drawing.Size(228, 20);
            this.txtBox_Pass.TabIndex = 2;
            this.txtBox_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Pass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password :";
            // 
            // rtxtBox
            // 
            this.rtxtBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBox.Location = new System.Drawing.Point(249, 29);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.Size = new System.Drawing.Size(130, 98);
            this.rtxtBox.TabIndex = 5;
            this.rtxtBox.Text = "";
            // 
            // rtxtBox2
            // 
            this.rtxtBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBox2.Location = new System.Drawing.Point(249, 133);
            this.rtxtBox2.Name = "rtxtBox2";
            this.rtxtBox2.Size = new System.Drawing.Size(130, 130);
            this.rtxtBox2.TabIndex = 6;
            this.rtxtBox2.Text = "";
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.ForeColor = System.Drawing.Color.DimGray;
            this.btnAbout.Location = new System.Drawing.Point(344, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(35, 13);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // btnDeletSpecific
            // 
            this.btnDeletSpecific.Enabled = false;
            this.btnDeletSpecific.Location = new System.Drawing.Point(12, 206);
            this.btnDeletSpecific.Name = "btnDeletSpecific";
            this.btnDeletSpecific.Size = new System.Drawing.Size(231, 28);
            this.btnDeletSpecific.TabIndex = 9;
            this.btnDeletSpecific.Text = "Delete Messages with a specific title";
            this.btnDeletSpecific.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.ForeColor = System.Drawing.Color.DimGray;
            this.btnShow.Location = new System.Drawing.Point(227, 66);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(16, 13);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "◉";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.AutoSize = true;
            this.btnShow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow2.Location = new System.Drawing.Point(227, 61);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(19, 20);
            this.btnShow2.TabIndex = 11;
            this.btnShow2.Text = "●";
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // AboutHover1
            // 
            this.AboutHover1.AutoSize = true;
            this.AboutHover1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutHover1.ForeColor = System.Drawing.Color.OrangeRed;
            this.AboutHover1.Location = new System.Drawing.Point(344, 9);
            this.AboutHover1.Name = "AboutHover1";
            this.AboutHover1.Size = new System.Drawing.Size(35, 13);
            this.AboutHover1.TabIndex = 12;
            this.AboutHover1.Text = "About";
            this.AboutHover1.MouseHover += new System.EventHandler(this.AboutHover1_MouseHover);
            // 
            // labelHide
            // 
            this.labelHide.AutoSize = true;
            this.labelHide.ForeColor = System.Drawing.Color.Gray;
            this.labelHide.Location = new System.Drawing.Point(131, 66);
            this.labelHide.Name = "labelHide";
            this.labelHide.Size = new System.Drawing.Size(100, 13);
            this.labelHide.TabIndex = 14;
            this.labelHide.Text = "Hide your password";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelShow.Location = new System.Drawing.Point(126, 66);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(105, 13);
            this.labelShow.TabIndex = 15;
            this.labelShow.Text = "Show your password";
            // 
            // frm_Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 272);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.labelHide);
            this.Controls.Add(this.AboutHover1);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDeletSpecific);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.rtxtBox2);
            this.Controls.Add(this.rtxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "frm_Gmail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gmail Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtBox;
        private System.Windows.Forms.RichTextBox rtxtBox2;
        private System.Windows.Forms.Label btnAbout;
        private System.Windows.Forms.Button btnDeletSpecific;
        private System.Windows.Forms.Label btnShow;
        private System.Windows.Forms.Label btnShow2;
        private System.Windows.Forms.Label AboutHover1;
        private System.Windows.Forms.Label labelHide;
        private System.Windows.Forms.Label labelShow;
    }
}

