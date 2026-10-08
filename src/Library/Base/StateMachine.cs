using System.Collections.Generic;

public abstract class StateMachine<T>
{
    private List<State<T>> states = new List<State<T>>();

    public List<State<T>> States
    {
        get
        {
            return this.states;
        }
    }

    public State<T> CurrentState { get; protected set; }

    public void AddState(State<T> state)
    {
        foreach (State<T> item in this.states)
        {
            if (item.GetType() == state.GetType())
            {
                return;
            }
        }

        this.states.Add(state);
    }
}