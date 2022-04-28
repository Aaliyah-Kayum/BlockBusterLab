namespace BlockBusterLab
{
    internal class Movie
    {
        internal bool Title;
        internal bool Category;
        private string v1;
        private string v2;

        public Movie(string v1, object animation, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal object PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}