using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    /// <summary>
    /// 
    /// </summary>
    public class MATH
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name => "Interpolation";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public double[][] Process(double[][] table)
        {
            if (table[1][0] - table[0][0] <= 0.25) return table;

            double[][] newArray = new double[(((table.Length - 1) * 4) + 1)][];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = new double[3];
            }

            for (int i = 0, j = 0; i < table.Length - 1; i++, j += 4)
            {
                for (int z = 0; z < 3; z++)
                {
                    newArray[j    ][z] = table[i    ][z];
                    newArray[j + 4][z] = table[i + 1][z];
                }
                
                newArray[j + 2][0] = newArray[j    ][0] + ((newArray[j + 4][0] - newArray[j    ][0]) / 2);
                newArray[j + 1][0] = newArray[j    ][0] + ((newArray[j + 2][0] - newArray[j    ][0]) / 2);
                newArray[j + 3][0] = newArray[j + 2][0] + ((newArray[j + 4][0] - newArray[j + 2][0]) / 2);

                newArray[j + 2][1] = newArray[j    ][1] + (((newArray[j + 4][1] - newArray[j    ][1]) * (newArray[j + 2][0] - newArray[j    ][0])) / (newArray[j + 4][0] - newArray[j    ][0]));
                newArray[j + 2][2] = newArray[j    ][2] + (((newArray[j + 4][2] - newArray[j    ][2]) * (newArray[j + 2][0] - newArray[j    ][0])) / (newArray[j + 4][0] - newArray[j    ][0]));

                newArray[j + 1][1] = newArray[j    ][1] + (((newArray[j + 2][1] - newArray[j    ][1]) * (newArray[j + 1][0] - newArray[j    ][0])) / (newArray[j + 2][0] - newArray[j    ][0]));
                newArray[j + 1][2] = newArray[j    ][2] + (((newArray[j + 2][2] - newArray[j    ][2]) * (newArray[j + 1][0] - newArray[j    ][0])) / (newArray[j + 2][0] - newArray[j    ][0]));

                newArray[j + 3][1] = newArray[j + 2][1] + (((newArray[j + 4][1] - newArray[j + 2][1]) * (newArray[j + 3][0] - newArray[j + 2][0])) / (newArray[j + 4][0] - newArray[j + 2][0]));
                newArray[j + 3][2] = newArray[j + 2][2] + (((newArray[j + 4][2] - newArray[j + 2][2]) * (newArray[j + 3][0] - newArray[j + 2][0])) / (newArray[j + 4][0] - newArray[j + 2][0]));
            }

            return Process(newArray);
        }
    }
}
