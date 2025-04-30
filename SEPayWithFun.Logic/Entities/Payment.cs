namespace SEPayWithFun.Logic.Entities;

/// <summary>
/// Represents a payment entity with details about the transaction.
/// </summary>
[Table("Payments")]
[Index(nameof(CardNumber), nameof(TurnoverTime), IsUnique = true)]
public partial class Payment : VersionEntityObject
{
    /// <summary>
    /// Gets or sets the card number used for the payment. Maximum length is 16 characters.
    /// </summary>
    [MaxLength(16)]
    public string CardNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date when the payment was executed.
    /// </summary>
    public DateTime ExecutionDate { get; set; }

    /// <summary>
    /// Gets or sets the time when the turnover occurred.
    /// </summary>
    public DateTime TurnoverTime { get; set; }

    /// <summary>
    /// Gets or sets the name of the dealer involved in the transaction. Maximum length is 128 characters.
    /// </summary>
    [MaxLength(128)]
    public string DealerName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the location of the dealer involved in the transaction. Maximum length is 128 characters.
    /// </summary>
    [MaxLength(128)]
    public string DealerLocation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the turnover amount for the payment.
    /// </summary>
    public decimal Turnover { get; set; }

    /// <summary>
    /// Gets or sets an optional note for the payment. Maximum length is 1024 characters.
    /// </summary>
    [MaxLength(1024)]
    public string? Note { get; set; }
}
