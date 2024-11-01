namespace Calculadora_MVC
{
    partial class GUI
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnData = new System.Windows.Forms.Button();
            this.BtnBinario = new System.Windows.Forms.Button();
            this.BtnPrimo = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnAvg = new System.Windows.Forms.Button();
            this.BtnMemory = new System.Windows.Forms.Button();
            this.btnVerBitacora = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Navy;
            this.txtResultado.ForeColor = System.Drawing.SystemColors.Info;
            this.txtResultado.Location = new System.Drawing.Point(28, 25);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(315, 20);
            this.txtResultado.TabIndex = 0;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(208, 296);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(50, 50);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(208, 240);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(50, 50);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(208, 128);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicacion.TabIndex = 3;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(208, 184);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 50);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(264, 240);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(79, 106);
            this.btnIgual.TabIndex = 5;
            this.btnIgual.Text = "=";
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(88, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 50);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnData
            // 
            this.BtnData.Location = new System.Drawing.Point(208, 60);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(135, 52);
            this.BtnData.TabIndex = 9;
            this.BtnData.Text = "Data";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // BtnBinario
            // 
            this.BtnBinario.Location = new System.Drawing.Point(28, 60);
            this.BtnBinario.Name = "BtnBinario";
            this.BtnBinario.Size = new System.Drawing.Size(170, 23);
            this.BtnBinario.TabIndex = 10;
            this.BtnBinario.Text = "Binario";
            this.BtnBinario.UseVisualStyleBackColor = true;
            this.BtnBinario.Click += new System.EventHandler(this.BtnBinario_Click);
            // 
            // BtnPrimo
            // 
            this.BtnPrimo.Location = new System.Drawing.Point(28, 89);
            this.BtnPrimo.Name = "BtnPrimo";
            this.BtnPrimo.Size = new System.Drawing.Size(170, 23);
            this.BtnPrimo.TabIndex = 11;
            this.BtnPrimo.Text = "Primo";
            this.BtnPrimo.UseVisualStyleBackColor = true;
            this.BtnPrimo.Click += new System.EventHandler(this.BtnPrimo_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(28, 128);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(50, 50);
            this.Btn7.TabIndex = 12;
            this.Btn7.Text = "7";
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(88, 128);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(50, 50);
            this.Btn8.TabIndex = 13;
            this.Btn8.Text = "8";
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(148, 128);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(50, 50);
            this.Btn9.TabIndex = 14;
            this.Btn9.Text = "9";
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(148, 184);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(50, 50);
            this.Btn6.TabIndex = 17;
            this.Btn6.Text = "6";
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(88, 184);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(50, 50);
            this.Btn5.TabIndex = 16;
            this.Btn5.Text = "5";
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(28, 184);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(50, 50);
            this.Btn4.TabIndex = 15;
            this.Btn4.Text = "4";
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(148, 240);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(50, 50);
            this.Btn3.TabIndex = 20;
            this.Btn3.Text = "3";
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(88, 240);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(50, 50);
            this.Btn2.TabIndex = 19;
            this.Btn2.Text = "2";
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(28, 240);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 50);
            this.Btn1.TabIndex = 18;
            this.Btn1.Text = "1";
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(28, 296);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(50, 50);
            this.Btn0.TabIndex = 21;
            this.Btn0.Text = "0";
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnAvg
            // 
            this.BtnAvg.Location = new System.Drawing.Point(264, 128);
            this.BtnAvg.Name = "BtnAvg";
            this.BtnAvg.Size = new System.Drawing.Size(79, 50);
            this.BtnAvg.TabIndex = 23;
            this.BtnAvg.Text = "Avg";
            this.BtnAvg.UseVisualStyleBackColor = true;
            this.BtnAvg.Click += new System.EventHandler(this.BtnAvg_Click);
            // 
            // BtnMemory
            // 
            this.BtnMemory.Location = new System.Drawing.Point(264, 184);
            this.BtnMemory.Name = "BtnMemory";
            this.BtnMemory.Size = new System.Drawing.Size(79, 50);
            this.BtnMemory.TabIndex = 24;
            this.BtnMemory.Text = "M+";
            this.BtnMemory.UseVisualStyleBackColor = true;
            this.BtnMemory.Click += new System.EventHandler(this.BtnMemory_Click);
            // 
            // btnVerBitacora
            // 
            this.btnVerBitacora.Location = new System.Drawing.Point(117, 352);
            this.btnVerBitacora.Name = "btnVerBitacora";
            this.btnVerBitacora.Size = new System.Drawing.Size(110, 38);
            this.btnVerBitacora.TabIndex = 0;
            this.btnVerBitacora.Text = "Ver Bitácora";
            this.btnVerBitacora.Click += new System.EventHandler(this.btnVerBitacora_Click_1);
            // 
            // BtnDot
            // 
            this.BtnDot.Location = new System.Drawing.Point(148, 296);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(50, 50);
            this.BtnDot.TabIndex = 22;
            this.BtnDot.Text = ".";
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(360, 399);
            this.Controls.Add(this.btnVerBitacora);
            this.Controls.Add(this.BtnMemory);
            this.Controls.Add(this.BtnAvg);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnPrimo);
            this.Controls.Add(this.BtnBinario);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnClear);
            this.Name = "GUI";
            this.Text = "Calculadora MVC";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnClear;

        #endregion
        private System.Windows.Forms.Button BtnData;
        private System.Windows.Forms.Button BtnBinario;
        private System.Windows.Forms.Button BtnPrimo;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnAvg;
        private System.Windows.Forms.Button BtnMemory;
        private System.Windows.Forms.Button btnVerBitacora;
        private System.Windows.Forms.Button BtnDot;
    }
}
