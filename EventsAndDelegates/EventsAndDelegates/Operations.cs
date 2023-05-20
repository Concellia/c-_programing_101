﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Operations
    {
        
            // TODO
            public delegate float OperationDelegate(float float1, float float2);


            public static float Add(float num1, float num2)
            {
                return num1 + num2;
            }

            public static float Subtract(float num1, float num2)
            {
                return num1 - num2;
            }

            public static float Multiply(float num1, float num2)
            {
                return num1 * num2;
            }

            public static float Divide(float num1, float num2)
            {
                return num1 / num2;
            }

            public static float ApplyOperation(float num1, float num2, OperationDelegate operation)
            {
                return operation(num1, num2);
            }
        }
    
}
