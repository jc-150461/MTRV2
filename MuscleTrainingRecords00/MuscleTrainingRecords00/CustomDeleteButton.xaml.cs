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
	public partial class CustomDeleteButton : ContentView
	{

        public static readonly BindableProperty NoTextProperty =
            BindableProperty.Create(
                "NoText",
                typeof(string),
                typeof(CustomDeleteButton),
                null,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    ((CustomDeleteButton)bindable).textNoLabel.Text = (string)newValue;
                });

        public static readonly BindableProperty NameTextProperty =
           BindableProperty.Create(
               "NameText",
               typeof(string),
               typeof(CustomDeleteButton),
               null,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   ((CustomDeleteButton)bindable).textNameLabel.Text = (string)newValue;
               });

       /* public static readonly BindableProperty DateTextProperty =
        BindableProperty.Create(
            "DateText",
            typeof(string),
            typeof(CustomDeleteButton),
            null,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((CustomDeleteButton)bindable).textNameLabel.Text = (string)newValue;
            });*/



        public static readonly BindableProperty IsCheckedProperty =
           BindableProperty.Create(
               "IsChecked",
               typeof(bool),
               typeof(CustomDeleteButton),
               false,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   CustomDeleteButton button = (CustomDeleteButton)bindable;

                   //イベント発行
                   EventHandler<bool> eventHandler = button.CheckedChanged;
                   if (eventHandler != null)
                   {
                       eventHandler(button, (bool)newValue);
                   }
               });

        public event EventHandler<bool> CheckedChanged;

        public CustomDeleteButton()
        {
            InitializeComponent();
        }

        public string NoText
        {
            set { SetValue(NoTextProperty, value); }
            get { return (string)GetValue(NoTextProperty); }
        }

        public string NameText
        {
            set { SetValue(NameTextProperty, value); }
            get { return (string)GetValue(NameTextProperty); }
        }

       

        public bool IsChecked
        {
            set { SetValue(IsCheckedProperty, value); }
            get { return (bool)GetValue(IsCheckedProperty); }
        }

        //TapGestureRecognizerハンドラー
        void OnButtonTapped(object sender, EventArgs args)
        {
            IsChecked = !IsChecked;
        }
    }
}