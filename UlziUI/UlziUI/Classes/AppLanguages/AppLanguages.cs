using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Messages;

namespace UlziUI.Classes.AppLanguages
{
    #region AppLanguages
    public static class AppLanguages
    {
        public static readonly string ENGLISH_LANGUAGE_NAME = "English";

        private static Dictionary<string, AppLanguage> __languages = new Dictionary<string, AppLanguage>();

        static AppLanguages()
        {
            CurrentLanguage = new AppLanguage("");

            AddLanguage(new EnglishAppLanguage());

            SetLanguage(ENGLISH_LANGUAGE_NAME);
        }

        public static void SetLanguage(string languageDisplayName)
        {
            if ((CurrentLanguage == null) || (CurrentLanguage.DisplayName != languageDisplayName))
            {
                AppLanguage language = null;
                if (__languages.TryGetValue(languageDisplayName, out language))
                {
                    CurrentLanguage.Assign(language);
                    LanguageSelectedMessage.Send();
                }
            }
        }

        private static void AddLanguage(AppLanguage appLanguage)
        {
            __languages.Add(appLanguage.DisplayName, appLanguage);
        }

        public static AppLanguage CurrentLanguage { get; private set; }
    }
    #endregion
}
