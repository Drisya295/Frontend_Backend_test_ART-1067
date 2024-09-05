
using System.Collections.Generic;
using System;

public class Cafe
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    public string Logo { get; set; }
    public string Location { get; set; }
    public List<Employee> Employees { get; set; }
}
