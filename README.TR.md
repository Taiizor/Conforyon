![logo](https://www.photo.herominyum.com/resimler/2020/08/04/1mpl.png)

![dotnetframework-version](https://img.shields.io/badge/.NET%20Framework-%3E%3D4.0-blue)
![dotnetcore-version](https://img.shields.io/badge/.NET%20Core-%3E%3D2.1-blue)
![dotnetstandard-version](https://img.shields.io/badge/.NET%20Standard-%3E%3D2.1-blue)
![csharp-version](https://img.shields.io/badge/C%23-8.0-blue.svg)
![ide-version](https://img.shields.io/badge/IDE-vs2019-blue.svg)
[![nuget-version](https://img.shields.io/nuget/v/Conforyon.svg)](https://www.nuget.org/packages/Conforyon)
[![nuget](https://img.shields.io/nuget/dt/Conforyon)](https://www.nuget.org/packages/Conforyon)

# Conforyon'a Hoşgeldiniz
Conforyon bir Birim Dönüştürücü kütüphanesidir. Sunduğu çeşitli birim dönüşümlerini dönüştürmenize olanak sağlar.

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

## Örnekler

### Conforyon UI

![ConforyonUIDemo](https://www.photo.herominyum.com/resimler/2020/08/04/1xQU.png)

### Conforyon UX

![ConforyonUXDemo](https://www.photo.herominyum.com/resimler/2020/08/04/XxXx.png)

## Ayrıntılı Kullanım

### Pano

#### Metin

```CS
/* CopyText(string Text, bool Copy = true) */
CopyText("Conforyon");
```

```CS
/* PasteText(bool Clear = false, string Back = EmptyMessage, string Error = ErrorMessage) */
PasteText(true, "Boş!");
```

#### Ses

```CS
/* CopyAudio(byte[] Bytes) */
CopyAudio(byte[] Bytes);
```

```CS
/* PasteAudio(bool Clear = false) */
PasteAudio(true);
```

#### Örnek

```CS
/* CopyAudio(byte[] Bytes) */
CopyAudio(byte[] Bytes);
```

```XML
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="pack://application:,,,/HandyControl;component/Themes/SkinDefault.xaml"/>
            <ResourceDictionary Source="pack://application:,,,/HandyControl;component/Themes/Theme.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```