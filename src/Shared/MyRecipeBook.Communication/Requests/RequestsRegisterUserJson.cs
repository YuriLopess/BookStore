﻿namespace MyRecipeBook.Communication.Requests
{
    public class RequestsRegisterUserJson
    {
        public string name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;   
    }
}
