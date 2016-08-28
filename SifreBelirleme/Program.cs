using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreBelirleme
{
    class Program
    {
        //kullanıcıdan isim ve doğum yılı isteyelim. Belirle adında overload edilmiş 2 func. biri kullanıcı adı, diğer şifre belirleyecek

        static void Main(string[] args)
        {
            Console.Write("İsim giriniz:");
            string isim = Console.ReadLine();

            Console.Write("Doğum yılınız:");
            int yil = int.Parse(Console.ReadLine());

            string username = Belirle(isim, yil);
            string password = Belirle(yil, isim);
            Console.WriteLine("Username={0}\nPassword={1}",username,password);



            Console.ReadLine();
        }
        /// <summary>
        /// Kullanıcı için şifre oluşturur
        /// </summary>
        /// <param name="yil">Kullanıcının doğum yılı</param>
        /// <param name="isim">Kullanıcının adı</param>
        /// <returns></returns>
        static string Belirle(int yil, string isim)
        {
            return yil + isim;
        }
        /// <summary>
        /// Kullanıcı için isim oluşturur
        /// </summary>
        /// <param name="isim">Kullanıcının adı</param>
        /// <param name="yil">Kullanıcının doğum yılı</param>
        /// <returns></returns>
         static string Belirle(string isim, int yil)
        {
            return isim + yil;
        }

       
        

    }
}
