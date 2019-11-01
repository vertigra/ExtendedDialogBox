using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

namespace ExtendedDialogBoxTest
{
    [TestFixture, RequiresSTA]
    class WarningDialogBoxTest
    {
        [Test, Explicit]
        public void SimpleWarningDialogBox()
        {
            new WarningDialogBox("Test warning dialog box").OkButton();
        }
    }
}
