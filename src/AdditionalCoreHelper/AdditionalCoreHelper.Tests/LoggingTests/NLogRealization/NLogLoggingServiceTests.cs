using NLog;
using NLog.Config;
using NLog.Targets;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalCoreHelper.Tests.LoggingTests.NLogRealization
{
    [TestFixture]
    public class NLogLoggingServiceTests
    {
        private readonly Exception _ex;

        public NLogLoggingServiceTests()
        {
            _ex = new Exception("test");
        }

        [TestCase("trace log message")]
        [TestCase("trace log message {0}", 1)]
        public void Trace_WriteMessage(string message, params object[] args)
        {
            var compareMessage = string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Trace, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Trace(message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("trace log message")]
        [TestCase("trace log message {0}", 1)]
        public void Trace_WithException_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Trace, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Trace(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("debug log message")]
        [TestCase("debug log message {0}", 1)]
        public void Debug_WriteMessage(string message, params object[] args)
        {
            var compareMessage = string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Debug, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Debug(message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("debug log message")]
        [TestCase("debug log message {0}", 1)]
        public void Debug_WithException_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Debug, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Debug(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("info log message")]
        [TestCase("info log message {0}", 1)]
        public void Info_WriteMessage(string message, params object[] args)
        {
            var compareMessage = string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Info, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Info(message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("info log message")]
        [TestCase("info log message {0}", 1)]
        public void Info_WithException_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Info, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Info(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("warn log message")]
        [TestCase("warn log message {0}", 1)]
        public void Warn_WriteMessage(string message, params object[] args)
        {
            var compareMessage = string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Warn, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Warn(message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("warn log message")]
        [TestCase("warn log message {0}", 1)]
        public void Warn_WithException_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Warn, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Warn(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("error log message")]
        [TestCase("error log message {0}", 1)]
        public void Error_WriteMessage(string message, params object[] args)
        {
            var compareMessage = string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Error, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Error(message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("error log message")]
        [TestCase("error log message {0}", 1)]
        public void Error_WithException_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Error, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Error(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("fatal log message")]
        [TestCase("fatal log message {0}", 1)]
        public void Fatal_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Fatal, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Fatal(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }

        [TestCase("fatal log message")]
        [TestCase("fatal log message {0}", 1)]
        public void Fatal_WithException_WriteMessage(string message, params object[] args)
        {
            var compareMessage = _ex.Message + " " + string.Format(message, args);
            var tw = new StringWriter();
            var config = new LoggingConfiguration();
            var consoleTarget = new ConsoleTarget();
            var rule = new LoggingRule("*", LogLevel.Fatal, consoleTarget);
            var loggingService = AdditionalCorehelper.Logging.NLogRealization.LoggingService.GetLoggingService();

            consoleTarget.Layout = @"${exception} ${message}";
            config.LoggingRules.Add(rule);
            config.AddTarget("console", consoleTarget);
            Console.SetOut(tw);
            LogManager.Configuration = config;
            loggingService.Fatal(_ex, message, args);
            var containsRes = tw.ToString().Contains(compareMessage);

            Assert.True(containsRes, tw.ToString());
        }
    }
}
