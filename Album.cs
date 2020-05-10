/*
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace CsDesignPatterns_Interpreter
{
    internal class Album : IAlbum
    {
        private readonly string _name;
        private readonly string _author;

        public Album(string author, string name)
        {
            _name = name;
            _author = author;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
