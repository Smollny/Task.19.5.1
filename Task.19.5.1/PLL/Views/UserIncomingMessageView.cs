using System;
using System.Collections.Generic;
using System.Linq;
using Task._19._5._1.BLL.Models;

namespace Task._19._5._1.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Входящие сообщения");

            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("Входящих сообщения нет");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine($"От кого: {message.SenderEmail}. Текст сообщения: {message.Content}");
            });
        }
    }
}
