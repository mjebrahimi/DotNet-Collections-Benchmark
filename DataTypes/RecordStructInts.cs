public record struct RecordStructInts(int Prop1, int Prop2, int Prop3) : IComparable<RecordStructInts>
{
    public int CompareTo(RecordStructInts other)
    {
        var result = Prop1.CompareTo(other.Prop1);
        if (result == 0)
        {
            result = Prop2.CompareTo(other.Prop2);
            if (result == 0)
                result = Prop3.CompareTo(other.Prop3);
        }
        return result;
    }
}
