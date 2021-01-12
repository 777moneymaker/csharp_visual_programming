using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calc {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalcService : ICalcService {
        double ICalcService.Add(double n1, double n2) => n1 + n2;
        double ICalcService.Divide(double n1, double n2) => n1 / n2;
        double ICalcService.Multiply(double n1, double n2) =>  n1 * n2;
        double ICalcService.Subtract(double n1, double n2) => n1 - n2;
    }
}
