using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace MiniMural
{
    /// <summary>
    /// Main page.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainPageViewModel();
            ViewModel.Widgets.Add(new StickyNote(DateTime.Now.ToString(), GetRandomColor()));
        }

        public MainPageViewModel ViewModel { get; }

        private void WidgetsCanvas_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            var wc = sender as Controls.WidgetsCanvas;

            if (ViewModel.WidgetTypeStickyNote)
            {
                AddStickyNoteItem(wc, e.GetPosition(wc));
            }
            else if (ViewModel.WidgetTypeRandomImage)
            {
                AddRandomImageItem(wc, e.GetPosition(wc));
            }
        }

        private void AddStickyNoteItem(Controls.WidgetsCanvas canvas, Point position)
        {
            //var sn = new Controls.StickyNoteControl();
            //sn.Margin = new Thickness(position.X, position.Y, 0, 0);
            //sn.StickyNoteObject = new StickyNote(DateTime.Now.ToString(), GetRandomColor());
            //canvas.WidgetControls.Add(sn);
        }

        private void AddRandomImageItem(Controls.WidgetsCanvas canvas, Point position)
        {
            
        }

        private Random mRandomGenerator = new Random(DateTime.Now.Second);
        private System.Drawing.Color GetRandomColor()
        {
            var colors = new[] { System.Drawing.Color.LightBlue, System.Drawing.Color.Yellow, System.Drawing.Color.LightSalmon, System.Drawing.Color.LightGreen, System.Drawing.Color.LightGray };
            return colors[mRandomGenerator.Next(0, 5)];
        }
    }
}
