string PROJECT_ID = Environment.GetEnvironmentVariable("PROJECT_ID")!;

if (string.IsNullOrEmpty(PROJECT_ID))
{
    Console.WriteLine("PROJECT_ID environment variable must be set.");
    return;
}

GetSecretVersionSample test = new();
var result = test.GetSecretVersion(
    projectId: PROJECT_ID, secretId: "GOOGLE_CLIENT_SECRET", secretVersionId: "1"
);

Console.WriteLine($"Secret version {result.Name} retrieved.");

GetSecretSample test2 = new();
var result2 = test2.GetSecret(projectId: PROJECT_ID, secretId: "GOOGLE_CLIENT_SECRET");

Console.WriteLine($"Secret {result2} retrieved.");


AccessSecretVersionSample test3 = new();
var result3 = test3.AccessSecretVersion(projectId: PROJECT_ID, secretId: "GOOGLE_CLIENT_SECRET", secretVersionId: "1");

Console.WriteLine($"Secret {result3} retrieved.");