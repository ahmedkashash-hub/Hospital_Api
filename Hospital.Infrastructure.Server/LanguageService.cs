using Hospital.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Infrastructure.Server
{
    public class LanguageService(LanguageManager languageManager, ICurrentUserService currentUserService) : ILanguageService
    {
        public string GetMessage(string key)
        {
            return languageManager.GetValue(currentUserService.Language, key);
        }
    }
}
