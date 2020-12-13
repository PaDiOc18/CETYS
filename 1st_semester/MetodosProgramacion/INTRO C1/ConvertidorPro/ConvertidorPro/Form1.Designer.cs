namespace ConvertidorPro
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbBinario1 = new System.Windows.Forms.RadioButton();
            this.rbDecimal1 = new System.Windows.Forms.RadioButton();
            this.rbHexa1 = new System.Windows.Forms.RadioButton();
            this.rbBinario2 = new System.Windows.Forms.RadioButton();
            this.rbDecimal2 = new System.Windows.Forms.RadioButton();
            this.rbHexa2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertidor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(580, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(346, 20);
            this.textBox2.TabIndex = 2;
            // 
            // rbBinario1
            // 
            this.rbBinario1.AutoSize = true;
            this.rbBinario1.Location = new System.Drawing.Point(234, 88);
            this.rbBinario1.Name = "rbBinario1";
            this.rbBinario1.Size = new System.Drawing.Size(57, 17);
            this.rbBinario1.TabIndex = 3;
            this.rbBinario1.TabStop = true;
            this.rbBinario1.Text = "Binario";
            this.rbBinario1.UseVisualStyleBackColor = true;
            // 
            // rbDecimal1
            // 
            this.rbDecimal1.AutoSize = true;
            this.rbDecimal1.Location = new System.Drawing.Point(234, 124);
            this.rbDecimal1.Name = "rbDecimal1";
            this.rbDecimal1.Size = new System.Drawing.Size(63, 17);
            this.rbDecimal1.TabIndex = 4;
            this.rbDecimal1.TabStop = true;
            this.rbDecimal1.Text = "Decimal";
            this.rbDecimal1.UseVisualStyleBackColor = true;
            // 
            // rbHexa1
            // 
            this.rbHexa1.AutoSize = true;
            this.rbHexa1.Location = new System.Drawing.Point(234, 160);
            this.rbHexa1.Name = "rbHexa1";
            this.rbHexa1.Size = new System.Drawing.Size(86, 17);
            this.rbHexa1.TabIndex = 5;
            this.rbHexa1.TabStop = true;
            this.rbHexa1.Text = "Hexadecimal";
            this.rbHexa1.UseVisualStyleBackColor = true;
            // 
            // rbBinario2
            // 
            this.rbBinario2.AutoSize = true;
            this.rbBinario2.Location = new System.Drawing.Point(52, 11);
            this.rbBinario2.Name = "rbBinario2";
            this.rbBinario2.Size = new System.Drawing.Size(57, 17);
            this.rbBinario2.TabIndex = 6;
            this.rbBinario2.TabStop = true;
            this.rbBinario2.Text = "Binario";
            this.rbBinario2.UseVisualStyleBackColor = true;
            // 
            // rbDecimal2
            // 
            this.rbDecimal2.AutoSize = true;
            this.rbDecimal2.Location = new System.Drawing.Point(52, 56);
            this.rbDecimal2.Name = "rbDecimal2";
            this.rbDecimal2.Size = new System.Drawing.Size(63, 17);
            this.rbDecimal2.TabIndex = 7;
            this.rbDecimal2.TabStop = true;
            this.rbDecimal2.Text = "Decimal";
            this.rbDecimal2.UseVisualStyleBackColor = true;
            // 
            // rbHexa2
            // 
            this.rbHexa2.AutoSize = true;
            this.rbHexa2.Location = new System.Drawing.Point(52, 98);
            this.rbHexa2.Name = "rbHexa2";
            this.rbHexa2.Size = new System.Drawing.Size(86, 17);
            this.rbHexa2.TabIndex = 8;
            this.rbHexa2.TabStop = true;
            this.rbHexa2.Text = "Hexadecimal";
            this.rbHexa2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBinario2);
            this.panel1.Controls.Add(this.rbHexa2);
            this.panel1.Controls.Add(this.rbDecimal2);
            this.panel1.Location = new System.Drawing.Point(656, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 129);
            this.panel1.TabIndex = 9;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(325, 294);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(135, 65);
            this.btnConvertir.TabIndex = 10;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(580, 294);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 65);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 399);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbHexa1);
            this.Controls.Add(this.rbDecimal1);
            this.Controls.Add(this.rbBinario1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbBinario1;
        private System.Windows.Forms.RadioButton rbDecimal1;
        private System.Windows.Forms.RadioButton rbHexa1;
        private System.Windows.Forms.RadioButton rbBinario2;
        private System.Windows.Forms.RadioButton rbDecimal2;
        private System.Windows.Forms.RadioButton rbHexa2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

