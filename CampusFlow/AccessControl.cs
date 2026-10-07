namespace CampusFlow;

public class AccessControl
{
    public bool CanAccess(string role, string section)
    {
        if (role == "Admin")
            return true;

        if (role == "Teacher")
            return section != "Users";

        if (role == "Student")
            return section == "Tasks" || section == "Deadlines"; 

        //if(role == "Student")
        //{
        //    return true; // сделали ошибку 
        //}

        return false; 
    }
}