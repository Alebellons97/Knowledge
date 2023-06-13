using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Presentation.Utils
{
    public static class TemperatureUtils
    { public static float CelsiusToKelvin(float value ) 
        {
            return  (float)(value + 273.15);
                

        }
 
    public static float CelsiusToFahrenheit (float value)
        {
            return (float)((value * 9) / 5 + 32);
        }
    
    
    }
}





