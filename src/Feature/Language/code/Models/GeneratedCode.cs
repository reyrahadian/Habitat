
using System;
using Sitecore.Data.Fields;
using System.Collections.Generic;

namespace Sitecore.Feature.Language.Poco
{
    public interface ILanguageSettings 
    {
   
         IEnumerable<Guid> SupportedLanguages { get; set; }
    }
}
