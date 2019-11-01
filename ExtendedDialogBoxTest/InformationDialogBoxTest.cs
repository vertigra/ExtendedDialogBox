using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

namespace ExtendedDialogBoxTest
{
    [TestFixture, RequiresSTA]
    public class InformationDialogBoxTest
    {
        [Test, Explicit]
        public void SimpleInformationDialogBox()
        {
            new InformationDialogBox("Test information dialog box").OkButton();
        }

    }
}
