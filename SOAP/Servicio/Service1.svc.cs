using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool ComprobarRut(int rut, string digito)
        {
			int suma = 0;
			int multiplicador = 1;
			string dv = "X";
			digito = digito.ToUpper();
			while (rut != 0)
			{
				multiplicador++;
				if (multiplicador == 8)
					multiplicador = 2;
				suma += (rut % 10) * multiplicador;
				rut = rut / 10;
			}
			suma = 11 - (suma % 11);
			if (suma == 11)
			{
				dv = "0";
			}
			else if (suma == 10)
			{
				dv = "K";
			}
			else
			{
				dv = suma.ToString();
			}

			if(dv == digito)
				return true;
			else
				return false;
		}

        public string[] MostrarNombre(string nombre)
        {
			string[] auxNombre = nombre.Split(' ');
			return auxNombre;
        }
    }
}
