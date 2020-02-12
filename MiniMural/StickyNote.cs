using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MiniMural
{
    [DataContract]
    public class StickyNote : Widget
    {
        public StickyNote(string txt, System.Drawing.Color color)
        {
            Text = txt;
            Color = color;
        }

        private string mText;
        private System.Drawing.Color mColor;

        [DataMember]
        public string Text
        {
            get
            {
                return mText;
            }
            set
            {
                SetProperty(ref mText, value, nameof(Text));
            }
        }

        [DataMember]
        public System.Drawing.Color Color {
            get
            {
                return mColor;
            }
            set
            {
                SetProperty(ref mColor, value, nameof(Color));
            }
        }
    }
}
