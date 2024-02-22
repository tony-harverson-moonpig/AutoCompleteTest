using System;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AutoCompleteTest
{
    public class AutoCompleteTest
    {
        private readonly ILogger<AutoCompleteTest> _logger;

        public AutoCompleteTest(ILogger<AutoCompleteTest> logger)
        {
            _logger = logger;
        }

        [Function(nameof(AutoCompleteTest))]
        public void Run([ServiceBusTrigger("{your-queuename-here}", Connection = "ServiceBusConnection", AutoCompleteMessages = false)] ServiceBusReceivedMessage message)
        {
            _logger.LogInformation("Message ID: {id}", message.MessageId);
            _logger.LogInformation("Message Body: {body}", message.Body);
            _logger.LogInformation("Message Content-Type: {contentType}", message.ContentType);
        }
    }
}
