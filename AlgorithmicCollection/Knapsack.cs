using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicCollection
{
    //recursion 
    /*
     * K[i,capacity ] = max( K[i-1,capacity] , val(i) + k[i-1, capacity-weight[i])
     * */

    public class Knapsack
    {
        int[] capacity;
        int sackcapacity;
        int numberofElements;
        int[,] K;
        int[] valueArray;


        public Knapsack()
        {
            numberofElements = 5;
            capacity = new int[5] { 12, 32, 432, 23, 21 };
            valueArray = new int[5] { 12, 23, 342, 23, 212 };


            K = new int[numberofElements + 1, numberofElements + 1];

        }

        private void dyanmicKnapsack()
        {
            for (int i = 0; i <= numberofElements; i++)
            {
                for (int j = 0; j <= sackcapacity; j++)
                {
                    if (i == 0 || j == 0)
                        K[i, j] = 0;

                    if (capacity[j] > sackcapacity)
                        K[i, j] = K[i - 1, j];

                    else
                    {
                        int predecessor = valueArray[i - 1] + K[i - 1, j - capacity[i - 1]];
                        K[i, j] = Math.Max(K[i - 1, j], K[i - 1, predecessor]);

                    }

                }
            }
        }

    }
}
