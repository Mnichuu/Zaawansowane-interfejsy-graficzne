using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Utils
{
    public static class Randomizer {
        private static Random random = new Random();
        public static int GetRandomNumber(int min, int max) {
            return random.Next(min, max);
        }
        public static T GetRandomElement<T>(IEnumerable<T> collection) {
            int index = GetRandomNumber(0, collection.Count());
            return collection.ElementAt(index);
        }
        public static List<T> GetRandomElements<T>(IEnumerable<T> collection, int count) {
            return collection.OrderBy(x => random.Next()).Take(count).ToList();
        }
    }
}
