﻿using ExtendedDialogBox.PublicDialogBox;
using NUnit.Framework;

namespace ExtendedDialogBoxTest
{
    [TestFixture, RequiresSTA]
    public class QuestionDialogBoxTest
    {
        [Test, Explicit]
        public void SimpleQuestionDialogBox()
        {
            new QuestionDialogBox("Test question dialog box").OkButton(); 
        }
    }
}
