using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WpfLIb.Extensions
{
    public static class FindParentExtensions
    {
        public static T? FindParent<T>(this DependencyObject child) where T : DependencyObject
        {
            return FindParent<T>(child, null);
        }

        public static T? FindParent<T>(this DependencyObject child, string? parentName) where T : DependencyObject
        {
            while (true)
            {
                DependencyObject parentObject = VisualTreeHelper.GetParent(child);

                if (parentObject == null) return null;


                var frameworkElement = parentObject as FrameworkElement;
                if (frameworkElement == null) return null;

                if ((parentName == null || frameworkElement.Name == parentName) && frameworkElement is T)
                {
                    return frameworkElement as T;
                }
                else
                {
                    return FindParent<T>(parentObject, parentName);
                }
            }
        }

    }
}
