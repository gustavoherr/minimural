using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace MiniMural.Controls
{
    public sealed partial class RandomImageControl : UserControl, IWidget, INotifyPropertyChanged
    {
        public RandomImageControl()
        {
            this.InitializeComponent();
            IsDoubleTapEnabled = false;
            ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            Tapped += RandomImageControl_Tapped;
            ManipulationDelta += RandomImageControl_ManipulationDelta;
        }

        private void RandomImageControl_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTransform.TranslateX += e.Delta.Translation.X;
            dragTransform.TranslateY += e.Delta.Translation.Y;
        }

        private void RandomImageControl_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var ric = sender as RandomImageControl;
            ric.RandomImageObject.Selected = !ric.RandomImageObject.Selected;
            e.Handled = true;
        }

        public WidgetTypeEnum WidgetType => WidgetTypeEnum.RandomImage;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public RandomImage RandomImageObject
        {
            get { return (RandomImage)GetValue(RandomImageObjectProperty); }
            set { SetValue(RandomImageObjectProperty, value); }
        }

        public static readonly DependencyProperty RandomImageObjectProperty = DependencyProperty.Register("RandomImageObject", typeof(RandomImage), typeof(RandomImageControl), new PropertyMetadata(false, RandomImageObjectPropertyChanged));

        private static void RandomImageObjectPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs ea)
        {
            RandomImageControl instance = dependencyObject as RandomImageControl;
            RandomImage img = ea.NewValue as RandomImage;
            instance.DisplayUrl = img.UrlImage;
            instance.Margin = new Thickness { Left = img.Left, Top = img.Top };
        }

        private string mDisplayUrl;
        public string DisplayUrl
        {
            get { return mDisplayUrl; }

            private set
            {
                SetProperty(ref mDisplayUrl, value);
            }
        }
    }
}
