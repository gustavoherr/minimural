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
        public List<IWidget> WidgetControls { get; set; } = new List<IWidget>();
    }
}
