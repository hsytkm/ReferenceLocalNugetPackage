# ReferenceLocalNugetPackage

ローカルのNuGetパッケージをプロジェクトに追加する。



Stackoveflow に沿って作業しただけ。

[Add a package with a local package file in 'dotnet' - Stackoverflow](https://stackoverflow.com/questions/43400069/add-a-package-with-a-local-package-file-in-dotnet)



#### 手順

  1. `*.nupkg` を用意して、どっかローカルフォルダに置く

    2. VisualStudio → ツール → オプション → NuGetパッケージマネージャー から、上記ローカルフォルダ を追加する。 名前は `local-packages` とかにしとく。
     この操作により `%APPDATA%\NuGet\NuGet.Config` が更新される。
    3. NuGetパッケージマネージャを開いて、右上の パッケージソースを `local-packages` にする。
     これでローカルフォルダに保存した nupkg が表示されるはず。

