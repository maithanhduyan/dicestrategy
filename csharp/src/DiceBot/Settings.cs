using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.Sample.Bot
{
    public static class Settings
    {
        // Change to your own key.
        // Your own key is linked to your account, so any new accounts created from within your software
        // will be credited as referrals by you.

#if DEBUG
        public const string ApiKey = "07630a3a892944429aeaee68e76afedc";
#else
        public const string ApiKey = "07630a3a892944429aeaee68e76afedc";
#endif


        // Change at least "Dice.Sample.Bot"
        public static readonly string DataFileDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Dice.Sample.Bot");

        static Settings()
        {
            Directory.CreateDirectory(DataFileDirectory);
        }
    }
}
