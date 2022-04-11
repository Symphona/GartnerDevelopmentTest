using GartnerDevelopmentTest.Model;
using System.Text.Json;

namespace GartnerDevelopmentTest.Input_Readers
{
    public class SoftwareAdviceFileReader : IFileReader
    {
        List<MySqlRowEntity> IFileReader.Read(string v)
        {
            var entity = JsonSerializer.Deserialize<SoftwareAdviceJsonEntity>(File.ReadAllText(v));

            if (entity == null)
                throw new Exception("File is empty");

            return entity.products
                .Select(prod => new MySqlRowEntity(prod.categories, prod.title, prod.twitter))
                .ToList();
        }
    }
}
