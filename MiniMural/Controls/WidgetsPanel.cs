using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MiniMural.Controls
{
    public class WidgetsPanel : ItemsControl
    {
        //public WidgetsPanel()
        //{
        //    DoubleTapped += WidgetsPanel_DoubleTapped;
        //}

        public WidgetsCanvas CanvasControl
        {
            get
            {
                return (WidgetsCanvas)ItemsPanelRoot;
            }
        }

        //public void WidgetsPanel_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        //{
        //    var pos = e.GetPosition(null);
        //}

        //public List<IWidget> WidgetControls
        //{
        //    get { return CanvasControl.WidgetControls; }
        //}
    }
}
