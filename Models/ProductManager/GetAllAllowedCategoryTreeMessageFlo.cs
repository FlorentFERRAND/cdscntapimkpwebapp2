using System.Collections.Generic;
using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;


namespace cdscntapimkpwebapp1.Models
{
    public class GetAllAllowedCategoryTreeMessageFlo : Message
    {
        public Task<CategoryTreeMessage> _AllCategoryTreeMessage { get; set; }


        public GetAllAllowedCategoryTreeMessageFlo(Request MyRequest)
        {

            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _AllCategoryTreeMessage = _MarketplaceAPIService.GetAllAllowedCategoryTreeAsync(MyRequest._HeaderMessage);
            //  XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;

        }

    }
}
