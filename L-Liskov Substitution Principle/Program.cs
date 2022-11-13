#region Before
//public abstract class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }

//    public Employee()
//    {
//    }

//    public Employee(int id, string name)
//    {
//        this.ID = id; this.Name = name;
//    }

//    public abstract decimal CalculateBonus(decimal salary);

//    public override string ToString()
//    {
//        return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
//    }
//}

//public class PermanentEmployee : Employee
//{
//    public PermanentEmployee()
//    { }

//    public PermanentEmployee(int id, string name) : base(id, name)
//    { }
//    public override decimal CalculateBonus(decimal salary)
//    {
//        return salary * .1M;
//    }
//}

//public class TemporaryEmployee : Employee
//{
//    public TemporaryEmployee()
//    { }

//    public TemporaryEmployee(int id, string name) : base(id, name)
//    { }
//    public override decimal CalculateBonus(decimal salary)
//    {
//        return salary * .05M;
//    }
//}

//public class ContractEmployee : Employee
//{
//    public ContractEmployee()
//    { }

//    public ContractEmployee(int id, string name) : base(id, name)
//    { }
//    public override decimal CalculateBonus(decimal salary)
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion

#region After
/*
 Implementation guidelines : In the process of development we should ensure that
1. No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.
2. We should also ensure that Clients should not know which specific subtype they are calling, nor should they need to know that.
The client should behave the same regardless of the subtype instance that it is given.
3. And last but not the least, New derived classes just extend without replacing the functionality of old classes
*/
interface IEmployee
{
    int ID { get; set; }
    string Name { get; set; }
    decimal GetMinimumSalary();
}

interface IEmployeeBonus
{
    decimal CalculateBonus(decimal salary);
}

public abstract class Employee : IEmployee, IEmployeeBonus
{
    public int ID { get; set; }

    public string Name { get; set; }

    public Employee()
    { }

    public Employee(int id, string name)
    {
        this.ID = id;
        this.Name = name;

    }

    public abstract decimal CalculateBonus(decimal salary);

    public override string ToString()
    {
        return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
    }

    public abstract decimal GetMinimumSalary();
}

public class PermanentEmployee : Employee
{
    public PermanentEmployee()
    { }

    public PermanentEmployee(int id, string name) : base(id, name)
    { }

    public override decimal CalculateBonus(decimal salary)
    {
        return (salary * .1M);
    }

    public override decimal GetMinimumSalary()
    {
        return 15000;
    }
}

public class TemporaryEmployee : Employee
{
    public TemporaryEmployee()
    { }

    public TemporaryEmployee(int id, string name) : base(id, name)
    { }

    public override decimal CalculateBonus(decimal salary)
    {
        return (salary * .05M);
    }

    public override decimal GetMinimumSalary()
    {
        return 5000;
    }
}

public class ContractEmployee : IEmployee
{
    public int ID { get; set; }

    public string Name { get; set; }
    public ContractEmployee()
    { }

    public ContractEmployee(int id, string name)
    {
        this.ID = id;
        this.Name = name;
    }

    public decimal GetMinimumSalary()
    {
        return 5000;
    }

    public override string ToString()
    {
        return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
    }
}
#endregion

