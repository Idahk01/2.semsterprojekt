using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SlukLys_Udkast
{
    public interface IAfstandsSensor
    {
        event EventHandler<double> DistanceMeasured;
        event EventHandler DistanceMeasurementFailed;
        Task MeasureDistanceAsync();

    }
}
