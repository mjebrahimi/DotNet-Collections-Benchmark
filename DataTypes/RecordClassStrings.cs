public record RecordClassStrings(string Prop1, string Prop2, string Prop3) :
    IComparable<RecordClassStrings>
{
    public int CompareTo(RecordClassStrings other)
    {
        if (other is null)
            return 1;

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