using System;
using System.Linq;

namespace AnagramDetection
{
    class Program
    {


        static void Main(string[] args)
        {
            var anagramDetector = new AnagramDetector();
            var test1 = anagramDetector.GetNumberOfAnagramOccurences("AdnBndAndBdaBn", "dAn");
            var test2 = anagramDetector.GetNumberOfAnagramOccurences("AbrAcadAbRa", "cAda");


            Console.WriteLine($"test1 no --> {test1} works? {test1 == 4}");
            Console.WriteLine($"test1 no --> {test2} works? {test2 == 2}");
            Console.ReadKey();
        }


        private static int _Occurences(string parent, string child)
        {
            int occurences = 0;
            if (child.Length > parent.Length)
                return 0;

            for (int i = 0; i <= (parent.Length - child.Length); i++)
            {
                var parentSub = parent.Substring(i, child.Length);

                if (_IsAnagram(parentSub, child))
                    occurences++;
            }
            return occurences;
        }


        private static bool _IsAnagram(string s, string t)
        {
            var s1 = s.OrderBy(c => c);
            var t1 = t.OrderBy(c => c);

            return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
        }


        private static bool _IsAnagram2(string s, string t)
        {

            for (int i = 0; i < t.Length; i++)
            {
                var n = s.IndexOf(t[i]);
                if (n < 0)
                    return false;
                s = s.Remove(n, 1);
            }
            return String.IsNullOrEmpty(s);
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");



        //}
    }
}
