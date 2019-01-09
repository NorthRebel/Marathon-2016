# Marathon
##### Marathon - ��� ������� ������, � ������� � ������������ fullstack �������������� �������.

��������! ���� ������ ��������� �� ������ ����������
------
![alt text](Docs/Git/Images/desktop.png "������� �������� ����������� ����������")


### ������������ ���������� ������� �������� ���������, ������� ������� production ��������:

* ���������������� - ������� ������ ���� ������� �� ��������� �������. ����� ������� ����������� ������ ����������� �����, ��������, �������������� � ���������� ��������� ������;
* ������������� - ���������� ����������� ������ - ������ ��������� ������� ������-������ ������ ����� ����������� �������� test-case � ������������� ���������. ��� ����������� ��������� �������� ������� ������������;
* ������������ - ���-������, ������ ������������� ��������� HTTPS, ������ ����� �������������� ��� ������ �� �������������������� ������� �� ������� �������;
* ������������� �� ��������� ������ - ����������� �� ���� ��������� ������������ (Dependency Injection) � ������ � ORM ������������, �������, � ���� �������, ���������� ������� Unit-Of-Work � Repository ��� ������ ��������.

------

### ������������ ���� ����������:

�� ������� ���������� ��������� ��������� ������� �������.

* Backend:
  * [ASP.NET Core WEB.API](Src/Marathon.API/README.md);
  * [ORM Entity Framework Core](Src/Marathon.Persistence/README.md);
  * MSSQL Express (������� ����������� ������������� ������ ���� �� ���� ORM);

* Frontend:
  * [Desktop - WPF](Src/Marathon.Desktop/README.md);
  * [��������� - Xamarin.Forms](Src/Marathon.Mobile/Marathon.Mobile/README.md);
  * Web:
    * [ASP.NET Core MV�](Src/Marathon.MVC/README.md);
    * [ASP.NET Core SPA � �������������� React.JS + Redux](Src/Marathon.SPA/README.md).

------

## [����������� �������](/Docs)

------

## ��������� ����������

1. Microsoft Visual Studio 2017;
2. ASP.NET Core 2.1 SDK;
3. Node.js (��� ������� SPA ����������).


��������� ����������:
1. ������������� ����� ��� ���������� �����-������������� ���������� (Xamarin);
2. Android API 27 ������.

------

## ������� ������

1. �������� ���� ����������� �� ����� ��������� ������:
   ```
    https://github.com/NorthRebel/Marathon.git
   ```
2. �������� ������� � Visual Studio;
2. ������������ ����������� �������� ��������� package manager console:
    ```
    Update-Package 
   ```
3. ���������� ������ ���������� ��������, ��� �����:
   * ������� ��� �� �������;
   * �������� ����� "������� ����������� �������"
   * � ����������� ���������� ���� �������� "������ ����������":
   * �����, ��� �������� ��������� ����, �������� "������":
     * Marathon.API (�����������);
     * ���������� - Marathon.Desktop;
     * ��������� - (Marathon.Mobile);
     * MVC - (Marathon.MVC);
     * SPA - (Marathon.SPA);
5. ������� F5 ��� ������� ��������
6. ����� ������� SPA ���������� � �������� ������ �������:
    ```
    http://localhost:53070/ 
   ```
7. ����� ������� MVC ���������� � �������� ������ �������:
    ```
    http://localhost:5002/ 
   ```
8. ����� ���������� REST ������������ ���-������ � �������� ������ �������:
    ```
    http://localhost:5000/swagger/ 
   ```

------

## ��������

���� ������ ������������ �� �������� MIT - ����������� ��. � ����� [LICENSE.md](/LICENSE.md).