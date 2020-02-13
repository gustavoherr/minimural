using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural
{
    public class RandomImage : Widget
    {
        public RandomImage()
        {
            // get url image from https://picsum.photos/{height}/{width}
            UrlImage = "https://picsum.photos/300/200?nocache=" + DateTime.Now.Ticks;
        }

        private string mUrlImage;

        public string UrlImage
        {
            get
            {
                return mUrlImage;
            }
            set
            {
                SetProperty(ref mUrlImage, value, nameof(UrlImage));
            }
        }
    }
}
