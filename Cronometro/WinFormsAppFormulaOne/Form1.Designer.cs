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
            lblQuilometragem = new Label();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            txtQuilometragem = new TextBox();
            lblCapacidade = new Label();
            txtCapacidade = new TextBox();
            lblConsumo = new Label();
            txtConsumo = new TextBox();
            lblLitros = new Label();
            txtLitros = new TextBox();
            btnRegistrarViagem = new Button();
            txtViagem = new TextBox();
            btnCalcularQuilometros = new Button();
            btnAdicionarCombustivel = new Button();
            txtLitrosAdicionar = new TextBox();
            txtCustoPorLitro = new TextBox();
            btnCustoMedio = new Button();
            lblResultado = new Label();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAtualizarMatricula = new Button();
            lblInfoDetalhada = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblQuilometragem
            // 
            lblQuilometragem.AutoSize = true;
            lblQuilometragem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuilometragem.Location = new Point(454, 183);
            lblQuilometragem.Name = "lblQuilometragem";
            lblQuilometragem.Size = new Size(262, 28);
            lblQuilometragem.TabIndex = 0;
            lblQuilometragem.Text = "Quilometragem Total (km)";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(18, 9);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(84, 25);
            lblMatricula.TabIndex = 7;
            lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(12, 37);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(125, 31);
            txtMatricula.TabIndex = 8;
            // 
            // txtQuilometragem
            // 
            txtQuilometragem.BackColor = SystemColors.Info;
            txtQuilometragem.Enabled = false;
            txtQuilometragem.Location = new Point(512, 140);
            txtQuilometragem.Name = "txtQuilometragem";
            txtQuilometragem.Size = new Size(142, 31);
            txtQuilometragem.TabIndex = 9;
            // 
            // lblCapacidade
            // 
            lblCapacidade.AutoSize = true;
            lblCapacidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidade.Location = new Point(306, 275);
            lblCapacidade.Name = "lblCapacidade";
            lblCapacidade.Size = new Size(310, 28);
            lblCapacidade.TabIndex = 10;
            lblCapacidade.Text = "Capacidade do Depósito (litros)";
            // 
            // txtCapacidade
            // 
            txtCapacidade.BackColor = SystemColors.Info;
            txtCapacidade.Enabled = false;
            txtCapacidade.Location = new Point(419, 238);
            txtCapacidade.Name = "txtCapacidade";
            txtCapacidade.Size = new Size(125, 31);
            txtCapacidade.TabIndex = 11;
            // 
            // lblConsumo
            // 
            lblConsumo.AutoSize = true;
            lblConsumo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumo.Location = new Point(715, 375);
            lblConsumo.Name = "lblConsumo";
            lblConsumo.Size = new Size(308, 28);
            lblConsumo.TabIndex = 12;
            lblConsumo.Text = "Consumo Médio (litros/100km)";
            // 
            // txtConsumo
            // 
            txtConsumo.Enabled = false;
            txtConsumo.Location = new Point(898, 337);
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(125, 31);
            txtConsumo.TabIndex = 13;
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLitros.Location = new Point(634, 275);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(186, 28);
            lblLitros.TabIndex = 14;
            lblLitros.Text = "Litros no Depósito";
            // 
            // txtLitros
            // 
            txtLitros.BackColor = SystemColors.Info;
            txtLitros.Enabled = false;
            txtLitros.Location = new Point(634, 238);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(125, 31);
            txtLitros.TabIndex = 15;
            // 
            // btnRegistrarViagem
            // 
            btnRegistrarViagem.BackColor = SystemColors.ActiveCaption;
            btnRegistrarViagem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarViagem.Location = new Point(5, 368);
            btnRegistrarViagem.Name = "btnRegistrarViagem";
            btnRegistrarViagem.Size = new Size(273, 43);
            btnRegistrarViagem.TabIndex = 16;
            btnRegistrarViagem.Text = "Registrar Viagem";
            btnRegistrarViagem.UseVisualStyleBackColor = false;
            btnRegistrarViagem.Click += btnRegistrarViagem_Click;
            // 
            // txtViagem
            // 
            txtViagem.BackColor = SystemColors.ButtonHighlight;
            txtViagem.Location = new Point(512, 37);
            txtViagem.Name = "txtViagem";
            txtViagem.Size = new Size(142, 31);
            txtViagem.TabIndex = 17;
            // 
            // btnCalcularQuilometros
            // 
            btnCalcularQuilometros.BackColor = SystemColors.ActiveCaption;
            btnCalcularQuilometros.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularQuilometros.Location = new Point(5, 417);
            btnCalcularQuilometros.Name = "btnCalcularQuilometros";
            btnCalcularQuilometros.Size = new Size(273, 79);
            btnCalcularQuilometros.TabIndex = 18;
            btnCalcularQuilometros.Text = "Calcular Quilómetros Possíveis";
            btnCalcularQuilometros.UseVisualStyleBackColor = false;
            btnCalcularQuilometros.Click += btnCalcularQuilometros_Click;
            // 
            // btnAdicionarCombustivel
            // 
            btnAdicionarCombustivel.BackColor = SystemColors.ActiveCaption;
            btnAdicionarCombustivel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarCombustivel.Location = new Point(464, 375);
            btnAdicionarCombustivel.Name = "btnAdicionarCombustivel";
            btnAdicionarCombustivel.Size = new Size(217, 72);
            btnAdicionarCombustivel.TabIndex = 19;
            btnAdicionarCombustivel.Text = "Adicionar Combustível";
            btnAdicionarCombustivel.UseVisualStyleBackColor = false;
            btnAdicionarCombustivel.Click += btnAdicionarCombustivel_Click;
            // 
            // txtLitrosAdicionar
            // 
            txtLitrosAdicionar.BackColor = SystemColors.ButtonHighlight;
            txtLitrosAdicionar.Location = new Point(495, 337);
            txtLitrosAdicionar.Name = "txtLitrosAdicionar";
            txtLitrosAdicionar.Size = new Size(159, 31);
            txtLitrosAdicionar.TabIndex = 20;
            // 
            // txtCustoPorLitro
            // 
            txtCustoPorLitro.BackColor = SystemColors.ButtonHighlight;
            txtCustoPorLitro.Location = new Point(927, 241);
            txtCustoPorLitro.Name = "txtCustoPorLitro";
            txtCustoPorLitro.Size = new Size(96, 31);
            txtCustoPorLitro.TabIndex = 22;
            // 
            // btnCustoMedio
            // 
            btnCustoMedio.BackColor = SystemColors.ActiveCaption;
            btnCustoMedio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustoMedio.Location = new Point(5, 502);
            btnCustoMedio.Name = "btnCustoMedio";
            btnCustoMedio.Size = new Size(273, 76);
            btnCustoMedio.TabIndex = 23;
            btnCustoMedio.Text = "Calcular Custo Médio por Km";
            btnCustoMedio.UseVisualStyleBackColor = false;
            btnCustoMedio.Click += btnCustoMedio_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(512, 515);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(106, 28);
            lblResultado.TabIndex = 24;
            lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(407, 465);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(364, 31);
            txtResultado.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(874, 272);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 26;
            label1.Text = "Custo por litro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 87);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 27;
            label2.Text = "Quilómetros da Viagem";
            // 
            // btnAtualizarMatricula
            // 
            btnAtualizarMatricula.BackColor = SystemColors.ActiveCaption;
            btnAtualizarMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarMatricula.Location = new Point(12, 74);
            btnAtualizarMatricula.Name = "btnAtualizarMatricula";
            btnAtualizarMatricula.Size = new Size(190, 75);
            btnAtualizarMatricula.TabIndex = 28;
            btnAtualizarMatricula.Text = "Atualizar Matricula";
            btnAtualizarMatricula.UseVisualStyleBackColor = false;
            btnAtualizarMatricula.Click += btnAtualizarMatricula_Click;
            // 
            // lblInfoDetalhada
            // 
            lblInfoDetalhada.AutoSize = true;
            lblInfoDetalhada.Location = new Point(18, 191);
            lblInfoDetalhada.Name = "lblInfoDetalhada";
            lblInfoDetalhada.Size = new Size(0, 25);
            lblInfoDetalhada.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(220, 28);
            label3.TabIndex = 30;
            label3.Text = "Informação detalhada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 598);
            Controls.Add(label3);
            Controls.Add(lblInfoDetalhada);
            Controls.Add(btnAtualizarMatricula);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnCustoMedio);
            Controls.Add(txtCustoPorLitro);
            Controls.Add(txtLitrosAdicionar);
            Controls.Add(btnAdicionarCombustivel);
            Controls.Add(btnCalcularQuilometros);
            Controls.Add(txtViagem);
            Controls.Add(btnRegistrarViagem);
            Controls.Add(txtLitros);
            Controls.Add(lblLitros);
            Controls.Add(txtConsumo);
            Controls.Add(lblConsumo);
            Controls.Add(txtCapacidade);
            Controls.Add(lblCapacidade);
            Controls.Add(txtQuilometragem);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatricula);
            Controls.Add(lblQuilometragem);
            Name = "Form1";
            Text = "Fabrica de boguinhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblQuilometragem;
        private Label lblMatricula;
        private TextBox txtMatricula;
        private TextBox txtQuilometragem;
        private Label lblCapacidade;
        private TextBox txtCapacidade;
        private Label lblConsumo;
        private TextBox txtConsumo;
        private Label lblLitros;
        private TextBox txtLitros;
        private Button btnRegistrarViagem;
        private TextBox txtViagem;
        private Button btnCalcularQuilometros;
        private Button btnAdicionarCombustivel;
        private TextBox txtLitrosAdicionar;
        private TextBox txtCustoPorLitro;
        private Button btnCustoMedio;
        private Label lblResultado;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Button btnAtualizarMatricula;
        private Label lblInfoDetalhada;
        private Label label3;
    }
}
