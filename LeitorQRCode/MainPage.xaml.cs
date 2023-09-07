using LeitorQRCode.LeitorQR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing.Common;
using ZXing;
using ZXing.QrCode;
using System.Runtime;

namespace LeitorQRCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnCamera_OnClicked(object sender, EventArgs e)
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();
            if (!string.IsNullOrEmpty(result))
            {
                if (Uri.IsWellFormedUriString(result, UriKind.Absolute))
                {
                    await Launcher.OpenAsync(new Uri(result));
                }
                else
                {
                    await DisplayAlert("Código Lido", $"Código lido: {result}", "OK");
                }
            }

        }


    }
}
