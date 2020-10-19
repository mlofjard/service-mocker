using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System;
using System.Windows.Forms;

namespace ServiceMocker
{
    static class Program
    {
        public static MainForm MainForm { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            var host = CreateWebHostBuilder(args).Build();
            host.Start();
            var addresses = host.ServerFeatures.Get<IServerAddressesFeature>().Addresses;
            MainForm.statusStrip.Items.Add($"Service listening on {string.Join(", ", addresses)}");

            Application.Run(MainForm);
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseStartup<Startup>();
    }
}
