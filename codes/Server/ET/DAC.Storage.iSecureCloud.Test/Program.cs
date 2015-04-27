﻿using System.Reflection;
using NUnit.Util;

namespace DAC.Storage.iSecureCloud.Test
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string loc = Assembly.GetExecutingAssembly().Location;
            NUnitTestRunner.Run(loc, args);
        }
    }
}
