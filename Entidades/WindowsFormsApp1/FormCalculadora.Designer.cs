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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.operadores = new System.Windows.Forms.ComboBox();
            this.RealizarCuenta = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Binario = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(87, 93);
            this.txt_num1.Multiline = true;
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(130, 20);
            this.txt_num1.TabIndex = 0;
            this.txt_num1.TextChanged += new System.EventHandler(this.txt_num1_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.SystemColors.Info;
            this.Resultado.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(467, 372);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 28);
            this.Resultado.TabIndex = 1;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(431, 93);
            this.txt_num2.Multiline = true;
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(130, 20);
            this.txt_num2.TabIndex = 2;
            this.txt_num2.TextChanged += new System.EventHandler(this.txt_num2_TextChanged);
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
            this.operadores.Location = new System.Drawing.Point(256, 92);
            this.operadores.Name = "operadores";
            this.operadores.Size = new System.Drawing.Size(130, 21);
            this.operadores.TabIndex = 3;
            this.operadores.SelectedIndexChanged += new System.EventHandler(this.operadores_SelectedIndexChanged);
            // 
            // RealizarCuenta
            // 
            this.RealizarCuenta.Location = new System.Drawing.Point(87, 156);
            this.RealizarCuenta.Name = "RealizarCuenta";
            this.RealizarCuenta.Size = new System.Drawing.Size(130, 55);
            this.RealizarCuenta.TabIndex = 4;
            this.RealizarCuenta.Text = "REALIZAR CUENTA\r\n";
            this.RealizarCuenta.UseVisualStyleBackColor = true;
            this.RealizarCuenta.Click += new System.EventHandler(this.RealizarCuenta_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(256, 156);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(130, 55);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "LIMPIAR";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(431, 156);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(130, 55);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "CERRAR";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Binario
            // 
            this.Binario.Location = new System.Drawing.Point(161, 254);
            this.Binario.Name = "Binario";
            this.Binario.Size = new System.Drawing.Size(123, 49);
            this.Binario.TabIndex = 7;
            this.Binario.Text = "convertir a binario ";
            this.Binario.UseVisualStyleBackColor = true;
            this.Binario.Click += new System.EventHandler(this.Binario_Click);
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(376, 254);
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
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "CALCULADORA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.RealizarCuenta);
            this.Controls.Add(this.operadores);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora hecha por SANTIAGO SBAGLIA .. curso 2º D ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.ComboBox operadores;
        private System.Windows.Forms.Button RealizarCuenta;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Binario;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

