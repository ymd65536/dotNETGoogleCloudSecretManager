GetSecretVersionSample test = new();
var result = test.GetSecretVersion(
    projectId: "pj-id", secretId: "GOOGLE_CLIENT_SECRET", secretVersionId: "1"
);

Console.WriteLine($"Secret version {result.Name} retrieved.");

GetSecretSample test2 = new();
var result2 = test2.GetSecret(projectId: "pj-id", secretId: "GOOGLE_CLIENT_SECRET");

Console.WriteLine($"Secret {result2} retrieved.");


AccessSecretVersionSample test3 = new();
var result3 = test3.AccessSecretVersion(projectId: "pj-id", secretId: "GOOGLE_CLIENT_SECRET", secretVersionId: "1");

Console.WriteLine($"Secret {result3} retrieved.");