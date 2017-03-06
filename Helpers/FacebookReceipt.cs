using Newtonsoft.Json;
using System.Collections.Generic;

namespace BotTools.Helpers
{
    public class FacebookReceipt
    {
        [JsonProperty("type")]
        public string Type => "template";

        [JsonProperty("payload")]
        public ReceiptPayload Payload { get; set; }


        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class ReceiptPayload
    {
        [JsonProperty("template_type")]
        public string TemplateType => "receipt";

        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("order_url")]
        public string OrderUrl { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("elements")]
        public List<ReceiptElement> Elements { get; set; }

        [JsonProperty("address")]
        public ReceiptAddress Address { get; set; }

        [JsonProperty("summary")]
        public ReceiptSummary Summary { get; set; }

        public List<ReceiptAdjustments> Adjustments { get; set; }
    }

    public class ReceiptElement
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ReceiptAddress
    {
        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ReceiptSummary
    {
        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        [JsonProperty("shipping_cost")]
        public double ShippingCost { get; set; }

        [JsonProperty("total_tax")]
        public double TotalTax { get; set; }

        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }
    }

    public class ReceiptAdjustments
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}