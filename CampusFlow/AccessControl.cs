namespace CampusFlow;

public class AccessControl
{
    public bool CanAccess(string role, string section)
    {
        if (role == "Admin")
            return true;

        if (role == "Teacher")
            return section != "Users";

        //if (role == "Student")
        //    return section == "Tasks" || section == "Deadlines"; // коментраий для примера ещё добвим, ибо я пытаюсь сделать коммит..

        if (role == "Student")
        {
            return true; // сделал ошибку 
        }

        return false; 
    }
}