using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemsControllerTest
  {
    [TestMethod]
    public void Index_HasCorrectModelType_ItemList()
    {
      //Arrange
      ItemsController controller = new ItemsController();
      ViewResult indexView = controller.Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Item>));
    }
  }
}
