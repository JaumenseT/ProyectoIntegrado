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
	public class InicioSesionTests
	{
		[TestMethod()]
		public void ValidarInicioSesionTest()
		{
			InicioSesion i = new InicioSesion();

			string nomUsu2 = "@";
			string pass2 = "f$";
			Assert.IsTrue(InicioSesion.ValidarInicioSesion(nomUsu2, pass2));
		}
	}
}