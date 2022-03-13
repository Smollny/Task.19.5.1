using System;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;
using Task._19._5._1.PLL.Helpers;

namespace Task._19._5._1.PLL.Views
{
    public class UserDataUpdateView
    {
        UserService userService;
        public UserDataUpdateView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("Меня зовут:");
            user.FirstName = Console.ReadLine();

            Console.Write("Моя фамилия:");
            user.LastName = Console.ReadLine();

            Console.Write("Ссылка на моё фото:");
            user.Photo = Console.ReadLine();

            Console.Write("Мой любимый фильм:");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("Моя любимая книга:");
            user.FavoriteBook = Console.ReadLine();

            userService.Update(user);

            ConsoleMessage.Show("Ваш профиль успешно обновлён!", ConsoleColor.Green);
        }
    }
}
