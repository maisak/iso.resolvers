# ISO-4217 (currency codes) resolver 
Resolver for ISO-4217 codes.
## Data matrix
| Number | Code | Name | Country |
|--------|------|------|---------|
| 980 | UAH | Hryvnia   | Ukraine
| 978 | EUR | Euro      | Germany
| 840 | USD | US Dollar | United States of America
|...|...|...|...
## How to use
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
