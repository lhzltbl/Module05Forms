using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();

            var genderList = new List<string>();
            genderList.Add("Male");
            genderList.Add("Female");
            genderList.Add("Other");

            var picker = new Picker { Title = "Gender"};
            picker.ItemsSource = genderList;
        }

    DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };

        private async void btnSubmit(object sender, EventArgs e)
        {
            await DisplayAlert("Form Submitted", "Your form has been submitted. Thank you!", "OK");
        }

    }
}