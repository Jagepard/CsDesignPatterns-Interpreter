/*
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;

namespace CsDesignPatterns_Interpreter
{
    internal class Interpreter : IInterpreter
    {
        private readonly List<Album> _registry = new List<Album>();

        public void Interpret(string input)
        {
            var exploded = input.Split(' ');

            foreach (var value in exploded)
            {
                if (int.TryParse(value, out var number))
                {
                    GetDataFromRegistry(exploded, _registry[number - 1]);
                }
            }
        }

        public void AddAlbumToRegistry(Album album)
        {
            _registry.Add(album);
        }

        private static void GetDataFromRegistry(IEnumerable<string> exploded, IAlbum item)
        {
            string album = "", author = "";

            foreach (var value in exploded)
            {
                switch (value)
                {
                    case "album":
                        album = item.GetName();
                        break;
                    case "author":
                        author = item.GetAuthor();
                        break;
                }
            }

            Console.WriteLine("{0} {1}", album, author);
        }
    }
}
