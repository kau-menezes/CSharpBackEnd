namespace Server;

public static class ConfigurationExtension
{
    public static string GetClient(this IConfiguration config)
    {
        var clientURL = config["LocalUrl"]
            ?? throw new Exception("Missing");

        return clientURL;
    }

        public static string GetJWTSecret(this IConfiguration config)
    {
        var clientURL = config["JWTSecret"]
            ?? throw new Exception("Missing");

        return clientURL;
    }
}