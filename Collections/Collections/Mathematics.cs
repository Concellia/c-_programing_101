using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Mathematics
    {

        public static int MIN(params int[] args)
        {
            if (args.Length == 0)
                return 0;

            int min = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] < min)
                {
                    min = args[i];
                }
            }

            return min;
        }

        public static int MAX(params int[] args)
        {
            if (args.Length == 0)
                return 0;

            int max = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > max)
                {
                    max = args[i];
                }
            }

            return max;
        }

        public static double AVG(params int[] args)
        {
            if (args.Length == 0)
                return 0;

            int sum = 0;
            double result = 0.0;

            for (int i = 0; i < args.Length; i++)
            {
                sum+= args[i];
            }

            result = (double)sum/(double)args.Length;

            return result;
        }
    }
}
