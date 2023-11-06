using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        decimal valor1 = 0, valor2 = 0; 
        int operacao = 0;

        public frmCalculadora()
        {
            InitializeComponent();
            this.RightToLeftLayout = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            InsereTexto("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InsereTexto("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InsereTexto("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           InsereTexto("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InsereTexto("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InsereTexto("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InsereTexto("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InsereTexto("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InsereTexto("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InsereTexto("9");
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblResultado.Text.Contains(","))
            {
                InsereTexto(",");
            }
            ActiveControl = null;
        }

        private void LimpaCampo(int opcao)
        {
            switch (opcao)
            {
                case 0:
                    lblResultado.Text = "";
                    break;
                case 1:
                    lblOperacao.Text = "";
                    break;
            }
        }

        private void ZerarCampo(int opcao)
        {
            switch (opcao)
            {
                case 0:
                    lblResultado.Text = "0";
                    break;
                case 1:
                    valor1 = 0;
                    break;
                case 2:
                    valor2 = 0;
                    break;
                case 3:
                    operacao = 0;
                    break;
            }
        }

        private void InsereTexto(String Value)
        {
            if (lblResultado.Text == "0")
            {
                    LimpaCampo(0);
            }

            lblResultado.Text += Value; 
            if (lblResultado.Text.Length > 15)
            {
                lblResultado.Text = lblResultado.Text.Substring(0, 15); 
            }
            ActiveControl = null;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TratarErro(false);
        }
        private void LimparCampos()
        {
            ZerarCampo(0);
            ZerarCampo(1);
            ZerarCampo(2);
            ZerarCampo(3);
            LimpaCampo(1);
            ActiveControl = null;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            RealizaOperacao(sender, e, 1);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            RealizaOperacao(sender, e, 2);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            RealizaOperacao(sender, e, 3);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            RealizaOperacao(sender, e, 4);
        }

        private void btnResultar_Click(object sender, EventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = ConverteResultado();
            }
            else
            {
                valor2 = ConverteResultado();
            }

            MostraOperacao();
            CalcularOperacao();

            if (lblSinal.Visible)
            {
                btnInverter_Click(sender, e);
            }

            ActiveControl = null;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length > 0)
            {
                lblResultado.Text = lblResultado.Text.Substring(0, lblResultado.Text.Length - 1);
                if (lblResultado.Text.Length == 0)
                {
                    btn0_Click(sender, e);
                }
            }
            ActiveControl = null;
        }

        private void RealizaOperacao(object sender, EventArgs e, int operador)
        {
            if (valor1 != 0)
            {
                btnResultar_Click(sender, e);
            }
            valor1 = ConverteResultado();

            if (lblSinal.Visible)
            {
                btnInverter_Click(sender, e);
            }

            ZerarCampo(2);
            operacao = operador;
            MostraOperacao();
            ZerarCampo(0);
            ActiveControl = null;
        }

        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (btn0.Enabled)
            {
                switch (e.KeyCode)
                {
                    /* Numericos */
                    case Keys.NumPad0:
                    case Keys.D0:
                        btn0_Click(sender, e);
                        break;
                    case Keys.NumPad1:
                    case Keys.D1:
                        btn1_Click(sender, e);
                        break;
                    case Keys.NumPad2:
                    case Keys.D2:
                        btn2_Click(sender, e);
                        break;
                    case Keys.NumPad3:
                    case Keys.D3:
                        btn3_Click(sender, e);
                        break;
                    case Keys.NumPad4:
                    case Keys.D4:
                        btn4_Click(sender, e);
                        break;
                    case Keys.NumPad5:
                    case Keys.D5:
                        btn5_Click(sender, e);
                        break;
                    case Keys.NumPad6:
                    case Keys.D6:
                        btn6_Click(sender, e);
                        break;
                    case Keys.NumPad7:
                    case Keys.D7:
                        btn7_Click(sender, e);
                        break;
                    case Keys.NumPad8:
                    case Keys.D8:
                        btn8_Click(sender, e);
                        break;
                    case Keys.NumPad9:
                    case Keys.D9:
                        btn9_Click(sender, e);
                        break;

                    /* Operadores */
                    case Keys.Add:
                        btnAdicionar_Click(sender, e);
                        break;
                    case Keys.Subtract:
                        btnSubtrair_Click(sender, e);
                        break;
                    case Keys.Multiply:
                        btnMultiplicar_Click(sender, e);
                        break;
                    case Keys.Divide:
                        btnDividir_Click(sender, e);
                        break;
                    case Keys.Enter:
                        btnResultar_Click(sender, e);
                        break;

                    /* Atalhos */
                    case Keys.Escape:
                        btnC_Click(sender, e);
                        break;
                    case Keys.Back:
                        btnCE_Click(sender, e);
                        break;
                    case Keys.Oemcomma:
                    case Keys.Decimal:
                        btnVirgula_Click(sender, e);
                        break;
                }
            }
        }

        private void btnPercentual_Click(object sender, EventArgs e)
        {
            valor1 = ConverteResultado();
            ZerarCampo(2);

            Decimal resultado = ConverteResultado();
            resultado /= 100;

            if (resultado.ToString().Length > 15)
            {
                lblResultado.Text = "Limite Excedido";
                TratarErro(true);
            }
            lblResultado.Text = resultado.ToString();

            ActiveControl = null;
        }

        private void CalcularOperacao()
        {
            Decimal resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Divisão por zero não permitida");
                        return;
                    }
                    resultado = valor1 / valor2;
                    break;
                default:
                    resultado = ConverteResultado();
                    break;
            }

            ZerarCampo(1);
            lblResultado.Text = resultado.ToString();
            if (lblResultado.Text.Length > 15)
            {
                lblResultado.Text = "Limite Excedido";
                TratarErro(true);
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            lblSinal.Visible = !lblSinal.Visible;
            ActiveControl = null;
        }

        private Decimal ConverteResultado()
        {
            Decimal resultado = 0;
            if (lblSinal.Visible)
            {
                resultado = Decimal.Parse(lblResultado.Text) * -1;

            }
            else
            {
                resultado = Decimal.Parse(lblResultado.Text);
            }

            return resultado;
        }
        private void TratarErro(bool erro)
        {
            btn0.Enabled            = !erro;
            btn1.Enabled            = !erro;
            btn2.Enabled            = !erro;
            btn3.Enabled            = !erro;
            btn4.Enabled            = !erro;
            btn5.Enabled            = !erro;
            btn6.Enabled            = !erro;
            btn7.Enabled            = !erro;
            btn8.Enabled            = !erro;
            btn9.Enabled            = !erro;
            btnAdicionar.Enabled    = !erro;
            btnSubtrair.Enabled     = !erro;
            btnMultiplicar.Enabled  = !erro;
            btnDividir.Enabled      = !erro;
            btnResultar.Enabled     = !erro;
            btnVirgula.Enabled      = !erro;
            btnInverter.Enabled     = !erro;
            btnCE.Enabled           = !erro;
            btnPercentual.Enabled   = !erro;
        }

        private String RetornaOperador()
        {   
            switch (operacao)
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "x";
                case 4: return "/";
                default: return "";
            }
        }

        private void MostraOperacao()
        {
            lblOperacao.Text = valor1.ToString() + " " + RetornaOperador() + " " + valor2.ToString();
        }
    }
}
