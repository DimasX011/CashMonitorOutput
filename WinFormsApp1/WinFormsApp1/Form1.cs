using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinFormsApp1
{
    public partial class ArmKassirLauncher : Form
    {
        public ArmKassirLauncher()
        {
            try
            {
                InitializeComponent();
                GoStart();
                this.Close();
            }
            catch (Exception e)
            {
            }
           

        }
         private void StartRecordFile(object sender, EventArgs e)
        {
            string applicvation = PathToApplication.Text;
            string paramethres = ApplicationParamether.Text;
            string settingsLaunh = FileSettingsLaunch.Text;
            string filenameSettings = FileNameParamethres.Text;
            string namebase = BaseName1.Text;
            try
            {
                DirectoryInfo path = new DirectoryInfo(settingsLaunh);
                List<string> paramethress = new List<string>();
                paramethress.Add(applicvation);
                paramethress.Add(paramethres);
                paramethress.Add(namebase);
                if (File.Exists(settingsLaunh +"\\" + filenameSettings))
                {
                    string[] parameterss = File.ReadAllLines(FileSettingsLaunch.Text +"\\"+ FileNameParamethres.Text);
                    if (parameterss.Length > 5)
                    {
                        File.WriteAllText(settingsLaunh +"\\" + filenameSettings, " ");
                    }
                    foreach (var c in paramethress)
                    {
                        if (namebase == "" && parameterss.Length == 0)
                        {
                            MessageBox.Show("Заполните имя кофигурации с кассовым монитором!");
                            ClearFileLaunch();
                            Record();
                            return;
                        }
                        else if ((namebase!=""&&parameterss.Length==0)||parameterss.Length!=0)
                        {
                            if (!(c == ""))
                            {
                                File.AppendAllText(settingsLaunh + "\\" + filenameSettings, c);
                                File.AppendAllText(settingsLaunh + "\\" + filenameSettings, Environment.NewLine);
                            }
                            if (parameterss.Length > 5)
                            {
                                BaseName1.ReadOnly = false;
                            }
                        }
                    }
                    FileInfo contr = new FileInfo(settingsLaunh + "\\" + filenameSettings);
                    if (contr.Length > 0)
                    {
                        BaseName1.Clear();
                        BaseName1.ReadOnly = true;
                    }
                }
                else if (!(File.Exists(settingsLaunh +"\\" + filenameSettings)))
                {
                    File.Create(settingsLaunh + filenameSettings);
                    string[] parameterss = File.ReadAllLines(FileSettingsLaunch.Text + "\\" + FileNameParamethres.Text);
                    foreach (var c in paramethress)
                    {
                        if (namebase == "" && parameterss.Length == 0)
                        {
                            MessageBox.Show("Заполните имя кофигурации с кассовым монитором!");
                            ClearFileLaunch();
                            Record();
                            return;
                        }
                        else if ((namebase != "" && parameterss.Length == 0) || parameterss.Length != 0)
                        {
                            if (!(c == ""))
                            {
                                File.AppendAllText(settingsLaunh + "\\" + filenameSettings, c);
                                File.AppendAllText(settingsLaunh + "\\" + filenameSettings, Environment.NewLine);
                            }
                        }
                    }
                }
                Record();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        private void ReadRecordFile(object sender, EventArgs e)
        {
            Record();
        }
        async private void Record()
        {
            try
            {
                string settingsLaunh = FileSettingsLaunch.Text;
                string filenameSettings = FileNameParamethres.Text;
                using (FileStream fstream = File.OpenRead(settingsLaunh + "\\" + filenameSettings))
                {
                    byte[] buffer = new byte[fstream.Length];
                    await fstream.ReadAsync(buffer, 0, buffer.Length);
                    string textFromFile = Encoding.Default.GetString(buffer);
                    listPanel.Text = textFromFile;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void ClearFile(object sender, EventArgs e)
        {
            ClearFileLaunch();
        }

        private void ClearFileLaunch()
        {
            string settingsLaunh = FileSettingsLaunch.Text;
            string filenameSettings = FileNameParamethres.Text;
            File.WriteAllText(settingsLaunh + "\\" + filenameSettings, " ");
            BaseName1.ReadOnly = false;
            Record();
        }

        private void Start(object sender, EventArgs e)
        {
            GoStart();
        }

        public void GoStart()
        {
            try
            {
                FileSettingsLaunch.Text = "C:\\terminal";
                FileNameParamethres.Text = "parametr.txt";
                string application = PathToApplication.Text;
                string parameters = ApplicationParamether.Text;
                string namebase = "";
                if (File.Exists(FileSettingsLaunch.Text + "\\" + FileNameParamethres.Text))
                {
                    string[] parameterss = File.ReadAllLines(FileSettingsLaunch.Text + "\\" + FileNameParamethres.Text);
                    if (parameterss.Length > 3)
                    {
                        List<string> launch1 = new List<string>();
                        List<string> launch2 = new List<string>();
                        launch1.Add(parameterss[0]);
                        launch1.Add(parameterss[1]);
                        launch1.Add(parameterss[2]);
                        launch2.Add(parameterss[3]);
                        launch2.Add(parameterss[4]);
                        if (parameterss[2] == "")
                        {
                            MessageBox.Show("Не указано имя конфигурации, отчистите список и повторите попытку");
                            return;
                        }
                        List<List<string>> Launchers = new List<List<string>>();
                        Launchers.Add(launch1);
                        Launchers.Add(launch2);
                        foreach (var app in Launchers)
                        {
                            if (app == Launchers[0])
                            {
                                application = app[0];
                                parameters = app[1];
                                namebase = app[2];
                                LaunchProces process = new LaunchProces();
                                IntPtr applic = process.launchProcesses(application, parameters, namebase);
                                int monitor = 1;
                                process.moveWindowToMonitors(monitor, applic);
                            }
                            else if (app == Launchers[1])
                            {
                                application = app[0];
                                parameters = app[1];
                                LaunchProces process = new LaunchProces();
                                IntPtr applic = process.launchProcesses(application, parameters);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                if (exception.Message == "Input string was not in a correct format.")
                {
                    MessageBox.Show("Неверно задано имя параметра, отчистите список и повторите попытку!");
                }
            }
        }

        private void FileSettingsLaunch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArmKassirLauncher_Load(object sender, EventArgs e)
        {

        }

        private void оРазработчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчики:\nДмитрий Яковлев\nЮрий Яковлев\nПочта для связи:\nDimon1998daf1@mail.ru");
        }

        private void какИспользоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для запуска кассового монитора и автоматизированного рабочего места кассира. В окне путь к приложению должен распологаться исходный путь установленной программы 1сv8.exe В окне параметры указываются исходные параметры запуска информационной базы(режим запуска, путь к информационной базе и.т.п). В окне расположения файла с параметрами будет указываться путь для записи настроек, которые вы ввели в программу, для возможности ручного изменения. Поле имя информационной базы должно быть заполнено именем конфигурации, используемой в качестве кассового монитораю. Для второй конфигурации заполнять имя не нужно! Настоятельно рекомендуется копировать пути расположений из проводника Windows, в целях избежаний ошибки при составлении пути. После полной загрузки кассового монитора и арм кассира программу можно закрыть.");
        }

        private void запускНа1МонитореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В случае если обе программы запускаются на одном мониторе необходимо:\n1)Проверить файл с настройками, параметры должны быть записаны каждый в новую строку(пробелы с новой строки недопустимы), всего должно быть 5 строк\n2)Обыкновенный перезапуск также может помочь запуститься программе верно");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PathToApplication_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    }
}
