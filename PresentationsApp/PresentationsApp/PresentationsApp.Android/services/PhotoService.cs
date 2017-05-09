using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PresentationsApp.services;
using Xamarin.Forms;

namespace PresentationsApp.Droid.services
{
    public class PhotoService : IPhotoService
    {
        public byte[] TakePhoto()
        {

            return new byte[] {36};
        }
    }
}