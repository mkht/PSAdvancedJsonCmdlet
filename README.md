# PSAdvancedJsonCmdlet

JSON serializer and deserializer for Windows PowerShell 5.1.  
This module provides two cmdlets for JSON serializer and deserializer.

* `ConvertFrom-AdvancedJson`
* `ConvertTo-AdvancedJson`

These cmdlets are backported from modern PowerShell 7.3 to legacy Windows PowerShell 5.1. 

## Supported Platforms
* Windows PowerShell 5.1

> This module may also work with PowerShell 7 or higher. (only on Windows)  
> But not useful because it has better built-in cmdlets.

## Install
Install from PowerShellGallery
```PowerShell
Install-Module -Name PSAdvancedJsonCmdlet
```
## Usage
See docs by Microsoft.  
These have same parameters, same outputs, same usage.

### ConvertFrom-AdvancedJson
https://learn.microsoft.com/ja-jp/powershell/module/microsoft.powershell.utility/convertfrom-json?view=powershell-7.3

### ConvertTo-AdvancedJson
https://learn.microsoft.com/ja-jp/powershell/module/microsoft.powershell.utility/convertto-json?view=powershell-7.3

## Notes

### Not a complete backport
These commands are based on PowerShell 7.3 source code, but are not exactly the same. Full compatibility is not guaranteed.  
For example, the PowerShell 7.3 uses `Newtonsoft.Json 13.0.2`, but this module uses `Newtonsoft.Json 12.0.3`.

### AsHashTable returns `[OrderedHashtable]` type of object
`ConvertFrom-Json -AsHashtable` returns `[OrderedHashtable]`. This is the same behavior as in PS 7.3, but different from 7.2 and earlier. `[OrderedHashtable]` is not a built-in type of Windows PowerShell, it is also backported.  

It is not compatible with `[System.Collections.Specialized.OrderedDictionary]`, which is commonly used in Windows PowerShell. You can clone `[OrderedHashtable]` to `[OrderedDictionary]` with the following code.

```PowerShell
# $hash is [OrderedHashtable]
$hash = ConvertFrom-AdvancedJson -InputObject $SomeJsonText -AsHashtable

# $dic is [OrderedDictionary]
$dic = [System.Collections.Specialized.OrderedDictionary]::new($hash.Count)

# Copy $hash to $dic
foreach ($item in $hash.GetEnumerator()) {
    $dic.Add($item.key, $item.Value)
}
```

## Release
* Not Released
