using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MiniMural.Controls
{
    public class WidgetDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate StickNoteTemplate { get; set; }
        public DataTemplate RandomImageTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            switch (item)
            {
                case StickyNote _:
                    return StickNoteTemplate;
                case RandomImage _:
                    return RandomImageTemplate;
            }
            return base.SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            switch (item)
            {
                case StickyNote _:
                    return StickNoteTemplate;
                case RandomImage _:
                    return RandomImageTemplate;
            }
            return base.SelectTemplateCore(item, container);
        }
    }
}
