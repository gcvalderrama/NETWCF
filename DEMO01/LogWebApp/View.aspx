<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="LogWebApp.View" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://code.jquery.com/jquery.min.js"> </script>
    <script type="text/javascript">
        $(document).ready(function () {
            var def = $.ajax({ url: '<%= ResolveClientUrl("~/LogService.svc/GetMessages") %>' });
            def.done(function (data) {
                $.each(data, function () {
                    var t = $("<p style='background-color:blue'>");
                    t.html(this);
                    $("#demo").append(t); 
                });
                
            });
        });  
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="demo">
        
    </div>
    </form>
</body>
</html>
