using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using XamarinNotification.iOS;

[assembly: Dependency(typeof(NotificationHelper))]
namespace XamarinNotification.iOS
{
    class NotificationHelper:INotification
    {
        public void CreateNotification(string title,string message)
        {
          //  new NotificationDelegate().RegisterNotification(title,message);
        }
    }
}