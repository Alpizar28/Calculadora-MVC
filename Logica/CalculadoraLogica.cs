using Calculadora_MVC.Controllers;

namespace Calculadora_MVC.Logica
{
    public class CalculadoraLogica
    {
        public double Calcular(double primerNumero, double segundoNumero, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    resultado = primerNumero / segundoNumero;
                    break;
            }

            return resultado;
        }

        public bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public string ConvertirABinario(int numero)
        {
            string binario = string.Empty;

            while (numero > 0)
            {
                binario = (numero % 2) + binario;
                numero /= 2;
            }

            return binario;
        }

        public double CalcularPromedio(double[] numeros)
        {
            double suma = 0;

            foreach (double numero in numeros)
            {
                suma += numero;
            }

            return suma / numeros.Length;
        }

        // Método para guardar un número en memoria
        public void GuardarEnMemoria(double numero)
        {
        }

        // Método para recuperar un número de memoria
        public double RecuperarDeMemoria()
        {
            return 0;
        }
    }
}

