﻿using System;
using HandlebarsDotNet;
using Microsoft.Extensions.DependencyInjection;
using Orchard.Services;
using Orchard.Settings;

namespace Orchard.Tokens
{
    public static class StandardTokens
    {
        public static void RegisterStandardTokens(this IHandlebars handlebars)
        {
            handlebars.RegisterHelper("dateformat", (output, context, arguments) =>
            {
                IServiceProvider serviceProvider = context.ServiceProvider;
                var clock = serviceProvider.GetRequiredService<IClock>();
                var siteService = serviceProvider.GetRequiredService<ISiteService>();
                var site = siteService.GetSiteSettingsAsync().Result;
                var timeZone = TimeZoneInfo.FindSystemTimeZoneById(site.TimeZone);
                var now = TimeZoneInfo.ConvertTime(clock.UtcNow.UtcDateTime, TimeZoneInfo.Utc, timeZone);

                var format = arguments[0].ToString();
                output.Write(now.ToString(format));
            });
        }
    }
}
