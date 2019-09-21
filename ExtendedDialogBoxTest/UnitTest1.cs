using System;
using System.Windows;
using ExtendedDialogBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtendedDialogBoxTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DialogBox dialogBox = new DialogBox();

            dialogBox.CancelButtonVisiblity = Visibility.Visible;
        }

    }
}
