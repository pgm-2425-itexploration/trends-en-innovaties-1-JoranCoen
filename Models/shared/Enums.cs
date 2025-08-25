namespace Models.Shared
{
    public enum PaymentMethod
    {
        CreditCard = 0,
        PayPal = 1,
        BankTransfer = 2,
    }

    public enum OrderStatus
    {
        Pending = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 4,
        Cancelled = 8,
    }

    public enum PopupType
    {
        Success = 0,
        Danger = 1,
    }
}
