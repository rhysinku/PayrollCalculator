using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PayrollCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double ratehour = Double.Parse(hrate.Text);
            double emplostatus;
            double oth;
            double ot;
            double rateph;
            double basic;
            double gross;
            double wtax;
            double ph;
            double piibig;
            double deduction;
            double net;

            if (estatus.Text == "R" || estatus.Text == "r")
            {
                emplostatus = 800;
            }
            else if (estatus.Text == "P" || estatus.Text == "p")
            {
                emplostatus = 600;
            }
            else if (estatus.Text == "C" || estatus.Text == "c")
            {
                emplostatus = 500;

            }
            else if (estatus.Text == "T" || estatus.Text == "t")
            {
                emplostatus = 450;
            }
            else
            {
                emplostatus = 400;
            }


            rateph = emplostatus / 8;
            basic = ratehour * rateph;
            oth = ratehour - 120;
            if (ratehour > 120)
            {
                ot = oth * (rateph * 1.5);
            }
            else
            {
                ot = 0;
            }
            gross = basic + ot;
            if (gross > 10000)
            {
                wtax = 0.1 * gross;
            }
            else if (gross > 5000)
            {
                wtax = 0.08 * gross;
            }
            else
            {
                wtax = 0.05 * gross;
            }
            if (cstatus.Text == "S" || cstatus.Text == "s")
            {
                ph = 500;
            }
            else if (cstatus.Text == "M" || cstatus.Text == "m")
            {
                ph = 300;
            }
            else
            {
                ph = 400;
            }
            if (gross > 10000)
            {
                piibig = 0.05 * gross;
            }
            else if (gross > 5000)
            {
                piibig = 0.03 * gross;
            }
            else
            {
                piibig = 0.02 * gross;
            }
            deduction = wtax + ph + piibig;
            net = gross - deduction;


            deduction = wtax + ph + piibig;
            net = gross - deduction;

            Application.Current.Properties["displaygross"] = gross;
            Application.Current.Properties["displaydeduction"] = deduction;
            Application.Current.Properties["displaynet"] = net;
            Navigation.PushAsync(new Page1());
        }
    }
}
