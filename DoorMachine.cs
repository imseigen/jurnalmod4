using System;

public class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State currentState = State.Terkunci;

    public void Lock()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void Unlock()
    {
        currentState = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }
}