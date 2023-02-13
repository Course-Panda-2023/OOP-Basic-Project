
using System;
using System.Threading;


public abstract class Competitor: Member{

    public Competitor(MemberName name): base(name){
        if (Metadata.MemberNameToType[name] != MemberType.Competitor){
            throw new Exception($"{name} is not a competitor");
        }
    }

    public abstract string StartSinging(); // the competitor (single singer or band) starts to sing and the function returns the lyrics
}