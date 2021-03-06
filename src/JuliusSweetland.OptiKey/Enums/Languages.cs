using JuliusSweetland.OptiKey.Properties;
using System.Globalization;

namespace JuliusSweetland.OptiKey.Enums
{
    public enum Languages
    {
        CatalanSpain,
        CroatianCroatia,
        CzechCzechRepublic,
        DanishDenmark,
        DutchBelgium,
        DutchNetherlands,
        EnglishCanada,
        EnglishUK,
        EnglishUS,
        FrenchCanada,
        FrenchFrance,
        GermanGermany,
        GreekGreece,
        ItalianItaly,
        JapaneseJapan,
        KoreanKorea,
        PolishPoland,
        PortuguesePortugal,
        RussianRussia,
        SlovenianSlovenia,
        SlovakSlovakia,
        SpanishSpain,
        TurkishTurkey
    }

    public static partial class EnumExtensions
    {
        public static string ToDescription(this Languages language)
        {
            switch (language)
            {
                case Languages.CatalanSpain: return Resources.CATALAN_SPAIN;
                case Languages.CroatianCroatia: return Resources.CROATIAN_CROATIA;
                case Languages.CzechCzechRepublic: return Resources.CZECH_CZECH_REPUBLIC;
                case Languages.DanishDenmark: return Resources.DANISH_DENMARK;
                case Languages.DutchBelgium: return Resources.DUTCH_BELGIUM;
                case Languages.DutchNetherlands: return Resources.DUTCH_NETHERLANDS;
                case Languages.EnglishCanada: return Resources.ENGLISH_CANADA;
                case Languages.EnglishUK: return Resources.ENGLISH_UK;
                case Languages.EnglishUS: return Resources.ENGLISH_US;
                case Languages.FrenchCanada: return Resources.FRENCH_CANADA;
                case Languages.FrenchFrance: return Resources.FRENCH_FRANCE;
                case Languages.GermanGermany: return Resources.GERMAN_GERMANY;
                case Languages.GreekGreece: return Resources.GREEK_GREECE;
                case Languages.ItalianItaly: return Resources.ITALIAN_ITALY;
                case Languages.JapaneseJapan: return Resources.JAPANESE_JAPAN;
                case Languages.KoreanKorea: return Resources.KOREAN_KOREA;
                case Languages.PolishPoland: return Resources.POLISH_POLAND;
                case Languages.PortuguesePortugal: return Resources.PORTUGUESE_PORTUGAL;
                case Languages.RussianRussia: return Resources.RUSSIAN_RUSSIA;
                case Languages.SlovakSlovakia: return Resources.SLOVAK_SLOVAKIA;
                case Languages.SlovenianSlovenia: return Resources.SLOVENIAN_SLOVENIA;
                case Languages.SpanishSpain: return Resources.SPANISH_SPAIN;
                case Languages.TurkishTurkey: return Resources.TURKISH_TURKEY;
            }

            return language.ToString();
        }

        public static CultureInfo ToCultureInfo(this Languages language)
        {
            switch (language)
            {
                case Languages.CatalanSpain: return CultureInfo.GetCultureInfo("ca-ES");
                case Languages.CroatianCroatia: return CultureInfo.GetCultureInfo("hr-HR");
                case Languages.CzechCzechRepublic: return CultureInfo.GetCultureInfo("cs-CZ");
                case Languages.DanishDenmark: return CultureInfo.GetCultureInfo("da-DK");
                case Languages.DutchBelgium: return CultureInfo.GetCultureInfo("nl-BE");
                case Languages.DutchNetherlands: return CultureInfo.GetCultureInfo("nl-NL");
                case Languages.EnglishUS: return CultureInfo.GetCultureInfo("en-US");
                case Languages.EnglishUK: return CultureInfo.GetCultureInfo("en-GB");
                case Languages.EnglishCanada: return CultureInfo.GetCultureInfo("en-CA");
                case Languages.FrenchCanada: return CultureInfo.GetCultureInfo("fr-CA");
                case Languages.FrenchFrance: return CultureInfo.GetCultureInfo("fr-FR");
                case Languages.GermanGermany: return CultureInfo.GetCultureInfo("de-DE");
                case Languages.GreekGreece: return CultureInfo.GetCultureInfo("el-GR");
                case Languages.ItalianItaly: return CultureInfo.GetCultureInfo("it-IT");
                case Languages.JapaneseJapan: return CultureInfo.GetCultureInfo("ja-JP");
                case Languages.KoreanKorea: return CultureInfo.GetCultureInfo("ko-KR");
                case Languages.PolishPoland: return CultureInfo.GetCultureInfo("pl-PL");
                case Languages.PortuguesePortugal: return CultureInfo.GetCultureInfo("pt-PT");
                case Languages.RussianRussia: return CultureInfo.GetCultureInfo("ru-RU");
                case Languages.SlovakSlovakia: return CultureInfo.GetCultureInfo("sk-SK");
                case Languages.SlovenianSlovenia: return CultureInfo.GetCultureInfo("sl-SI");
                case Languages.SpanishSpain: return CultureInfo.GetCultureInfo("es-ES");
                case Languages.TurkishTurkey: return CultureInfo.GetCultureInfo("tr-TR");
            }
            return CultureInfo.GetCultureInfo("en-GB");
        }

        public static bool SupportsAutoSpace(this Languages language)
        {
            switch (language)
            {
                case Languages.JapaneseJapan:
                    return false;

                case Languages.KoreanKorea:
                    return false;

                default:
                    return true;
            }
        }
    }
}
