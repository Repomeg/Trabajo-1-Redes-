using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de Servicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio : System.Web.Services.WebService
    {

        [WebMethod]
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

			if (dv == digito)
				return true;
			else
				return false;
		}

		[WebMethod]
		public string[] MostrarNombre(string nombre)
		{
			if (string.IsNullOrEmpty(nombre))
			{
				string[] cadenaVacia = {"Ingrese un nombre"};
				return cadenaVacia;
			}
            else
            {
				nombre = nombre.Trim();
				string[] auxNombre = nombre.Split(' ');
				int i = 0;
				foreach (string nomb in auxNombre)
                {
					bool Valido = Regex.IsMatch(auxNombre[i], @"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+$");
					if (Valido == false)
					{
						string[] cadenaNoValida = {"Nombre no Valido"};
						return cadenaNoValida;
					}
					i++;
                }
				return auxNombre;
			}
		}
	}
}
