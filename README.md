# ForumTesting

## �M��²��

���M�׬� .NET 8 Razor Pages �Q�װϽd�ҡA�䴩�T���s�W�B�s��B�R���B�˵��C

## ���һݨD
- .NET 8 SDK
- SQL Server�]�Ψ�L�䴩����Ʈw�^

## �ظm�M��
```bash
dotnet build
```

## ��Ʈw�s�u�]�w
�нs�� `appsettings.json`�A�]�w�s�u�r��G
```json
"ConnectionStrings": {
  "MessageContext": "Server=YOUR_SERVER;Database=ForumTestingDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
�бN `YOUR_SERVER` �������A�� SQL Server �W�١C

## �}�o���ҳ]�w
�}�o�ɽбN `appsettings.json` �����e�ƻs�� `appsettings.Development.json`�A�îھڶ}�o�ݨD�ק��Ʈw�s�u���]�w�C
`appsettings.Development.json` �w�[�J `.gitignore`�A���|�Q���e�� Git�C

## �M��w��
�p�ݦw�� Entity Framework Core �� SQL Server provider�G
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

## ��ƪ�E���P��s
1. �إߪ�l�E���G
```bash
dotnet ef migrations add InitialCreate
```
2. �M�ξE���ܸ�Ʈw�G
```bash
dotnet ef database update
```

## ����M��
```bash
dotnet run
```

## ��L
- �����\��G�T���s�W�B�s��B�R���B�˵��C
- Controller �P Razor Pages �ҥi�ΡC

�p�ݧ�Բӳ]�w�ιJ����D�A�аѦҩx����αM�׭�l�X�C

