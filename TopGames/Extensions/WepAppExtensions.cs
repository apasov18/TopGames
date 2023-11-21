namespace TopGames.Extensions
{
    public static class WepAppExtensions
    {
        public static void UseLocalization(this WebApplication app)
        {
            var cultures = new string[] { "en", "ru" };
            var localizationOption = new RequestLocalizationOptions()
                .SetDefaultCulture(cultures[0])
                .AddSupportedCultures(cultures)
                .AddSupportedUICultures(cultures);

            app.UseRequestLocalization(localizationOption);

        }
    }
}
