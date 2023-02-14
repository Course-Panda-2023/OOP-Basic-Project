enum GuitarType
{
    Classical,
    Acoustic,
    Electric
}

class Guitarist : Person // don't inherit from competitor because he can't on his own
{   
    GuitarType GuitarType;
    public Guitarist(string name, uint age, GuitarType guitarType) : base(name, age)
    {
        this.GuitarType = guitarType;
    }
}