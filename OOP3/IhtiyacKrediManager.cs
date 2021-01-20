using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            throw new NotImplementedException();
        }

        public void BiSeyYap()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");

        }
    }
}
