using System.Windows;
using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

namespace ExtendedDialogBoxTest
{
    [TestFixture]
    public class PasswordDialogBoxTest
    {
        [Test, Explicit]
        public void TestEnterPassword()
        {
            PasswordDialogBox dialogBox = new PasswordDialogBox("Enter 123456 in password box");
            MessageBoxResult result = dialogBox.OkButton();


            Assert.AreEqual("123456", dialogBox.Password);
            Assert.AreEqual(MessageBoxResult.OK, result);
            Assert.AreEqual("Password", dialogBox.PasswordLabel);
        }
    }
}
