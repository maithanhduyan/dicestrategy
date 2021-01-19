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
        public const string ApiKey = "861a6ff910d54607b5b5158a21f4c473";
#else
        public const string ApiKey = "CA3D5DCBAA8542B690086209B271B272";
#endif


        // Change at least "Dice.Sample.Bot"
        public static readonly string DataFileDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Dice.Sample.Bot");

        static Settings()
        {
            Directory.CreateDirectory(DataFileDirectory);
        }
    }
}
