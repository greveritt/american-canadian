using System;
namespace CanadianTranslator
{
    class Canadian 
    {
        static void Main() 
        {
            Console.WriteLine("What would you like me to translate for you?");
            String input = Console.ReadLine();
            String output = null;
            //if (input.EndsWith(".") || input.EndsWith("?") || input.EndsWith("!"))
            //{
            //    Console.WriteLine("Bad input, brah. Can't make this into Canadian, dawg, without a bit of preprocessing. Be right back, dude. American slang endearment terms.");
            //    output = input;
            //    output = output.Substring(0, output.Length - 1);
            //    output = String.Concat(output, ", eh?");
            //    Console.WriteLine(output);
            //}
            output = RemovePunctuation(input);
            //else
            //{
                output = String.Concat(output, ", eh?");
                Console.WriteLine(output);
            //}

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static String RemovePunctuation(String unpruned)
        {
            String pruned = unpruned;
            if (pruned.EndsWith(".") || pruned.EndsWith("?") || pruned.EndsWith("!"))
            {
                //Console.WriteLine("Bad input, brah. Can't make this into Canadian, dawg, without a bit of preprocessing. Be right back, dude. American slang endearment terms.");
                pruned = pruned.Substring(0, pruned.Length - 1);
                pruned = RemovePunctuation(pruned);
                return pruned;
            }
            else
                return pruned;
        }
    }
}