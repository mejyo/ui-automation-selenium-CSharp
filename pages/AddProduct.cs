using App_automation.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace App_automation.Pages
{
    class AddProduct
    {
        public AddProduct()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region 
        //Element for Search Products
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search products, brands, and more...']")]
        private IWebElement SearchProducts { get; set; }

        //Element for Search Input
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search products, brands…']")]
        private IWebElement SearchInput { get; set; }

        //Element for Search Button
        [FindsBy(How = How.CssSelector, Using = "button[title='Start Search']")]
        private IWebElement SearchButton { get; set; }

        //Element for first item
        [FindsBy(How = How.CssSelector, Using = "img[alt='ASUS Vivobook Go 15 E510KA 15.6\" FHD Laptop (128GB) [Intel Celeron]']")]
        private IWebElement Item { get; set; }

        //Element for Add to cart
        [FindsBy(How = How.CssSelector, Using = ".Button_fullWidthVariant__ickenoa.Button_typeVariants_action__ickeno6.Button_solidButtonStyles__ickeno0.be8y1j0")]
        private IWebElement AddToCart { get; set; }

        //Element for My Cart
        [FindsBy(How = How.CssSelector, Using = ".Button_typeVariants_primary__ickeno4.Button_solidButtonStyles__ickeno0.zrarkx7")]
        private IWebElement MyCart { get; set; }

        //Element for Remove item
        [FindsBy(How = How.CssSelector, Using = ".remove-link.remove-button")]
        private IWebElement RemoveItem { get; set; }

        //Element for No Items in the cart
        [FindsBy(How = How.CssSelector, Using = "div[class='empty-cart'] p")]
        private IWebElement NoItems { get; set; }
        #endregion

        internal void AddProductSteps()
        {
            

            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector("input[placeholder='Search products, brands, and more...']"), 10);
            SearchProducts.Click();
            SearchInput.SendKeys("Computer");
            SearchButton.Click();
            Item.Click();
            GlobalDefinitions.ImplicitWaitTime(20);
            AddToCart.Click();
            GlobalDefinitions.ImplicitWaitTime(10);
            MyCart.Click();
            RemoveItem.Click();

            GlobalDefinitions.ImplicitWaitTime(10);

            Assert.AreEqual("There are no items in your cart", NoItems.Text);

            Assert.Pass("Selected product has been removed from the Cart sucessfully!");
        }
    }
}