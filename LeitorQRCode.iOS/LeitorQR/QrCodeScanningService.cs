using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(LeitorQRCode.iOS.LeitorQR.QrCodeScanningService))]
namespace LeitorQRCode.iOS.LeitorQR
{
    public class QrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barra",
                BottomText = "Toque na tela para focar a camera"
            };
            var scanResults = await scanner.Scan();
            //Fix by Ale
            return (scanResults != null) ? scanResults.Text : string.Empty;

        }
    }
}