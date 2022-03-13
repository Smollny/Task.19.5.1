using System;
using Task._19._5._1.BLL.Exceptions;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;
using Task._19._5._1.PLL.Helpers;

namespace Task._19._5._1.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;

        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя, которого хотите добавить в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                userService.AddFriend(userAddingFriendData);

                ConsoleMessage.Show("Вы успешно добавили пользователя в друзья!", ConsoleColor.Green);
            }

            catch (UserNotFoundException)
            {
                ConsoleMessage.Show("Пользователя с указанным почтовым адресом не существует!", ConsoleColor.Red);
            }

            catch (Exception)
            {
                ConsoleMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!", ConsoleColor.Red);
            }
        }
    }
}
