
using Bridge.Stays;

namespace Bridge
{
    public class Zoo
    {
        private List<Stay> stays = new List<Stay>();

        public void Open()
        {
            foreach(Stay v in stays)
            {
                v.Rammel();
            }
        }
        public void Add(Stay v)
        {
            stays.Add(v);
        }
    }
}
