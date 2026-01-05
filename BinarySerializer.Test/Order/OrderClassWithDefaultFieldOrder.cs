namespace BinarySerialization.Test.Order;

public class OrderClassWithDefaultFieldOrder
{
    [FieldOrder] public byte NameLength { get; set; }

    [FieldOrder]
    [FieldLength(nameof(NameLength))]
    public string Name { get; set; }
        
    [FieldOrder] public byte Second { get; set; }

    [FieldOrder] public byte First { get; set; }
}