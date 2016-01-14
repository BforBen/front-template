---
layout: default
---

<div class="page-header">
    <h1>{{ site.title }}</h1>
</div>

## Layout configuration

The following options can be set via `ViewData` typically in the _ViewStart.cshtml file:

```
ViewContext.ViewData["ApplicationTitle"] = "My application";
```

<div class="table-responsive">
    <table class="table">
        <thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
                <th>Default</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>NgApp</td>
                <td>Angular app name</td>
                <td></td>
            </tr>
            <tr>
                <td>HtmlClass</td>
                <td>CSS class name at the HTML element level</td>
                <td></td>
            </tr>
            <tr>
                <td>ApplicationTitle</td>
                <td>Application title, displayed in the nav bar</td>
                <td></td>
            </tr>
            <tr>
                <td>ApplicationVersion</td>
                <td>App version, displayed in the footer</td>
                <td></td>
            </tr>
            <tr>
                <td>NavBrandUrl</td>
                <td>Navbar link URL</td>
                <td><code>Url.Content("~/")</code></td>
            </tr>
            <tr>
                <td>NavBrandTitle</td>
                <td>Navbar link title</td>
                <td><code>Link to home</code></td>
            </tr>
            <tr>
                <td>Robots</td>
                <td></td>
                <td><code>noindex, follow</code></td>
            </tr>
            <tr>
                <td>FeedbackUrl</td>
                <td>Url for feedback link in footer</td>
                <td></td>
            </tr>
            <tr>
                <td>SupportUrl</td>
                <td>Url for support link in footer</td>
                <td></td>
            </tr>
            <tr>
                <td>LegacyMode</td>
                <td>Display in legacy mode with logo and all white UI</td>
                <td><code>false</code></td>
            </tr>
            <tr>
                <td>ErrorHelpUrl</td>
                <td>Url of a contact page in the case of errors</td>
                <td><code>http://loop.guildford.gov.uk/BS/Pages/LogaServiceDeskCall.aspx</code></td>
            </tr>
            <tr>
                <td>ErrorHelpName</td>
                <td>Name of who deals with errors</td>
                <td><code>ICT Service Desk</code></td>
            </tr>
            <tr>
                <td>ErrorHelpTel</td>
                <td>Telephone number displayed in the event of an error</td>
                <td><code>x4906</code></td>
            </tr>
        </tbody>
    </table>
</div>

The template expects a CSS style bundle at the address `~/assets/css` which includes main.css.

## Sections

