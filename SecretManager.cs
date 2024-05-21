using Google.Cloud.SecretManager.V1;

public class GetSecretVersionSample
{
  public SecretVersion GetSecretVersion(
    string projectId = "my-project", string secretId = "my-secret", string secretVersionId = "123")
  {
    // Create the client.
    SecretManagerServiceClient client = SecretManagerServiceClient.Create();

    // Build the resource name.
    SecretVersionName secretVersionName = new SecretVersionName(projectId, secretId, secretVersionId);

    // Call the API.
    SecretVersion version = client.GetSecretVersion(secretVersionName);
    return version;
  }
}

public class GetSecretSample
{
    public Secret GetSecret(string projectId = "my-project", string secretId = "my-secret")
    {
        // Create the client.
        SecretManagerServiceClient client = SecretManagerServiceClient.Create();

        // Build the resource name.
        SecretName secretName = new SecretName(projectId, secretId);

        // Call the API.
        Secret secret = client.GetSecret(secretName);
        return secret;
    }
}

public class AccessSecretVersionSample
{
    public String AccessSecretVersion(
      string projectId = "my-project", string secretId = "my-secret", string secretVersionId = "1")
    {
        // Create the client.
        SecretManagerServiceClient client = SecretManagerServiceClient.Create();

        // Build the resource name.
        SecretVersionName secretVersionName = new SecretVersionName(projectId, secretId, secretVersionId);

        // Call the API.
        AccessSecretVersionResponse result = client.AccessSecretVersion(secretVersionName);

        // Convert the payload to a string. Payloads are bytes by default.
        String payload = result.Payload.Data.ToStringUtf8();
        return payload;
    }
}