namespace API.Entities.OrderAggregate;

public enum OrderStatus
{
    Pending,
    PaymentReveived,
    PaymentFailed,
    PaymentMismatch
}
