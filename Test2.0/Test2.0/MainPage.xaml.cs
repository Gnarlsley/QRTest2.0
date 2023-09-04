using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test2._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            ScannerView.IsScanning = false;
            Device.BeginInvokeOnMainThread(() =>
            {
                scanResults_txt.Text = result.Text + " (type: " + result.BarcodeFormat + ")";
            });

        }

        private void Scan_button_Pressed(object sender, EventArgs e)
        {
            ScannerView.IsScanning = true;
        }
    }
}
