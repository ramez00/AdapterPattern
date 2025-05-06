using PayrollSystem.Core;

namespace AdapterPattern.Core.Adapter;
public class PayItemAdapter
{
    private readonly PayItem _payItem;
    public PayItemAdapter(PayItem payItem)
    {
        _payItem = payItem;
    }
    public string Name => _payItem.Name;

    // Here we are using the Adapter pattern to change the behavior of the Value property
    public decimal Value => _payItem.IsDeduction ? -_payItem.Value : _payItem.Value;
}
