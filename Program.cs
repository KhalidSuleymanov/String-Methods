using System;
using System.Drawing;

namespace MyHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "rehim", "salman", "elcin", "Nuru" };

            Console.WriteLine(HasValue(names, "leman"));

            int[] numbers = { 45, 23, 45, 456, 67, 787, 3, 422, 454, 57, 87 };

            Console.WriteLine(HasValue(numbers, 45));

            Console.WriteLine(HasValue(numbers, new int[] { 100, 67, 300 }));


            string word = "Hello World!";

            var result = Substring(word, 4);

            Console.WriteLine(word);
            Console.WriteLine(result);



            string email;

            do
            {
                Console.WriteLine("Email daxil edin:");
                email = Console.ReadLine();


            } while (FindIndex(email, '@') == -1);


            #region HOME TASKS.

            #region Task 1: Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir).
            string polo = "BMW is fast car";
            var result1 = PoloWord(polo);
            Console.WriteLine(result);
            #endregion

            #region Task 2: Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın).
            Console.WriteLine("Zehmet olmasa yazini daxil edin");
            string word1 = Console.ReadLine();
            int count = 1;
            Console.WriteLine(FindNumber(word, count));

            #endregion


            #region Task 3: Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
            #region Misalçün verilmiş arraydə {4, -3, 10, -24}  dəyərləridirsə methoddan geriyə {4, 10} dəyərli array qayıdır.
            int[] pape = { 1, -2, 3, -4, -5, 6, 7, -8 };
            var result5 = SedateNumbers(pape);

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion


            #region Task 4: Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
            string[] words = { "Hello", "Sa8lam", "Nane", "Keri4m", "Xaliq", "Lale" };
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.WriteLine(FoundNum(words, arr));

            #endregion

            #region Task 5: Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. 
            #region Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.

            string myWord = "     Hello";
            var result2 = IndexOf(myWord);
            Console.WriteLine(result2);

            #endregion
            #endregion

            #region Task 6: Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod.
            string myPolo = "  Hello World";
            var result3 = NewWord(myPolo);
            Console.WriteLine(result3);

            #endregion
            #endregion
        }


        static bool HasValue(string[] arr, string value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }



        static bool HasValue(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }




        static bool HasValue(int[] arr, int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == values[i])
                        return true;
                }

                if (HasValue(arr, values[i]))
                {
                    return true;
                }
            }
            return false;
        }



        static bool IsDigit(char cr)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == cr)
                    return true;
            }

            return false;
        }


        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                    return true;
            }

            return false;
        }



        static int FindIndex(string str, char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                    return i;
            }

            return -1;
        }



        static string Substring(string str, int index)
        {
            string newStr = "";

            for (int i = 0; i < index; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }


        #region Home Tasks

        #region
        static string PoloWord(string polo)
        {
            
            string newString = "";

            for (int i = 0; i < polo.Length; i++)
            {
                if (polo[i] != ' ')
                {
                    newString = newString + polo[i];

                }
                if (polo[i] == ' ')
                {
                    newString = newString + " ";
                    break;
                }
            }
            return newString;
        }
        #endregion

        #region
        static int FindNumber(string word, int count)
        {
            
            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == ' ')
                {
                    count++;
                }
            }
            return count;
            
        }
        #endregion

        #region
        static int[] SedateNumbers(int[] arr)
        {
            
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    counter++;
                }
            }

            int[] result = new int[counter];
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    result[count] = arr[i]; 
                    count++;
                }
            }
            return result;
            
        }
        #endregion

        #region
        static int FoundNum(string[] words, char[] arr)
        {
            
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (words[i][j] == arr[c])
                        {
                            count++;
                        }
                    }
                }
            }
            if(count == 0)
            {
                return 0;
            }
            
            return count;
        }
        #endregion

        #region
        static string IndexOf(string myWord)
        {
            string newWord = "";
            for(int j = 0; j < myWord.Length; j++)
            {
                if(myWord[j] != ' '){
                    newWord = newWord + myWord[j];
                    break;
                }
            }
            return newWord;

        }
        #endregion

        #region
        static string NewWord(string myPolo)
        {
            string wordStr = "";
            bool isWord = false;
            for(int i = 0; i < myPolo.Length;i++) 
            {
                if (myPolo[i] != ' ')
                {
                    wordStr = wordStr + myPolo[i];
                    isWord= true;
                }
                if (myPolo[i] == ' ' && isWord == true)
                {
                    wordStr= wordStr + myPolo[i];   
                }
            }
            return wordStr;
        }
        #endregion

        #endregion
    }
}
