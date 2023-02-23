using System;

using Xamarin.Forms;

namespace theAppMocki.iOS.Resources.xml
{
    public class file_paths : ContentPage
    {
        public file_paths ()
        {
            Content = new StackLayout { 
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


