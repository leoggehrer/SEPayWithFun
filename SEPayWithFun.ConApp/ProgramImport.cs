#if GENERATEDCODE_ON
namespace SEPayWithFun.ConApp;

partial class Program
{
    static partial void ImportData()
    {
        var filepath = Path.Combine("data", "payment_dataset.csv");
        var entities = File.ReadAllLines(filepath)
            .Skip(1)
            .Select(line => line.Split(';'))
            .Select(values => new Logic.Entities.Payment
            {
                CardNumberWithoutSpaces = values[0],
                TurnoverTime = DateTime.Parse(values[1]),
                ExecutionDate = DateTime.Parse(values[2]),
                DealerName = values[3],
                DealerLocation = values[4],
                Turnover = decimal.Parse(values[5].Replace(".", ",")),
                Note = values.Length > 6 ? values[6] : null
            })
            .ToList();

        var index = 0;
        using var context = CreateContext();

        foreach (var entity in entities)
        {
            try
            {
                index++;
                context.PaymentSet.Add(entity);
                context.SaveChanges();
            }
            catch (Logic.Modules.Exceptions.BusinessRuleException ex)
            {
                Console.WriteLine($"Error on line {index} {entity}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error on line {index}: {ex.InnerException}");
            }
            finally
            {
                context.RejectChanges();
            }
        }
    }
}
#endif