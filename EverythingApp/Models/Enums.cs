namespace EverythingE.Models
{
    public enum UserRole
    {
        Customer = 0,
        Admin = 1
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}