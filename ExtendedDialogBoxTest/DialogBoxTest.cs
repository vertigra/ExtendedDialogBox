using ExtendedDialogBox.PublicDialogBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtendedDialogBoxTest
{
    [TestClass]
    public class DialogBoxTest
    {
        [TestMethod]
        public void TestOkButton()
        {
            new DialogBox("TestMessage", "TestTitle").OkButton();
        }
    }
}
