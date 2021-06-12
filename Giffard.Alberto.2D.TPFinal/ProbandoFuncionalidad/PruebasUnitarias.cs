using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Biblioteca;
namespace ProbandoFuncionalidad
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void AgregarClienteABaseDeClientes()
        {
            //Arrange
            //Preparo lo necesario para poder ejectuar el metodo
            BaseDeCompradores base1 = new BaseDeCompradores("Base de prueba");
            Cliente c1 = new Cliente(1, "Anakin", false);
            Cliente aux = null;

            //Act
            //Ejectuo el metodo con el valor a probar
            base1 += c1;
            aux = BaseDeCompradores.TraerCliente(base1, 1);

            //Assert
            //evaluar los resultados
            Assert.IsNotNull(aux);
        }

        [TestMethod]
        [ExpectedException(typeof(ClienteExisteException))]
        public void ClienteExisteEnBasePorLoTantoArrojaLaExcepcion()
        {
            //Arrange
            BaseDeCompradores base1 = new BaseDeCompradores("Base de prueba");
            Cliente c1 = new Cliente(1, "Anakin", false);
            Cliente c2 = new Cliente(1, "Anakin", false);

            //Act
            base1 += c1;
            base1 += c2;
        }

        [TestMethod]
        public void AgregarProductoConStockACliente()
        {
            //Arrange
            Cliente c1 = new Cliente(1, "Anakin", false);
            Producto p1 = new Droide(Droide.TipoDroide.Astromecanico, 2, 600, 1999, true);

            //Act
            c1 += p1;

            //Assert
            Assert.AreNotEqual<int>(0, c1.ListadoProductos.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(SinStockException))]
        public void AgregarProductoSinStock()
        {
            //Arrange
            Cliente c1 = new Cliente(1, "Anakin", false);
            //producto sin stock
            Producto p1 = new Droide(Droide.TipoDroide.Astromecanico, 2, 0, 1999, true);

            //Act
            c1 += p1;
        }

        [TestMethod]
        public void EnsamblaElDroidePorqueElModeloEsMayorACero()
        {
            //Arrange
            Droide d1 = new Droide(5, 344, 9999, false);

            //Assert
            Assert.IsTrue(d1.Ensamblar(d1));
        }

        [TestMethod]
        public void NoDebeEnsamblarLaTunicaPorqueNoPermiteCortePersonalizado()
        {
            //Arrange
            Tunica t1 = new Tunica(Tunica.Corte.Personalizada, Tunica.Color.Oscura, 1, 199, true);

            //Assert
            Assert.IsFalse(t1.Ensamblar(t1));
        }

        [TestMethod]
        public void EnsamblaElSablePorqueLasHojasSonMenorACincoYMayorACero()
        {
            //Arrange
            Sable s1 = new Sable(Sable.Cristales.Azul, 2, 7, 799, false);

            //Assert
            Assert.IsTrue(s1.Ensamblar(s1));
        }
    }
}
