using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenudetaliPage : ContentPage
    {
        string t;

        //今日の日付
        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        public MenudetaliPage(string m, string d, string i)//String m
        {
            InitializeComponent();


            Transition.Text = m.Trim();

            Description.Text = d;

            //image.Source = i;

            t = m;
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {

            RecordsModel.InsertRe(1,t,0,0,0,now);

            Navigation.PushAsync(new RecordListPage());

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e,string m)
        {
            var result = await DisplayAlert("削除", "この記録を削除しますか", "OK", "キャンセル");

            if (result == true)
            {
                int M_no = int.Parse(m);

                RecordsModel.DeleteRecords(M_no);

                await Navigation.PushAsync(new RecordListPage());



                InitializeComponent();
            }
        }

        /*public MenudetaliPage(String l)
        {
        this.l = l;
        }*/
    }
}