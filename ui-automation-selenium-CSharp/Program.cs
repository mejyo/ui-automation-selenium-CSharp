using App_automation.Global;
using App_automation.Pages;
using NUnit.Framework;

namespace App_automation
{
    public static class Program
    {
        [TestFixture]
        class User : Base
        {
            [Test, Order(1)]
            public void AddToCart()
            {
                AddProduct AddProductObj = new AddProduct();
                AddProductObj.AddProductSteps();
            }
        }
    }
}