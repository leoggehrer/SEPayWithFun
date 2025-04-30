using SEPayWithFun.Logic.Contracts;
using SEPayWithFun.Logic.Modules.Exceptions;

namespace SEPayWithFun.Logic.Entities;

public partial class Payment : IValidatableEntity
{
    /// <summary>
    /// Validates the payment entity based on business rules.
    /// </summary>
    /// <param name="context">The context in which the validation is performed.</param>
    /// <param name="entityState">The state of the entity being validated.</param>
    /// <exception cref="BusinessRuleException">Thrown when a business rule is violated.</exception>
    public void Validate(IContext context, EntityState entityState)
    {
        // A1
        if (CheckCreditCardNumber(CardNumber) == false)
        {
            throw new BusinessRuleException("Invalid credit card number!");
        }
        // A2
        if (TurnoverTime > ExecutionDate)
        {
            throw new BusinessRuleException("TurnoverTime must not be younger than ExecutionTime!");
        }
        // A4
        if (DealerName.IsNullOrEmpty())
        {
            throw new BusinessRuleException("DealerName must not be empty!");
        }
        // A5
        if (DealerLocation.IsNullOrEmpty())
        {
            throw new BusinessRuleException("DealerLocation must not be empty!");
        }
        // A6
        if (TurnoverTime > DateTime.UtcNow)
        {
            throw new BusinessRuleException("TurnoverTime must not be empty!");
        }
    }

    /// <summary>
    /// Checks whether the credit card number meets the requirements (Luhn algorithm).
    /// </summary>
    /// <param name="number">The credit card number to check.</param>
    /// <returns>True if the number is valid, otherwise false.</returns>
    public static bool CheckCreditCardNumber(string number)
    {
        var result = number != null && number.Length == 16 && number.All(c => char.IsDigit(c));
        var oddSum = 0;
        var evenSum = 0;

        for (int i = 0; result && number != null && i < number.Length - 1; i++)
        {
            if (i % 2 == 0)
                evenSum += SumOfDigits((number[i] - '0') * 2);
            else
                oddSum += (number[i] - '0');
        }

        var sum = evenSum + oddSum;
        var rest = sum % 10 == 0 ? 0 : 10 - (sum % 10);

        return result && number != null && number[^1] - '0' == rest;
    }
    /// <summary>
    /// Calculates the sum of the digits of a given number.
    /// </summary>
    /// <param name="number">The number whose digits are to be summed.</param>
    /// <returns>The sum of the digits of the number.</returns>
    public static int SumOfDigits(int number)
    {
        var result = 0;

        while (number != 0)
        {
            result += number % 10;
            number /= 10;
        }
        return result;
    }
}
