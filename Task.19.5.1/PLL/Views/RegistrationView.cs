using System;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;
using Task._19._5._1.PLL.Helpers;

namespace Task._19._5._1.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;
        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.WriteLine("Для создания нового профиля введите ваше имя: ");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            userRegistrationData.LastName = Console.ReadLine();

            Console.Write("Пароль: ");
            userRegistrationData.Password = Console.ReadLine();

            Console.Write("Почтовый адрес: ");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                userService.Register(userRegistrationData);

                ConsoleMessage.Show("Ваш профиль успешно создан. Теперь Вы можете войти в систему под своими учетными данными.", ConsoleColor.Green);
            }

            catch (ArgumentNullException)
            {
                ConsoleMessage.Show("Введите корректное значение.", ConsoleColor.Red);
            }

            catch (Exception ex)
            {
                ConsoleMessage.Show("Произошла ошибка при регистрации: " + ex.Message, ConsoleColor.Red);
            }
        }
    }
}
