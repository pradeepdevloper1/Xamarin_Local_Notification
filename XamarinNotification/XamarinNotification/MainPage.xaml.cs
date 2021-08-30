using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinNotification
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

    
        private void SendNotification_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<INotification>().CreateNotification("PradeepApp",message.Text);
        }
    }
}
