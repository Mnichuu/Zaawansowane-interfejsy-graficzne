using System.ComponentModel;

namespace ZIG01.UnitTest
{
    [TestClass]
    public sealed class Zadanie01Test
    {
        [TestMethod]
        [DataRow(2, 3, 0)]
        [DataRow(3, 3, -1)]
        [DataRow(4, 3, -2)]
        public void potega_cLessOrEqualThenZero_ThrowsWarningException(int podst, int wykł, int flag)
        {
            Assert.ThrowsException<WarningException>(() => ZIG01.Zadanie01.potega(podst, wykł, flag));
        }

        [TestMethod]
        [DataRow(2, -3, 1)]
        [DataRow(3, -1, 1)]
        [DataRow(4, -3, 2)]
        public void potega_bLessThenZero_ThrowsWarningException(int podst, int wykł, int flag)
        {
            Assert.ThrowsException<WarningException>(() => ZIG01.Zadanie01.potega(podst, wykł, flag));
        }

        [TestMethod]
        [DataRow(2, 3, 1, 8)]
        [DataRow(3, 1, 1, 3)]
        [DataRow(4, 3, 2, 64)]
        public void potega_validInput_ReturnsValidOutput(int podst, int wykł, int flag, int result)
        {
            Assert.AreEqual(ZIG01.Zadanie01.potega(podst, wykł, flag), result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 2, new int[] { 2, 4, 6 })]
        [DataRow(new int[] { 4, 5, 6 }, 3, new int[] { 12, 15, 18 })]
        public void zapiszWTablicy_ValidInput_ReturnsValidOutput(int[] tab, int a, int[] expected)
        {
            var result = ZIG01.Zadanie01.zapiszWTablicy(tab, a);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 12.566370614359172)]
        [DataRow(3, 28.274333882308138)]
        public void poleKola_ValidInput_ReturnsValidOutput(double r, double expected)
        {
            var result = ZIG01.Zadanie01.poleKola(r);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        [DataRow(123, "liczba podzielna przez 3")]
        [DataRow(124, "liczba nie jest podzielna przez 3")]
        [DataRow(99, "Podana liczba nie jest trzycyfrowa")]
        public void sumaCyfr_ValidInput_ReturnsValidOutput(int liczba, string expected)
        {
            var result = ZIG01.Zadanie01.sumaCyfr(liczba);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 0, 2, 1, new int[] { 3, 2, 1 })]
        [DataRow(new int[] { 4, 5, 6 }, 1, 2, 1, new int[] { 4, 6, 5 })]
        public void zamienElementy_ValidInput_ReturnsValidOutput(int[] tab, int index1, int index2, int warunek, int[] expected)
        {
            var result = ZIG01.Zadanie01.zamienElementy(tab, index1, index2, warunek);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, -1, 2, 1)]
        [DataRow(new int[] { 4, 5, 6 }, 1, 3, 1)]
        public void zamienElementy_InvalidIndex_ThrowsWarningException(int[] tab, int index1, int index2, int warunek)
        {
            Assert.ThrowsException<WarningException>(() => ZIG01.Zadanie01.zamienElementy(tab, index1, index2, warunek));
        }
    }
}
