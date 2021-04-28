using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureServiceBus.Common
{
    public class MessageConverter
    {
        public static string TextMessage(Message mySbMsg)
        {
            var messageBody = Encoding.UTF8.GetString(mySbMsg.Body, 0, mySbMsg.Body.Length);
            var messageBodyObject = Helper.ConvertToObject<string>(messageBody);
            return messageBodyObject;
        }
    }
}
