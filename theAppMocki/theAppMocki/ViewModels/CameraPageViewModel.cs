using System;
using System.IO;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace theAppMocki.ViewModels
{
    public class CameraPageViewModel : BindableBase, INavigationAware
    {
        //private ImageSource _image;
        //public ImageSource Image
        //{
        //    get => _image;
        //    set => SetProperty(ref _image, value);
        //}

        public DelegateCommand TakePhotoCommand { get; }

        public CameraPageViewModel()
        {
            //TakePhotoCommand = new DelegateCommand(async () => await TakePhotoAsync());
        }

        //public async Task TakePhotoAsync()
        //{
        //    var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
        //    {
        //        Title = "Take Photo"
        //    });

        //    var stream = await photo.OpenReadAsync();

        //    var filePath = Path.Combine(FileSystem.CacheDirectory, "photo.jpg");
        //    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        //    {
        //        await stream.CopyToAsync(fileStream);
        //    }

        //    var galleryPath = Path.Combine(FileSystem.AppDataDirectory, "My Photos");
        //    var galleryFilePath = Path.Combine(galleryPath, "photo.jpg");

        //    try
        //    {
        //        Directory.CreateDirectory(galleryPath);
        //        File.Copy(filePath, galleryFilePath, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception
        //    }

        //    Image = ImageSource.FromFile(filePath);
        //}

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            // Implement if needed
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            // Implement if needed
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            // Implement if needed
        }
    }
}