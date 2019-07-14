::
:: Overview
:: --------
::
:: This will copy the required DLL's to the bin diretcory for Razor intellisense to work. 
:: Yes, its a bit of a hack but Razor was not intended to work with Console Apps.
:: This will stop errors from occuring in the Error List window.

ECHO Post Build Event - Setting up Temporary DLLs for HTML Razor Intellisense 

:: Step 01 - Get directory batch file is in
cd /d %~dp0 

:: Step 02 - Copy the files 
copy ..\bin\Debug\System.Web.Mvc.dll ..\bin
copy ..\bin\Debug\System.Web.Helpers.dll  ..\bin
copy ..\bin\Debug\System.Web.WebPages.dll  ..\bin
copy ..\bin\Debug\SBCL.dll  ..\bin

ECHO IMPORTANT! - For intellisense to work please make sure you alter the app.config file to include the system.web details.

REM <system.web>
REM <compilation debug="true" targetFramework="4.5">
REM   <assemblies>
REM 	<add assembly="System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
REM 	<add assembly="System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
REM 	<add assembly="Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
REM 	<add assembly="System.Web.Helpers, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
REM 	<add assembly="System.Web.WebPages, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
REM 	<add assembly="System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
REM 	<add assembly="System.Data.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
REM 	<add assembly="SBCL" />
REM   </assemblies>
REM </compilation>
REM <pages>
REM   <namespaces>
REM 	<add namespace="System.Web.Helpers" />
REM 	<add namespace="System.Web.Mvc" />
REM 	<add namespace="System.Web.Mvc.Ajax" />
REM 	<add namespace="System.Web.Mvc.Html" />
REM 	<add namespace="System.Web.Routing" />
REM 	<add namespace="System.Web.WebPages" />
REM 	<add namespace="Crt.Scada.Foundation.CoreData.Reporting.Model" />
REM   </namespaces>
REM </pages>
REM </system.web>