using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpApp.ProblemSolving
{
    public class FindLongestConseqSubseqClass
    {
        public static int findLongestConseqSubseqLength()
        {
            int temp, count, max = 0;
            int[] arr = { 1, 9, 3, 10, 4, 20, 2, 21, 22, 23, 24 };
            var hash = new HashSet<int>(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                if (!hash.Contains(arr[i] - 1))
                {
                    temp = arr[i];
                    while (hash.Contains(temp))
                    {
                        count++;
                        temp++;
                    }

                    max = max > count ? max : count;
                }
            }

            return max;
        }

        public static int[] findLongestConseqSubseq()
        {
            int tempElem;
            int maxLength = 0;
            int[] arr = {1, 9, 3, 10, 4, 20, 2, 21, 22, 23, 24};
            var longetSeq = new List<int>();
            var temp = new HashSet<int>();
            var hash = new HashSet<int>(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                temp.Clear();
                if (!hash.Contains(arr[i] - 1))
                {
                    tempElem = arr[i];
                    while (hash.Contains(tempElem))
                    {
                        temp.Add(tempElem);
                        tempElem++;
                    }

                    if (maxLength<temp.Count())
                    {
                        longetSeq.Clear();
                        longetSeq.AddRange(temp);
                        maxLength = temp.Count();
                    }
                }
            }

            Console.WriteLine(longetSeq.Count());
            longetSeq.ForEach(val =>
            {
                Console.WriteLine(val);
            });
            return longetSeq.ToArray();
        }

        public static int[] findLongestConseqSubseqV2()
        {
            int[] arr = { 1, 9, 3, 10, 4, 20, 2, 21, 22, 23, 24 };
            var arrSet = new HashSet<int>();
            var res = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr.Contains(arr[i] -1)) {
                    arrSet.Clear();
                    int j = arr[i];
                    while (arr.Contains(j))
                    {
                        arrSet.Add(j);
                        j++;
                    }

                    if (arrSet.Count() > res.Count())
                    {
                        res = arrSet;
                    }

                }
            }

            Console.WriteLine(res.Count());
            foreach(var val in res){
                Console.WriteLine(val);
            };
            return res.ToArray();
        }

        public static void Main()
        {
            //findLongestConseqSubseq();
            Console.WriteLine(findLongestConseqSubseqV2());
            Console.ReadKey();
        }
    }
}
