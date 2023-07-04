using System.Diagnostics.Contracts;
using System.Threading;

namespace Observer;

internal class LogFileReader : IDisposable
{
    private readonly string _logFileName;
    private readonly Action<string> _logEntrySubscriber;
    private static readonly TimeSpan ChekFileInterval = TimeSpan.FromSeconds(5);
    private readonly Timer _timer;

    public LogFileReader(string logFileName, Action<string> logEntrySubscriber)
    {
        Contract.Requires(File.Exists(logFileName));

        _logEntrySubscriber = logEntrySubscriber;
        _logFileName = logFileName;
        _timer = new Timer(CheckFile, null, ChekFileInterval, ChekFileInterval);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    private void CheckFile(object o = null)
    {
        foreach (var logEntry in ReadNewLogEntries())
        {
        }
    }

    private IEnumerable<object> ReadNewLogEntries()
    {
        throw new NotImplementedException();
    }
}