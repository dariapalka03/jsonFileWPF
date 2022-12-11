using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JSONSave
{
    internal class CustomCommands
    {
        public static readonly RoutedUICommand Save = new RoutedUICommand(
            "Save",
            "Save",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.F2)
            }
            );

        public static readonly RoutedUICommand Add = new RoutedUICommand(
            "Add",
            "Add",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture (Key.F1)
            }
            );
    }
}
