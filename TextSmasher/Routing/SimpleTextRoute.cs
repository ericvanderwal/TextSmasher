using TextSmasher.Core;
using TextSmasher.Core.Commands;
using TextSmasher.Core.Commands.Text;

namespace TextSmasher.Routing
{
    public static class SimpleTextRoute
    {
        public static ISimpleText Parse(ConversionType conversionType)
        {
            switch (conversionType)
            {
                case ConversionType.ToUpperAll:
                    return new ToUpperAll();
                    break;
                case ConversionType.ToLowerAll:
                    return new ToLowerAll();
                    break;
                default:
                    return null;
            }
        }
    }
}