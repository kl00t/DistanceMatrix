namespace DistanceMatrix.Connector
{
    using System.Configuration;
    using Domain.Exceptions;

    /// <summary>
    /// Class to help get configuration settings.
    /// </summary>
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Gets the application setting.
        /// </summary>
        /// <param name="appSetting">The application setting.</param>
        /// <returns>
        /// Returns application setting.
        /// </returns>
        /// <exception cref="GoogleApiException"></exception>
        public static string GetAppSetting(string appSetting)
        {
            try
            {
                return ConfigurationManager.AppSettings[appSetting];
            }
            catch (ConfigurationErrorsException configurationErrorsException)
            {
                throw new GoogleApiException(configurationErrorsException.Message, configurationErrorsException.InnerException);
            }
        }
    }
}