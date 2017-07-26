using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Demo.UWP.CustomControls.Library
{
    public sealed class MyCustomControl : Control
    {
        public static readonly DependencyProperty FirstNameProperty = DependencyProperty.Register("FirstName", typeof(string), typeof(MyCustomControl), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty LastNameProperty = DependencyProperty.Register("LastName", typeof(string), typeof(MyCustomControl), new PropertyMetadata(string.Empty));

        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        public MyCustomControl()
        {
            this.DefaultStyleKey = typeof(MyCustomControl);
        }
    }
}
