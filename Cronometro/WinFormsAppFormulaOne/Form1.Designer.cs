namespace WinFormsAppFormulaOne
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
            lblKilometragem = new Label();
            progressBarCombustivel = new ProgressBar();
            lblViagens = new Label();
            lblReserva = new Label();
            lblCustoTotal = new Label();
            lblCustoMedio = new Label();
            SuspendLayout();
            // 
            // lblKilometragem
            // 
            lblKilometragem.AutoSize = true;
            lblKilometragem.Location = new Point(551, 173);
            lblKilometragem.Name = "lblKilometragem";
            lblKilometragem.Size = new Size(38, 25);
            lblKilometragem.TabIndex = 0;
            lblKilometragem.Text = "Km";
            // 
            // progressBarCombustivel
            // 
            progressBarCombustivel.Location = new Point(441, 298);
            progressBarCombustivel.Name = "progressBarCombustivel";
            progressBarCombustivel.Size = new Size(262, 31);
            progressBarCombustivel.TabIndex = 2;
            // 
            // lblViagens
            // 
            lblViagens.AutoSize = true;
            lblViagens.Location = new Point(37, 362);
            lblViagens.Name = "lblViagens";
            lblViagens.Size = new Size(169, 25);
            lblViagens.TabIndex = 3;
            lblViagens.Text = "Numero de Viagens";
            // 
            // lblReserva
            // 
            lblReserva.AutoSize = true;
            lblReserva.Location = new Point(499, 362);
            lblReserva.Name = "lblReserva";
            lblReserva.Size = new Size(123, 25);
            lblReserva.TabIndex = 4;
            lblReserva.Text = "Alerta Reserva";
            // 
            // lblCustoTotal
            // 
            lblCustoTotal.AutoSize = true;
            lblCustoTotal.Location = new Point(37, 252);
            lblCustoTotal.Name = "lblCustoTotal";
            lblCustoTotal.Size = new Size(183, 25);
            lblCustoTotal.TabIndex = 5;
            lblCustoTotal.Text = "Total em Combustivel";
            // 
            // lblCustoMedio
            // 
            lblCustoMedio.AutoSize = true;
            lblCustoMedio.Location = new Point(42, 304);
            lblCustoMedio.Name = "lblCustoMedio";
            lblCustoMedio.Size = new Size(178, 25);
            lblCustoMedio.TabIndex = 6;
            lblCustoMedio.Text = "Custo Medio por KM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCustoMedio);
            Controls.Add(lblCustoTotal);
            Controls.Add(lblReserva);
            Controls.Add(lblViagens);
            Controls.Add(progressBarCombustivel);
            Controls.Add(lblKilometragem);
            Name = "Form1";
            Text = "Fabrica de boguinhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblKilometragem;
        private ProgressBar progressBarCombustivel;
        private Label lblViagens;
        private Label lblReserva;
        private Label lblCustoTotal;
        private Label lblCustoMedio;
    }
}
