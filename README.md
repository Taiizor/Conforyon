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

![ConforyonUIDemo](https://www.photo.herominyum.com/resimler/2020/08/04/1xQU.png)

### Conforyon UX

![ConforyonUXDemo](https://www.photo.herominyum.com/resimler/2020/08/04/XxXx.png)

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