using Hospital.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Text;

namespace Hospital.Infrastructure.Server
{
    public class LanguageManager(ResourceManager resourceManager)
    {
        public string GetValue(Language language, string key)
        {
            return resourceManager.GetString(key, new CultureInfo(language.ToString()))
                ?? throw new KeyNotFoundException($"language:{language}\nResource Key:{key}");
        }
    }
}
