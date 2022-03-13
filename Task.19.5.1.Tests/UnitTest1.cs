using NUnit.Framework;
using Task._19._5._1.BLL.Exceptions;
using Task._19._5._1.BLL.Models;
using Task._19._5._1.BLL.Services;

namespace Task._19._5._1.Tests
{
    public class Tests
    {
        [Test]
        public void Authenticate_MustThrowUserNotFoundException()
        {
            UserService userService = new UserService();

            UserAuthenticationData userAuthenticationData = new UserAuthenticationData
            {
                Email = "user@mail.ru",
                Password = "Qwerty"
            };

            Assert.Throws<UserNotFoundException>(() => userService.Authenticate(userAuthenticationData));
        }

        [Test]
        public void Authenticate_MustThrowWrongPasswordException()
        {
            UserService userService = new UserService();

            UserAuthenticationData userAuthenticationData = new UserAuthenticationData
            {
                Email = "smollny@mail.ru",
                Password = "Qwerty"
            };

            Assert.Throws<WrongPasswordException>(() => userService.Authenticate(userAuthenticationData));
        }

        [Test]
        public void AddFriend_MustThrowUserNotFoundException()
        {
            UserService userService = new UserService();

            var userAddingFriendData = new UserAddingFriendData { UserId = 1, FriendEmail = "qwerty@mail.ru" };

            Assert.Throws<UserNotFoundException>(() => userService.AddFriend(userAddingFriendData));
        }
    }
}