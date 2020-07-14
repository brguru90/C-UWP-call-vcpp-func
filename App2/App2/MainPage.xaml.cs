using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Reflection;
using Windows.Storage;
using System.Runtime.InteropServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        //Add existing item ->choose built dll

        [DllImport(@"Assets\libs\Dll1.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int test(int a,int b);

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

           
            int a = Int32.Parse(num1.Text);
            int b = Int32.Parse(num2.Text);

       

            System.Diagnostics.Debug.WriteLine("add="+ test(a, b));

            var dialog = new MessageDialog(test(a, b) + "");
            await dialog.ShowAsync();

        }
    }
}
