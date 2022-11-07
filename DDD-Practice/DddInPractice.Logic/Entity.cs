namespace DddInPractice.Logic;

public abstract class Entity : IEquatable<Entity>
{
    public long Id { get; set; }

    public override bool Equals(object? obj)
    {
        var other = obj as Entity;

        if (other == null) return false;

        if(ReferenceEquals(this, obj)) return true;

        if (GetType() != other.GetType()) return false;

        if (Id == 0 && other.Id == 0) return false;

        return Id == other.Id;
    }

    public static bool operator ==(Entity a, Entity b )
    {
        return Equals(a, b);
    }

    public static bool operator !=(Entity a, Entity b)
    {
        return !Equals(a, b);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public bool Equals(Entity? other)
    {
        return Equals((Entity?)other);
    }
}
