### Example 1: Create Microsoft SQL server provider
```powershell
New-AzWorkloadsProviderSqlServerInstanceObject -Password ****** -Port 1433 -Username ams -Hostname 10.1.14.5 -SapSid X00 -SslPreference Disabled
```

```output
ProviderType DbPassword   DbPasswordUri DbPort DbUsername Hostname  SapSid SslCertificateUri SslPreference
------------ ----------   ------------- ------ ---------- --------  ------ ----------------- -------------
MsSqlServer  ******               1433   ams        10.1.14.5 X00                      Disabled
```

Create Microsoft SQL server provider for an AMS instance
