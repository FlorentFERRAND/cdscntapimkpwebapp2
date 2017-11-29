
namespace cdscntapimkpwebapp1.Enumeration
{
    public enum EnvironmentEnum
    {
        Production,
        Preproduction,
        Local/*,
        Recette,
        Dev,
        Sandbox,
        Local*/
    }

    public enum OrderStatesEnum
    {
        CancelledByCustomer,
        WaitingForSellerAcceptation,
        AcceptedBySeller,
        PaymentInProgress,
        WaitingForShipmentAcceptation,
        Shipped,
        RefusedBySeller,
        AutomaticCancellation,
        PaymentRefused,
        ShipmentRefusedBySeller,
        RefusedNoShipment
    }
}
