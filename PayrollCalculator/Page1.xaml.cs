using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PayrollCalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            gross.Text = $"{Application.Current.Properties["displaygross"].ToString()}";
            deduction.Text = $"{Application.Current.Properties["displaydeduction"].ToString()}";
            net.Text = $"{Application.Current.Properties["displaynet"].ToString()}";
        }
    }
}