using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Diagnostics;

//В проекте, который будет анализироваться, нужно будет установить Microsoft.CodeAnalysis.Metrics через Nuget


namespace CodeMetricsExample
{
    class Program
    {

        static void Main(string[] args)
        {
            //путь до папки решения, где содержится sln решение, которое мы анализируем
            string path = "C:\\Users\\Shama\\source\\repos\\testmetric";
            //путь до папки решения, где содержится все основные файлв файл 
            string path2 = "C:\\Users\\Shama\\source\\repos\\testmetric\\testmetric\\";
            //Создание процесса по запуску командной строки
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    //путь до командной строки
                    FileName = @"C:\Windows\System32\cmd.exe",
                    /*аргумет запуска, может отличатся. Надо найти в поиске Developer Command Prompt for VS ярлык
                     и посмотреть в свойствах ярлыка, в строке "обьект",все что находся до пути к файлу 
                    */
                    Arguments = "%comspec% /k",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                }
            };
            //Запуск процесса
            proc.Start();
/*          string cmd = "C:\\Windows\\SysWOW64\\WindowsPowerShell\\v1.0\\powershell.exe - noe - c \"&{Import-Module \"\"\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\Tools\\Microsoft.VisualStudio.DevShell.dll\"\"\"; Enter-VsDevShell 43c03af7}";
*/          //Команда перемещния в нужную директорию
            string cmd1 = "cd " + path;
            //Команда для подсчета метрик
            string cmd2 = "msbuild /t:Metrics /p:MetricsOutputFile=metr";
            //выход
            string cmd3 = "exit";
            /*Путь до пакета данных, что бы запустить консоль для разработчиков, Надо найти в поиске Developer Command Prompt for VS ярлык
            и посмотреть в свойствах ярлыка, в строке "обьект",и скопировать путь до файла
            */
            string cmd4 = "\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\Tools\\VsDevCmd.bat\"";
            proc.StandardInput.WriteLine(cmd4);
            proc.StandardInput.WriteLine(cmd1);
            proc.StandardInput.WriteLine(cmd2);
            proc.StandardInput.WriteLine(cmd3);


            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            proc.WaitForExit();
            Console.WriteLine(proc.StandardOutput.ReadToEnd());
/*            while (!File.Exists(path2 + "metr"))
            {

            }*/
            //Открытие xml файла 
            XDocument doc = XDocument.Load(path2 + "metr");
            //А дольше парсинг файла и вывод нужных данных
            var metrics = doc.Descendants("Metric");
            int i = 1;
            foreach (var metric in metrics)
            {
                if (i == 4)
                {
                    Console.WriteLine("Глубина наследования " + metric.Attribute("Value").Value);
                }
                if (i == 3)
                {
                    Console.WriteLine("Взаимосвязанность классов " + metric.Attribute("Value").Value);
                }
                if (i == 5)
                {
                    Console.WriteLine("Строки исходного кода " + metric.Attribute("Value").Value);
                }
                if (i == 6)
                {
                    Console.WriteLine("Строки исполняемого кода " + metric.Attribute("Value").Value);
                }
                if (i == 7)
                {
                    break;
                }
                i++;
            }


        }
    }
}
