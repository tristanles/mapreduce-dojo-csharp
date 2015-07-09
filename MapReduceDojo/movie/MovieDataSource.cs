using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MapReduceDojo.movie
{
    public class MovieDataSource : IDataSource {
        private readonly List<String> _movies;

        public MovieDataSource(String fileName)
        {
            _movies = File.ReadAllLines(fileName).ToList();
        }

        public IEnumerator<String> GetIterator()
        {
            return _movies.GetEnumerator();
        }

        public int Size()
        {
            return _movies.Count;
        }
    }
}