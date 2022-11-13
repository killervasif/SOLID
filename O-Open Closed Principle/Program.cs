#region Before
//public class Employee
//{
//    Employee() { }
//    public Employee(int id, string name, string type)
//    {
//        this.ID = id;
//        this.Name = name;
//        this.EmployeeType = type;
//    }

//    public int ID { get; set; }
//    public string EmployeeType { get; set; }
//    public string Name { get; set; }

//    public decimal CalculateBonus(decimal salary)
//    {
//        if (this.EmployeeType == "Permanent")
//            return salary * .1M;
//        else
//            return salary * .05M;
//    }
//}
#endregion

#region After
/*
 What if I do not follow Open closed principle during a requirement enhancement in the development process.  
In that case, we end up with the following disadvantages 
1. If a class or a function always allows the addition of new logic, as a developer we end up testing the entire functionality along
with the requirement
2. Also, as a developer we need to ensure to communicate the scope of the changes to the Quality Assurance team in advance so that
they can gear up for enhanced regression testing along with the feature testing. 
3. Step 2 above is a costly process to adapt for any organization  
4. Not following the Open Closed Principle breaks the SRP since the class or function might end up doing multiple tasks. 
5. Also, if the changes are implemented on the same class, Maintenance of the class becomes difficult since the code of the class 
increases by thousands of unorganized lines.
 */
public abstract class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Employee()
    {
    }
    public Employee(int id, string name)
    {
        this.ID = id; this.Name = name;
    }
    public abstract decimal CalculateBonus(decimal salary);

    public override string ToString()
    {
        return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
    }
}

public class PermanentEmployee : Employee
{
    public PermanentEmployee()
    { }

    public PermanentEmployee(int id, string name) : base(id, name)
    { }
    public override decimal CalculateBonus(decimal salary)
    {
        return salary * .1M;
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
        return salary * .05M;
    }
}
#endregion