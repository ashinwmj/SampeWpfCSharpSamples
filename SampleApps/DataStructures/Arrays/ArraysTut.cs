using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class ArraysTut
    {
        //Declaration

        private int[] numArray = new[] {1, 2};

        //multidimensionalarray

        int[,] twoDimensional=new int[,]{{1,2},{3,2}};
        int[,] twoDi1=new int[3,4]; // first value is the row count, second is the column count

        private int[,,] array3D = new int[2, 2, 3]
        {
            {{1, 2, 3}, {2, 3, 4}},
            {{1, 2, 3}, {2, 3, 4}}
        };

        int[][] jaggedAray=new int[5][];
        //array of array

      
     

        public void Method1()
        {
            //Model Sales in each moth in an year
            int[] jan = new int[31];
         int[] feb = new int[29];
         int[][] year2020 = new[] {jan,feb};
        }
    }
}
