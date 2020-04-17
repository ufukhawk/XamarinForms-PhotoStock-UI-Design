using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Photostock.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            try
            {
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch (Exception ex)
            {

            }
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
          
        }
    }
}
