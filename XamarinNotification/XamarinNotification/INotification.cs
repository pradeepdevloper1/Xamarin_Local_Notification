using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNotification
{
    public interface INotification
    {
        void CreateNotification(String title, String message);
    }
}
