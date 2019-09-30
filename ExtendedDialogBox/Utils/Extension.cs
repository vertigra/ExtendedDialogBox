using System.Drawing;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ExtendedDialogBox.Utils
{
    internal static class Extension
    {
        internal static ImageSource ToImageSource(this Icon icon)
        {
            if (icon == null) return null;

            ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
                icon.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return imageSource;
        }

        internal static Icon ToIcon(this MessageBoxImage boxImage)
        {
            Icon icon;

            switch (boxImage)
            {
                case MessageBoxImage.Exclamation | MessageBoxImage.Warning:
                    icon = SystemIcons.Warning;
                    break;
                case MessageBoxImage.Error | MessageBoxImage.Stop | MessageBoxImage.Hand:
                    icon = SystemIcons.Hand;
                    break;
                case MessageBoxImage.Information | MessageBoxImage.Asterisk:
                    icon = SystemIcons.Information;
                    break;
                case MessageBoxImage.Question:
                    icon = SystemIcons.Question;
                    break;
                case MessageBoxImage.None:
                    icon = null;
                    break;
                default:
                    icon = null;
                    break;
            }

            return icon;
        }
    } 
}
