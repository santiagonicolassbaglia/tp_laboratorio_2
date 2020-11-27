namespace WindowsFormsApp1
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.operadores = new System.Windows.Forms.ComboBox();
            this.RealizarCuenta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Binario = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(14, 94);
            this.txt_num1.Multiline = true;
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(216, 20);
            this.txt_num1.TabIndex = 0;
            // 
            // Resultado
            // 
            this.Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.SystemColors.Info;
            this.Resultado.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(467, 372);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 40);
            this.Resultado.TabIndex = 1;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(537, 94);
            this.txt_num2.Multiline = true;
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(211, 20);
            this.txt_num2.TabIndex = 2;
            // 
            // operadores
            // 
            this.operadores.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.operadores.FormattingEnabled = true;
            this.operadores.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.operadores.Location = new System.Drawing.Point(272, 93);
            this.operadores.Name = "operadores";
            this.operadores.Size = new System.Drawing.Size(212, 21);
            this.operadores.TabIndex = 3;
            // 
            // RealizarCuenta
            // 
            this.RealizarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealizarCuenta.Location = new System.Drawing.Point(217, 215);
            this.RealizarCuenta.Name = "RealizarCuenta";
            this.RealizarCuenta.Size = new System.Drawing.Size(331, 75);
            this.RealizarCuenta.TabIndex = 4;
            this.RealizarCuenta.Text = "REALIZAR CUENTA\r\n";
            this.RealizarCuenta.UseVisualStyleBackColor = true;
            this.RealizarCuenta.Click += new System.EventHandler(this.RealizarCuenta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(181, 47);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(547, 149);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(181, 43);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "CERRAR";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Binario
            // 
            this.Binario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binario.Location = new System.Drawing.Point(93, 296);
            this.Binario.Name = "Binario";
            this.Binario.Size = new System.Drawing.Size(137, 49);
            this.Binario.TabIndex = 7;
            this.Binario.Text = "convertir a binario ";
            this.Binario.UseVisualStyleBackColor = true;
            this.Binario.Click += new System.EventHandler(this.Binario_Click);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(537, 296);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(125, 49);
            this.Decimal.TabIndex = 8;
            this.Decimal.Text = "convertir a decimal";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "El resultado es :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-52, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Binario);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.RealizarCuenta);
            this.Controls.Add(this.operadores);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora hecha por SANTIAGO SBAGLIA .. curso 2º D ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.ComboBox operadores;
        private System.Windows.Forms.Button RealizarCuenta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Binario;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

