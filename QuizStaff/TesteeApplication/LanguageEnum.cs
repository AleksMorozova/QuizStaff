﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteeApplication
{
    public enum LanguageEnum
    {
        None = -1,
        English = 0,
        Russian = 1
    }

    public static class LanguageConvert
    {
        public static string ConvertFromEnum(LanguageEnum language)
        {
            switch (language)
            {
                case LanguageEnum.English:
                    return "en-US";
                case LanguageEnum.Russian:
                    return "ru-RU";
                default :
                    return "en-US";
            }
        }

        public static LanguageEnum ConvertToEnum(string language)
        {
            switch (language)
            {
                case "en-US" :
                    return LanguageEnum.English;
                case "ru-RU":
                    return LanguageEnum.Russian;
                default:
                    return LanguageEnum.English;
            }
        }
    }
}