namespace ZooExample.Adapters
{
    using ZooExample.Contracts;

    public class TurkeyToDuckAdapter : IDuck
    {
        private ITurkey turkey;

        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            this.turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                this.turkey.Fly();
            }
        }
    }
}
