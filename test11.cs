// using System;

// namespace Test11
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string cleaned = "";
//             Console.WriteLine("Enter a word, phrase, or sentence:");
//             string word = Console.ReadLine();

//             foreach (char c in word.ToLower())
//             {
//                 if (char.IsLetterOrDigit(c))
//                 {
//                     cleaned += c;
//                 }
//             }

//             char[] reversedArray = cleaned.ToCharArray();
//             Array.Reverse(reversedArray);
//             string reversed = new string(reversedArray);

     
//             if (cleaned == reversed)
//             {
//                 Console.WriteLine("This is palindrome.");
//             }
//             else
//             {
//              Console.WriteLine("not a palindrome!");
//             }
//         }
//     }
// }
