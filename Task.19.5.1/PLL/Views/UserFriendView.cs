using System;
using System.Collections.Generic;
using System.Linq;
using Task._19._5._1.BLL.Models;

namespace Task._19._5._1.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья");

            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас нет друзей");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine($"Почтовый адрес друга: {friend.Email}. Имя друга: {friend.FirstName}. Фамилия друга: {friend.LastName}");
            });
        }
    }
}
