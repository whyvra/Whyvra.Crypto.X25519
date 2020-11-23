# Whyvra.Crypto.X25519

[![LICENSE](https://img.shields.io/badge/license-MIT-blue?style=flat-square)](./LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)
[![NuGet](https://img.shields.io/nuget/v/Whyvra.Crypto.X25519.svg?style=flat-square)](https://www.nuget.org/packages/Whyvra.Crypto.X25519/)

An elliptic curve offering 128 bits of security and designed for use with the elliptic curve Diffie–Hellman (ECDH) key agreement scheme.

The goal of this library is to provide a NuGet package targeting .NET Standard 2.0 that is compatible with Blazor WebAssembly.

## Installation

```bash
dotnet add package Whyvra.Crypto.X25519
```

## Usage

```csharp
var curve25519 = new Curve25519();
var alicePrivate = curve25519.CreateRandomPrivateKey();
var alicePublic = curve25519.GetPublicKey(alicePrivate);

var bobPrivate = curve25519.CreateRandomPrivateKey();
var bobPublic = curve25519.GetPublicKey(bobPrivate);

var aliceShared = curve25519.GetSharedSecret(alicePrivate, bobPublic);
var bobShared = curve25519.GetSharedSecret(bobPrivate, alicePublic);
var equal = aliceShared.SequenceEqual(bobShared);
```

## Attribution

This library is based on work by Timothy Meadows and
Michael Heyman and their respective libraries linked below.

[https://github.com/TimothyMeadows/Curve25519.NetCore](https://github.com/TimothyMeadows/Curve25519.NetCore)
[https://github.com/mheyman/Isopoh.Cryptography.Argon2](https://github.com/mheyman/Isopoh.Cryptography.Argon2)

Curve25519 was designed by Daniel J. Bernstein.

All credit for work go to the original authors.

## License

Released under the [MIT License](./LICENSE).