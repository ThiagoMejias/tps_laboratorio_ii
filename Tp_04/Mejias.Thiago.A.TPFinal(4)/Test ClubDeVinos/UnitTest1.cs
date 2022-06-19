using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Exceptions;
namespace Test_ClubDeVinos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(EstaOnoEnlalista))]
        public void Test_Add()
        {
            Cliente c1 = new Cliente(new System.DateTime(), "Juan", 44816634, "adasd 22", 555);
            Cliente c2 = new Cliente(new System.DateTime(), "Thiago", 44816634, "aaa 11", 0);
            Listado<Cliente> clientes = new Listado<Cliente>();
            clientes.add(c1);
            clientes.add(c2);
        }
        [TestMethod]
        [ExpectedException(typeof(NoExisteException))]
        public void Test_Buscar_Cliente()
        {
            Vinoteca vinoteca = new Vinoteca("Prueba");
            vinoteca.buscarCliente(46465);
        }

    }
}
