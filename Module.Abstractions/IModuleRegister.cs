namespace Module.Abstractions;

public interface IModuleRegister
{
    MauiAppBuilder RegisterModule(MauiAppBuilder builder);
}
