﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AidMethods
{
    public static class GetSolution
    {
       
        public static Assembly AssemblyByName(string name)
        {
            return Safe.Run(() => Assembly.Load(name), null);
        }

        public static List<Type> TypesForAssembly(string assemblyName)
        {
            return Safe.Run(() =>
            {
                var a = AssemblyByName(assemblyName);
                return a.GetTypes().ToList();
            }, new List<Type>());
        }

    }
}