using System;
using Whyvra.Crypto.X25519;

namespace Whyvra.Crypto.Examples
{
    public class Program
    {
        public static void Main()
        {
            var curve = new Curve25519();
            var privateKey = curve.CreateRandomPrivateKey();
            var publicKey = curve.GetPublicKey(privateKey);

            Console.WriteLine(Convert.ToBase64String(privateKey));
            Console.WriteLine(Convert.ToBase64String(publicKey));
        }
    }
}
