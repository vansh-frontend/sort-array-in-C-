using System;

namespace MyArray {
    class ArrayProgarm
    {
        //sorting array in c#
       static void Main(string[] args)
        {
            int[] Num = {2,4,1,5,6,0 };
            Array.Sort(Num);
            foreach (int i in Num)
            {   
                Console.WriteLine(i);
            }
        }
    }

}


