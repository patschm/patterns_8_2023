using JsonWebToken;

namespace Media;

internal class JwtTokenIssuer
{
    private SymmetricJwk key = SymmetricJwk.FromBase64Url("Test123456Test123456Test123456");
    private string issuer = "https://myaccess.nl/";
    private string audience = "123456789A123456789B";
    private SignatureAlgorithm signatureAlgorithm = SignatureAlgorithm.HmacSha256;

    public string Create(string user, string item)
    {   
        var desc = new JwsDescriptor()
        {
            Algorithm = signatureAlgorithm,
            SigningKey = key,
            Issuer = issuer,
            Audience = audience,
            IssuedAt = DateTime.UtcNow,
            ExpirationTime = DateTime.UtcNow.AddDays(7)
        };
        desc.Payload.Add("user", user);
        desc.Payload.Add("item", item);

        var writer = new JwtWriter();
        return writer.WriteTokenString(desc);
    }
    public bool Validate(string token, string user, string item)
    {
        var policy = new TokenValidationPolicyBuilder()
           .RequireSignature(key, signatureAlgorithm)
           .RequireAudience(audience)
           .RequireIssuer(issuer)
           .RequireClaim("user")
           .RequireClaim("item")
           .Build();
        var reader = new JwtReader();
        var result = reader.TryReadToken(token, policy);
        if (result == null) return false;
        if (!result.Succedeed) return false;
        if (result.Token == null || result.Token.Payload == null) return false;

        if (result.Token.Payload.TryGetValue("user", out JwtProperty juser) &&
            result.Token.Payload.TryGetValue("item", out JwtProperty jitem))
        {
            if (juser.Value != null && jitem.Value != null)
            {
                return juser.Value.Equals(user) && jitem.Value.Equals(item);
            }
        }
        return false;
    }
}
