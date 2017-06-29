namespace DistanceMatrix.Core.Logging
{
    using Domain.Enums;
    using log4net;
    using log4net.Config;

    public class Logger : ILogger
    {
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger()
        {
            BasicConfigurator.Configure();
        }

        /// <summary>
        /// The trace.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="args">The arguments.</param>
        public void Trace(EventType eventType, string eventDescription, params object[] args)
        {
            logger.Info(string.Format("{0} | EventType: {1} | Event Description: {2}", LogLevel.Trace, eventType, eventDescription));
        }

        /// <summary>
        /// The debug.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="args">The arguments.</param>
        public void Debug(EventType eventType, string eventDescription, params object[] args)
        {
            logger.Debug(string.Format("{0} | EventType: {1} | Event Description: {2}", LogLevel.Debug, eventType, eventDescription));
        }

        /// <summary>
        /// Log information.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="args">The arguments.</param>
        public void Info(EventType eventType, string eventDescription, params object[] args)
        {
            logger.Info(string.Format("{0} | EventType: {1} | Event Description: {2}", LogLevel.Info, eventType, eventDescription));
        }

        /// <summary>
        /// Log warning.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="args">The arguments.</param>
        public void Warn(EventType eventType, string eventDescription, params object[] args)
        {
            logger.Warn(string.Format("{0} | EventType: {1} | Event Description: {2}", LogLevel.Warn, eventType, eventDescription));
        }

        /// <summary>
        /// Log error.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="args">The arguments.</param>
        public void Error(EventType eventType, string eventDescription, params object[] args)
        {
            logger.Error(string.Format("{0} | EventType: {1} | Event Description: {2}", LogLevel.Error, eventType, eventDescription));
        }

        /// <summary>
        /// The fatal.
        /// </summary>
        /// <param name="eventType">The event type.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="args">The arguments.</param>
        public void Fatal(EventType eventType, string eventDescription, params object[] args)
        {
            logger.Fatal(string.Format("EventType: {0} | Event Description: {1}", eventType, eventDescription));
        }

        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="exceptionDetails">The exception details.</param>
        /// <param name="logLevel">The log level.</param>
        public void LogMessage(string eventDescription, string exceptionDetails, LogLevel logLevel)
        {
            logger.Info(string.Format("{0} | Event Description: {1} | Exception: {2}", logLevel, eventDescription, exceptionDetails));
        }

        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="eventType">Type of the event.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="logLevel">The log level.</param>
        public void LogMessage(EventType eventType, string eventDescription, LogLevel logLevel)
        {
            logger.Info(string.Format("{0} | Event Type: {1} | Event Description: {2}", logLevel, eventType, eventDescription));
        }

        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="eventType">Type of the event.</param>
        /// <param name="eventDescription">The event description.</param>
        /// <param name="exceptionDetails">The exception details.</param>
        /// <param name="logLevel">The log level.</param>
        public void LogMessage(EventType eventType, string eventDescription, string exceptionDetails, LogLevel logLevel)
        {
            logger.Info(string.Format("{0} | Event Type: {1} | Event Description: {2} | Exception: {3}", logLevel, eventType, eventDescription, exceptionDetails));
        }
    }
}