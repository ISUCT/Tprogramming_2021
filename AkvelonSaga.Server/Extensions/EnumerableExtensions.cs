using System;
using System.Collections.Generic;
using System.Linq;

namespace AkvelonSaga.Server.Extensions
{
    public static class EnumerableExtensions
    {
        private static readonly Random Random = new();

        public static T GetRandomValue<T>(this IReadOnlyCollection<T> collection)
        {
            var index = Random.Next(0, collection.Count);
            return collection.ElementAt(index);
        }
    }
}
