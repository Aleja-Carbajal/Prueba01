using System.ComponentModel;

namespace Parcial02
{
    partial class frmSignIn
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
            this.grpFrmSignIn = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestionSign = new System.Windows.Forms.TextBox();
            this.cmbQuestions = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordSign2 = new System.Windows.Forms.TextBox();
            this.txtPasswordSign = new System.Windows.Forms.TextBox();
            this.txtUserSign = new System.Windows.Forms.TextBox();
            this.txtIdSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.grpFrmSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFrmSignIn
            // 
            this.grpFrmSignIn.BackColor = System.Drawing.Color.White;
            this.grpFrmSignIn.Controls.Add(this.label5);
            this.grpFrmSignIn.Controls.Add(this.txtQuestionSign);
            this.grpFrmSignIn.Controls.Add(this.cmbQuestions);
            this.grpFrmSignIn.Controls.Add(this.label4);
            this.grpFrmSignIn.Controls.Add(this.txtPasswordSign2);
            this.grpFrmSignIn.Controls.Add(this.txtPasswordSign);
            this.grpFrmSignIn.Controls.Add(this.txtUserSign);
            this.grpFrmSignIn.Controls.Add(this.txtIdSign);
            this.grpFrmSignIn.Controls.Add(this.label3);
            this.grpFrmSignIn.Controls.Add(this.label2);
            this.grpFrmSignIn.Controls.Add(this.label1);
            this.grpFrmSignIn.Controls.Add(this.lblUser);
            this.grpFrmSignIn.Controls.Add(this.lblTitulo);
            this.grpFrmSignIn.Location = new System.Drawing.Point(71, 30);
            this.grpFrmSignIn.Name = "grpFrmSignIn";
            this.grpFrmSignIn.Size = new System.Drawing.Size(505, 464);
            this.grpFrmSignIn.TabIndex = 0;
            this.grpFrmSignIn.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(67, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Selecciona una pregunta y escribe aquí tu respuesta:\r\n\r\n\r\n\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQuestionSign
            // 
            this.txtQuestionSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestionSign.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtQuestionSign.Location = new System.Drawing.Point(67, 403);
            this.txtQuestionSign.Name = "txtQuestionSign";
            this.txtQuestionSign.Size = new System.Drawing.Size(362, 28);
            this.txtQuestionSign.TabIndex = 17;
            // 
            // cmbQuestions
            // 
            this.cmbQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestions.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbQuestions.FormattingEnabled = true;
            this.cmbQuestions.Items.AddRange(new object[] {"¿En qué año naciste?", "¿Cómo se llamó tu primer mascota?", "¿De qué colegio te graduaste de bachiller?", "¿Nombre de tu película favorita?"});
            this.cmbQuestions.Location = new System.Drawing.Point(92, 335);
            this.cmbQuestions.Name = "cmbQuestions";
            this.cmbQuestions.Size = new System.Drawing.Size(301, 23);
            this.cmbQuestions.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(75, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pregunta de seguridad:\r\n\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPasswordSign2
            // 
            this.txtPasswordSign2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordSign2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPasswordSign2.Location = new System.Drawing.Point(198, 246);
            this.txtPasswordSign2.Name = "txtPasswordSign2";
            this.txtPasswordSign2.PasswordChar = '*';
            this.txtPasswordSign2.Size = new System.Drawing.Size(231, 28);
            this.txtPasswordSign2.TabIndex = 14;
            // 
            // txtPasswordSign
            // 
            this.txtPasswordSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordSign.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPasswordSign.Location = new System.Drawing.Point(198, 189);
            this.txtPasswordSign.Name = "txtPasswordSign";
            this.txtPasswordSign.PasswordChar = '*';
            this.txtPasswordSign.Size = new System.Drawing.Size(231, 28);
            this.txtPasswordSign.TabIndex = 13;
            // 
            // txtUserSign
            // 
            this.txtUserSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserSign.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUserSign.Location = new System.Drawing.Point(198, 144);
            this.txtUserSign.Name = "txtUserSign";
            this.txtUserSign.Size = new System.Drawing.Size(231, 28);
            this.txtUserSign.TabIndex = 12;
            // 
            // txtIdSign
            // 
            this.txtIdSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdSign.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtIdSign.Location = new System.Drawing.Point(198, 99);
            this.txtIdSign.Name = "txtIdSign";
            this.txtIdSign.Size = new System.Drawing.Size(231, 28);
            this.txtIdSign.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(56, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirmar Contraseña:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(56, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(66, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(66, 95);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(126, 30);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Carné:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo.Location = new System.Drawing.Point(74, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 46);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Regístrate";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.LightGray;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(209, 479);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(233, 77);
            this.btnSignIn.TabIndex = 15;
            this.btnSignIn.Text = "Registrarse";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(652, 579);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.grpFrmSignIn);
            this.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica UCA Registrate";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.grpFrmSignIn.ResumeLayout(false);
            this.grpFrmSignIn.PerformLayout();
            this.ResumeLayout(false);
        }

        
        // Labels from Log in Form and Sign In Form       
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;

        // Buttons 
        private System.Windows.Forms.Button btnSignIn;

        // Text Boxs
        private System.Windows.Forms.TextBox txtIdSign;
        private System.Windows.Forms.TextBox txtUserSign;
        private System.Windows.Forms.TextBox txtPasswordSign;
        private System.Windows.Forms.TextBox txtPasswordSign2;
        private System.Windows.Forms.TextBox txtQuestionSign;
        private System.Windows.Forms.ComboBox cmbQuestions;

        
        private System.Windows.Forms.GroupBox grpFrmSignIn;

        #endregion
    }
}