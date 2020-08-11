﻿

/*===================================================================================
* 
*   Copyright (c) Userware (OpenSilver.net, CSHTML5.com)
*      
*   This file is part of both the OpenSilver Simulator (https://opensilver.net), which
*   is licensed under the MIT license (https://opensource.org/licenses/MIT), and the
*   CSHTML5 Simulator (http://cshtml5.com), which is dual-licensed (MIT + commercial).
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/



using System.Reflection;
using System.Windows;
namespace DotNetForHtml5.EmulatorWithoutJavascript
{
    static class ScreenCoordinatesHelper
    {
        public static double ConvertWidthOrNaNToDpiAwareWidthOrNaN(double widthOrNaN, bool invert = false)
        {
#if BROWSER_IS_NOT_DPI_AWARE
            // We take into account the "Font Size" (DPI) setting of Windows: //cf. http://answers.awesomium.com/questions/321/non-standard-dpi-rendering-is-broken-in-webcontrol.html
            if (!double.IsNaN(widthOrNaN))
            {
                var dpiXProperty = typeof(SystemParameters).GetProperty("DpiX", BindingFlags.NonPublic | BindingFlags.Static);
                var dpiX = (int)dpiXProperty.GetValue(null, null);
                double factor = (dpiX / 96.0);
                double dpiAwareWidth = (invert ? (widthOrNaN * factor) : (widthOrNaN / factor));
                return dpiAwareWidth;
            }
            else
                return double.NaN;
#else
            return widthOrNaN;
#endif
        }

        public static double ConvertHeightOrNaNToDpiAwareHeightOrNaN(double heightOrNaN, bool invert = false)
        {
#if BROWSER_IS_NOT_DPI_AWARE
            // We take into account the "Font Size" (DPI) setting of Windows: //cf. http://answers.awesomium.com/questions/321/non-standard-dpi-rendering-is-broken-in-webcontrol.html
            if (!double.IsNaN(heightOrNaN))
            {
                var dpiYProperty = typeof(SystemParameters).GetProperty("Dpi", BindingFlags.NonPublic | BindingFlags.Static);
                var dpiY = (int)dpiYProperty.GetValue(null, null);
                double factor = (dpiY / 96.0);
                double dpiAwareHeight = (invert ? (heightOrNaN * factor) : (heightOrNaN / factor));
                return dpiAwareHeight;
            }
            else
                return double.NaN;
#else
            return heightOrNaN;
#endif
        }
    }
}
