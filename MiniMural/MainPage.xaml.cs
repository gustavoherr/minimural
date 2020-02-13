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

            // initial items for test
            var sn = new StickyNote(DateTime.Now.ToString(), GetRandomColor()) { Left = 200, Top = 400 };
            var ri = new RandomImage() { Left = 300, Top = 100 };
            
            ViewModel.Widgets.Add(sn);
            ViewModel.Widgets.Add(ri);
        }

        public MainPageViewModel ViewModel { get; }

        private void WidgetsCanvas_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            var wc = sender as Canvas;

            if (ViewModel.WidgetTypeStickyNote)
            {
                AddStickyNoteItem(e.GetPosition(wc));
            }
            else if (ViewModel.WidgetTypeRandomImage)
            {
                AddRandomImageItem(e.GetPosition(wc));
            }
            e.Handled = true;
        }

        private void Canvas_Tapped(object sender, TappedRoutedEventArgs e)
        {
            foreach (var widget in ViewModel.Widgets)
            {
                widget.Selected = false;
            }
            e.Handled = true;
        }

        private void AddStickyNoteItem(Point position)
        {
            var sn = new StickyNote(DateTime.Now.ToString(), GetRandomColor());
            sn.Left = position.X;
            sn.Top = position.Y;
            ViewModel.Widgets.Add(sn);
        }

        private void AddRandomImageItem(Point position)
        {
            var ri = new RandomImage();
            ri.Left = position.X;
            ri.Top = position.Y;
            ViewModel.Widgets.Add(ri);
        }

        private Random mRandomGenerator = new Random(DateTime.Now.Second);
        private System.Drawing.Color GetRandomColor()
        {
            var colors = new[] { System.Drawing.Color.LightBlue, System.Drawing.Color.Yellow, System.Drawing.Color.LightSalmon, System.Drawing.Color.LightGreen, System.Drawing.Color.LightGray };
            return colors[mRandomGenerator.Next(0, 5)];
        }

        private void ButtonDeleteSelected_Click(object sender, RoutedEventArgs e)
        {
            var selected = ViewModel.Widgets.Where(w => w.Selected).ToList();
            foreach (var sw in selected)
            {
                ViewModel.Widgets.Remove(sw);
            }
        }

        
    }
}
