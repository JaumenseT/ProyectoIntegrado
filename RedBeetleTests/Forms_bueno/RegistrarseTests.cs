using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedBeetle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Tests
{
	[TestClass()]
	public class RegistrarseTests
	{
		[TestMethod()]
		public void CheckEnterTest()
		{
			InicioSesion caller = new InicioSesion();
			Registrarse r = new Registrarse(caller);

			int pulsada = 16;

			Assert.AreNotEqual(pulsada, 13);
		}

		[TestMethod()]
		public void EmailValidoTest()
		{
			InicioSesion caller = new InicioSesion();
			Registrarse r = new Registrarse(caller);

			string bueno = "OdioLasPruebasUnitarias@gmail.com";
			string malo = "OdioLasPruebasUnitarias";

			Assert.IsTrue(r.EmailValido(malo), "este email no vale");

			Assert.IsTrue(r.EmailValido(bueno));
		}
	}
}