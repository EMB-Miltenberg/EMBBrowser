using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMBBrowser
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            string _UriAPPValueLink = ((App)Application.Current)._UriValueLink;
            string _MainWindowWidth = ((App)Application.Current)._MainWindowWidth;
            string _MainWindowHeight = ((App)Application.Current)._MainWindowHeight;
            string _MainWindowLeft = ((App)Application.Current)._MainWindowLeft;
            string _MainWindowTop = ((App)Application.Current)._MainWindowTop;




            if (!string.IsNullOrEmpty(_UriAPPValueLink))
            {
                _MainWindowWebView.Source = new Uri(_UriAPPValueLink);
            }

            if (!string.IsNullOrEmpty(_MainWindowWidth))
            {
                this.Width = Convert.ToInt16(_MainWindowWidth);
            }

            if (!string.IsNullOrEmpty(_MainWindowHeight))
            {
                this.Height= Convert.ToInt16(_MainWindowHeight);
            }

            if (!string.IsNullOrEmpty(_MainWindowTop))
            {
                this.Top = Convert.ToInt16(_MainWindowTop);
            }

            if (!string.IsNullOrEmpty(_MainWindowLeft))
            {
                this.Left = Convert.ToInt16(_MainWindowLeft);
            }








        }

        private void SetupMainWindow()
        {
            //Create File on Local Storage 
        }

        private void LoadingMainWindow()
        {

        }


    }
}
