using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Contract
{
    public interface ILanguageService
    {
        string GetMessage(string key);

    }
}
