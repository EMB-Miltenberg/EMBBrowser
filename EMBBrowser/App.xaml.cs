using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EMBBrowser
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public string _UriValueLink { get; set; }
        public string _MainWindowWidth { get; set; }
        public string _MainWindowHeight { get; set; }
        public string _MainWindowTop { get; set; }
        public string _MainWindowLeft { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            for (int i = 0; i < e.Args.Length; i++)
            {
                if (e.Args[i].StartsWith("-Uri="))
                {
                    _UriValueLink = e.Args[i].Substring("-Uri=".Length);
                    break;
                }
            }

            for (int i = 0; i < e.Args.Length; i++)
            {
                if (e.Args[i].StartsWith("-WindowWidth="))
                {
                    _MainWindowWidth = e.Args[i].Substring("-WindowWidth=".Length);
                    break;
                }
            }

            for (int i = 0; i < e.Args.Length; i++)
            {
                if (e.Args[i].StartsWith("-MainWindowHeight="))
                {
                    _MainWindowHeight = e.Args[i].Substring("-WindowHeight=".Length);
                    break;
                }
            }

            for (int i = 0; i < e.Args.Length; i++)
            {
                if (e.Args[i].StartsWith("-Top="))
                {
                    _MainWindowTop = e.Args[i].Substring("-Top=".Length);
                    break;
                }
            }
            
            for (int i = 0; i < e.Args.Length; i++)
            {
                if (e.Args[i].StartsWith("-Left="))
                {
                    _MainWindowLeft = e.Args[i].Substring("-Left=".Length);
                    break;
                }
            }


        }
    }
}
