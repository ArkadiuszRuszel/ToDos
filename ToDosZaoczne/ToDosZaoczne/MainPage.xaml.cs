using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDosZaoczne.Model;
using Xamarin.Forms;

namespace ToDosZaoczne
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            var toDos = new List<ToDo>() {
                new ToDo(){Title = "Xamarin", Description = "Nauczyć się Xamarin" },
                new ToDo(){Title = "Xamarin", Description = "Nauczyć się Xamarin" }
            };
        }

    }
}
