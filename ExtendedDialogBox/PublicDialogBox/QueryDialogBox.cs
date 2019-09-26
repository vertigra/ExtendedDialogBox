﻿using ExtendedDialogBox.Command;
using System.Windows;

namespace ExtendedDialogBox.PublicDialogBox
{
    public class QueryDialogBox
    {
        private readonly DialogBox mDialogBox;

        public QueryDialogBox()
        {
            mDialogBox = new DialogBox();
        }
        public MessageBoxResult YesNoButton()
        {
            mDialogBox.OkButtonVisiblity = Visibility.Visible;
            mDialogBox.CancelButtonVisiblity = Visibility.Visible;
            mDialogBox.YesButtonVisiblity = Visibility.Visible;
            mDialogBox.NoButtonVisiblity = Visibility.Visible;
            
            //set as base parametr
            mDialogBox.MessageImage = MessageBoxImage.Warning;

            mDialogBox.Message = "Warning";
            mDialogBox.Title = "Warning!";

            mDialogBox.ShowDialog();

            return Result;
        }

        private RelayCommand buttonCommand;
        public RelayCommand ButtonCommands
        {
            get
            {
                return buttonCommand ??
                       (buttonCommand = new RelayCommand(obj =>
                       {
                           string result = (string) obj;

                           switch (result)
                           {
                               case "Cancel":
                                   Result = MessageBoxResult.Cancel;
                                   break;
                               case "No":
                                   Result = MessageBoxResult.No;
                                   break;
                               case "Yes":
                                   Result = MessageBoxResult.Yes;
                                   break;
                               case "Ok":
                                   Result = MessageBoxResult.OK;
                                   break;
                               default:
                                   Result = MessageBoxResult.None;
                                   break;
                           }

                           mDialogBox.Close();
                       }));
            }
        }

        private MessageBoxResult Result { get; set; }
    }
}
