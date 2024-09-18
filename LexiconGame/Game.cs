

using System.Data;

namespace LexiconGame
{
    internal class Game
    {
        private Map map= null!;
        private Hero hero = null!;

        public Game()
        {
        }

        internal void run()
        {
            Initializer();
            Play();

        }

        private void Play()
        {
            throw new NotImplementedException();
        }

        private void Initializer()
        {
            //ToDo :Read from config maybe
            map = new Map(width: 10, height: 10);
            hero = new Hero();
        }
    }
}