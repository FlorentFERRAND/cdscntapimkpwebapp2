﻿using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace cdscntapimkpwebapp1.Models.OrderManager
{
    public class GetOrderListMessage: Message
        {
            public Task<OrderListMessage> _OrderListMessage { get; set; }

            public List<OrderStateEnum> orderStatesEnum { get; set; }

            public GetOrderListMessage(GetOrderListRequest MyRequest)
            {
                _Environment = MyRequest._EnvironmentSelected;
                GetService();
                _OrderListMessage = _MarketplaceAPIService.GetOrderListAsync(MyRequest._HeaderMessage, MyRequest._OrderFilter);
                XmlSerializer xmlSerializer = new XmlSerializer(_OrderListMessage.Result.GetType());

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;
            }

            public GetOrderListMessage()
            {
                _Environment = Enumeration.EnvironmentEnum.Preproduction;

            }

            

        }
    }


