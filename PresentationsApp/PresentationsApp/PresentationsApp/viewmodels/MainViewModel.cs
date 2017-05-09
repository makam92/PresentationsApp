using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationsApp.services;
using Xamarin.Forms;

namespace PresentationsApp.viewmodels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IPhotoService _photoService;
        private string _userName;
        private string _password;

        public Command TakePhoto { get; set; }

        public MainViewModel(IPhotoService photoService)
        {
            _photoService = photoService;
            TakePhoto = new Command(async () =>
            {
                var photo = _photoService.TakePhoto();
                await App.Current.MainPage.DisplayAlert("", $"Photo: {photo[0]}", "proceed");
            });
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
}
