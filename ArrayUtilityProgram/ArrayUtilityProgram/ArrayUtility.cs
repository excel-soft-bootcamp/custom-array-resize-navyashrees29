using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilityProgram
{
    class ArrayUtility
    {
        public static void Resize(ref int[] array, int newSize)
        {
            array = new int[newSize];
            int[] array1 = new int[newSize];
          
           for (int i=0;i<array.Length;i++)
            {
                array[i] = array1[i];
            }

        }
    }
}
