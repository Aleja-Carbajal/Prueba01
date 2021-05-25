using System.ComponentModel;

namespace Parcial02
{
    partial class frmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.grpFormChangePassword = new System.Windows.Forms.GroupBox();
            this.btnCheckCarne = new System.Windows.Forms.Button();
            this.grpCheckQuestion = new System.Windows.Forms.GroupBox();
            this.lblQuestionChangePassword = new System.Windows.Forms.Label();
            this.btnCheckQuestion = new System.Windows.Forms.Button();
            this.txtQuestionChangePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grpUpdatePassword = new System.Windows.Forms.GroupBox();
            this.txtChangePassword2 = new System.Windows.Forms.TextBox();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCarneChangePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFormChangePassword.SuspendLayout();
            this.grpCheckQuestion.SuspendLayout();
            this.grpUpdatePassword.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFormChangePassword
            // 
            this.grpFormChangePassword.BackColor = System.Drawing.Color.White;
            this.grpFormChangePassword.Controls.Add(this.btnCheckCarne);
            this.grpFormChangePassword.Controls.Add(this.grpCheckQuestion);
            this.grpFormChangePassword.Controls.Add(this.grpUpdatePassword);
            this.grpFormChangePassword.Controls.Add(this.groupBox1);
            this.grpFormChangePassword.Controls.Add(this.label1);
            this.grpFormChangePassword.Location = new System.Drawing.Point(104, 5);
            this.grpFormChangePassword.Name = "grpFormChangePassword";
            this.grpFormChangePassword.Size = new System.Drawing.Size(591, 806);
            this.grpFormChangePassword.TabIndex = 0;
            this.grpFormChangePassword.TabStop = false;
            // 
            // btnCheckCarne
            // 
            this.btnCheckCarne.BackColor = System.Drawing.Color.LightGray;
            this.btnCheckCarne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCarne.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCheckCarne.ForeColor = System.Drawing.Color.White;
            this.btnCheckCarne.Location = new System.Drawing.Point(174, 191);
            this.btnCheckCarne.Name = "btnCheckCarne";
            this.btnCheckCarne.Size = new System.Drawing.Size(233, 61);
            this.btnCheckCarne.TabIndex = 24;
            this.btnCheckCarne.Text = "Verificar";
            this.btnCheckCarne.UseVisualStyleBackColor = false;
            this.btnCheckCarne.Click += new System.EventHandler(this.btnCheckCarne_Click);
            // 
            // grpCheckQuestion
            // 
            this.grpCheckQuestion.BackColor = System.Drawing.Color.Transparent;
            this.grpCheckQuestion.Controls.Add(this.lblQuestionChangePassword);
            this.grpCheckQuestion.Controls.Add(this.btnCheckQuestion);
            this.grpCheckQuestion.Controls.Add(this.txtQuestionChangePassword);
            this.grpCheckQuestion.Controls.Add(this.label4);
            this.grpCheckQuestion.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpCheckQuestion.Location = new System.Drawing.Point(76, 272);
            this.grpCheckQuestion.Name = "grpCheckQuestion";
            this.grpCheckQuestion.Size = new System.Drawing.Size(444, 249);
            this.grpCheckQuestion.TabIndex = 27;
            this.grpCheckQuestion.TabStop = false;
            this.grpCheckQuestion.Text = "Escriba la respuesta ";
            this.grpCheckQuestion.Visible = false;
            // 
            // lblQuestionChangePassword
            // 
            this.lblQuestionChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestionChangePassword.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblQuestionChangePassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblQuestionChangePassword.Location = new System.Drawing.Point(22, 72);
            this.lblQuestionChangePassword.Name = "lblQuestionChangePassword";
            this.lblQuestionChangePassword.Size = new System.Drawing.Size(404, 33);
            this.lblQuestionChangePassword.TabIndex = 22;
            this.lblQuestionChangePassword.Text = "\r\n\r\n\r\n";
            this.lblQuestionChangePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCheckQuestion
            // 
            this.btnCheckQuestion.BackColor = System.Drawing.Color.LightGray;
            this.btnCheckQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckQuestion.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCheckQuestion.ForeColor = System.Drawing.Color.White;
            this.btnCheckQuestion.Location = new System.Drawing.Point(103, 165);
            this.btnCheckQuestion.Name = "btnCheckQuestion";
            this.btnCheckQuestion.Size = new System.Drawing.Size(233, 58);
            this.btnCheckQuestion.TabIndex = 23;
            this.btnCheckQuestion.Text = "Aceptar";
            this.btnCheckQuestion.UseVisualStyleBackColor = false;
            this.btnCheckQuestion.Click += new System.EventHandler(this.btnCheckQuestion_Click);
            // 
            // txtQuestionChangePassword
            // 
            this.txtQuestionChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestionChangePassword.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtQuestionChangePassword.Location = new System.Drawing.Point(26, 117);
            this.txtQuestionChangePassword.Name = "txtQuestionChangePassword";
            this.txtQuestionChangePassword.Size = new System.Drawing.Size(404, 29);
            this.txtQuestionChangePassword.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(85, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pregunta de seguridad:\r\n\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.LightGray;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(98, 159);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(233, 72);
            this.btnChangePassword.TabIndex = 25;
            this.btnChangePassword.Text = "Aceptar";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // grpUpdatePassword
            // 
            this.grpUpdatePassword.BackColor = System.Drawing.Color.Transparent;
            this.grpUpdatePassword.Controls.Add(this.txtChangePassword2);
            this.grpUpdatePassword.Controls.Add(this.txtChangePassword);
            this.grpUpdatePassword.Controls.Add(this.btnChangePassword);
            this.grpUpdatePassword.Controls.Add(this.label3);
            this.grpUpdatePassword.Controls.Add(this.label2);
            this.grpUpdatePassword.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpUpdatePassword.Location = new System.Drawing.Point(76, 544);
            this.grpUpdatePassword.Name = "grpUpdatePassword";
            this.grpUpdatePassword.Size = new System.Drawing.Size(444, 241);
            this.grpUpdatePassword.TabIndex = 24;
            this.grpUpdatePassword.TabStop = false;
            this.grpUpdatePassword.Text = "Ingrese la nueva contraseña:";
            this.grpUpdatePassword.Visible = false;
            // 
            // txtChangePassword2
            // 
            this.txtChangePassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangePassword2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtChangePassword2.Location = new System.Drawing.Point(142, 112);
            this.txtChangePassword2.Name = "txtChangePassword2";
            this.txtChangePassword2.Size = new System.Drawing.Size(284, 28);
            this.txtChangePassword2.TabIndex = 26;
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangePassword.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtChangePassword.Location = new System.Drawing.Point(142, 49);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(284, 28);
            this.txtChangePassword.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 63);
            this.label3.TabIndex = 25;
            this.label3.Text = "Confirme contraseña:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(-4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.txtCarneChangePassword);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 141);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los siguientes datos:";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(26, 61);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(130, 30);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Carné:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCarneChangePassword
            // 
            this.txtCarneChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarneChangePassword.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCarneChangePassword.Location = new System.Drawing.Point(175, 61);
            this.txtCarneChangePassword.Name = "txtCarneChangePassword";
            this.txtCarneChangePassword.Size = new System.Drawing.Size(255, 28);
            this.txtCarneChangePassword.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recuperación de contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 823);
            this.Controls.Add(this.grpFormChangePassword);
            this.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.Text = "Recuperar contraseña";
            this.grpFormChangePassword.ResumeLayout(false);
            this.grpCheckQuestion.ResumeLayout(false);
            this.grpCheckQuestion.PerformLayout();
            this.grpUpdatePassword.ResumeLayout(false);
            this.grpUpdatePassword.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpCheckQuestion;
        private System.Windows.Forms.Button btnCheckQuestion;
        private System.Windows.Forms.Button btnCheckCarne;

        private System.Windows.Forms.Button btnChangePassword;

       

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.TextBox txtChangePassword2;
        private System.Windows.Forms.GroupBox grpUpdatePassword;
        private System.Windows.Forms.TextBox txtQuestionChangePassword;

  

        private System.Windows.Forms.Label lblQuestionChangePassword;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox txtCarneChangePassword;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblUser;

        private System.Windows.Forms.GroupBox grpFormChangePassword;

        #endregion
    }
}