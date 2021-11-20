
namespace Cliente1
{
    partial class Iniciar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar));
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioTbt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraseñaTbt = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.RegistrarseBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p3 = new System.Windows.Forms.RadioButton();
            this.p2 = new System.Windows.Forms.RadioButton();
            this.p1 = new System.Windows.Forms.RadioButton();
            this.EnviarPet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTbt2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContraseñaBtn2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_consultas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(136, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // UsuarioTbt
            // 
            this.UsuarioTbt.Location = new System.Drawing.Point(108, 52);
            this.UsuarioTbt.Name = "UsuarioTbt";
            this.UsuarioTbt.Size = new System.Drawing.Size(106, 20);
            this.UsuarioTbt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(127, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // ContraseñaTbt
            // 
            this.ContraseñaTbt.Location = new System.Drawing.Point(108, 103);
            this.ContraseñaTbt.Name = "ContraseñaTbt";
            this.ContraseñaTbt.PasswordChar = 'o';
            this.ContraseñaTbt.Size = new System.Drawing.Size(106, 20);
            this.ContraseñaTbt.TabIndex = 6;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.Location = new System.Drawing.Point(129, 142);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 7;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // RegistrarseBtn
            // 
            this.RegistrarseBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarseBtn.Location = new System.Drawing.Point(110, 167);
            this.RegistrarseBtn.Name = "RegistrarseBtn";
            this.RegistrarseBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistrarseBtn.TabIndex = 8;
            this.RegistrarseBtn.Text = "Registrarse";
            this.RegistrarseBtn.UseVisualStyleBackColor = true;
            this.RegistrarseBtn.Click += new System.EventHandler(this.RegistrarseBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.p3);
            this.groupBox1.Controls.Add(this.p2);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.EnviarPet);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Petición";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.Location = new System.Drawing.Point(67, 94);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(256, 18);
            this.p3.TabIndex = 9;
            this.p3.TabStop = true;
            this.p3.Text = "Máximo número de puntos ganados en una partida";
            this.p3.UseVisualStyleBackColor = true;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.Location = new System.Drawing.Point(99, 64);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(147, 18);
            this.p2.TabIndex = 7;
            this.p2.TabStop = true;
            this.p2.Text = "Partidas ganadas por Berta";
            this.p2.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.Location = new System.Drawing.Point(118, 33);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(107, 18);
            this.p1.TabIndex = 8;
            this.p1.TabStop = true;
            this.p1.Text = "Ganador partida 2";
            this.p1.UseVisualStyleBackColor = true;
            // 
            // EnviarPet
            // 
            this.EnviarPet.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarPet.Location = new System.Drawing.Point(134, 133);
            this.EnviarPet.Name = "EnviarPet";
            this.EnviarPet.Size = new System.Drawing.Size(97, 23);
            this.EnviarPet.TabIndex = 5;
            this.EnviarPet.Text = "Enviar petición";
            this.EnviarPet.UseVisualStyleBackColor = true;
            this.EnviarPet.Click += new System.EventHandler(this.EnviarPet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario:";
            // 
            // UsuarioTbt2
            // 
            this.UsuarioTbt2.Location = new System.Drawing.Point(93, 66);
            this.UsuarioTbt2.Name = "UsuarioTbt2";
            this.UsuarioTbt2.Size = new System.Drawing.Size(106, 20);
            this.UsuarioTbt2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña:";
            // 
            // ContraseñaBtn2
            // 
            this.ContraseñaBtn2.Location = new System.Drawing.Point(93, 135);
            this.ContraseñaBtn2.Name = "ContraseñaBtn2";
            this.ContraseñaBtn2.PasswordChar = 'o';
            this.ContraseñaBtn2.Size = new System.Drawing.Size(106, 20);
            this.ContraseñaBtn2.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.UsuarioTbt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ContraseñaTbt);
            this.groupBox2.Controls.Add(this.SignInBtn);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 190);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inicio de sesión";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.UsuarioTbt2);
            this.groupBox3.Controls.Add(this.ContraseñaBtn2);
            this.groupBox3.Controls.Add(this.RegistrarseBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 211);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro";
            // 
            // listBox_consultas
            // 
            this.listBox_consultas.FormattingEnabled = true;
            this.listBox_consultas.Location = new System.Drawing.Point(420, 253);
            this.listBox_consultas.Name = "listBox_consultas";
            this.listBox_consultas.Size = new System.Drawing.Size(363, 147);
            this.listBox_consultas.TabIndex = 16;
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 438);
            this.Controls.Add(this.listBox_consultas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Iniciar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Iniciar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraseñaTbt;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button RegistrarseBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton p3;
        private System.Windows.Forms.RadioButton p2;
        private System.Windows.Forms.RadioButton p1;
        private System.Windows.Forms.Button EnviarPet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTbt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ContraseñaBtn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_consultas;
    }
}

