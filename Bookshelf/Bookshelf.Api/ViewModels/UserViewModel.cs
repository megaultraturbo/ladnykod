﻿using System;

namespace Bookshelf.Api.ViewModels{

    public class UserViewModel
    {
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}