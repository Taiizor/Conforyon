![logo](https://www.photo.herominyum.com/resimler/2020/08/04/1mpl.png)

![dotnetframework-version](https://img.shields.io/badge/.NET%20Framework-%3E%3D4.0-blue)
![dotnetcore-version](https://img.shields.io/badge/.NET%20Core-%3E%3D2.1-blue)
![dotnetstandard-version](https://img.shields.io/badge/.NET%20Standard-%3E%3D2.1-blue)
![csharp-version](https://img.shields.io/badge/C%23-8.0-blue.svg)
![ide-version](https://img.shields.io/badge/IDE-vs2019-blue.svg)
[![nuget-version](https://img.shields.io/nuget/v/Conforyon.svg)](https://www.nuget.org/packages/Conforyon)
[![nuget](https://img.shields.io/nuget/dt/Conforyon)](https://www.nuget.org/packages/Conforyon)

# Welcome to Conforyon
Conforyon is a Unit Converter library. It allows the conversion of various unit conversions it offers.

## Contributors

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<table>
  <tr>
    <td align="center">
		<a href="https://github.com/Taiizor">
			<img src="https://avatars3.githubusercontent.com/u/41683699?s=460&v=4" width="80px;" alt="Taiizor"/>
			<br/>
			<sub>
				<b>Taiizor</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Taiizor/Conforyon/commits?author=Taiizor" title="Code">💻</a>
		<a href="https://www.taiizor.com" title="Ideas & Planning, Feedback">🤔</a>
	</td>
  </tr>
</table>

This project follows the [all contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!

## Backers

<table>
  <tr>
    <td align="center">
		<a href="https://github.com/Soferity">
			<img src="https://avatars3.githubusercontent.com/u/63516515?s=200&v=4" width="80px;" alt="Soferity"/>
			<br/>
			<sub>
				<b>Soferity</b>
			</sub>
		</a>
		<br/>
		<a href="https://github.com/Soferity" target="_blank" title="Content">🖋</a>
	</td>
  </tr>
</table>

## Usage

Step 1：Add a reference to Conforyon or search for Conforyon on the NuGet;

```Install-Package Conforyon```

Step 2：Enjoy conversions

## Demos

### Conforyon UI

![ConforyonUIDemo](https://www.photo.herominyum.com/resimler/2020/08/08/1TXE.png)

### Conforyon UX

![ConforyonUXDemo](https://www.photo.herominyum.com/resimler/2020/08/07/1bhT.png)

## Detailed Usage

### Clipboard

#### Text

```CS
/* CopyText(string Text, bool Copy = true) */
CopyText("Conforyon", false);
```

```CS
/* PasteText(bool Clear = false, string Back = EmptyMessage, string Error = ErrorMessage) */
PasteText(true, "Empty!", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>Conforyon</ReturnValue>
</FunctionResult>
```

#### Audio

```CS
/* CopyAudio(byte[] Bytes) */
CopyAudio(File.ReadAllBytes(FilePath));
```

```CS
/* PasteAudio(bool Clear = false) */
PasteAudio(true);
```
```XML
<FunctionResult>
	<ReturnType>System.IO.Stream</ReturnType>
	<ReturnValue>DataFormats.WaveAudio</ReturnValue>
</FunctionResult>
```

### Color

#### HEX -> RGB

```CS
/* HEXtoRGB(string Variable, ColorType Mode = ColorType.RGB1, string Error = ErrorMessage) */
HEXtoRGB("FFFFFF", ColorType.RGB1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>255, 255, 255</ReturnValue>
</FunctionResult>
```

```CS
/* HEXtoRGB(string Variable, ColorType Mode = ColorType.RGB1, string Error = ErrorMessage) */
HEXtoRGB("000000", ColorType.RRGGBB1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>R: 0, G: 0, B: 0</ReturnValue>
</FunctionResult>
```

#### RGB -> HEX

```CS
/* RGBtoHEX(string R, string G, string B, bool Sharp = false, string Error = ErrorMessage) */
RGBtoHEX("255", "255", "255", true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>#FFFFFF</ReturnValue>
</FunctionResult>
```

```CS
/* RGBtoHEX(string R, string G, string B, bool Sharp = false, string Error = ErrorMessage) */
RGBtoHEX("0", "0", "0", false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>000000</ReturnValue>
</FunctionResult>
```

### Crypto

#### TEXT -> BASE64

```CS
/* TEXTtoBASE64(string Variable, string Error = ErrorMessage) */
TEXTtoBASE64("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>Q29uZm9yeW9u</ReturnValue>
</FunctionResult>
```

#### BASE64 -> TEXT

```CS
/* BASE64toTEXT(string Variable, string Error = ErrorMessage) */
BASE64toTEXT("Q29uZm9yeW9u", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>Conforyon</ReturnValue>
</FunctionResult>
```

#### TEXT -> MD5

```CS
/* TEXTtoMD5(string Variable, string Error = ErrorMessage) */
TEXTtoMD5("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>9946dc70f0672da2ba000a0cb80f8872</ReturnValue>
</FunctionResult>
```

#### TEXT -> SHA1

```CS
/* TEXTtoSHA1(string Variable, string Error = ErrorMessage) */
TEXTtoSHA1("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>4a417fe4795f59e4848c403ffc4c569417a743b4</ReturnValue>
</FunctionResult>
```

#### TEXT -> SHA256

```CS
/* TEXTtoSHA256(string Variable, string Error = ErrorMessage) */
TEXTtoSHA256("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>4a772e794799efdf4dc171ea2779e78bfa582c46ef86c6c018b7e9387d7fe56b</ReturnValue>
</FunctionResult>
```

#### TEXT -> SHA384

```CS
/* TEXTtoSHA384(string Variable, string Error = ErrorMessage) */
TEXTtoSHA384("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>3dca281c6056810ca6aff8bb151ea8d0a1908f8650d573237cc038dce3bb30d04a79d2c0f778a5a2e609951a11443db3</ReturnValue>
</FunctionResult>
```

#### TEXT -> SHA512

```CS
/* TEXTtoSHA512(string Variable, string Error = ErrorMessage) */
TEXTtoSHA512("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>d47368182220aab5f687dde734acbb8d895bb2d870e789ee03216f3b215ac00a4202ead0aabce2049ae49a0079b130211323453604c088b09a27ee989de9db8b</ReturnValue>
</FunctionResult>
```

### Hash

#### FILE -> MD5

```CS
/* FILEtoMD5(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoMD5("C:\\Conforyon.dll", false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>f9d992a8e8e021c00baa6fe40a35b2fd</ReturnValue>
</FunctionResult>
```

```CS
/* FILEtoMD5(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoMD5("C:\\Conforyon.dll", true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>F9D992A8E8E021C00BAA6FE40A35B2FD</ReturnValue>
</FunctionResult>
```

#### FILE -> SHA1

```CS
/* FILEtoSHA1(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA1("C:\\Conforyon.dll", false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>5622cc83830cf224545f122a3ca129d60d151dcb</ReturnValue>
</FunctionResult>
```

```CS
/* FILEtoSHA1(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA1("C:\\Conforyon.dll", true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>5622CC83830CF224545F122A3CA129D60D151DCB</ReturnValue>
</FunctionResult>
```

#### FILE -> SHA256

```CS
/* FILEtoSHA256(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA256("C:\\Conforyon.dll", false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>0d71a9f754b5c02cf143a4af153cbe853cda8fc096a253ebe86e6d7970615ece</ReturnValue>
</FunctionResult>
```

```CS
/* FILEtoSHA256(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA256("C:\\Conforyon.dll", true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>0D71A9F754B5C02CF143A4AF153CBE853CDA8FC096A253EBE86E6D7970615ECE</ReturnValue>
</FunctionResult>
```

#### FILE -> SHA384

```CS
/* FILEtoSHA384(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA384("C:\\Conforyon.dll", false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>154af1bf38dc9b0495704d0a67bf5890f89833165f14d9f4990004bea1f29341a8699e70537a188e0cade1695083c9c6</ReturnValue>
</FunctionResult>
```

```CS
/* FILEtoSHA384(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA384("C:\\Conforyon.dll", true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>154AF1BF38DC9B0495704D0A67BF5890F89833165F14D9F4990004BEA1F29341A8699E70537A188E0CADE1695083C9C6</ReturnValue>
</FunctionResult>
```

#### FILE -> SHA512

```CS
/* FILEtoSHA512(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA512("C:\\Conforyon.dll", false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>a9de54d604fba423c81862b0559aa21165d6d69cc751c74f7d2dcc360ba1b750f4e4fee934c24939bb15c70d9a632b203e086a1b9eeeb745e2e7959325c1e968</ReturnValue>
</FunctionResult>
```

```CS
/* FILEtoSHA512(string Path, bool Uppercase = false, string Error = ErrorMessage) */
FILEtoSHA512("C:\\Conforyon.dll", true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>A9DE54D604FBA423C81862B0559AA21165D6D69CC751C74F7D2DCC360BA1B750F4E4FEE934C24939BB15C70D9A632B203E086A1B9EEEB745E2E7959325C1E968</ReturnValue>
</FunctionResult>
```

### Data Storage

#### Auto Data Convert

```CS
/* AutoDataConvert(string InputVariable, StorageType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage) */
AutoDataConvert("987654321", StorageType.Byte, true, true, true, 2, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>941,90 MB</ReturnValue>
</FunctionResult>
```

```CS
/* AutoDataConvert(string InputVariable, StorageType InputType, bool TypeText = false, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage) */
AutoDataConvert("987654321", StorageType.Byte, false, true, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>941</ReturnValue>
</FunctionResult>
```

#### Data Convert

```CS
/* DataConvert(string InputVariable, StorageType InputType, StorageType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage) */
DataConvert("987654321", StorageType.Byte, StorageType.GB, true, true, 2, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>0,91</ReturnValue>
</FunctionResult>
```

```CS
/* DataConvert(string InputVariable, StorageType InputType, StorageType TypeConvert, bool Decimal = false, bool Comma = false, int PostComma = 0, string Error = ErrorMessage) */
DataConvert("987654321", StorageType.Byte, StorageType.GB, false, true, 5, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>0,91982</ReturnValue>
</FunctionResult>
```

### Temperature

#### Celsius -> Fahrenheit

```CS
/* CtoF(string Variable, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage) */
CtoF("12345", true, true, 1, true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>22.253,0 F</ReturnValue>
</FunctionResult>
```

```CS
/* CtoF(string Variable, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage) */
CtoF("12345", false, false, 0, false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>22253</ReturnValue>
</FunctionResult>
```

#### Fahrenheit -> Celsius

```CS
/* FtoC(string Variable, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage) */
FtoC("12345", true, true, 2, true, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>6.840,55 C</ReturnValue>
</FunctionResult>
```

```CS
/* FtoC(string Variable, bool Decimal, bool Comma, int PostComma = 0, bool Text = true, string Error = ErrorMessage) */
FtoC("12345", false, false, 0, false, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>6840</ReturnValue>
</FunctionResult>
```

### Typography

#### INCH -> CM

```CS
/* INCHtoCM(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
INCHtoCM("12345", true, true, 1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>31.356,3</ReturnValue>
</FunctionResult>
```

```CS
/* INCHtoCM(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
INCHtoCM("12345", false, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>31356</ReturnValue>
</FunctionResult>
```

#### INCH -> PX

```CS
/* INCHtoPX(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
INCHtoPX("12345", true, true, 1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>1.185.120,0</ReturnValue>
</FunctionResult>
```

```CS
/* INCHtoPX(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
INCHtoPX("12345", false, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>1185120</ReturnValue>
</FunctionResult>
```

#### CM -> INCH

```CS
/* CMtoINCH(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
CMtoINCH("12345", true, true, 1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>4.860,2</ReturnValue>
</FunctionResult>
```

```CS
/* CMtoINCH(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
CMtoINCH("12345", false, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>4860</ReturnValue>
</FunctionResult>
```

#### CM -> PX

```CS
/* CMtoPX(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
CMtoPX("12345", true, true, 1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>466.582,6</ReturnValue>
</FunctionResult>
```

```CS
/* CMtoPX(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
CMtoPX("12345", false, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>466582</ReturnValue>
</FunctionResult>
```

#### PX -> CM

```CS
/* PXtoCM(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
PXtoCM("12345", true, true, 1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>326,6</ReturnValue>
</FunctionResult>
```

```CS
/* PXtoCM(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
PXtoCM("12345", false, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>326</ReturnValue>
</FunctionResult>
```

#### PX -> INCH

```CS
/* PXtoINCH(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
PXtoINCH("12345", true, true, 1, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>128,5</ReturnValue>
</FunctionResult>
```

```CS
/* PXtoINCH(string Variable, bool Decimal, bool Comma, int PostComma = 0, string Error = ErrorMessage) */
PXtoINCH("12345", false, false, 0, "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>128</ReturnValue>
</FunctionResult>
```

### Unicode

#### CHAR -> ASCII

```CS
/* CHARtoASCII(string Variable, string Error = ErrorMessage) */
CHARtoASCII("Conforyon", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>67,111,110,102,111,114,121,111,110</ReturnValue>
</FunctionResult>
```

#### ASCII -> CHAR

```CS
/* ASCIItoCHAR(string Variable, string Error = ErrorMessage) */
ASCIItoCHAR("67,111,110,102,111,114,121,111,110", "Error!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>Conforyon</ReturnValue>
</FunctionResult>
```