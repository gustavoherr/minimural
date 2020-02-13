using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural
{
    public class Widget : BindableBase
    {
        public double Left { get; set; }
        public double Top { get; set; }

        private bool mSelected;
        public bool Selected
        {
            get { return mSelected; }
            set
            {
                SetProperty(ref mSelected, value, nameof(Selected));
            }
        }
    }
}
