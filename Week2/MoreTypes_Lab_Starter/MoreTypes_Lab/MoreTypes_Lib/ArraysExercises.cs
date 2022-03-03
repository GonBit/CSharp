using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string [,,] arrayContent = new string [length1, length2, length3];
            int count = 0;
            
            if (length1 * length2 * length3 != contents.Count)
            {

                throw new ArgumentException("Number of elements in list must match array size");

            }

            for (int x = 0; x < length1; x++) 
            {                           
                
                for (int y = 0; y < length2; y++)
                {                   
                    
                    for (int z = 0; z < length3; z++) 
                    {
                        arrayContent[x,y,z] = contents[count++];
                        //arrayContent[x,y,z]= contents[z + y * (length1 +1) + (x * (length1 + 1) * length2)];
                    }

                }

            }          

           return arrayContent; 

        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            
            string[][] mainArray = new string[countRow1][];
            string[] subArray = new string[countRow2]; 
            
            //populate 2 arrays and add to the main array

            int countX = 0;
            int countY = 0;

            if (countRow1 + countRow2 > contents.Count)
            {

                throw new ArgumentException("Number of elements in list must match array size");

            }

            for (int x = 0; x < countRow1; x++)
            {

                for (int y = 0; y < countRow2 ; y++)
                {
                    
                    mainArray[x][y] = contents[countY];
                }

            }

            return mainArray;
            //throw new ArgumentException("Headache");


        }
    }
}
