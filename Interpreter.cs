/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;

namespace CsDesignPatterns_Iterator
{
    class Interpreter : IInterpreter
    {
        private readonly List<Album> registry = new List<Album>();

        public void Interpret(string input)
        {
            string[] exploded = input.Split(' ');

            foreach (string value in exploded)
            {
                if (Int32.TryParse(value, out int number))
                {
                    this.GetDataFromRegistry(exploded, this.registry[number - 1]);
                }
            }
        }

        public void AddAlbumToRegistry(Album album)
        {
            this.registry.Add(album);
        }

        private void GetDataFromRegistry(string[] exploded, Album item)
        {
            string album = "", author = "";

            foreach (string value in exploded) {
                if (value == "album")
                {
                    album = item.GetName();
                }

                if (value == "author")
                {
                    author = item.GetAuthor();
                }
            }

            Console.WriteLine("{0} {1} \n", album, author);
        }
    }
}
