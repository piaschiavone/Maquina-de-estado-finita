public class Transition<T>
{
    public State<T> NextState { get; set; }
    public T Input { get; set; }

    public Transition(State<T> nextState, T input)
    {
        NextState = nextState;
        Input = input;
    }

    public bool IsTriggeredBy(T input)
    {
        return Input.Equals(input);
    }
}