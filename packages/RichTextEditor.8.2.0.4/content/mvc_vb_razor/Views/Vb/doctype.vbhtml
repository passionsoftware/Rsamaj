﻿<!DOCTYPE html>
<html>
<head>
    <title>RichTextEditor - DesignDocType</title>
    <link rel="stylesheet" href="/Content/example.css" type="text/css" />
</head>
<body>
    @Code Html.BeginForm()End Code
    <h1>
        Design DocType</h1>
    <p>
    </p>
    <div>
        <div>
            <span id="MainContent_rbl_type">
                <input id="MainContent_rbl_type_0" type="radio" name="SelectType" value="" checked="checked"
                    onclick="MvcSubmit();" /><label for="MainContent_rbl_type_0">Default</label>
                <input id="MainContent_rbl_type_1" type="radio" name="SelectType" value="HTML4" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_1">HTML4</label>
                <input id="MainContent_rbl_type_2" type="radio" name="SelectType" value="HTML5" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_2">HTML5</label>
                <input id="MainContent_rbl_type_3" type="radio" name="SelectType" value="XHTML" onclick="MvcSubmit();" /><label
                    for="MainContent_rbl_type_3">XHTML</label></span>
            <script type="text/javascript">
                var ipts = document.getElementsByName("SelectType");
                var mode = '@ViewBag._mode' || "";
                if (mode) {
                    for (var i = 0; i < ipts.length; i++) {
                        if (ipts[i].value == mode) {
                            ipts[i].checked = true;
                            break;
                        }
                    }
                }
                function MvcSubmit() {
                    document.getElementById('btn_sumbit').click();
                }
            </script>
            <button id="btn_sumbit" style="display: none;" type="submit">
                Submit</button>
        </div>
        <br />
        @Html.Raw(ViewBag.Editor)
    </div>
    @Code Html.EndForm()End Code
</body>
</html>
