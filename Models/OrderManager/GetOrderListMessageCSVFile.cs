using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;

namespace cdscntapimkpwebapp1.Models.OrderManager
{
    public class GetOrderListMessageCSVFile : Message
    {
        public Task<OrderListMessage> _OrderListMessage { get; set; }

        public GetOrderListMessageCSVFile(GetOrderListRequestCSVFile MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _OrderListMessage = _MarketplaceAPIService.GetOrderListAsync(MyRequest._HeaderMessage, MyRequest._OrderFilter);
            XmlSerializer xmlSerializer = new XmlSerializer(_OrderListMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }

        public GetOrderListMessageCSVFile()
        {
            _Environment = Enumeration.EnvironmentEnum.Preproduction;

        }
    }
}