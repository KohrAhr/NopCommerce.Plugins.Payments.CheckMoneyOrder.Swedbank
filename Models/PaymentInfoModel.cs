using Nop.Web.Framework.Models;

namespace Nop.Plugin.Payments.CheckMoneyOrder.Swedbank.Models
{
    public record PaymentInfoModel : BaseNopModel
    {
        public string DescriptionText { get; set; }
    }
}