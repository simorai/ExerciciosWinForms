namespace WindowsFormsAppPost
{
    partial class NovoFormPost
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
            this.lblTitulo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNaoGostos = new System.Windows.Forms.Label();
            this.lblGostos = new System.Windows.Forms.Label();
            this.btnNaoGostar = new System.Windows.Forms.Button();
            this.btnGostar = new System.Windows.Forms.Button();
            this.btnSubmeter = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(516, 86);
            this.lblTitulo.Multiline = true;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 45);
            this.lblTitulo.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Enabled = false;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(516, 176);
            this.lblDescricao.Multiline = true;
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.ReadOnly = true;
            this.lblDescricao.Size = new System.Drawing.Size(225, 117);
            this.lblDescricao.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(513, 296);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 16);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            // 
            // lblNaoGostos
            // 
            this.lblNaoGostos.AutoSize = true;
            this.lblNaoGostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoGostos.Location = new System.Drawing.Point(634, 339);
            this.lblNaoGostos.Name = "lblNaoGostos";
            this.lblNaoGostos.Size = new System.Drawing.Size(108, 20);
            this.lblNaoGostos.TabIndex = 18;
            this.lblNaoGostos.Text = "Não Gostos";
            // 
            // lblGostos
            // 
            this.lblGostos.AutoSize = true;
            this.lblGostos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGostos.Location = new System.Drawing.Point(512, 339);
            this.lblGostos.Name = "lblGostos";
            this.lblGostos.Size = new System.Drawing.Size(69, 20);
            this.lblGostos.TabIndex = 17;
            this.lblGostos.Text = "Gostos";
            // 
            // btnNaoGostar
            // 
            this.btnNaoGostar.Enabled = false;
            this.btnNaoGostar.Location = new System.Drawing.Point(666, 373);
            this.btnNaoGostar.Name = "btnNaoGostar";
            this.btnNaoGostar.Size = new System.Drawing.Size(75, 65);
            this.btnNaoGostar.TabIndex = 16;
            this.btnNaoGostar.Text = "Não Gosto";
            this.btnNaoGostar.UseVisualStyleBackColor = true;
            this.btnNaoGostar.Click += new System.EventHandler(this.btnNaoGostar_Click);
            // 
            // btnGostar
            // 
            this.btnGostar.Enabled = false;
            this.btnGostar.Location = new System.Drawing.Point(516, 373);
            this.btnGostar.Name = "btnGostar";
            this.btnGostar.Size = new System.Drawing.Size(75, 65);
            this.btnGostar.TabIndex = 15;
            this.btnGostar.Text = "Gosto";
            this.btnGostar.UseVisualStyleBackColor = true;
            this.btnGostar.Click += new System.EventHandler(this.btnGostar_Click_2);
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmeter.Location = new System.Drawing.Point(25, 387);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(134, 35);
            this.btnSubmeter.TabIndex = 23;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = true;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(34, 179);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(223, 117);
            this.txtDescricao.TabIndex = 22;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(37, 89);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(223, 45);
            this.txtTitulo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Conteudo do Post";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Titulo do Post";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(148, 30);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "FaceTruque";
            // 
            // NovoFormPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSubmeter);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaoGostos);
            this.Controls.Add(this.lblGostos);
            this.Controls.Add(this.btnNaoGostar);
            this.Controls.Add(this.btnGostar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Name = "NovoFormPost";
            this.Text = "NovoFormPost";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblTitulo;
        private System.Windows.Forms.TextBox lblDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNaoGostos;
        private System.Windows.Forms.Label lblGostos;
        private System.Windows.Forms.Button btnNaoGostar;
        private System.Windows.Forms.Button btnGostar;
        private System.Windows.Forms.Button btnSubmeter;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
    }
}