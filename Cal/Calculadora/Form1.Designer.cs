
namespace Calculadora
{
    partial class FormPrincipal
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(331, 23);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVisor.TextChanged += new System.EventHandler(this.txtVisor_TextChanged);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPorcentagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentagem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPorcentagem.Location = new System.Drawing.Point(12, 62);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(74, 62);
            this.btnPorcentagem.TabIndex = 1;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnC
            // 
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(92, 62);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(74, 62);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDivisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivisao.Location = new System.Drawing.Point(252, 62);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(74, 62);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApagar.Location = new System.Drawing.Point(172, 62);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(74, 62);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "<---";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.Location = new System.Drawing.Point(252, 198);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(74, 62);
            this.btnSoma.TabIndex = 8;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnNove
            // 
            this.btnNove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNove.Location = new System.Drawing.Point(172, 130);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(74, 62);
            this.btnNove.TabIndex = 7;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnOito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOito.Location = new System.Drawing.Point(92, 130);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(74, 62);
            this.btnOito.TabIndex = 6;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSete.Location = new System.Drawing.Point(12, 130);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(74, 62);
            this.btnSete.TabIndex = 5;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            this.btnSete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSete_KeyPress);
            this.btnSete.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSete_PreviewKeyDown);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMultiplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicacao.Location = new System.Drawing.Point(252, 129);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(74, 62);
            this.btnMultiplicacao.TabIndex = 12;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.Location = new System.Drawing.Point(172, 198);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(74, 62);
            this.btnSeis.TabIndex = 11;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.Location = new System.Drawing.Point(92, 198);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(74, 62);
            this.btnCinco.TabIndex = 10;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnQuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuatro.Location = new System.Drawing.Point(12, 198);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(74, 62);
            this.btnQuatro.TabIndex = 9;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(252, 334);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(74, 62);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnTres
            // 
            this.btnTres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTres.Location = new System.Drawing.Point(172, 266);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(74, 62);
            this.btnTres.TabIndex = 15;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDois.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDois.Location = new System.Drawing.Point(92, 266);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(74, 62);
            this.btnDois.TabIndex = 14;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnUm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUm.Location = new System.Drawing.Point(12, 266);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(74, 62);
            this.btnUm.TabIndex = 13;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnVirgula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVirgula.Location = new System.Drawing.Point(172, 334);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(74, 62);
            this.btnVirgula.TabIndex = 19;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(12, 334);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(154, 62);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            this.btnZero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSete_KeyPress);
            // 
            // btnMenos
            // 
            this.btnMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.Location = new System.Drawing.Point(252, 266);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(74, 62);
            this.btnMenos.TabIndex = 20;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(275, 38);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(0, 15);
            this.lblConta.TabIndex = 21;
            this.lblConta.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(351, 435);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.txtVisor);
            this.Name = "FormPrincipal";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConta;
    }
}

