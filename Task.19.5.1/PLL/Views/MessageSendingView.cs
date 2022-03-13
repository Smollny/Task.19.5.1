using System;
using Task._19._5._1.BLL.Exceptions;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;
using Task._19._5._1.PLL.Helpers;

namespace Task._19._5._1.PLL.Views
{
    public class MessageSendingView
    {
        UserService userService;
        MessageService messageService;
        public MessageSendingView(MessageService messageService, UserService userService)
        {
            this.messageService = messageService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var messageSendingData = new MessageSendingData();

            Console.Write("Введите почтовый адрес получателя: ");
            messageSendingData.RecipientEmail = Console.ReadLine();

            Console.WriteLine("Введите сообщение (не больше 5000 символов): ");
            messageSendingData.Content = Console.ReadLine();

            messageSendingData.SenderId = user.Id;

            try
            {
                messageService.SendMessage(messageSendingData);

                ConsoleMessage.Show("Сообщение успешно отправлено!", ConsoleColor.Green);

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                ConsoleMessage.Show("Пользователь не найден!", ConsoleColor.Red);
            }

            catch (ArgumentNullException)
            {
                ConsoleMessage.Show("Введите корректное значение!", ConsoleColor.Red);
            }

            catch (Exception)
            {
                ConsoleMessage.Show("Произошла ошибка при отправке сообщения!", ConsoleColor.Red);
            }

        }
    }
}
