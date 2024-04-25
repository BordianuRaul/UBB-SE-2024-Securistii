﻿using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMacrow.UserTests
{
    class FakeRepo : IUserRepository
    {
        private List<IUserTemplate> _users;
        public FakeRepo() { 
            _users = new List<IUserTemplate>();
        }
        public void AddUserToRepo(IUserTemplate User)
        {
            _users.Add(User);
        }

        public List<IUserTemplate> GetListOfUsers()
        {
            return _users;
        }

        public void RemoveUserFromRepo(IUserTemplate User)
        {
            _users.Remove(User);
        }

        public void UpdateUserIntoRepo(IUserTemplate olduser, IUserTemplate newuser)
        {
            _users.Remove(olduser);
            _users.Add(newuser);
        }
    }
    internal class UserServiceTests
    {

        [Test]
        public void TestAddingSuccessfullyABasicUserToTheRepo()
        {
            //Setup
            IUserRepository fakeRepo = new FakeRepo();
            UserService userService = new UserService(fakeRepo);

            //Act
            userService.AddBasicUser(1, "user1");

            //Assert
            Assert.AreEqual(1, fakeRepo.GetListOfUsers().Count);
        }

        [Test]
        public void TestAddingSuccessfullyAnAdminUserToTheRepo()
        {
            //Setup
            IUserRepository fakeRepo = new FakeRepo();
            UserService userService = new UserService(fakeRepo);

            //Act
            userService.AddAdminUser(1, "user1");

            //Assert
            Assert.AreEqual(1, fakeRepo.GetListOfUsers().Count);
        }

        [Test]
        public void TestRemovingSuccessfullyAUserFromTheRepo()
        {
            //Setup
            IUserRepository fakeRepo = new FakeRepo();
            UserService userService = new UserService(fakeRepo);
            userService.AddBasicUser(1, "user1");

            //Act
            userService.RemoveUser(1, "user1");

            //Assert
            Assert.AreEqual(0, fakeRepo.GetListOfUsers().Count);
        }

        [Test]
        public void TestUpdatingSuccessfullyAUserFromTheRepo()
        {
            //Setup
            IUserRepository fakeRepo = new FakeRepo();
            UserService userService = new UserService(fakeRepo);
            userService.AddBasicUser(1, "user1");

            //Act
            userService.UpdateUser(1, "user1", "user2");

            //Assert
            Assert.AreEqual(1, fakeRepo.GetListOfUsers().Count);
        }

        [Test]
        public void TestGettingListOfUsers()
        {
            //Setup
            IUserRepository fakeRepo = new FakeRepo();
            UserService userService = new UserService(fakeRepo);
            userService.AddBasicUser(1, "user1");

            //Act
            List<IUserTemplate> users = userService.GetListOfUsers();

            //Assert
            Assert.AreEqual(1, users.Count);
        }
    }
}
