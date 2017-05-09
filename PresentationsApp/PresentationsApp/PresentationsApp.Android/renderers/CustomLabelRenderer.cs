using Android.Views;
using PresentationsApp.controls;
using PresentationsApp.Droid.renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly:ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace PresentationsApp.Droid.renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                var customLabel = (CustomLabel) e.NewElement;
                Control.SetBackgroundColor(Color.Bisque);
                Control.Gravity = GravityFlags.CenterHorizontal;
                
            }
        }
    }
}