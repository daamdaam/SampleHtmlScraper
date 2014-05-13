using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// use the selenium dlls (one for IE and one for js)
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // clear the ScrapedHtml Textbox
        txtScrapedHtml.Text = "";

        if (!IsPostBack)
        {
        }
        if (IsPostBack)
        {
            if (radlstBrowserToUse.SelectedValue == "PhantomJSDriver")
            {
                var Driver = createHeadlessBrowserDriver();

                Driver.Navigate().GoToUrl(txtUrlToScrape.Text);
                txtScrapedHtml.Text = Driver.PageSource.ToString();
            }
            else if (radlstBrowserToUse.SelectedValue == "InternetExplorerDriver")
            {
                var Driver = createIEBrowserDriver(); 
                Driver.Navigate().GoToUrl(txtUrlToScrape.Text);
                txtScrapedHtml.Text = Driver.PageSource.ToString();
            }

        }

    }

    // this is the phantomjs driver - the headless one
    public PhantomJSDriver createHeadlessBrowserDriver()
    {
        string path = AppDomain.CurrentDomain.BaseDirectory.ToString();

        //Phantom driver - no browser shown
        var driver = new PhantomJSDriver(path + "drivers");

        return driver;
    }

    public InternetExplorerDriver createIEBrowserDriver()
    {
        // get the domain
        string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        // open IE to login to the website
        var options = new InternetExplorerOptions()
        {
            IntroduceInstabilityByIgnoringProtectedModeSettings = true,
        };
        var driver = new InternetExplorerDriver(path + "drivers", options);

        return driver;
    }
}