using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerHandBook
{
    public class QuestionAnswer
    {
        public QuestionAnswer()
        {
             
            Console.WriteLine(@"
            Question: Write an efficient program for printing k largest elements in an array.Elements in array can be in any order.
            For example, if given array is [1, 23, 12, 9, 30, 2, 50] and you are asked for the largest 3 elements i.e.,
            k = 3 then your program should print 50, 30 and 23.
            ");
            int[] questionArray =new int[] { 1, 23, 12, 9, 30, 2, 50 };
            QuicSort.quickSort(ref questionArray);

            Console.WriteLine("Answer:{0}, {1}, {2}",questionArray[questionArray.Length-3], questionArray[questionArray.Length - 2], questionArray[questionArray.Length - 1]);


        }
    }

  
}
