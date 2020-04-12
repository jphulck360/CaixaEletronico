using System;
using CaixaEletronico;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaixaEletronicoTeste
{
    [TestClass]
    public class CaixaEletronicoTeste
    {
        // Exemplo: Nota de -5: Cédula indisponível
        [TestMethod]
        public void TesteValorInvalido()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(-5);
            Console.WriteLine(notas);
            Assert.AreEqual("Valor inválido! Insira um valor maior que 0", notas);
        }

        // Exemplo: Nota de 5: Cédula indisponível
        [TestMethod]
        public void TesteCedulaIndisponivel()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(5);
            Console.WriteLine(notas);
            Assert.AreEqual("Cédula indisponível", notas);
        }

        // Exemplo: Nota de 100: 1 (quantidade)
        [TestMethod]
        public void TesteNotaCem()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(100);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 100: 1", notas);
        }

        // Exemplo: Nota de 50: 1 (quantidade)
        [TestMethod]
        public void TesteNotaCinquenta()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(50);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 50: 1", notas);
        }

        // Exemplo: Nota de 20: 1 (quantidade)
        [TestMethod]
        public void TesteNotaVinte()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(20);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 20: 1", notas);
        }

        // Exemplo: Nota de 10: 1 (quantidade)
        [TestMethod]
        public void TesteNotaDez()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(10);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 10: 1", notas);
        }

        // Exemplo: Nota de 100: 1, Nota de 50: 1
        [TestMethod]
        public void TestaNotas1()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(150);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 100: 1" + "Quantidade notas de R$ 50: 1", notas);
        }

        // Exemplo: Nota de 100: 1, Nota de 50: 1, Nota de 20: 1
        [TestMethod]
        public void TestaNotas2()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(170);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 100: 1" + "Quantidade notas de R$ 50: 1" + "Quantidade notas de R$ 20: 1", notas);
        }

        // Exemplo: Nota de 100: 1, Nota de 50: 1, Nota de 20: 1, Nota de 10: 1
        [TestMethod]
        public void TestaNotas3()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(180);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 100: 1" + "Quantidade notas de R$ 50: 1" + "Quantidade notas de R$ 20: 1" + "Quantidade notas de R$ 10: 1", notas);
        }

        [TestMethod]
        public void TestaNotas4()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(280);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 100: 2" + "Quantidade notas de R$ 50: 1" + "Quantidade notas de R$ 20: 1" + "Quantidade notas de R$ 10: 1", notas);
        }

        [TestMethod]
        public void TestaNotas5()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(60);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 50: 1" + "Quantidade notas de R$ 10: 1", notas);
        }

        [TestMethod]
        public void TestaNotas6()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(110);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 100: 1" + "Quantidade notas de R$ 10: 1", notas);
        }

        [TestMethod]
        public void TestaNotas7()
        {
            Caixa cx = new Caixa();

            string notas = cx.RealizarSaque(70);
            Console.WriteLine(notas);
            Assert.AreEqual("Quantidade notas de R$ 50: 1" + "Quantidade notas de R$ 20: 1", notas);
        }
    }
}