﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(WCF_Project.ServiceCalculate)))
            {
                host.Open();
                Console.WriteLine("Start");
                Console.ReadLine();
            }
        }
    }
}
