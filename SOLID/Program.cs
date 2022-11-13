#region Before
//interface IUser
//{
//    bool Login(string username, string password);
//    bool Register(string username, string password, string email);
//    void LogError(string error);
//    bool SendEmail(string emailContent);
//}
#endregion

#region After
/*
 In Single Responsibility Principle 
1. Each class and module should focus on a single task at a time
2. Everything in the class should be related to that single purpose
3. There can be many members in the class as long as they related to the single responsibility
4. With SRP, classes become smaller and cleaner
5. Code is less fragile 
 */

interface IUser
{
    bool Login(string username, string password);
    bool Register(string username, string password, string email);
}
interface ILogger
{
    void LogError(string error);
}

interface IEmail
{
    bool SendEmail(string emailContent);
}

#endregion