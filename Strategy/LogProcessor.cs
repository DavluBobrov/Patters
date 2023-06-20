/// пример Стратегии для сохранения логов

namespace Strategy;

/// <summary>
/// Модель логов
/// </summary>
internal class LogEntry
{
}

/// <summary>
/// на диаграмме это "Контекст"
/// </summary>
internal class LogProcessor
{
    /// <summary>
    /// вместо ILogReader, сюда помещается метод из конкретной стратегии, чтобы не делать
    /// интерфейс с 1-им методом. На диаграмме - это "Стратегия"
    /// </summary>
    private readonly Func<List<LogEntry>> _logImporter;

    /// <summary>
    /// конструктор для определения стратегии, вместо интерфейса - делегат
    /// </summary>
    /// <param name="logImporter">конкретная реализация стратегии</param>
    public LogProcessor(Func<List<LogEntry>> logImporter)
    {
        _logImporter = logImporter;
    }

    /// <summary>
    /// пример использования сохранения логов
    /// </summary>
    public void ProcessLogs()
    {
        foreach (var logEntry in _logImporter.Invoke())
        {
            SaveLogEntry(logEntry);
        }
    }

    private void SaveLogEntry(LogEntry logEntry)
    {
        throw new NotImplementedException();
    }
}