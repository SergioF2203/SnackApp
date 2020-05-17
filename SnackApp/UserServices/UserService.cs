﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackApp.UserServices;

namespace SnackApp.UserServices
{
    public class UserService
    {
        List<User> _users;

        public UserService()
        {
            _users = UserInitialaizer.GetSampleUserData();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users.OrderByDescending(x => x.Score);
        }

        public User CreateUser(string name)
        {
            var user = new User();
            var existUser = _users.Select(x => x.Name);
            try
            {
                if (name == "")
                    throw new ArgumentException("Name is empty");
                if (existUser.Contains(name))
                    throw new ArgumentException("The User exists");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            user.Name = name;

            _users.Add(user);

            return user;
        }

        public void SaveScore(User user)
        {
            if (user.Name == null)
                return;
            _users.Add(user);
        }
    }
}
