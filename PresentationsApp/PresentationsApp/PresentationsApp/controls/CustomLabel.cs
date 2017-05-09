using Xamarin.Forms;

namespace PresentationsApp.controls
{
    public class CustomLabel : Label
    {
        public static readonly BindableProperty BorderRadiusProperty =
            BindableProperty.Create("BorderRadius", typeof(int), typeof(CustomLabel), 0);

        public int BorderRadius
        {
            get { return (int)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }
    }
}
