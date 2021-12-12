using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;

namespace AutoPark.Entity
{
    
    [Serializable]
    public class CarPicture
    {
        public CarPicture(){

        }

        private byte[] img;

        public string Number { get; set; }

        [XmlIgnore]
        public Bitmap Picture { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Icon")]
        public byte[] IconSerialized
        {
            get
            { // serialize
                if (Picture == null) return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    Picture.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            set
            { // deserialize
                if (value == null)
                {
                    Picture = null;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        Picture = new Bitmap(ms);
                    }
                }
            }
        }
    }
}
