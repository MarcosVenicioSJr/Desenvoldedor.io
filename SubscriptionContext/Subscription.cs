using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
  public class Subscription : Base
  {
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool isInactive => EndDate <= DateTime.Now;
  }
}