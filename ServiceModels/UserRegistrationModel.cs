﻿namespace QuizAppApi.ServiceModels
{
    public class UserRegistrationModel
    {
        public required string UserName {get; set;}
        public required string Email {get; set;}
        public required string Password {get; set;}
    }
}