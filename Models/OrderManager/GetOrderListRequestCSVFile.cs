using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.OrderManager
{
    public class GetOrderListRequestCSVFile : Request
    {
        public OrderFilter _OrderFilter { get; set; }
        public GetOrderListRequestCSVFile()
        {
            _OrderFilter = new OrderFilter();

        }

    }
}
