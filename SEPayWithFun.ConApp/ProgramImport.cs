using System;

namespace SEPayWithFun.ConApp;

partial class Program
{
    static partial void ImportData()
    {
        var filepath = Path.Combine("data", "payment_dataset.csv");
        var entities = File.ReadAllLines(filepath)
            .Skip(1)
            .Select(line => line.Split(';'))
            .Select(values => new
            {
                CardNumber = values[0],
                ExecutionDate = DateTime.Parse(values[1]),
                TurnoverTime = DateTime.Parse(values[2]),
                DealerName = values[3],
                DealerLocation = values[4],
                Turnover = decimal.Parse(values[5]),
                Note = values.Length > 6 ? values[6] : null
            })
            .ToList();
    }
}
