using ExtendedDialogBox.PublicDialogBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;

namespace ExtendedDialogBoxTest
{
    [TestClass]
    public class QuestionDialogBoxTest
    {
        [TestMethod]
        public void TestYesNoCancelButtonWithCustomContent()
        {
            var result = new QuestionDialogBox("Text message").YesNoCancelButton("CusutomYes", "CustomNo", "CustomCancel");
            Assert.IsInstanceOfType(result, typeof(MessageBoxResult));
        }
    }
}
