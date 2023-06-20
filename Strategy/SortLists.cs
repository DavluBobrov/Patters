// Пример стратегии для сортировки

namespace Strategy;

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString() => string.Format("Id = {0}, Name = {1}", Id, Name);
}

internal class EmployeeByIdComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x.Id.CompareTo(y.Id);
    }
}

public static class SortLists
{
    public static void Sort()
    {
        var list = new List<Employee>();
    }
}