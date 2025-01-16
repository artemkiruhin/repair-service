using System.Security.Cryptography;
using System.Text;

namespace CompRepair.Core.Services;

public class Hasher
{
    public string Hash(string input) => Convert.ToHexStringLower(SHA256.HashData(Encoding.UTF8.GetBytes(input)));
}