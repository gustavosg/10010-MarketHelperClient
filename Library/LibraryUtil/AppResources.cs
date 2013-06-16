using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Core.Library.LibraryUtil
{
    public class AppResources
    {

        public AppResources()
        {


        }

        private static AppResources libraryStrings = new AppResources();

        public AppResources StringResources
        {
            get { return libraryStrings; }
        }


    }
}
