namespace PZ12.Controllers;

public class CounterViewModel {
    public int Counter { get; set; } = 0;
    public void CountUp() {
        Counter++;
    }
}
