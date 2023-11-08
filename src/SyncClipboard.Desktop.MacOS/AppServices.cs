﻿using Microsoft.Extensions.DependencyInjection;
using SyncClipboard.Core.Interfaces;
using SyncClipboard.Desktop.MacOS.Views;

namespace SyncClipboard.Desktop.MacOS;

public class AppServices
{
    public static ServiceCollection ConfigureServices()
    {
        var services = new ServiceCollection();

        SyncClipboard.Desktop.AppServices.ConfigDesktopCommonService(services);

        services.AddSingleton<IMainWindow, MainWindow>();
        return services;
    }
}