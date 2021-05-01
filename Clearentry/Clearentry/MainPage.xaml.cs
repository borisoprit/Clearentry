using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clearentry
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entry = new List<Entry>();
        public MainPage()
        {
            InitializeComponent();
            entry.Clear();
            entry.Add(Nr1);
            entry.Add(Nr2);
            entry.Add(Nr3);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            foreach (var entry in entry)
            {

                entry.Text = "";
            }

        }
    }
}
