using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;

namespace dawg
{
    internal class Dog
    {
        private string DogName;

        public Dog(string name) { DogName = name; }

        public string GetDogName() { return DogName; }

        public void DogBark(string path) { SoundPlayer player = new SoundPlayer(path); player.Play(); }

    }
}
