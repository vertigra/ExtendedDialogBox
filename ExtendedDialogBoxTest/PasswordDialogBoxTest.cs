using System.Windows;
using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

namespace ExtendedDialogBoxTest
{
    [TestFixture, RequiresSTA]
    public class PasswordDialogBoxTest
    {
        [Test, Explicit]
        public void SimplePasswordDialogBox()
        {
            string password = null;

            PasswordDialogBox dialogBox = new PasswordDialogBox("Enter 123456 in password box");
            MessageBoxResult result = dialogBox.OkButton();

            if (result == MessageBoxResult.OK)
                password = dialogBox.Password;

            Assert.AreEqual("123456", password);
            Assert.AreEqual(MessageBoxResult.OK, result);
            Assert.AreEqual("Password", dialogBox.PasswordLabel);
        }
    }
}
