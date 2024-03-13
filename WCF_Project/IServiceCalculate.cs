using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Project
{
    [ServiceContract]
    public interface IServiceCalculate
    {
        [OperationContract]
        double Calculate(double a, double b, double c);
    }
}
