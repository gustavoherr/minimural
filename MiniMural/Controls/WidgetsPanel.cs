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

        public WidgetsCanvas CanvasControl
        {
            get
            {
                return (WidgetsCanvas)ItemsPanelRoot;
            }
        }

        public List<IWidget> WidgetControls
        {
            get { return CanvasControl.WidgetControls; }
        }
    }
}
