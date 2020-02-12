using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural
{
    [DataContract]
    public class Model
    {
        public Model()
        {
            Initialize();
        }

        private void Initialize()
        {
            mWidgets = new ObservableCollection<Widget>();
        }

        private ObservableCollection<Widget> mWidgets;

        /// <summary>
        /// Collection of widgets
        /// </summary>
        [DataMember]
        public ObservableCollection<Widget> Widgets => mWidgets;

    }
}
