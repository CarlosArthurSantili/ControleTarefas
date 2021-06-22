using BancoDeDados.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ControleTarefas.Testes
{
    [TestClass]
    public class TarefaTestes
    {
        [TestMethod]
        public void AoCriarTarefaDataConclusaoValorMaximo()
        {
            Tarefa teste = new Tarefa("", 1, Convert.ToDateTime("1/1/1"), 0);

            Assert.AreEqual(DateTime.MaxValue, teste.dataConclusao);
        }

        [TestMethod]
        public void ValidarPrioridade2()
        {
            Tarefa teste = new Tarefa("", 2, Convert.ToDateTime("1/1/1"), 0);

            Assert.AreEqual(true, teste.ValidarPrioridade());
        }

        [TestMethod]
        public void ValidarPrioridade5()
        {
            Tarefa teste = new Tarefa("", 5, Convert.ToDateTime("1/1/1"), 0);

            Assert.AreEqual(false, teste.ValidarPrioridade());
        }

        [TestMethod]
        public void ValidarPercentualConcluido110()
        {
            Tarefa teste = new Tarefa("", 1, Convert.ToDateTime("1/1/1"), 110);

            Assert.AreEqual(false, teste.ValidarPercentualConcluido());
        }

        [TestMethod]
        public void ValidarPercentualConcluido70()
        {
            Tarefa teste = new Tarefa("", 1, Convert.ToDateTime("1/1/1"), 70);

            Assert.AreEqual(true, teste.ValidarPercentualConcluido());
        }
    }
}
