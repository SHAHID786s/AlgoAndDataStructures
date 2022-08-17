using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDataStructures.ArrInsertion
{
    public static class Employee
    {
        //inserting @ END.
        public static void Insert()
        {
            int[] details = new int[10];
            int length = 0;
            for (int i = 0; i<2; i++)
			{
                details[length] = i; // 0,1,2
                length++;
			}
            details[length] = 77; // add the value to the last array element which is in position number 3;
            length++; // increment counter as another value has been placed into our array        

            //inserting @ start of array
            /*  for (int i = 2; i >=0; i--)
              {
                  details[i + 1] = details[i]; // move values over so element at number 1 is in element number 2 and so on 

              }
              details[0] = 78;*/

            //**********************inserting anywhere in array***********************
            /*int count = 0;
            int position = 3; //postion we want to put number
            for (int i = 6; i >=position; i--)
            {
                details[i + 1] = details[i];
                count = i;
            }
            details[count] = 33;*/ // the value we want to put in that position

        }

    }
}
