using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        double primerNumero = 0.0;
        double segundoNumero = 0.0;
        string operacion;
        public MainPage()
        {
            InitializeComponent();
        }
        void OnButton_one(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "1";
        }
        void OnButton_two(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "2";
        }
        void OnButton_tree(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "3";
        }
        void OnButton_four(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "4";
        }
        void OnButton_five(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "5";
        }
        void OnButton_six(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "6";
        }
        void OnButton_seven(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "7";
        }
        void OnButton_eigth(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "8";
        }
        void OnButton_nine(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "9";
        }
        void OnButton_zero(object sender, EventArgs e)
        {
            resul_.Text = resul_.Text + "0";
        }
        void OnButton_point(object sender, EventArgs e)
        {
            if (!resul_.Text.Contains("."))
            {
                resul_.Text = resul_.Text += ".";   
            }
            //punto.IsEnabled = false;
        }
        void OnButton_clean(object sender, EventArgs e)
        {
            punto.IsEnabled = true;
            if (resul_.Text != "")
            {
                resul_.Text = "";
            }
        }
        void OnButton_divs(object sender, EventArgs e)
        {
            if (operacion != "")
            {

            }
            try
            {
                operacion = "";
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resul_.Text);
                    operacion = "dividir";
                    resul_.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        void OnButton_mult(object sender, EventArgs e)
        {
            if (operacion != "")
            {

            }
            try
            {
                operacion = "";
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resul_.Text);
                    operacion = "multiplicar";
                    resul_.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        void OnButton_add(object sender, EventArgs e)
        {
            if (operacion != "")
            {

            }
            try
            {
                operacion = "";
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resul_.Text);
                    operacion = "suma";
                    resul_.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        void OnButton_resta(object sender, EventArgs e)
        {
            if (operacion != "")
            {
                resul_.Text = "-";
            }
            try
            {
                operacion = "";
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resul_.Text);
                    operacion = "resta";
                    resul_.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        void OnButton_porcentaje(object sender, EventArgs e)
        {
            if (operacion != "")
            {

            }
            try
            {
                operacion = "";
                if (primerNumero == 0)
                {
                    primerNumero = Convert.ToDouble(resul_.Text);
                    operacion = "porciento";
                    resul_.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }
        void OnButton_equal(object sender, EventArgs e)
        {
            if (operacion != "")
            {

            }
            try
            {
                segundoNumero = Convert.ToDouble(resul_.Text);
                switch (operacion)
                {
                    case "dividir":

                        resul_.Text = Convert.ToString(primerNumero / segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;

                        break;
                    case "multiplicar":
                        resul_.Text = Convert.ToString(primerNumero * segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    case "suma":
                        resul_.Text = Convert.ToString(primerNumero + segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    case "resta":
                        resul_.Text = Convert.ToString(primerNumero - segundoNumero);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    case "porciento":
                        resul_.Text = Convert.ToString(primerNumero * segundoNumero / 100);
                        segundoNumero = 0;
                        primerNumero = 0;
                        break;
                    default:
                        DisplayAlert("Sintaxis Error", "Opreacion no valida", "ok");
                        if (resul_.Text != "")
                        {
                            resul_.Text = "";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
