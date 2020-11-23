namespace supermercado
{
    partial class registroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroUsuario));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.USUARIO = new System.Windows.Forms.Label();
            this.CONTRASEÑA = new System.Windows.Forms.Label();
            this.btn_IngresarUsuario = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txt_usuario, "txt_usuario");
            this.txt_usuario.Name = "txt_usuario";
      
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txt_contraseña, "txt_contraseña");
            this.txt_contraseña.Name = "txt_contraseña";
        
            // 
            // USUARIO
            // 
            resources.ApplyResources(this.USUARIO, "USUARIO");
            this.USUARIO.BackColor = System.Drawing.Color.RoyalBlue;
            this.USUARIO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.USUARIO.Name = "USUARIO";
            // 
            // CONTRASEÑA
            // 
            resources.ApplyResources(this.CONTRASEÑA, "CONTRASEÑA");
            this.CONTRASEÑA.BackColor = System.Drawing.Color.RoyalBlue;
            this.CONTRASEÑA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            // 
            // btn_IngresarUsuario
            // 
            this.btn_IngresarUsuario.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.btn_IngresarUsuario, "btn_IngresarUsuario");
            this.btn_IngresarUsuario.Name = "btn_IngresarUsuario";
            this.btn_IngresarUsuario.UseVisualStyleBackColor = false;
            this.btn_IngresarUsuario.Click += new System.EventHandler(this.btn_IngresarUsuario_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.btn_Salir, "btn_Salir");
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // registroUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_IngresarUsuario);
            this.Controls.Add(this.CONTRASEÑA);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "registroUsuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label CONTRASEÑA;
        private System.Windows.Forms.Button btn_IngresarUsuario;
        private System.Windows.Forms.Button btn_Salir;
    }
}

