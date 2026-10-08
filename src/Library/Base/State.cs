using System.Collections.Generic;
public class State<T>
{
    private List<Transition<T>> transitions;

    public State()
    {
        transitions = new List<Transition<T>>();
    }

    public void AddTransition(Transition<T> transition)
    {
        transitions.Add(transition);
    }

    public State<T> GetNextState(T input)
    {
        foreach (Transition<T> transition in transitions)
        {
            if (transition.Input.Equals(input))
            {
                return transition.NextState;
            }
        }

        return this;
    }
    public virtual void Enter()
    {
    }
    public virtual void Exit()
    {
    }
}