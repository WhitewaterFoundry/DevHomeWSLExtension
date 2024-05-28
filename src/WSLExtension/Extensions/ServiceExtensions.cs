﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Windows.DevHome.SDK;
using WSLExtension.Providers;
using WSLExtension.Services;

namespace WSLExtension.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddWslExtensionServices(this IServiceCollection services, HostBuilderContext context)
    {
        // Services
        services.AddSingleton<IComputeSystemProvider, WslProvider>();
        services.AddSingleton<WslExtension>();
        services.AddSingleton<IWslManager, WslManager>();

        return services;
    }
}
