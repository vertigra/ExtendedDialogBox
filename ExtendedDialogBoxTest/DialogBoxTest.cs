using ExtendedDialogBox.PublicDialogBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtendedDialogBoxTest
{
    [TestClass]
    public class DialogBoxTest
    {
        
        [TestMethod]
        public static void TestOkButton()
        {
            new DialogBox("Test").OkButton();
        }
    }
}
