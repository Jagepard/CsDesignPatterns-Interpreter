/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace CsDesignPatterns_Interpreter
{
    class Album : IAlbum
    {
        private readonly string name;
        private readonly string author;

        public Album(string author, string name)
        {
            this.name = name;
            this.author = author;
        }

        public string GetAuthor()
        {
            return this.author;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
