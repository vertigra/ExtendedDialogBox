using ExtendedDialogBox.Enum;
using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;
using System.Windows;

namespace ExtendedDialogBoxTest
{
    [TestFixture, RequiresSTA]
    public class DialogBoxTest
    {
        
        [Test, Explicit]
        public static void TestOkButton()
        {
            new DialogBox("Test").OkButton();
        }

        [Test, Explicit]
        public static void TestOkButtonCustomContent()
        {
            DialogBox dialog = new DialogBox("Test") { Focused = Focused.OkButton};
            MessageBoxResult result =  dialog.OkButton();

            Assert.AreEqual(MessageBoxResult.OK, result);
        }
    }
}
