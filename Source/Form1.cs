using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace autoMoodle
{
    public partial class Form1 : Form
    {

        WebClient wc = new WebClient();
        IWebDriver Browser;
        int NeedUpdate = 0;
        bool NeedDownloadF;
        int Version = 16;
        string VersionOnSite;
        int countReload = 0;
        int BestReloadC = 0;
        int Tutorialok = 0;
        int VisBrows = 0;
        int CheckBrows = 0;
        int TimeLeft = 50;
        int PageUpdate = 1000;
        int svInt = 0;
        string Fname = "ok.txt";
        string Login = "";
        string Pass = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Wa | v" + Version;
            if (!File.Exists("WebDriver.dll"))
            {
                if (!internetCheck())
                {
                    NeedDownloadF = true;
                }
                else
                {
                    wc.DownloadFile("https://github.com/Cat4Wizard/AutoMoodle/blob/master/Release/WebDriver.dll?raw=true", "WebDriver.dll");
                }
            }
            if (!File.Exists("chromedriver.exe"))
            {
                if (!internetCheck())
                {
                    NeedDownloadF = true;
                }
                else
                {
                    wc.DownloadFile("https://github.com/Cat4Wizard/AutoMoodle/blob/master/Release/chromedriver.exe?raw=true", "chromedriver.exe");
                }
            }
            if (!internetCheck())
            {
                saveinternet.Start();
                autoOpen.Checked = false;
            }
            if (File.Exists(Fname))
            {
                string[] In_file = File.ReadAllLines(Fname);
                if (In_file[1].IndexOf("st") != -1)
                {
                    UpdateProgramm();
                    Login = In_file[1];
                    Pass = In_file[2];
                    if (In_file[4].IndexOf(" ") == -1)
                    {
                        BestReloadC = int.Parse(In_file[4]);
                    }
                    else
                    {
                        BestReloadC = 0;
                    }
                    if(In_file[3].IndexOf(" ") == -1)
                    {
                        PageUpdate = int.Parse(In_file[3]);
                    }
                    else
                    {
                        PageUpdate = 1000;
                    }
                    Login_box.Text = Login;
                    Pass_box.Text = Pass;
                    reloadBest.Text = "Максимальное количество перезагрузок = " + BestReloadC;
                    string[] VersionOnSite_InFile = File.ReadAllLines(Fname);
                    if(VersionOnSite_InFile[7] != String.Empty)
                    {
                        VersionOnSite = VersionOnSite_InFile[7];
                    }
                    WriteFile();
                    if (internetCheck())
                    {
                        timer1.Start();
                    }
                    Tutorialok = 1;
                }
                else
                {
                    AlertMSG("Программу нужно настроить.", 1);
                    autoOpen.Checked = false;
                }
            }
            else
            {
                autoOpen.Checked = false;
                AlertMSG("Программа запущена в первый раз. Нужно настроить её.", 1);
                File.Create(Fname).Dispose();
                File.WriteAllText(Fname, "Вам нужно настроить программу.\n(Автоматический вход в moodle)");
            }
        }
        void WriteFile()
        {
            File.WriteAllText(Fname, "Настройки от самой лучшей программы в мире.(Автоматический вход в moodle)\n" + Login + "\n" + Pass + "\n" + PageUpdate + "\n" + BestReloadC + "\nCтрочки ниже не для редактирования!!!\n--|\n" + VersionOnSite + "\n" + NeedUpdate + "\n" + "--|");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tutorialok == 1 && internetCheck())
            {
                if (CheckBrows == 0)
                {
                    OpenBrows();
                    TimeLeft = PageUpdate;
                    timer1.Start();
                    autoOpen.Checked = true;
                    LFunc();
                }
                else if(CheckBrows == 1)
                {
                    CloseBrows();
                }
            }
        }
        void AlertMSG(string text, int Type)
        {
            if (Type == 0)
            {
                trayIcon.BalloonTipText = text;
                trayIcon.ShowBalloonTip(10);
            }
            else
            {
                MessageBox.Show(text, "Alert", MessageBoxButtons.OK);
            }
        }
        void OpenBrows()
        {
            ticktak.Start();
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = !consoleVisib.Checked;
            if (VisBrows == 0)
            {
                ChromeOptions SettingBr = new OpenQA.Selenium.Chrome.ChromeOptions();
                SettingBr.AddArgument("headless");
                Browser = new ChromeDriver(driverService, SettingBr);
            }
            else
            {
                Browser = new OpenQA.Selenium.Chrome.ChromeDriver(driverService);
            }
            Browser.Navigate().GoToUrl("http://moodle.dgma.donetsk.ua/login/index.php");
            CheckBrows = 1;
        }
        void CloseBrows()
        {
            if (CheckBrows == 1)
            {
                Browser.Close();
                Browser.Quit();
                CheckBrows = 0;
                autoOpen.Checked = false;
                Start.Text = "Запустить Браузер";
                autoOpen.Text = "Автоматический запуск.";
            }
        }
        void LFunc()
        {
            IWebElement Login_inSite = Browser.FindElement(By.Id("username"));
            Login_inSite.SendKeys(Login);
            IWebElement Pass_inSite = Browser.FindElement(By.Id("password"));
            Pass_inSite.SendKeys(Pass + OpenQA.Selenium.Keys.Enter);
            if (IsErrorElem() == true)
            {
                string ErrorMsg = Browser.FindElement(By.ClassName("error")).Text;
                timer1.Stop();
                AlertMSG("Ошибка с сайта:\n\n" + ErrorMsg, 1);
                CloseBrows();
            }
        }
        public bool IsErrorElem()
        {
            try
            {
                Browser.FindElement(By.ClassName("error"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        void Go_Home()
        {
            IWebElement Page = Browser.FindElement(By.Id("headerlogo"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
            js.ExecuteScript("arguments[0].scrollIntoView();", Page);
            Page.Click();
        }
        private void Login_box_TextChanged(object sender, EventArgs e)
        {
            Login = Login_box.Text;
        }

        private void Pass_box_TextChanged(object sender, EventArgs e)
        {
            Pass = Pass_box.Text;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (Login_box.Text == "" || Pass_box.Text == "")
            {
                AlertMSG("Введите свой логин и пароль от Moodle!", 1);
            }
            else
            {
                WriteFile();
                AlertMSG("Сохранено!", 1);
                Application.Restart();
            }
        }

        private void autoOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (Tutorialok == 1)
            {
                if (autoOpen.Checked)
                {
                    if (CheckBrows == 0)
                    {
                        TimeLeft = 50;
                    }
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    if (CheckBrows == 0)
                    {
                        TimeLeft = 50;
                        autoOpen.Text = "Автоматический запуск.";
                    }
                    else
                    {
                        TimeLeft = PageUpdate;
                        autoOpen.Text = "Автоматическое обновление страницы.";
                    }
                }
            }
            else
            {
                autoOpen.Checked = false;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            trayIcon.Text = "Wa " + TimeLeft;
            if (CheckBrows == 0)
            {
                if (TimeLeft > 0)
                {
                    TimeLeft = TimeLeft - 1;
                    autoOpen.Text = TimeLeft + " До Автоматического запуска.";
                }
                else
                {
                    TimeLeft = PageUpdate;
                    OpenBrows();
                    LFunc();
                }
            }
            else
            {
                if (TimeLeft > 0)
                {
                    TimeLeft = TimeLeft - 1;
                    autoOpen.Text = TimeLeft + " До Автоматического обновления страницы.";
                }
                else
                {
                    if (internetCheck())
                    {
                        countReload++;
                        Go_Home();
                        TimeLeft = PageUpdate;
                    }
                    else
                    {
                        CloseBrows();
                        saveinternet.Start();
                    }
                }
            }
        }
        private void link_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/Cat4Wizard");
        }
        private void browserVisib_CheckedChanged(object sender, EventArgs e)
        {
            if (browserVisib.Checked)
            {
                VisBrows = 1;
            }
            else
            {
                VisBrows = 0;
            }
        }

        private void ticktak_Tick(object sender, EventArgs e)
        {
            reloadCountT.Text = "Количество перезагрузок = " + countReload;
            if(countReload >= BestReloadC)
            {
                BestReloadC = countReload;
                WriteFile();
                reloadBest.Text = "Максимальное количество перезагрузок = " + BestReloadC;
            }
            internetCheck();
            if (CheckBrows == 1)
            {
                Start.Text = "Закрыть Браузер";
                this.Height = 130;
                Login_box.Visible = false;
                Pass_box.Visible = false;
                Save.Visible = false;
                loginText.Visible = false;
                passText.Visible = false;
                browserVisib.Visible = false;
                consoleVisib.Visible = false;
                link2.Visible = true;
            }
            else if(CheckBrows == 0)
            {
                Start.Text = "Запустить Браузер";
                this.Height = 230;
                Login_box.Visible = true;
                Pass_box.Visible = true;
                Save.Visible = true;
                loginText.Visible = true;
                passText.Visible = true;
                browserVisib.Visible = true;
                consoleVisib.Visible = true;
                link2.Visible = false;
                ticktak.Stop();

            }
        }
        private void saveinternet_Tick(object sender, EventArgs e)
        {
            svInt = svInt + 1;
            internetTest.ForeColor = Color.Red;
            internetTest.Text = "Упс..." + svInt;
            if (internetCheck())
            {
                if (NeedDownloadF)
                {
                    wc.DownloadFile("https://github.com/Cat4Wizard/AutoMoodle/blob/master/Release/WebDriver.dll?raw=true", "WebDriver.dll");
                    wc.DownloadFile("https://github.com/Cat4Wizard/AutoMoodle/blob/master/Release/chromedriver.exe?raw=true", "chromedriver.exe");
                    Application.Restart();
                }
                autoOpen.Checked = true;
                saveinternet.Stop();
                svInt = 0;
            }
        }

        private void autoOpen_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (!internetCheck())
            {
                autoOpen.Checked = false;
            }
        }
        void CheckBoxRelandVisib(object sender, EventArgs e)
        {
            if (CheckBrows == 1)
            {
                AlertMSG("Перезапустите Браузер.", 0);
            }
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                trayIcon.Visible = false;
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseBrows();
            Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseBrows();
            trayIcon.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                this.Hide();
                AlertMSG("Приложение Свернуто.", 0);
            }
        }
        bool internetCheck()
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("moodle.dgma.donetsk.ua", 1000);
                if (reply.Status == IPStatus.Success)
                {
                    internetTest.ForeColor = Color.Green;
                    internetTest.Text = "Подключено!";
                }
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                internetTest.ForeColor = Color.Red;
                internetTest.Text = "Упс...";
                return false;
            }
        }
    void UpdateProgramm()
        {
            string[] NeedUpd_InFile = File.ReadAllLines(Fname);
            NeedUpdate = int.Parse(NeedUpd_InFile[8]);
            if (NeedUpdate == 0)
            {
                VersionOnSite = wc.DownloadString("https://raw.githubusercontent.com/AlexSlz/AutoMoodle/master/Version.txt");
                if (Version != int.Parse(VersionOnSite))
                {
                    this.Text = "Wa | Вам нужно обновиться!";
                    UpdButton.Visible = true;
                    NeedUpdate = 1;
                }
            }
            else if (NeedUpdate == 1)
            {
                this.Text = "Wa | Вам нужно обновиться!";
                UpdButton.Visible = true;
            } else if (NeedUpdate == 2)
            {
                NeedUpdate = 0;
                File.Delete("autoSite.exe");
                File.Move("autoSiteNew.exe", "autoSite.exe");
            } else if (NeedUpdate == 666){}
        }
        private void UpdButton_Click(object sender, EventArgs e)
        {
            wc.DownloadFile("https://github.com/Cat4Wizard/AutoMoodle/blob/master/Release/autoSite.exe?raw=true", "autoSiteNew.exe");
            NeedUpdate = 2;
            WriteFile();
            Process.Start("autoSiteNew.exe");
            Application.Exit();
        }
    }
}
