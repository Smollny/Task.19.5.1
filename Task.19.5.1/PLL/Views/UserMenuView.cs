using System;
using System.Linq;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;

namespace Task._19._5._1.PLL.Views
{
    public class UserMenuView
    {
        UserService userService;
        public UserMenuView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine($"Входящие сообщения: {user.IncomingMessages.Count()}");
                Console.WriteLine($"Исходящие сообщения: {user.OutgoingMessages.Count()}");
                Console.WriteLine($"Мои друзья: {user.Friends.Count()}");

                Console.WriteLine("Просмотреть информацию о моём профиле (нажмите 1)");
                Console.WriteLine("Редактировать мой профиль (нажмите 2)");
                Console.WriteLine("Добавить в друзья (нажмите 3)");
                Console.WriteLine("Написать сообщение (нажмите 4)");
                Console.WriteLine("Просмотреть входящие сообщения (нажмите 5)");
                Console.WriteLine("Просмотреть исходящие сообщения (нажмите 6)");
                Console.WriteLine("Просмотреть моих друзей (нажмите 7)");
                Console.WriteLine("Выйти из профиля (нажмите 8)");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.userInfoView.Show(user);
                            break;
                        }
                    case "2":
                        {
                            Program.userDataUpdateView.Show(user);
                            user = userService.FindById(user.Id);
                            break;
                        }

                    case "3":
                        {
                            Program.addingFriendView.Show(user);
                            user = userService.FindById(user.Id);
                            break;
                        }

                    case "4":
                        {
                            Program.messageSendingView.Show(user);
                            user = userService.FindById(user.Id);
                            break;
                        }

                    case "5":
                        {

                            Program.userIncomingMessageView.Show(user.IncomingMessages);
                            break;
                        }

                    case "6":
                        {
                            Program.userOutcomingMessageView.Show(user.OutgoingMessages);
                            break;
                        }

                    case "7":
                        {
                            Program.userFriendView.Show(user.Friends);
                            break;
                        }
                }
            }
        }
    }
}
