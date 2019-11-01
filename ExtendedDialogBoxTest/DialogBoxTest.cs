using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

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
            new DialogBox("Test simple dialog box").OkButton();
        }
    }
}
