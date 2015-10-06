<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatePickerTester.aspx.cs" Inherits="IndentApplicationManagement.DatePickerTester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Good to work</title>
    <link href="Kendo/styles/kendo.rtl.css" rel="stylesheet" />
        <link href="Kendo/styles/kendo.common.min.css" rel="stylesheet" />
        <link href="Kendo/styles/kendo.default.min.css" rel="stylesheet" />
        <link href="Kendo/styles/kendo.mobile.all.min.css" rel="stylesheet" />
    <script src="Kendo/js/jszip.min.js"></script>
    <script src="Kendo/js/jquery.min.js"></script>
    <script src="Kendo/js/angular.min.js"></script>
    <script src="Kendo/js/kendo.all.min.js"></script>
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <input id="datetimepicker" runat="server" clientidmode="Static" style="width: 11%; height: 38px;" />
    </div>
    </form>
         <script src="Kendo/examples/content/shared/js/products.js"></script>
    <script>

        $(document).ready(function () {

            $("#<%=datetimepicker.ClientID %>").kendoDatePicker({
                    value: new Date()
                });
            });

        </script>
</body>
</html>
