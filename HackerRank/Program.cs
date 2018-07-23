using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
           
           List<List<int>> arraySequence = new List<List<int>> { new List<int>{ 1, 0, 5 },new List<int> {1,1,7 }, new List<int> { 1,0,3},
               new List<int>{ 2,1,0},new List<int>{ 2, 1, 1 } };
            dynamicArray(2, arraySequence);
        }
        static List<int> dynamicArray(int n, List<List<int>> queries)
        {
          List<List<int>> seqList = new List<List<int>>(n);
            for(int i=0; i<n; i++)
            {
                seqList.Add( new List<int>());
            }
            List<int> finalAnswer = new List<int>();
            int lastAnswer = 0;
            foreach(var list in queries)
            {
                if (list[0] == 1)
                {
                    int index = ((list[1] ^ lastAnswer) % n);
                    seqList[index].Add(list[2]);
                }
                else
                {
                    int index= ((list[1] ^ lastAnswer) % n);
                    int temp =(list[2]% seqList[index].Count);
                     int num=  seqList[index][temp];
                    lastAnswer = num;
                    finalAnswer.Add(num);
                }

            }
     

            
            return finalAnswer;
        }
    }
}
