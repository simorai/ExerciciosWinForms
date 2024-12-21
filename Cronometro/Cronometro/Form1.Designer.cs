namespace Cronometro
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
            components = new System.ComponentModel.Container();
            ButtonOnOff = new Button();
            LabelContador = new Label();
            TimerRelogio = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ButtonOnOff
            // 
            ButtonOnOff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonOnOff.Location = new Point(629, 342);
            ButtonOnOff.Name = "ButtonOnOff";
            ButtonOnOff.Size = new Size(132, 84);
            ButtonOnOff.TabIndex = 0;
            ButtonOnOff.Text = "Ligar";
            ButtonOnOff.UseVisualStyleBackColor = true;
            ButtonOnOff.Click += ButtonOnOff_Click;
            // 
            // LabelContador
            // 
            LabelContador.AutoSize = true;
            LabelContador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelContador.Location = new Point(273, 176);
            LabelContador.Name = "LabelContador";
            LabelContador.Size = new Size(104, 31);
            LabelContador.TabIndex = 1;
            LabelContador.Text = "00:00:00";
            // 
            // TimerRelogio
            // 
            TimerRelogio.Interval = 60;
            TimerRelogio.Tick += TimerRelogio_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelContador);
            Controls.Add(ButtonOnOff);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonOnOff;
        private Label LabelContador;
        private System.Windows.Forms.Timer TimerRelogio;
    }
}
