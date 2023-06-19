# Flash_cards

`dotnet restore`

Go to `Services/MyApplicationDBContext.cs`

Uncomment first `optionsBuilder` and change the Connection string if needed.
Then comment the second `optionsBuilder`

```C#
if (!optionsBuilder.IsConfigured)
{
    //optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=FlashCard;TrustServerCertificate=True");
    optionsBuilder.UseSqlServer(GetConnectionString());
}
```

`cd Services`

`dotnet ef database update`
