using System;
using System.Collections.Generic;
using System.Linq;
using Task._19._5._1.BLL.Models;

namespace Task._19._5._1.PLL.Views
{
    public class UserOutcomingMessageView
    {
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            Console.WriteLine("Исходящие сообщения");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("Исходящих сообщений нет");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine($"Кому: {message.RecipientEmail}. \n\tТекст сообщения: {message.Content}");
            });
        }
    }
}
