using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyCore.BaseProject.Localization
{
    public static class BaseProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BaseProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BaseProjectLocalizationConfigurer).GetAssembly(),
                        "MyCore.BaseProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
