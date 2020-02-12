using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural.Controls
{
    public interface IWidget
    {
        WidgetTypeEnum WidgetType { get; }
    }
}
