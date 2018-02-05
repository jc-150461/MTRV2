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
    public partial class RMPage : ContentPage
    {
        public RMPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Double w = Double.Parse(Weight.Text);
                Double k = 0.0;
                String s = (String)count.SelectedItem;
                Double dCount = Double.Parse(s);

                if (dCount == null)
                {
                    DisplayAlert("", "回数を選択してください。", "OK");
                    //RM.Text = "入力してください。";
                }

                else if (w == null)
                {
                    DisplayAlert("", "重量を入力してください。", "OK");
                    //Weight.Text = "入力してください。";
                }



                else if (dCount == 1)
                {
                    k = w / 1;
                    Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 2)
                {
                    k = w / 0.95;
                    Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 3)
                {
                    k = w / 0.93;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 4)
                {
                    k = w / 0.9;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 5)
                {
                    k = w / 0.87;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 6)
                {
                    k = w / 0.85;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 7)
                {
                    k = w / 0.87;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 8)
                {
                    k = w / 0.8;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 9)
                {
                    k = w / 0.77;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }

                else if (dCount == 10)
                {
                    k = w / 0.7;
                    k = Math.Round(k, 1);
                    RM.Text = k.ToString();
                }
            }
            

            catch (Exception)
            {
                DisplayAlert("", "数値を入力してください。", "OK");
            }
        }
    }
}