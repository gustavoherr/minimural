using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MiniMural.Controls
{
    public class WidgetsCanvas : Canvas
    {
        //public WidgetsCanvas()
        //{
        //    //this.IsDoubleTapEnabled = true;
        //    //DoubleTapped += WidgetsCanvas_DoubleTapped;
        //}

        //private void WidgetsCanvas_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        //{
        //    var pos = e.GetPosition(null);
        //}


        public List<IWidget> WidgetControls { get; set; } = new List<IWidget>();
    }
}
