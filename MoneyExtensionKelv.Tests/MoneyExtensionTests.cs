namespace MoneyExtensionKelv.Tests;

[TestClass]
public class MoneyExtensionKelvTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;

        var cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}