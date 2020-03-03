/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Iterator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Interpreter interpreter = new Interpreter();

            interpreter.AddAlbumToRegistry(new Album("Korn", "Untouchables"));
            interpreter.AddAlbumToRegistry(new Album("Deftones", "Adrenaline"));

            interpreter.Interpret("album 2");
            interpreter.Interpret("album author 2");
            interpreter.Interpret("album author 1");
            interpreter.Interpret("author 1");
        }
    }
}
