using System;

public class Points
{
    private int ctr;
    private string player;
    public int Ctr
    {
        get { return ctr; }
        set { ctr = value; }
    }
    
    public string Player
    {
        get { return player; }
        set { player = value; }
    }

    public void AddPoint()
    {
        ctr++;
    }

}
