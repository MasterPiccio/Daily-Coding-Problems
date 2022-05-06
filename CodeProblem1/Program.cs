using System;

namespace CodeProblem1
{

    class Program
    {
        

        static void Main(string[] args)
        {
            int _avalue;
            string _astring;
            bool _abool;
            int storeNum =1;
            Console.WriteLine("Hi, this little program will solve the following problem from the book 'Daily Coding Problem'\n");
            Console.WriteLine("Given an array of integers, return a new array such that each element\nat index 'i' of the new array is" +
                               "the product of all the numbers in the orginal array except the one at 'i';\n" +
                               "What if you can't use division\n");
            Console.WriteLine("Insert the lenght of the array");
            _avalue = int.Parse(Console.ReadLine());
            Console.WriteLine("you typed: " + _avalue);
            int[] initialArray = new int[_avalue];
            int[] finalArray = new int[_avalue];

            for (int i = 0; i < _avalue; i++)
            {
                Console.WriteLine("insert value at position: " + i);
                initialArray[i] = int.Parse(Console.ReadLine());

                if (i == _avalue - 1)
                {
                    Console.WriteLine("array completed");
                    Console.WriteLine("now let me made some calculation");
                    
                }
            }
            for (int y=0; y<_avalue; y++)
                {
               
                
                    for (int x = 0; x < _avalue; x++)
                    {
                        if (x == y)
                        {
                            continue;
                        }
                        else
                        {
                            storeNum = initialArray[x] * storeNum;
                        }
                    }
                

                    finalArray[y] = storeNum;
                     Console.WriteLine("final array is composed by: " + finalArray[y] +" at position: " +y );
                    storeNum = 1;
                }
            Console.WriteLine("here's your final array:");
            for (int h=0; h<_avalue; h++)
            {
                Console.WriteLine(finalArray[h]);
            }
            



     

            
        }
    }
}
