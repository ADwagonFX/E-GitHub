using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_Battles
{
    class ImagePath
    {
        public static string BeginStr = "..\\..\\Images\\"; // image file location
        public static string EndDStr = ".png"; // Hexagon and soldier file type
        public static string MidGSTR = "Grass"; 
        public static string MidWSTR = "Water";
        public static string MidSSTR = "Special";
        public static string MidBSTR = "bonus";
        public static string MidP1 = "Player1";
        public static string MidP2 = "Player2";

        public static string HexImage(int num)
        {
            switch (num)
            {
                case 1:
                    return BeginStr + MidGSTR + EndDStr;
                case 2:
                    return BeginStr + MidSSTR + EndDStr;
                case 3:
                    return BeginStr + MidBSTR + EndDStr;
                case 4:
                    return BeginStr + MidWSTR + EndDStr;  
            }
            return null;
        }
        public static string SoldierImage(int num)
        {
            if (num == 1)
                return BeginStr + MidP1 + EndDStr;
            if (num == 2)
                return BeginStr + MidP2 + EndDStr;
            return null;
        }
    }
}
