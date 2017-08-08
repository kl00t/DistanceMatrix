namespace Travel.Api.Kernel.Converters
{

    using System.Collections.Generic;
    using AutoMapper;
    using Core.Helpers;

    public class StringFormatConverter : ITypeConverter<string, string[]>,  ITypeConverter<string[], List<string>>
    {
        string[] ITypeConverter<string, string[]>.Convert(ResolutionContext context)
        {
            if (context.IsSourceValueNull)
            {
                return new string[0];
            }

            var sourceValue = context.SourceValue as string;
            return StringHelper.SplitStringToArray('|', sourceValue);
        }

        List<string> ITypeConverter<string[], List<string>>.Convert(ResolutionContext context)
        {
            if (context.IsSourceValueNull)
            {
                return new List<string>();
            }

            var sourceValue = context.SourceValue as string[];
            return StringHelper.ConvertArrayToList(sourceValue);
        }
    }
}