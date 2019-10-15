using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;
using System.Windows;

namespace ExtendedDialogBoxTest
{
    public class QuestionDialogBoxTest
    {
        [Test]
        public void TestYesNoCancelButtonWithCustomContent()
        {
            MessageBoxResult result = new QuestionDialogBox("Text message").YesNoCancelButton("CusutomYes", "CustomNo", "CustomCancel");
            Assert.IsInstanceOf<MessageBoxResult>(result);
        }
    }
}
