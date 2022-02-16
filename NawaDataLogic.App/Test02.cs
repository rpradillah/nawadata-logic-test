using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NawaDataLogic.App
{
    class Test02
    {
        public Test02()
        {
            Console.WriteLine("Input the number of families :");
            int iFamilies = int.Parse(Console.ReadLine());

            var returnTrue = true;
            while (returnTrue)
            {
                Console.WriteLine("Input the number of members in the family (separated by a space) :");
                int[] iFamilyNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Array.Sort(iFamilyNumber);

                if (iFamilies == iFamilyNumber.Length)
                {
                    var iMinimumBus = 1;
                    var iTemp = iFamilyNumber[0];

                    for (int i = 1; i < iFamilyNumber.Length; i++)
                    {
                        if (iTemp + iFamilyNumber[i] >= 4)
                        {
                            iMinimumBus++;
                        }
                    }

                    Console.WriteLine("Minimum bus required is " + iMinimumBus);

                    returnTrue = false;
                }
                else
                {
                    Console.WriteLine("Input must be equal with count of family");
                }
            }
        }
    }
}
