using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App619
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        LoginViewModel myViewModel;
        public MainPage()
        {
            InitializeComponent();

            myViewModel = new LoginViewModel();
            this.BindingContext = myViewModel;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            myViewModel.ActIndVal = true;
            await myViewModel.VerifyClientID("clientID");
            myViewModel.ActIndVal = false;
        }
    }

    public class LoginViewModel : INotifyPropertyChanged
    {
        // For data binding of activity indicator
        bool actIndVal = false;
        public bool ActIndVal
        {
            get => actIndVal;
            set
            {
                if (actIndVal == value)
                {
                    return;
                }
                else
                {
                    actIndVal = value;
                    OnPropertyChanged(nameof(ActIndVal));
                }
            }
        }

        public LoginViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string value)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
        }
        public async Task VerifyClientID(string clientID)
        {
            // Start of HTTP Requests
            await Task.Delay(3000);
        }
    }

}