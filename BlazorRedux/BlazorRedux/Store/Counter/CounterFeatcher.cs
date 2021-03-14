using Fluxor;

namespace BlazorRedux.Store.Counter
{
    public class CounterFeatcher : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => new CounterState(0);
    }
}
