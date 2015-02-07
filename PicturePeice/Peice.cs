using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturePeice
{
    class Peice
    {
        public Bitmap Picture;
        public Rectangle HomeLocation, CurrentLocation;
        public Peice(Bitmap new_picture, Rectangle home_location)
        {
            Picture = new_picture;
            HomeLocation = home_location;
        }
        public bool IsHome()
        {
            return HomeLocation.Equals(CurrentLocation);
        }
        public bool Contains(Point pt)
        {
            return CurrentLocation.Contains(pt);
        }
        public bool SnapToHome()
        {
            if((Math.Abs(CurrentLocation.X-HomeLocation.X)<20)&&
                (Math.Abs(CurrentLocation.Y-HomeLocation.Y)<20))
            {
                CurrentLocation = HomeLocation;
                return true;
            }
            return false;
        }


    }
}
