/* 
 * American to Canadian translator by Gregory R. Everitt, Copyright 2012
 * Converts American English to Canadian English using ground-breaking natural language recognition algorithms.
 */
using System;
namespace CanadianTranslator
{
    class Canadian 
    {
        /*
         * Copies contents of standard input into new variable removes all punctuation at the end of the sentence,
         * then then concatenates ", eh?" to end of string. 
         */
        static void Main() 
        {
            Console.WriteLine("What would you like me to translate for you?");
            String input = Console.ReadLine();
            String output = RemovePunctuation(input);
            output = String.Concat(output, ", eh?");
            Console.WriteLine(output);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /*
         * If String unpruned doesn't end with a period, quotation mark or exclamation point, then it returns that string.
         * If it does end with one of the above punctuation marks, then punctuation is removed from string and method calls itself
         * to see if there is any remaining punctuation at the end.
         */
        static String RemovePunctuation(String unpruned)
        {
            String pruned = unpruned;
            if (pruned.EndsWith(".") || pruned.EndsWith("?") || pruned.EndsWith("!"))
            {
                pruned = pruned.Substring(0, pruned.Length - 1);
                pruned = RemovePunctuation(pruned);
                return pruned;
            }
            else
                return pruned;
        }
    }
}