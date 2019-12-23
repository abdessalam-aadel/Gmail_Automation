using System;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using Keys = System.Windows.Forms.Keys;

namespace Gmail_Scrape
{

    public partial class frm_Gmail : Form
    {
        IWebDriver driver;

        public frm_Gmail()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Enable Form and Change cursor
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            using (driver = new ChromeDriver())
            {
                try
                {
                    // Satrt Explicit Waits
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
                    // Navigate to Gmail.com
                    driver.Navigate().GoToUrl("https://mail.google.com/mail/");
                    
                    // email
                    string email = txtBox_User.Text;
                    // password
                    string pass = txtBox_Pass.Text;

                    // Maximize Navigator
                    driver.Manage().Window.Maximize();

                    // Enter Email and click next button
                    IWebElement emailSend = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@type='email']")));
                    emailSend.SendKeys(email);
                    IWebElement emailNextClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='identifierNext']")));
                    emailNextClick.Click();

                    // Enter Password and click next button
                    IWebElement passSend = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@type='password']")));
                    passSend.SendKeys(pass);
                    IWebElement passNextClick = driver.FindElement(By.XPath("//*[@id='passwordNext']"));
                    passNextClick.Click();

                    // Click to Social Media Messages
                    IWebElement value_SMClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tr[@role='tablist']/td[2]")));
                    value_SMClick.Click();

                    // Node of Selectionner Tout
                    string SelectAll = "//div[@role='button' and @style='user-select: none;']/div[1]/span";
                    // Node of button delete
                    //string node_Delet = "//div[@class='nH aqK']/div/div/div/div[2]/div[3]";
                    string node_Delet = "//div[@act='10' and @role='button']/div";
                    
                    // see if messages SM exit or not
                    IWebElement slide = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@class='ar5 J-J5-Ji']")));
                    string vide = slide.Text;
                    string rtextSM = "Your \"Social Networks\" tab is empty";
                    string totaleSM = "your Totale social media messages is : ";
                    SelectAndDelet_All(driver, vide, SelectAll, node_Delet, totaleSM, rtextSM);
                    
                    // Click to Promotions Messages
                    IWebElement PromotionClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tr[@role='tablist']/td[3]")));
                    PromotionClick.Click();
                    // see if messages PROMO exit or not
                    slide = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@class='ar5 J-J5-Ji']")));
                    vide = slide.Text;
                    string rtextPr = "Your \"Promotions\" tab is empty";
                    string totalePr = "And your Totale Promotions messages is : ";
                    SelectAndDelet_All(driver, vide, SelectAll, node_Delet,totalePr, rtextPr);

                    Thread.Sleep(10000);
                    // Close Browser & Driver
                    driver.Close();
                    driver.Quit();
                    // Show Message << your social media messages was deleted >> ..
                    MessageBox.Show("Social Media & Promotions Messages was successful deleted"
                        + "\n\n" + "Gongralutation ..",
                        "Messages Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Close Browser & Driver
                    driver.Close();
                    driver.Quit();
                    MessageBox.Show(ex.Message);
                }
            }

            // Default value
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void SelectAndDelet_All(IWebDriver driver, string vide, string SelectAll, string node_Delet, string totale, string rtext)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            bool b = Regex.IsMatch(totale, "social");

            if (vide != " ")
            {
                // Declare number of Messages in page
                // Old Xpath
                //string node_NbrOfmessage = "//div[@aria-label='Afficher plus de messages']/span/span[1]/span[2]";
                // New Xpath : Number of messages in page
                string node_NbrOfmessage = "//*[@style='position: relative;']/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/" +
                    "div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]/div[1]/span[1]/span[1]/span[2]";
                IWebElement nbrValue = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(node_NbrOfmessage)));

                // Declare number of pages messages
                // Old Xpath
                //string node_NbrOfPages = "//div[@aria-label='Afficher plus de messages']/span/span[2]";
                // New Xpath : Number of pages messages
                string node_NbrOfPages = "//*[@style='position: relative;']/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/" +
                    "div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]/div[1]/span[1]/span[2]";
                IWebElement nbrOfPage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(node_NbrOfPages)));

                // Start Conversion
                // convert number of messages in page to integer
                string nbr_Messages = nbrValue.Text;
                int j = Convert.ToInt32(nbr_Messages);

                // convert number of pages messages to integer
                string nbr_Pages = nbrOfPage.Text;
                // Replace space
                nbr_Pages = Regex.Replace(nbr_Pages, @"\s", "");
                int h = Convert.ToInt32(nbr_Pages);
                // End Conversion.

                // Show informations in Riche Text Box ..
                if (b)
                    rtxtBox.Text = totale + h;
                else
                    rtxtBox2.Text = totale + h;

                while (j != h)
                {
                    // Select All Messages in page
                    IWebElement selectAllClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(SelectAll)));
                    selectAllClick.Click();
                    // Delet Messages Selected
                    IWebElement DeletClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(node_Delet)));
                    DeletClick.Click();

                    // Sleep for 15 second to delet messages
                    TimeSpan waitforsecond = new TimeSpan(0, 0, 10);
                    Thread.Sleep(waitforsecond);

                    // Restart Value
                    nbrValue = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(node_NbrOfmessage)));
                    nbrOfPage = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(node_NbrOfPages)));
                    nbr_Messages = nbrValue.Text;
                    j = Convert.ToInt32(nbr_Messages);
                    nbr_Pages = nbrOfPage.Text;
                    nbr_Pages = Regex.Replace(nbr_Pages, @"\s", "");
                    h = Convert.ToInt32(nbr_Pages);
                }

                if (j == h)
                {
                    // Select All Messages in page
                    IWebElement selectAllClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(SelectAll)));
                    selectAllClick.Click();
                    // Delet Messages Selected
                    IWebElement DeletClick = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(node_Delet)));
                    DeletClick.Click();
                }
            }
            else
            {
                // Show informations in Riche Text Box ..
                if (b)
                    rtxtBox.Text = rtext;
                else
                    rtxtBox2.Text = rtext;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.ShowDialog();       
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            txtBox_Pass.PasswordChar = '\0';
            btnShow2.Visible = false;
            labelShow.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtBox_Pass.PasswordChar = char.Parse("▪");
            btnShow2.Visible = true;
            labelShow.Visible = true;
        }

        private void AboutHover1_MouseHover(object sender, EventArgs e)
        {
            AboutHover1.Visible = false;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            AboutHover1.Visible = true;
        }
    }
}
