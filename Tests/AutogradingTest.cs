namespace Tests;

using System.Reflection;
using knightmoves;
using Xunit;

public class AutogradingTest
{
  /*
should make `YearEstablished` a constant
- should make `Name` read only
  */

    [Fact]
    public void Should_Make_YearEstablished_A_Constant(){
      var organization = new Organization("test");
      var field = organization.GetType().GetField("YearEstablished", BindingFlags.NonPublic |  BindingFlags.Static |  BindingFlags.Instance);
      Assert.True(field.IsLiteral && !field.IsInitOnly);
    }

    [Fact]
    public void Should_Make_Name_Read_Only(){
      var organization = new Organization("test");
      var field = organization.GetType().GetField("Name", BindingFlags.NonPublic |  BindingFlags.Instance);
      Assert.True(field.IsInitOnly);
    }


}