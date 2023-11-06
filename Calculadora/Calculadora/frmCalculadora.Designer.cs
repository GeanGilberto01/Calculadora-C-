namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lvResultado = new System.Windows.Forms.ListView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnResultar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnPercentual = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.lblSinal = new System.Windows.Forms.Label();
            this.pnlVisor.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVisor
            // 
            this.pnlVisor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlVisor.Controls.Add(this.lblSinal);
            this.pnlVisor.Controls.Add(this.lblResultado);
            this.pnlVisor.Controls.Add(this.lblOperacao);
            this.pnlVisor.Controls.Add(this.lvResultado);
            this.pnlVisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVisor.Location = new System.Drawing.Point(0, 0);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(443, 79);
            this.pnlVisor.TabIndex = 20;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultado.Location = new System.Drawing.Point(43, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(379, 22);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperacao
            // 
            this.lblOperacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblOperacao.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(19, 20);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperacao.Size = new System.Drawing.Size(402, 15);
            this.lblOperacao.TabIndex = 2;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvResultado
            // 
            this.lvResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvResultado.HideSelection = false;
            this.lvResultado.Location = new System.Drawing.Point(12, 12);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new System.Drawing.Size(417, 56);
            this.lvResultado.TabIndex = 1;
            this.lvResultado.UseCompatibleStateImageBehavior = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlBotoes.Controls.Add(this.btnDividir);
            this.pnlBotoes.Controls.Add(this.btnC);
            this.pnlBotoes.Controls.Add(this.btnCE);
            this.pnlBotoes.Controls.Add(this.btnResultar);
            this.pnlBotoes.Controls.Add(this.btnSubtrair);
            this.pnlBotoes.Controls.Add(this.btnAdicionar);
            this.pnlBotoes.Controls.Add(this.btnMultiplicar);
            this.pnlBotoes.Controls.Add(this.btnPercentual);
            this.pnlBotoes.Controls.Add(this.btn8);
            this.pnlBotoes.Controls.Add(this.btn0);
            this.pnlBotoes.Controls.Add(this.btnVirgula);
            this.pnlBotoes.Controls.Add(this.btn1);
            this.pnlBotoes.Controls.Add(this.btn2);
            this.pnlBotoes.Controls.Add(this.btn3);
            this.pnlBotoes.Controls.Add(this.btn4);
            this.pnlBotoes.Controls.Add(this.btn5);
            this.pnlBotoes.Controls.Add(this.btn6);
            this.pnlBotoes.Controls.Add(this.btn7);
            this.pnlBotoes.Controls.Add(this.btn9);
            this.pnlBotoes.Controls.Add(this.btnInverter);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 79);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(443, 302);
            this.pnlBotoes.TabIndex = 21;
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDividir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(329, 15);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(100, 50);
            this.btnDividir.TabIndex = 39;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(223, 15);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(100, 50);
            this.btnC.TabIndex = 38;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(117, 15);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(100, 50);
            this.btnCE.TabIndex = 37;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnResultar
            // 
            this.btnResultar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResultar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultar.Location = new System.Drawing.Point(329, 239);
            this.btnResultar.Name = "btnResultar";
            this.btnResultar.Size = new System.Drawing.Size(100, 50);
            this.btnResultar.TabIndex = 36;
            this.btnResultar.Text = "=";
            this.btnResultar.UseVisualStyleBackColor = false;
            this.btnResultar.Click += new System.EventHandler(this.btnResultar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubtrair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(329, 127);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(100, 50);
            this.btnSubtrair.TabIndex = 35;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(329, 183);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 50);
            this.btnAdicionar.TabIndex = 34;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultiplicar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(329, 71);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(100, 50);
            this.btnMultiplicar.TabIndex = 33;
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnPercentual
            // 
            this.btnPercentual.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPercentual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentual.Location = new System.Drawing.Point(11, 15);
            this.btnPercentual.Name = "btnPercentual";
            this.btnPercentual.Size = new System.Drawing.Size(100, 50);
            this.btnPercentual.TabIndex = 32;
            this.btnPercentual.Text = "%";
            this.btnPercentual.UseVisualStyleBackColor = false;
            this.btnPercentual.Click += new System.EventHandler(this.btnPercentual_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(117, 71);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 50);
            this.btn8.TabIndex = 31;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(117, 239);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 50);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVirgula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(223, 239);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(100, 50);
            this.btnVirgula.TabIndex = 29;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(11, 183);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 50);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(117, 183);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 50);
            this.btn2.TabIndex = 27;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(223, 183);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 50);
            this.btn3.TabIndex = 26;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(11, 127);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 50);
            this.btn4.TabIndex = 25;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(117, 127);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 50);
            this.btn5.TabIndex = 24;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(223, 127);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 50);
            this.btn6.TabIndex = 23;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(11, 71);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 50);
            this.btn7.TabIndex = 22;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(223, 71);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 50);
            this.btn9.TabIndex = 21;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInverter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverter.Location = new System.Drawing.Point(11, 239);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(100, 50);
            this.btnInverter.TabIndex = 20;
            this.btnInverter.Text = "+/-";
            this.btnInverter.UseVisualStyleBackColor = false;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSinal.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSinal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSinal.Location = new System.Drawing.Point(18, 40);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSinal.Size = new System.Drawing.Size(19, 22);
            this.lblSinal.TabIndex = 4;
            this.lblSinal.Text = "-";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSinal.Visible = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 381);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 39);
            this.Name = "frmCalculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculadora_KeyDown);
            this.pnlVisor.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnResultar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnPercentual;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.ListView lvResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label lblSinal;
    }
}

