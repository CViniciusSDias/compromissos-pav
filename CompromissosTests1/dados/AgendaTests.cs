using Microsoft.VisualStudio.TestTools.UnitTesting;
using Compromissos.dados;
using System;
using System.Collections.Generic;

namespace Compromissos.dados.Tests
{
    [TestClass()]
    public class AgendaTests
    {
        private Agenda a;

        [TestInitialize()]
        public void Inicializa()
        {
            a = new Agenda();

            a.Inserir(new Compromisso("", "Descrição", DateTime.Now, "Consulta"));
            a.Inserir(new Compromisso("", "Descrição", DateTime.Now.AddDays(5), "Teste"));
            a.Inserir(new Compromisso("", "Descrição", DateTime.Now.AddDays(3), "Outro"));
            a.Inserir(new Compromisso("", "Descrição", DateTime.Now, "Consulta"));
        }

        [TestMethod()]
        public void Listacompromissos()
        {
            Assert.AreEqual(4, a.ListarTodos().Count);
        }

        [TestMethod()]
        public void RemoverTest()
        {
            Assert.IsTrue(a.Remover(3));
            Assert.AreEqual(3, a.ListarTodos().Count);
        }

        [TestMethod()]
        public void CompromissosDeHoje()
        {
            Assert.AreEqual(2, a.ListarHoje().Count);
        }

        [TestMethod()]
        public void FiltroPorAssunto()
        {
            Assert.AreEqual(2, a.ListarPorAssunto("Consulta").Count);
        }

        [TestMethod()]
        public void FiltroPorPeriodo()
        {
            Assert.AreEqual(
                2,
                a.ListarPorPeriodo(
                    DateTime.Today.AddDays(2),
                    DateTime.Today.AddDays(6)
                ).Count
            );
        }
        
        [TestMethod()]
        public void ListarProximosCompromissos()
        {
            Assert.AreEqual(3, a.ListarProximos(3).Count);
        }
    }
}