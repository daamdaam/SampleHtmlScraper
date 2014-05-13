<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A Simple HTML Scraper using IE and PhantomJS</title>
    <script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.DoTheScrape').click(function () {
                $('.ScrapedHtml').val(""); //clear the text area
            })
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="main-content">
        <h1>A really simple HTML Scraper written using Csharp and using PhantomJSDriver</h1>
        <label for="txtUrlToScrape">Enter a URL to scrape - not one that requires logging in.</label>
        <asp:TextBox Width="100%" ID="txtUrlToScrape" runat="server"/>
        <asp:RadioButtonList runat="server" ID="radlstBrowserToUse">
            <asp:ListItem Value="PhantomJSDriver" Text="Use PhantomJS Headless browser"></asp:ListItem>
            <asp:ListItem Value="InternetExplorerDriver" Text="Use Internet Explorer browser"></asp:ListItem>
        </asp:RadioButtonList> 
        <asp:Button runat="server" ID="btnDoTheScrape" Text="Do the scrape" class="DoTheScrape"/>
        <label for="txtScrapedHtml">The scraped HTML will appear in the Textbox below.</label>
        <asp:TextBox TextMode="MultiLine" ReadOnly="true" runat="server" CssClass="ScrapedHtml" ID="txtScrapedHtml" Width="100%" Height="800px"></asp:TextBox>
    </div>
    </div>
    </form>
</body>
</html>
