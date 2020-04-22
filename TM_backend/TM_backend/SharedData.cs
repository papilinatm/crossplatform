using System.Collections.Generic;

namespace TM_backend
{
    public static class SharedData
    {
        public static List<string> Summaries { get; } = new List<string>
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
    }
}
