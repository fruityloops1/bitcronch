using System;

namespace BitCronch
{
    public class Program
    {
        static void Main(string[] args)
        {
            string outputFile;
            switch (args.Length)
            {
                case 0:
                {
                    Console.WriteLine(Messages.English.NoArgs);
                    Console.WriteLine(Messages.English.Usage);
                    break;
                }
                case 1:
                {
                    outputFile = args[0] + ".bbmp.png";
                    Cruncher.Crunch(args[0]).Save(outputFile);
                    break;
                }
                case 2:
                {
                    Console.WriteLine(Messages.English.InvalidArgs);
                    break;
                }
                case 3:
                {
                    if (args[0] == "-o") outputFile = args[1];
                    else if (args[1] == "-o") outputFile = args[2];
                    else
                    {
                        outputFile = "";
                        Console.WriteLine(Messages.English.InvalidArgs);
                    }
                    if (args[0] == "-o") Cruncher.Crunch(args[2]).Save(outputFile);
                    else if(args[1] == "-o") Cruncher.Crunch(args[0]).Save(outputFile);     
                    else Console.WriteLine(Messages.English.InvalidArgs);             
                    break;
                }
            }
        }
    }
}