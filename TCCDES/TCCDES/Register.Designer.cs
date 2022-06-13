namespace TCCDES
{
    partial class Register
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
            this.lblUsuarioRegister = new System.Windows.Forms.Label();
            this.lblSenhaRegister = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuarioRegister
            // 
            this.lblUsuarioRegister.AutoSize = true;
            this.lblUsuarioRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRegister.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioRegister.Location = new System.Drawing.Point(51, 75);
            this.lblUsuarioRegister.Name = "lblUsuarioRegister";
            this.lblUsuarioRegister.Size = new System.Drawing.Size(103, 29);
            this.lblUsuarioRegister.TabIndex = 0;
            this.lblUsuarioRegister.Text = "Usuario";
            // 
            // lblSenhaRegister
            // 
            this.lblSenhaRegister.AutoSize = true;
            this.lblSenhaRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaRegister.ForeColor = System.Drawing.Color.White;
            this.lblSenhaRegister.Location = new System.Drawing.Point(51, 163);
            this.lblSenhaRegister.Name = "lblSenhaRegister";
            this.lblSenhaRegister.Size = new System.Drawing.Size(87, 29);
            this.lblSenhaRegister.TabIndex = 1;
            this.lblSenhaRegister.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 26);
            this.textBox2.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(56, 265);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(239, 62);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TCCDES.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 433);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSenhaRegister);
            this.Controls.Add(this.lblUsuarioRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioRegister;
        private System.Windows.Forms.Label lblSenhaRegister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRegister;
    }
}