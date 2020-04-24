using System.Collections.Generic;
using TM_backend.Models;

namespace TM_backend
{
    public static class SharedData
    {
        public static List<string> Summaries { get; } = new List<string>
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static List<User> Users { get; } = new List<User>
        {
            new User(){ Login = "user", Password = "user" },
            new User(){ Login = "admin", Password = "admin" },
        };
    }
}
