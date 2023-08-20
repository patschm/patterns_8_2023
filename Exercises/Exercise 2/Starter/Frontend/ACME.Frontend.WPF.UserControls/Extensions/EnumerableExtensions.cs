using ACME.DataLayer.Entities;
using System.Collections.Generic;

namespace ACME.Frontend.WPF.UserControls.Extensions;

internal static class ListHelper
{
    public static IEnumerable<T> Concatenate<T>(params IEnumerable<T>[] List) where T: Review
    {
        foreach (IEnumerable<T> element in List)
        {
            foreach (T subelement in element)
            {
                yield return subelement;
            }
        }
    }
}
