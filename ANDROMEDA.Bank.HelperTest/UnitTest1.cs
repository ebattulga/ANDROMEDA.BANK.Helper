using ANDROMEDA.BANK.Helper;

namespace ANDROMEDA.Bank.HelperTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KhanBankTest()
        {
            Assert.AreEqual(BankHelper.AccountNoToBank("5031103928"),BANK.Helper.BankCode.KhanBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("5180676734"), BANK.Helper.BankCode.KhanBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("5059314730"), BANK.Helper.BankCode.KhanBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("5107002900"), BANK.Helper.BankCode.KhanBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("5059064555"), BANK.Helper.BankCode.KhanBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("5058303152"), BANK.Helper.BankCode.KhanBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("5077384435"), BANK.Helper.BankCode.KhanBank);
        }


        [TestMethod]
        public void GolomtTest()
        {
            Assert.AreEqual(BankHelper.AccountNoToBank("3105152644"), BANK.Helper.BankCode.Golomt);
            Assert.AreEqual(BankHelper.AccountNoToBank("1909204280"), BANK.Helper.BankCode.Golomt);
        }

        [TestMethod]
        public void StateBankTest()
        {
            Assert.AreEqual(BankHelper.AccountNoToBank("104300034639"), BANK.Helper.BankCode.StateBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("106700013512"), BANK.Helper.BankCode.StateBank);
            Assert.AreEqual(BankHelper.AccountNoToBank("104300034639"), BANK.Helper.BankCode.StateBank);
        }

        [TestMethod]
        public void TDBTest()
        {
            Assert.AreEqual(BankHelper.AccountNoToBank("411004228"), BANK.Helper.BankCode.TDB);
            Assert.AreEqual(BankHelper.AccountNoToBank("499259176"), BANK.Helper.BankCode.TDB);
        }
    }
}