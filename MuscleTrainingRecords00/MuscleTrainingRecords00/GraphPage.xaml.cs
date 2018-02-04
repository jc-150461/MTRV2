using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraphPage : ContentPage
    {


        public GraphPage()
        {
            InitializeComponent();

            today.Text = DateTime.Today.ToString("yyyy/MM/dd");
            addItemButton.Clicked += Handle_ClickedAsync;

        }
        //DateTime yyyymmdd;//追加







        /********************ここから追加******************************************/

        public async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {


         

            try
            {

                if (bWeight.Text == null)
                {
                    await DisplayAlert("", "体重を入力してください", "OK");

                }
                else if (bFat.Text == null)
                {
                    await DisplayAlert("", "体脂肪率を入力してください", "OK");
                }
                else if (bWeight.Text == null && bFat.Text == null)
                {
                    await DisplayAlert("", "入力してください", "OK");
                }



                var db = TodoItemDatabase.getDatabase();
                    int B_Weight = int.Parse(bWeight.Text);
                    int B_Fat = int.Parse(bFat.Text);
                    DateTime dCreated = DateTime.Today;


                    TodoItem sameDateItem = await db.GetItemByCreatedAsync(dCreated);
                    if (sameDateItem == null)
                    {
                        TodoItem item = new TodoItem() { Created = dCreated, Bweight = B_Weight, Bfat = B_Fat };
                        await db.SaveItemAsync(item);
                        await DisplayAlert("", "記録されました:" + dCreated, "OK");
                    }
                    else
                    {
                        await db.DeleteItemAsync(sameDateItem);
                        TodoItem item = new TodoItem() { Created = dCreated, Bweight = B_Weight, Bfat = B_Fat };
                        await db.SaveItemAsync(item);
                        await DisplayAlert("", "更新されました:" + dCreated, "OK");

                    }

                    Application.Current.MainPage = new MainPage();
                
            }
        catch (Exception)
            {
                await DisplayAlert("", "数値を入力してください", "OK");
            }
        }
    }
}



        /*private void eCreated_DateSelected(object sender, DateChangedEventArgs e)//追加
        {
            yyyymmdd = new DateTime(eCreated.Date.Year, eCreated.Date.Month, eCreated.Date.Day);
        }*/