namespace ConversorMoneda
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMonto = new TextBox();
            cmbOrigen = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            label2 = new Label();
            cmbDestino = new ComboBox();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(307, 271);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(298, 111);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(322, 221);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click_1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(322, 320);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "RESULTADO";
            lblResultado.Click += lblResultado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 156);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 4;
            label2.Text = "DE:";
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(298, 174);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 23);
            cmbDestino.TabIndex = 5;
            cmbDestino.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDestino);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbOrigen);
            Controls.Add(txtMonto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private ComboBox cmbOrigen;
        private Button btnConvertir;
        private Label lblResultado;
        private Label label2;
        private ComboBox cmbDestino;
    }
}
