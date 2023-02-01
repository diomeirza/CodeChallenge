using System.Linq;

class LinqBasic
{
    public Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
    {
        
        return employees.GroupBy(x => x.Company)
                        .Select(x => new { Company = x.Key, AverageAge = (int) Math.Floor(x.Average(y => y.Age)) })
                        .OrderBy(o => o.Company)
                        .ToDictionary(g => g.Company, g => g.AverageAge);
    }
    public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
    {
         return employees.GroupBy(x => x.Company)
                        .Select(x => new { Company = x.Key, EmpCount = (int) x.Count() })
                        .OrderBy(o => o.Company)
                        .ToDictionary(g => g.Company, g => g.EmpCount);
    }

    public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
    { 
        // employees.GroupBy(x => x.Company)
        //          .Select(s => new { Company = s.Key, Emp = s.Max(y => y.Age)})
        //          .ToDictionary(d => d.Company, d => d.Emp);    

        return employees.GroupBy(x => x.Company)
                        .Select(g => g.OrderByDescending(r => r.Age).First())
                        .ToDictionary(d => d.Company, d => d);
                        
    }
}

public class Employee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string Company { get; set; }
    public Employee(string first, string last, int age, string company)
    {
        FirstName = first;
        LastName = last;
        Age = age;
        Company = company;
    }
}