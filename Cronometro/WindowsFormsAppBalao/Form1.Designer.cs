namespace WindowsFormsAppBalao
{
    partial class Form1
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
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnDescer = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.btnMudarCor = new System.Windows.Forms.Button();
            this.picChao = new System.Windows.Forms.PictureBox();
            this.picBalao = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBalao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubir
            // 
            this.btnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.Location = new System.Drawing.Point(744, 407);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(80, 29);
            this.btnSubir.TabIndex = 9;
            this.btnSubir.Text = "Norte";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnDescer
            // 
            this.btnDescer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescer.Location = new System.Drawing.Point(744, 442);
            this.btnDescer.Name = "btnDescer";
            this.btnDescer.Size = new System.Drawing.Size(80, 30);
            this.btnDescer.TabIndex = 10;
            this.btnDescer.Text = "Descer";
            this.btnDescer.UseVisualStyleBackColor = true;
            this.btnDescer.Click += new System.EventHandler(this.btnDescer_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(415, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(132, 20);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado do Balao";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(871, 267);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 22);
            this.txtCor.TabIndex = 12;
            // 
            // btnMudarCor
            // 
            this.btnMudarCor.Location = new System.Drawing.Point(830, 236);
            this.btnMudarCor.Name = "btnMudarCor";
            this.btnMudarCor.Size = new System.Drawing.Size(145, 25);
            this.btnMudarCor.TabIndex = 15;
            this.btnMudarCor.Text = "Mudar Cor do Balao";
            this.btnMudarCor.UseVisualStyleBackColor = true;
            this.btnMudarCor.Click += new System.EventHandler(this.btnMudarCor_Click_1);
            // 
            // picChao
            // 
            this.picChao.Image = global::WindowsFormsAppBalao.Properties.Resources.Sem_título;
            this.picChao.Location = new System.Drawing.Point(-14, 508);
            this.picChao.Name = "picChao";
            this.picChao.Size = new System.Drawing.Size(1022, 71);
            this.picChao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChao.TabIndex = 5;
            this.picChao.TabStop = false;
            // 
            // picBalao
            // 
            this.picBalao.Image = global::WindowsFormsAppBalao.Properties.Resources.balao_vermelho;
            this.picBalao.Location = new System.Drawing.Point(495, 397);
            this.picBalao.Name = "picBalao";
            this.picBalao.Size = new System.Drawing.Size(101, 105);
            this.picBalao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBalao.TabIndex = 4;
            this.picBalao.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsAppBalao.Properties.Resources.vecteezy_blue_sky_cloud_bubble_pixel_design_for_decoration_wheather_36395813;
            this.pictureBox4.Location = new System.Drawing.Point(790, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsAppBalao.Properties.Resources.vecteezy_blue_sky_cloud_bubble_pixel_design_for_decoration_wheather_36395813;
            this.pictureBox3.Location = new System.Drawing.Point(221, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsAppBalao.Properties.Resources.vecteezy_blue_sky_cloud_bubble_pixel_design_for_decoration_wheather_36395813;
            this.pictureBox2.Location = new System.Drawing.Point(0, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnDireita
            // 
            this.btnDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireita.Location = new System.Drawing.Point(830, 426);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(93, 29);
            this.btnDireita.TabIndex = 16;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsquerda.Location = new System.Drawing.Point(637, 426);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(101, 31);
            this.btnEsquerda.TabIndex = 17;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 564);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnMudarCor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnDescer);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.picChao);
            this.Controls.Add(this.picBalao);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Balao";
            ((System.ComponentModel.ISupportInitialize)(this.picChao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBalao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picBalao;
        private System.Windows.Forms.PictureBox picChao;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnDescer;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button btnMudarCor;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
    }
}

