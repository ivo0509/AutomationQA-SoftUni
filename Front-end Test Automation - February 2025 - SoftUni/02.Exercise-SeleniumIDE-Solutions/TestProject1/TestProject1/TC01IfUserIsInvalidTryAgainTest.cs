// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class TC01IfUserIsInvalidTryAgainTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Dispose();
  }
  [Test]
  public void tC01IfUserIsInvalidTryAgain() {
    // Test name: TC01 - If User Is Invalid Try Again
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    // 2 | setWindowSize | 1552x832 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    // 3 | click | css=*[data-test="username"] | 
    driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).Click();
    // 4 | type | css=*[data-test="username"] | user123
    driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys("user123");
    // 6 | click | css=*[data-test="login-password"] | 
    driver.FindElement(By.CssSelector("*[data-test=\"login-password\"]")).Click();
    // 7 | click | css=*[data-test="password"] | 
    driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).Click();
    // 8 | type | css=*[data-test="password"] | secret_sauce
    driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).SendKeys("secret_sauce");
    // 9 | click | css=*[data-test="login-button"] | 
    driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();
    // 10 | storeText | css=*[data-test="error"] | errorMessage
    vars["errorMessage"] = driver.FindElement(By.CssSelector("*[data-test=\"error\"]")).Text;
    // 11 | if |  ${errorMessage} === "Epic sadface: Username and password do not match any user in this service" | 
    if ((Boolean) js.ExecuteScript("return (arguments[0] === \'Epic sadface: Username and password do not match any user in this service\')", vars["errorMessage"])) {
      // 12 | echo | Wrong username | 
      Console.WriteLine("Wrong username");
      // 13 | click | css=*[data-test="username"] | 
      driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).Clear(); 
      // 14 | type | css=*[data-test="username"] | standard_user
      driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys("standard_user");
      // 15 | click | css=*[data-test="login-button"] | 
      driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();
      // 16 | assertText | css=*[data-test="title"] | Products
      Assert.That(driver.FindElement(By.CssSelector("*[data-test=\"title\"]")).Text, Is.EqualTo("Products"));
      // 17 | echo | Successful login  | 
      Console.WriteLine("Successful login ");
      // 18 | end |  | 
    }
    // 19 | close |  | 
    driver.Close();
  }
}
