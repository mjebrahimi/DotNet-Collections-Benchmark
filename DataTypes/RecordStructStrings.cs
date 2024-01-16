public record struct RecordStructStrings(string Prop1, string Prop2, string Prop3) : IComparable<RecordStructStrings>
{
    public int CompareTo(RecordStructStrings other)
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
