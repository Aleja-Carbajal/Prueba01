namespace Parcial02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picLogoUca = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.grpForm1 = new System.Windows.Forms.GroupBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoUca)).BeginInit();
            this.grpForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogoUca
            // 
            this.picLogoUca.Image = ((System.Drawing.Image) (resources.GetObject("picLogoUca.Image")));
            this.picLogoUca.Location = new System.Drawing.Point(24, 12);
            this.picLogoUca.Name = "picLogoUca";
            this.picLogoUca.Size = new System.Drawing.Size(313, 547);
            this.picLogoUca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoUca.TabIndex = 0;
            this.picLogoUca.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo.Location = new System.Drawing.Point(36, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 49);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Clínica UCA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo2.Location = new System.Drawing.Point(36, 129);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(355, 77);
            this.lblTitulo2.TabIndex = 2;
            this.lblTitulo2.Text = "Sistema de reserva de citas";
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(36, 219);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(126, 32);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPass.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPass.Location = new System.Drawing.Point(36, 263);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(133, 32);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Contraseña:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPassword.Location = new System.Drawing.Point(168, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 28);
            this.txtPassword.TabIndex = 6;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Silver;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(213, 319);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(168, 58);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Iniciar sesión";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // grpForm1
            // 
            this.grpForm1.BackColor = System.Drawing.Color.White;
            this.grpForm1.Controls.Add(this.txtUser);
            this.grpForm1.Controls.Add(this.lblNewPassword);
            this.grpForm1.Controls.Add(this.btnSignIn);
            this.grpForm1.Controls.Add(this.lblTitulo);
            this.grpForm1.Controls.Add(this.btnLogIn);
            this.grpForm1.Controls.Add(this.lblTitulo2);
            this.grpForm1.Controls.Add(this.txtPassword);
            this.grpForm1.Controls.Add(this.lblUser);
            this.grpForm1.Controls.Add(this.lblPass);
            this.grpForm1.Location = new System.Drawing.Point(364, 12);
            this.grpForm1.Name = "grpForm1";
            this.grpForm1.Size = new System.Drawing.Size(410, 557);
            this.grpForm1.TabIndex = 8;
            this.grpForm1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUser.Location = new System.Drawing.Point(168, 223);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 28);
            this.txtUser.TabIndex = 10;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewPassword.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNewPassword.Location = new System.Drawing.Point(36, 389);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(345, 63);
            this.lblNewPassword.TabIndex = 9;
            this.lblNewPassword.Text = "Olvidaste tu contraseña? Presiona aquí para recuperarla";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewPassword.Click += new System.EventHandler(this.lblNewPassword_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Silver;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(36, 319);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(168, 58);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Registrarse";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.grpForm1);
            this.Controls.Add(this.picLogoUca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clinica UCA ";
            ((System.ComponentModel.ISupportInitialize) (this.picLogoUca)).EndInit();
            this.grpForm1.ResumeLayout(false);
            this.grpForm1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.GroupBox grpForm1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.PictureBox picLogoUca;

        #endregion
    }
}