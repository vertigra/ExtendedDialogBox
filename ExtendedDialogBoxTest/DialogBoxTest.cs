using ExtendedDialogBox.PublicDialogBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtendedDialogBoxTest
{
    [TestClass]
    public class DialogBoxTest
    {
        [TestMethod, TestCategory("RunMannualy")]
        public static void TestOkButton()
        {
            new DialogBox("Test").OkButton();
        }

        [TestMethod, TestCategory("RunMannualy")]
        public static void TestOkButtonCustomContent()
        {
            new DialogBox("Test").OkButton("CustomText");
        }
    }
}
