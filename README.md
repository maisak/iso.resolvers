# ISO resolvers
## ISO-4217 (currency codes) resolver 
[![NuGet version (ISO.4217.CurrencyCodes)](https://img.shields.io/nuget/v/ISO.4217.CurrencyCodes.svg?style=flat-square)](https://www.nuget.org/packages/ISO.4217.CurrencyCodes/)

Resolver for ISO-4217 codes.
### Data matrix
| Number | Code | Name | Country |
|--------|------|------|---------|
| 980 | UAH | Hryvnia   | Ukraine
| 978 | EUR | Euro      | Germany
| 840 | USD | US Dollar | United States of America
|...|...|...|...
### How to use
Next code:
```
public void Demo()
{
    var code = CurrencyCodesResolver.GetCodeByNumber("978");

    Console.WriteLine(code);
}
```
Outputs:
`EUR`
## ISO-18245 (merchant category codes) resolver
[![NuGet version (ISO.18245.MerchantCategoryCodes)](https://img.shields.io/nuget/v/ISO.18245.MerchantCategoryCodes.svg?style=flat-square)](https://www.nuget.org/packages/ISO.18245.MerchantCategoryCodes/)

Resolver for ISO-18245 codes.
### Data matrix
| Code | Description |
|--------|------|
| 4121 | Taxicabs and Limousines |
| 5995 | Pet Shops, Pet Foods, and Supplies Stores |
|...|...|
### How to use
Next code:
```
public void Demo()
{
    var mcc = MerchantCategoryCodesResolver.GetByCode("4121");

    Console.WriteLine(mcc.Description);
}
```
Outputs:
`Taxicabs and Limousines`
