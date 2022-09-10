namespace SistemaSuperSecreto_1._0
{
    partial class VentanaPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVisualC = new System.Windows.Forms.CheckBox();
            this.cbVisualBasic = new System.Windows.Forms.CheckBox();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbPayPal = new System.Windows.Forms.RadioButton();
            this.btnComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cursos en Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formas de Pago";
            // 
            // cbVisualC
            // 
            this.cbVisualC.AutoSize = true;
            this.cbVisualC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualC.Location = new System.Drawing.Point(31, 97);
            this.cbVisualC.Name = "cbVisualC";
            this.cbVisualC.Size = new System.Drawing.Size(108, 28);
            this.cbVisualC.TabIndex = 4;
            this.cbVisualC.Text = "Visual C#";
            this.cbVisualC.UseVisualStyleBackColor = true;
            // 
            // cbVisualBasic
            // 
            this.cbVisualBasic.AutoSize = true;
            this.cbVisualBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisualBasic.Location = new System.Drawing.Point(31, 171);
            this.cbVisualBasic.Name = "cbVisualBasic";
            this.cbVisualBasic.Size = new System.Drawing.Size(130, 28);
            this.cbVisualBasic.TabIndex = 5;
            this.cbVisualBasic.Text = "Visual Basic";
            this.cbVisualBasic.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.Location = new System.Drawing.Point(480, 97);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(177, 28);
            this.rbTarjeta.TabIndex = 6;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta de Crédito";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbPayPal
            // 
            this.rbPayPal.AutoSize = true;
            this.rbPayPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPayPal.Location = new System.Drawing.Point(480, 158);
            this.rbPayPal.Name = "rbPayPal";
            this.rbPayPal.Size = new System.Drawing.Size(84, 28);
            this.rbPayPal.TabIndex = 7;
            this.rbPayPal.TabStop = true;
            this.rbPayPal.Text = "Paypal";
            this.rbPayPal.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(320, 344);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(157, 94);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.rbPayPal);
            this.Controls.Add(this.rbTarjeta);
            this.Controls.Add(this.cbVisualBasic);
            this.Controls.Add(this.cbVisualC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbVisualC;
        private System.Windows.Forms.CheckBox cbVisualBasic;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbPayPal;
        private System.Windows.Forms.Button btnComprar;
    }
}