using CampusFlow;

namespace CampusFlow.Tests;

public class AccessControlTests
{
    [Fact]
    public void Student_CanAccessTasks()
    {
        var access = new AccessControl();

        var result = access.CanAccess("Student", "Tasks");

        Assert.True(result);
    }

    [Fact]
    public void Student_CannotAccessUsers()
    {
        var access = new AccessControl();

        var result = access.CanAccess("Student", "Users");

        Assert.False(result);
    }

    [Fact]
    public void Teacher_CannotManageUsers()
    {
        var access = new AccessControl();

        var result = access.CanAccess("Teacher", "Users");

        Assert.False(result);
    }

    [Fact]
    public void Admin_CanAccessUsers()
    {
        var access = new AccessControl();

        var result = access.CanAccess("Admin", "Users");

        Assert.True(result);
    }
}