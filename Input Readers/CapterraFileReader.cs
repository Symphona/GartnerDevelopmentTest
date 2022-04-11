using GartnerDevelopmentTest.Model;
using System.Text.RegularExpressions;
using YamlDotNet;
using YamlDotNet.Serialization;

namespace GartnerDevelopmentTest.Input_Readers
{
    public class CapterraFileReader : IFileReader
    {
        //private static Deserializer Deserializer = (Deserializer)new DeserializerBuilder().Build();
        //I hate doing manual YAML loading but I don't have time to fight the deserialiser :/
        private readonly Regex getValueRegex = new Regex("\"(?<value>.+?)\"", RegexOptions.Compiled);


        List<MySqlRowEntity> IFileReader.Read(string v)
        {
            IEnumerable<string> file = File.ReadAllLines(v);
            if (file == null || file.Count() == 0)
                throw new Exception("Failed reading Yaml file");

            List<MySqlRowEntity> result = new List<MySqlRowEntity>();
            file = file.Skip(1); //header line


            for (int i = 0; i < file.Count() / 4; i++)
            {
                var lines = file.Skip(i*4).Take(4).ToArray();
                var tags = getValueRegex.Match(lines[1]).Groups[1].Value;
                var name = getValueRegex.Match(lines[2]).Groups[1].Value;
                var twitter = getValueRegex.Match(lines[3]).Groups[1].Value;

                result.Add(new MySqlRowEntity(tags.Split(','), name, twitter));
            }

            return result;
        }
    }
}
