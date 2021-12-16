using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public enum Status
    {
        Unavailable,
        Available,
        Dispatched
    }
    public enum Shift
    {
        Morning,
        Evening,
        Night
    }
    public enum Type
    {
        CTWO,
        Driver,
        EMT
    }
    public enum Attributes
    {
        id,
        rating,
        status,
        shift,
        pin,
        type
            
    }
}
