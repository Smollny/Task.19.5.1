using System;
using Task._19._5._1.BLL.Exceptions;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;
using Task._19._5._1.PLL.Helpers;

namespace Task._19._5._1.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;
        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Введите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = userService.Authenticate(authenticationData);

                ConsoleMessage.Show("Вы успешно вошли в социальную сеть! \nДобро пожаловать " + user.FirstName, ConsoleColor.Green);

                Program.userMenuView.Show(user);
            }

            catch (WrongPasswordException)
            {
                ConsoleMessage.Show("Пароль не корректный!", ConsoleColor.Red);
            }

            catch (UserNotFoundException)
            {
                ConsoleMessage.Show("Пользователь не найден!", ConsoleColor.Red);
            }

        }
    }
}
