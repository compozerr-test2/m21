using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using M21.Services;

namespace M21;

public class M21Feature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IM21Service, M21Service>();
    }
}