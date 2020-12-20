using System;
using System.Collections.Generic;

namespace HashMap
{
    class Program
    {        
        static void FindPair(int[]array, int sum){
            Dictionary <int,int> diction = new Dictionary<int, int>();
            
            for(int i = 0; i < array.Length; i++){

                if(diction.ContainsKey(sum - array[i])){                    
                    Console.WriteLine("Pair found at: "+diction[sum - array[i]] + 
                        " and "+i);
                        return;
                }

                diction.Add(array[i],i);                
            }
 
            Console.WriteLine("No pairs found.");
        }
        static void Main(string[] args)
        {
            int[]ar = { 4, 1, 2, 6, 3, 9 };
            int sum = 5;
            FindPair(ar,sum);
        }

    }
}
