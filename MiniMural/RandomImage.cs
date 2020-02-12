using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural
{
    public class RandomImage : Widget
    {
        public RandomImage(int width, int height)
        {
            // TODO: get url image from https://picsum.photos/{height}/{width}
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
