using System;

namespace HAL_9000.Models
{
    public static class Settings
    {
        //public static string Url { get; set; } = @"http://localhost:54159/";
        public static string Url { get; set; } = @"https://8fa213cf.ngrok.io/{0}";
        public static string Name { get; set; } = @"Kekistan_Ambassy_Bot";
        public static string Token { get; set; } = @"598866502:AAGlC__riVtJLRhWsnivRZMfYG500zgyKLw";
        public const string Path = @"update";
        public static Random GetRandom = new Random();
    }
}