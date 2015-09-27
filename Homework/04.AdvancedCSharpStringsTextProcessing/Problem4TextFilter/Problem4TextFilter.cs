//namespace Problem4TextFilter
//{
//    using System;
//    using System.Text;

//    internal class Problem4TextFilter
//    {
//        public static int LenghtWord;

//        private static string Result;

//        private static string LastResult;

//        //private static string WordForBann(string word) //priema string ot kluchovi dumi i dava sledvashta takava
//        //{
//        //    int count = 0;
//        //    string[] words = word.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
//        //    string emptyOrError = "";

//        //    if (words.Length != null)
//        //    {
//        //        if (Result != null)
//        //        {
//        //            count++;
//        //            emptyOrError = words[count];
//        //            return emptyOrError;
//        //        }
//        //    }
//        //    emptyOrError = words[count];
//        //}
//        private static int LenghtFromString(string word) //dava int s kolko "*" da se zapulni stringa // shte go vzeme ot WordForBan
//        {
//            LenghtWord = word.Length;
//            return LenghtWord;
//        }

//        private static string CheakingHowManyTimesIsReapiting(string consola, string keyWord) //pravi string ot chisla //IndexOf
//        {
//            int countForKey = 0;
//            string indexiMatch = "";

//            for (int i = 0; i < consola.Length; i++)
//            {
//                int index = consola.IndexOf(keyWord, countForKey);
//                if (i != index)
//                {
//                    continue;
//                }

//                indexiMatch += " " + index;
//                countForKey = index + 1;
//            }

//            return indexiMatch;
//        }

//        private static int[] FromStringToArray(string reapiting) //priema string ot chisla
//        {
//            int[] arr = new int[reapiting.Length - 1];
//            string[] numbers = reapiting.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                arr[i] = int.Parse(numbers[i]);
//            }

//            return arr;
//        }

//        private static string ReplacingTheString(string format, int[] array) //Zamestvame stringa sus ***
//        {
//            StringBuilder sb = new StringBuilder();

//            for (int i = 0, count = 0; i < format.Length; i++)
//            {
//                if (i == array[count])
//                {
//                    for (int j = 0; j < LenghtWord; j++)
//                    {
//                        sb.Append('*');
//                    }

//                    i = i + LenghtWord -1;
//                    if (array.Length - 1 != 0 )
//                    {
//                        count++;
//                    }
//                }
//                else
//                {
//                    sb.Append(format[i]);
//                }
//            }

//            return sb.ToString();
//        }

//        private static void Main()
//        {
//            string wordOrSimbolForBann = Console.ReadLine();
//            string readingLine = Console.ReadLine();
//            LenghtFromString(wordOrSimbolForBann); //WordForBann(string word) trqbva da go vklucha

//            Result = ReplacingTheString(readingLine, FromStringToArray(CheakingHowManyTimesIsReapiting(readingLine, wordOrSimbolForBann)));
//            Console.WriteLine(Result);
//            //if (LenghtWord != 0)
//            //{
//            //    LastResult = ReplacingTheString(
//            //        Result,
//            //        FromStringToArray(CheakingHowManyTimesIsReapiting(Result, WordForBann(wordOrSimbolForBann))));
//            //}
//            //if (LastResult != null)
//            //{
//            //    Console.WriteLine(LastResult);
//            //}
//            //else
//            //{
//            //    Console.WriteLine(Result);
//            //}
//        }
//    }
//}