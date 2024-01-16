public class ClassInts :
    IEquatable<ClassInts>,
    IComparable<ClassInts>
{
    public int Prop1 { get; set; }
    public int Prop2 { get; set; }
    public int Prop3 { get; set; }

    public override int GetHashCode()
    {
        // unchecked only needed if you're compiling with arithmetic checks enabled
        // (the default compiler behaviour is *disabled*, so most folks won't need this)
        unchecked // Overflow is fine, just wrap
        {
            var hash = 13 /*17*/;
            hash = (hash * 7 /*23*/) + Prop1.GetHashCode();
            hash = (hash * 7 /*23*/) + Prop2.GetHashCode();
            hash = (hash * 7 /*23*/) + Prop3.GetHashCode();
            return hash;
        }
    }

    public bool Equals(ClassInts other)
    {
        if (other is null)
            return false;

        return Prop1 == other.Prop1 && Prop2 == other.Prop2 && Prop3 == other.Prop3;
    }

    public int CompareTo(ClassInts other)
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