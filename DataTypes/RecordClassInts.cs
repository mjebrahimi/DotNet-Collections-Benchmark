public record RecordClassInts(int Prop1, int Prop2, int Prop3) :
    IComparable<RecordClassInts>
{
    public int CompareTo(RecordClassInts other)
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
