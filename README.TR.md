![logo](https://www.photo.herominyum.com/resimler/2020/08/04/1mpl.png)

![dotnetframework-version](https://img.shields.io/badge/.NET%20Framework-%3E%3D4.0-blue)
![dotnetcore-version](https://img.shields.io/badge/.NET%20Core-%3E%3D2.1-blue)
![dotnetstandard-version](https://img.shields.io/badge/.NET%20Standard-%3E%3D2.1-blue)
![csharp-version](https://img.shields.io/badge/C%23-8.0-blue.svg)
![ide-version](https://img.shields.io/badge/IDE-vs2019-blue.svg)
[![nuget-version](https://img.shields.io/nuget/v/Conforyon.svg)](https://www.nuget.org/packages/Conforyon)
[![nuget](https://img.shields.io/nuget/dt/Conforyon)](https://www.nuget.org/packages/Conforyon)

# Conforyon'a Hoşgeldiniz
Conforyon bir Birim Dönüştürücü kütüphanesidir. Sunduğu çeşitli birim dönüşümlerin dönüştürülmesine olanak sağlar.

## Katkıda Bulunanlar

Bu harika insanlara teşekkürler ([emoji anahtarı](https://allcontributors.org/docs/en/emoji-key)):

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
		<a href="https://github.com/Taiizor/Conforyon/commits?author=Taiizor" title="Kodlama">💻</a>
		<a href="https://www.taiizor.com" title="Fikirler & Planlama, Geri Bildirim">🤔</a>
	</td>
  </tr>
</table>

Bu proje [tüm katkıda bulunanların](https://github.com/all-contributors/all-contributors) özelliklerini takip ediyor. Her türlü katkıda hoş geldiniz!

## Destekleyenler

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
		<a href="https://github.com/Soferity" target="_blank" title="İçerik">🖋</a>
	</td>
  </tr>
</table>

## Kullanım

Step 1：Referans olarak Conforyon'u ekleyin veya NuGet üzerinden Conforyon'u aratın;

```Install-Package Conforyon```

Step 2：Dönüşümlerin tadını çıkarın

## Demolar

### Conforyon UI

![ConforyonUIDemo](https://www.photo.herominyum.com/resimler/2020/08/04/1xQU.png)

### Conforyon UX

![ConforyonUXDemo](https://www.photo.herominyum.com/resimler/2020/08/04/XxXx.png)

## Ayrıntılı Kullanım

### Pano

#### Metin

```CS
/* CopyText(string Text, bool Copy = true) */
CopyText("Conforyon", false);
```

```CS
/* PasteText(bool Clear = false, string Back = EmptyMessage, string Error = ErrorMessage) */
PasteText(true, "Boş!", "Hata!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>Conforyon</ReturnValue>
</FunctionResult>
```

#### Ses

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

### Renk

#### HEX -> RGB

```CS
/* HEXtoRGB(string Variable, ColorType Mode = ColorType.RGB1, string Error = ErrorMessage) */
HEXtoRGB("FFFFFF", ColorType.RGB1, "Hata!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>255, 255, 255</ReturnValue>
</FunctionResult>
```

```CS
/* HEXtoRGB(string Variable, ColorType Mode = ColorType.RGB1, string Error = ErrorMessage) */
HEXtoRGB("000000", ColorType.RRGGBB1, "Hata!");
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
RGBtoHEX("255", "255", "255", true, "Hata!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>#FFFFFF</ReturnValue>
</FunctionResult>
```

```CS
/* RGBtoHEX(string R, string G, string B, bool Sharp = false, string Error = ErrorMessage) */
RGBtoHEX("0", "0", "0", false, "Hata!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>000000</ReturnValue>
</FunctionResult>
```

### Kripto

#### TEXT -> BASE64

```CS
/* TEXTtoBASE64(string Variable, string Error = ErrorMessage) */
TEXTtoBASE64("Conforyon", "Hata!");
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
BASE64toTEXT("Q29uZm9yeW9u", "Hata!");
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
TEXTtoMD5("Conforyon", "Hata!");
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
TEXTtoSHA1("Conforyon", "Hata!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>9946dc70f0672da2ba000a0cb80f8872</ReturnValue>
</FunctionResult>
```

#### TEXT -> SHA256

```CS
/* TEXTtoSHA256(string Variable, string Error = ErrorMessage) */
TEXTtoSHA256("Conforyon", "Hata!");
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
TEXTtoSHA384("Conforyon", "Hata!");
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
TEXTtoSHA512("Conforyon", "Hata!");
```
```XML
<FunctionResult>
	<ReturnType>System.String</ReturnType>
	<ReturnValue>d47368182220aab5f687dde734acbb8d895bb2d870e789ee03216f3b215ac00a4202ead0aabce2049ae49a0079b130211323453604c088b09a27ee989de9db8b</ReturnValue>
</FunctionResult>
```