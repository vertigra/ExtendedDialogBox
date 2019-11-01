
using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

namespace ExtendedDialogBoxTest
{
    [TestFixture, RequiresSTA]
    class ErrorDialogBoxTest
    {
        [Test, Explicit]
        public void SimpleErrorDialogBox()
        {
            new ErrorDialogBox("Test error dialog box").OkButton();
        }

    }
}
