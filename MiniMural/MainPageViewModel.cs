using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural
{
    public class MainPageViewModel : BindableBase
    {
        private bool mWidgetTypeStickyNote = true;
        private bool mWidgetTypeRandomImage;

        public bool WidgetTypeStickyNote
        {
            get { return mWidgetTypeStickyNote; }
            set
            {
                SetProperty(ref mWidgetTypeStickyNote, value, nameof(WidgetTypeStickyNote));
            }
        }

        public bool WidgetTypeRandomImage
        {
            get { return mWidgetTypeRandomImage; }
            set
            {
                SetProperty(ref mWidgetTypeRandomImage, value, nameof(WidgetTypeRandomImage));
            }
        }

        private ObservableCollection<Widget> mWidgets = new ObservableCollection<Widget>();

        /// <summary>
        /// Collection of widgets
        /// </summary>
        [DataMember]
        public ObservableCollection<Widget> Widgets => mWidgets;
    }
}
