using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeitorQRCode.LeitorQR
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
