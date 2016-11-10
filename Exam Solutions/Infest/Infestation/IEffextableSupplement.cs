namespace Infestation
{
    public interface IEffextableSupplement
    {
        int AggressionEffect { get; }
        int AggressionEffect { get; }
        int HealthEffect { get; }
        int HealthEffect { get; }
        int PowerEffect { get; }
        int PowerEffect { get; }

        void ReactTo(ISupplement otherSupplement);
    }
}