
namespace BlackJack
{
    partial class Form_jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_jogo));
            this.btn_jogar_1 = new System.Windows.Forms.Button();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Pontos_A = new System.Windows.Forms.Label();
            this.lbl_legenda = new System.Windows.Forms.Label();
            this.btn_parar_1 = new System.Windows.Forms.Button();
            this.btn_parar_2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_jogar_2 = new System.Windows.Forms.Button();
            this.lbl_Pontos_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btnMarvel = new System.Windows.Forms.Button();
            this.bntTradicional = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFutebol = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jogar_1
            // 
            this.btn_jogar_1.Location = new System.Drawing.Point(24, 512);
            this.btn_jogar_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jogar_1.Name = "btn_jogar_1";
            this.btn_jogar_1.Size = new System.Drawing.Size(126, 39);
            this.btn_jogar_1.TabIndex = 0;
            this.btn_jogar_1.Text = "Jogar";
            this.btn_jogar_1.UseVisualStyleBackColor = true;
            this.btn_jogar_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(381, 16);
            this.btn_reiniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(137, 37);
            this.btn_reiniciar.TabIndex = 1;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(24, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Pontos_A
            // 
            this.lbl_Pontos_A.AutoSize = true;
            this.lbl_Pontos_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_A.Location = new System.Drawing.Point(405, 150);
            this.lbl_Pontos_A.Name = "lbl_Pontos_A";
            this.lbl_Pontos_A.Size = new System.Drawing.Size(30, 31);
            this.lbl_Pontos_A.TabIndex = 3;
            this.lbl_Pontos_A.Text = "0";
            // 
            // lbl_legenda
            // 
            this.lbl_legenda.AutoSize = true;
            this.lbl_legenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_legenda.Location = new System.Drawing.Point(414, 112);
            this.lbl_legenda.Name = "lbl_legenda";
            this.lbl_legenda.Size = new System.Drawing.Size(76, 28);
            this.lbl_legenda.TabIndex = 4;
            this.lbl_legenda.Text = "Pontos:";
            // 
            // btn_parar_1
            // 
            this.btn_parar_1.Location = new System.Drawing.Point(179, 512);
            this.btn_parar_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_parar_1.Name = "btn_parar_1";
            this.btn_parar_1.Size = new System.Drawing.Size(126, 39);
            this.btn_parar_1.TabIndex = 5;
            this.btn_parar_1.Text = "Parar";
            this.btn_parar_1.UseVisualStyleBackColor = true;
            this.btn_parar_1.Click += new System.EventHandler(this.btn_parar_1_Click);
            // 
            // btn_parar_2
            // 
            this.btn_parar_2.Location = new System.Drawing.Point(744, 512);
            this.btn_parar_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_parar_2.Name = "btn_parar_2";
            this.btn_parar_2.Size = new System.Drawing.Size(126, 39);
            this.btn_parar_2.TabIndex = 8;
            this.btn_parar_2.Text = "Parar";
            this.btn_parar_2.UseVisualStyleBackColor = true;
            this.btn_parar_2.Click += new System.EventHandler(this.btn_parar_2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(588, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 471);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_jogar_2
            // 
            this.btn_jogar_2.Location = new System.Drawing.Point(588, 512);
            this.btn_jogar_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_jogar_2.Name = "btn_jogar_2";
            this.btn_jogar_2.Size = new System.Drawing.Size(126, 39);
            this.btn_jogar_2.TabIndex = 6;
            this.btn_jogar_2.Text = "Jogar";
            this.btn_jogar_2.UseVisualStyleBackColor = true;
            this.btn_jogar_2.Click += new System.EventHandler(this.btn_jogar_2_Click);
            // 
            // lbl_Pontos_B
            // 
            this.lbl_Pontos_B.AutoSize = true;
            this.lbl_Pontos_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_B.Location = new System.Drawing.Point(469, 150);
            this.lbl_Pontos_B.Name = "lbl_Pontos_B";
            this.lbl_Pontos_B.Size = new System.Drawing.Size(30, 31);
            this.lbl_Pontos_B.TabIndex = 9;
            this.lbl_Pontos_B.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.Location = new System.Drawing.Point(312, 244);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 28);
            this.lbl_Resultado.TabIndex = 11;
            // 
            // btnMarvel
            // 
            this.btnMarvel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMarvel.Location = new System.Drawing.Point(335, 410);
            this.btnMarvel.Name = "btnMarvel";
            this.btnMarvel.Size = new System.Drawing.Size(227, 62);
            this.btnMarvel.TabIndex = 12;
            this.btnMarvel.Text = "cartas marvel";
            this.btnMarvel.UseVisualStyleBackColor = true;
            this.btnMarvel.Click += new System.EventHandler(this.btnMarvel_Click);
            // 
            // bntTradicional
            // 
            this.bntTradicional.Enabled = false;
            this.bntTradicional.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntTradicional.Location = new System.Drawing.Point(335, 489);
            this.bntTradicional.Name = "bntTradicional";
            this.bntTradicional.Size = new System.Drawing.Size(227, 62);
            this.bntTradicional.TabIndex = 13;
            this.bntTradicional.Text = "cartas tradicional";
            this.bntTradicional.UseVisualStyleBackColor = true;
            this.bntTradicional.Click += new System.EventHandler(this.bntTradicional_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BlackJack.Properties.Resources.marvel_comics;
            this.pictureBox3.Location = new System.Drawing.Point(24, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(282, 471);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BlackJack.Properties.Resources.marvel_comics;
            this.pictureBox4.Location = new System.Drawing.Point(588, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 471);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 78);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(588, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 78);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // btnFutebol
            // 
            this.btnFutebol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFutebol.Location = new System.Drawing.Point(335, 329);
            this.btnFutebol.Name = "btnFutebol";
            this.btnFutebol.Size = new System.Drawing.Size(227, 62);
            this.btnFutebol.TabIndex = 18;
            this.btnFutebol.Text = "cartas futebol";
            this.btnFutebol.UseVisualStyleBackColor = true;
            this.btnFutebol.Click += new System.EventHandler(this.btnFutebol_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BlackJack.Properties.Resources.futebol__7_;
            this.pictureBox5.Location = new System.Drawing.Point(24, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(282, 470);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BlackJack.Properties.Resources.futebol__7_;
            this.pictureBox6.Location = new System.Drawing.Point(588, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(282, 470);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // Form_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFutebol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntTradicional);
            this.Controls.Add(this.btnMarvel);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pontos_B);
            this.Controls.Add(this.btn_parar_2);
            this.Controls.Add(this.btn_jogar_2);
            this.Controls.Add(this.btn_parar_1);
            this.Controls.Add(this.lbl_legenda);
            this.Controls.Add(this.lbl_Pontos_A);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.btn_jogar_1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_jogo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BlackJack versão (meme)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jogar_1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Pontos_A;
        private System.Windows.Forms.Label lbl_legenda;
        private System.Windows.Forms.Button btn_parar_1;
        private System.Windows.Forms.Button btn_parar_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_jogar_2;
        private System.Windows.Forms.Label lbl_Pontos_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btnMarvel;
        private System.Windows.Forms.Button bntTradicional;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFutebol;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

