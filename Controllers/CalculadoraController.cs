﻿using Calculadora_MVC.Data;
using Calculadora_MVC.Logica;

namespace Calculadora_MVC.Controllers
{
    public class CalculadoraController
    {
        private readonly GUI _gui;
        private readonly CalculadoraLogica _logica;
        private readonly BitacoraManager _bitacora;
        private string _operador;
        private double _primerNumero;

        public CalculadoraController(GUI gui)
        {
            _gui = gui;
            _logica = new CalculadoraLogica();
            _bitacora = new BitacoraManager();
            _operador = string.Empty;
            _primerNumero = 0;
        }

        public void CalcularResultado()
        {
            if (double.TryParse(_gui.Resultado, out double segundoNumero))
            {
                double resultado = _logica.Calcular(_primerNumero, segundoNumero, _operador);
                string operacion = $"{_primerNumero} {_operador} {segundoNumero} = {resultado}";

                // Guardar la operación en la bitácora
                _bitacora.GuardarOperacion(operacion);

                _gui.ActualizarResultado(resultado.ToString());
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void MostrarBitacora()
        {
            string contenido = _bitacora.LeerBitacora();
            _gui.MostrarBitacora(contenido);
        }
    
        public void AgregarNumero(string numero)
        {
            if (_gui.Resultado == "0")
            {
                _gui.Resultado = numero;
            }
            else
            {
                _gui.Resultado += numero;
            }
        }

        public void RealizarOperacion(string operador)
        {
            if (double.TryParse(_gui.Resultado, out _primerNumero))
            {
                _operador = operador;
                _gui.Resultado = string.Empty;
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }


        public void Limpiar()
        {
            _bitacora.LimpiarBitacora();
            _gui.ActualizarResultado("0");
            _primerNumero = 0;
            _operador = string.Empty;
        }

        public void CalcularPrimo()
        {
            if (int.TryParse(_gui.Resultado, out int numero))
            {
                bool esPrimo = _logica.EsPrimo(numero);
                string resultado = esPrimo ? "Primo" : "No Primo";
                _gui.ActualizarResultado(resultado);

                _bitacora.GuardarOperacion($"{numero} es {resultado}");
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void ConvertirABinario()
        {
            if (int.TryParse(_gui.Resultado, out int numero))
            {
                string binario = _logica.ConvertirABinario(numero);
                _gui.ActualizarResultado(binario);

                _bitacora.GuardarOperacion($"{numero} en binario es {binario}");
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }


        public void GuardarEnMemoria()
        {
            if (double.TryParse(_gui.Resultado, out double numero))
            {
                _logica.GuardarEnMemoria(numero);
                _gui.ActualizarResultado("Memorizado");

                // Registrar en la bitácora
                _bitacora.GuardarOperacion($"Guardado en memoria: {numero}");
            }
            else
            {
                _gui.ActualizarResultado("Error");
            }
        }

        public void RecuperarDeMemoria()
        {
            double numero = _logica.RecuperarDeMemoria();
            _gui.ActualizarResultado(numero.ToString());

            // Registrar en la bitácora
            _bitacora.GuardarOperacion($"Recuperado de memoria: {numero}");
        }


        public void CalcularPromedio()
        {
            // Ejemplo: Calcula el promedio de valores en una lista o array
            double[] numeros = { 10, 20, 30 }; // Ejemplo fijo
            double promedio = _logica.CalcularPromedio(numeros);
            _gui.ActualizarResultado(promedio.ToString());
        }
    }
}