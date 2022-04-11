using GartnerDevelopmentTest.Input_Readers;
using GartnerDevelopmentTest.SqlRepositories;

namespace GartnerDevelopmentTest
{
    class Program{

        public static int Main (string[] args){

            if (args.Length != 2)
            {
                Console.WriteLine("Expected parameters: [$product $filePath], expected Product values in: capterra, softwareadvice");
                return 1;
            }

            IFileReader reader;

            switch (args[0])
            {
                case "capterra":
                    Console.WriteLine("Capterra");
                    reader = new CapterraFileReader();
                    break;
                case "softwareadvice":
                    Console.WriteLine("SoftwareAdvice");
                    reader = new SoftwareAdviceFileReader();
                    break;
                default:
                    Console.WriteLine($"Expected product in: capterra, softwareadvice");
                    return 1;
            }

            //Use the chosen importer and run.
            try
            {
                var inputData = reader.Read(args[1]);

                MysqlWriter.Write(inputData);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }

            return 0;
        }
    }
}

