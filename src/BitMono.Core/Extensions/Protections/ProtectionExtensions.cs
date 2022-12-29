﻿namespace BitMono.Core.Extensions.Protections;

public static class ProtectionExtensions
{
    public static bool TryGetDoNotResolveAttribute(this Type source, [AllowNull] out DoNotResolveAttribute attribute, bool inherit = false)
    {
        attribute = source.GetCustomAttribute<DoNotResolveAttribute>(inherit);
        if (attribute == null) 
        {
            return false;
        }
        return true;
    }
    public static bool TryGetDoNotResolveAttribute(this IProtection source, [AllowNull] out DoNotResolveAttribute attribute)
    {
        return TryGetDoNotResolveAttribute(source.GetType(), out attribute);
    }
    public static bool TryGetDoNotResolveAttribute(this IPacker source, [AllowNull] out DoNotResolveAttribute attribute)
    {
        return TryGetDoNotResolveAttribute(source.GetType(), out attribute);
    }
    public static bool TryGetDoNotResolveAttribute<TProtection>([AllowNull] out DoNotResolveAttribute attribute) where TProtection : IProtection
    {
        return TryGetDoNotResolveAttribute(typeof(TProtection), out attribute);
    }
    public static string GetName(this Type source, bool inherit = false)
    {
        var protectionNameAttribute = source.GetCustomAttribute<ProtectionNameAttribute>(inherit);
        if (protectionNameAttribute != null)
        {
            if (string.IsNullOrWhiteSpace(protectionNameAttribute.Name) == false)
            {
                return protectionNameAttribute.Name;
            }
            else
            {
                return source.Name;
            }
        }
        else
        {
            return source.Name;
        }
    }
    public static string GetName(this IProtection source)
    {
        return source.GetType().GetName(inherit: false);
    }
    public static string GetName(this IPacker source)
    {
        return source.GetType().GetName(inherit: false);
    }
    public static string GetName<TProtection>() where TProtection : IProtection
    {
        return GetName(typeof(TProtection), inherit: false);
    }
}