using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System.IO;

namespace RPAChallenge.Browser
{
    public class Elementos
    {
        public IWebDriver driver;
        public Elementos()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public bool wait(string elemento)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(ExpectedConditions.ElementToBeClickable(By.XPath(elemento)));
                return true;
            }
            catch (Exception e)
            {
                var erro = e.Message;
                string PASTA = @"C:\Fiskal\RPA\RPAChalenge\Log";
                if (Directory.Exists(PASTA))
                {
                    using StreamWriter file = new StreamWriter($"{PASTA} - {DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}  {DateTime.Now.Hour}-{DateTime.Now.Minute}.txt");
                    file.WriteLine(erro);
                    file.Close();
                }
                else
                {
                    Directory.CreateDirectory(PASTA);
                    using StreamWriter file = new StreamWriter($"{PASTA} - {DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}  {DateTime.Now.Hour}-{DateTime.Now.Minute}.txt");
                    file.WriteLine(erro);
                    file.Close();
                }
                return false;
            }
        }

        public void Url(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Download()
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//a[@class=' col s12 m12 l12 btn waves-effect waves-light uiColorPrimary center'][contains(text(),' Download Excel ')]")).Click();
            } while (wait(".//a[@class=' col s12 m12 l12 btn waves-effect waves-light uiColorPrimary center'][contains(text(),' Download Excel ')]") == false & contador <= 3);
        }

        public void Start()
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//button[contains(@class,'uiColorButton')]")).Click();
            } while (wait(".//button[contains(@class,'uiColorButton')]") == false & contador <= 3);
        }

        public void Andres(string Andress)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelAddress']")).SendKeys(Andress);
            } while (wait(".//input[@ng-reflect-name='labelAddress']") == false & contador <= 3);
        }

        public void CompanyName(string CompanyName)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelCompanyName']")).SendKeys(CompanyName);
            } while (wait(".//input[@ng-reflect-name='labelCompanyName']") == false & contador <= 3);
        }

        public void LabelPhone(string LabelPhone)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelPhone']")).SendKeys(LabelPhone);
            } while (wait(".//input[@ng-reflect-name='labelPhone']") == false & contador <= 3);
        }

        public void LabelEmail(string LabelEmail)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelEmail']")).SendKeys(LabelEmail);
            } while (wait(".//input[@ng-reflect-name='labelEmail']") == false & contador <= 3);
        }

        public void LabelRole(string LabelRole)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelRole']")).SendKeys(LabelRole);
            } while (wait(".//input[@ng-reflect-name='labelRole']") == false & contador <= 3);
        }

        public void LabelName(string LabelName)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelLastName']")).SendKeys(LabelName);
            } while (wait(".//input[@ng-reflect-name='labelLastName']") == false & contador <= 3);
        }

        public void FirstName(string Firstname)
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//input[@ng-reflect-name='labelFirstName']")).SendKeys(Firstname);
            } while (wait(".//input[@ng-reflect-name='labelFirstName']") == false & contador <= 3);
        }

        public void Submit()
        {
            driver.FindElement(By.XPath(".//input[@class='btn uiColorButton']")).Click();
        }

        public void Reset()
        {
            int contador = 0;
            do
            {
                driver.FindElement(By.XPath(".//button[@class='waves-effect col s12 m12 l12 btn-large uiColorButton']")).Click();
            } while (wait(".//button[@class='waves-effect col s12 m12 l12 btn-large uiColorButton']") == false & contador <= 3);
        }

        public string Congrulations()
        {
            int contador = 0;
            string texto = "";
            do
            {
                var elementos = driver.FindElements(By.XPath(".//*[@class='message2']"));
                foreach (IWebElement teste in elementos)
                {
                    if (teste.Text.ToString().Contains("Your success"))
                    {
                        texto = teste.Text.ToString();
                    }
                }
            } while (wait(".//*[@class='message2']") == false & contador <= 3);
            return texto;
        }
    }
}


//.//button[@class='waves-effect col s12 m12 l12 btn-large uiColorButton']