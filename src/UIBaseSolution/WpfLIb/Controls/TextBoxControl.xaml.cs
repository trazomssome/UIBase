using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLIb.Controls
{
    /// <summary>
    /// TextBoxControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TextBoxControl : UserControl
    {
        public TextBoxControl()
        {
            InitializeComponent();
        }

        #region Public Properties
        public new Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        public new Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }


        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }


        public Brush PlaceholderColor
        {
            get { return (Brush)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        #endregion

        #region Public statics
        // Using a DependencyProperty as the backing store for BorderBrush.  This enables animation, styling, binding, etc...
        public static new readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(TextBoxControl), new UIPropertyMetadata(Brushes.SkyBlue));

        // Using a DependencyProperty as the backing store for BorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(TextBoxControl), new UIPropertyMetadata(new Thickness(1)));

        // Using a DependencyProperty as the backing store for Placeholder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register("Placeholder", typeof(string), typeof(TextBoxControl), new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for PlaceholderColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderColorProperty =
            DependencyProperty.Register("PlaceholderColor", typeof(Brush), typeof(TextBoxControl), new UIPropertyMetadata(Brushes.Gray));

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextBoxControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        #endregion
    }
}
