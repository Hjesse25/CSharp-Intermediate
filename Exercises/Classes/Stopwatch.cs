namespace Classes;

public class Stopwatch
{
    private DateTime _startTime;
    private DateTime _endTime;
    private bool _running;

    public void Start()
    {
        if (!_running)
        {
            _running = true;
            _startTime = DateTime.Now;
            Console.WriteLine("Stopwatch has started..");
        }
        else
        {
            throw new InvalidOperationException("Stopwatch cannot be started twice.");
        }
    }

    public void Stop()
    {
        if (_running)
        {
            _running = false;
            _endTime = DateTime.Now;
            Console.WriteLine("Stopwatch ended.");
        }
    }

    public TimeSpan GetInterval()
    {
        return _endTime - _startTime;
    }
}