using ExtendedDialogBox.PublicDialogBox;
using System.Windows;

namespace ExtendedDialogBoxApp
{
    class ExtendedDialog
    {
        public void ShowQuery()
        {

            QuestionDialogBox dialogBox = new QuestionDialogBox("Вопрос");

            MessageBoxResult result = dialogBox.OkButton("Тест");

            if (result == MessageBoxResult.Yes)
                MessageBox.Show("Uieee");
        }

    }
}
