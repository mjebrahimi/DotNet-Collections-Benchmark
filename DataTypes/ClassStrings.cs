public class ClassStrings :
    IEquatable<ClassStrings>,
    IComparable<ClassStrings>
{
    public string Prop1 { get; set; }
    public string Prop2 { get; set; }
    public string Prop3 { get; set; }

    public override int GetHashCode()
    {
        // unchecked only needed if you're compiling with arithmetic checks enabled
        // (the default compiler behaviour is *disabled*, so most folks won't need this)
        unchecked // Overflow is fine, just wrap
        {
            var hash = 13 /*17*/;
            hash = (hash * 7 /*23*/) + (Prop1?.GetHashCode() ?? 0);
            hash = (hash * 7 /*23*/) + (Prop2?.GetHashCode() ?? 0);
            hash = (hash * 7 /*23*/) + (Prop3?.GetHashCode() ?? 0);
            return hash;
        }
    }

    public bool Equals(ClassStrings other)
    {
        if (other is null)
            return false;

        return Prop1 == other.Prop1 && Prop2 == other.Prop2 && Prop3 == other.Prop3;
    }

    public int CompareTo(ClassStrings other)
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