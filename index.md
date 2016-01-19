---
layout: default
---

<div class="page-header">
    <h1>{{ site.title }}</h1>
</div>

This packages contains the following two Razor template files:

 - _Layout.cshtml
 - Error.cshtml
 
These files should not amended directly as they will be over-written by future package updates. They can be configured and modified using the following options. If further configuration is required, please [log an issue](https://github.com/GuildfordBC/front-template/issues/new).

## Layout configuration

The following options can be set via `ViewData` typically in the _ViewStart.cshtml file:

```c#
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

The template expects a CSS style bundle at the address `~/assets/css` which includes main.css from the Asset folder. Add the following to your BundleConfig.cs

```c#
            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/assets/main.css"));
```

## External resources

The template loads the following resources from a CDN and local copies are therefore not required:

 - Bootstrap v3 CSS
 - Bootstrap v3 Javascript
 - Google Font (except in Legacy mode)
 - Favicon and touch icons
 - jQuery v2
 - Twitter Widget (Legacy mode only)
 
## Sections

### HeadScripts
Add markup such as scripts or CSS before the closing `</head>`

### BeforePrimaryNavigation

### PrimaryNavigation
List items to include in the primary navigation bar (rendered in the header and collapses to a menu on small devices).

```
   <li><a href="http://www.guildford.gov.uk">Home</a></li>
```

In legacy mode some standard links are automatically included if the section is defined.

### ServiceStage
A section to optionally display the service design phase.

```
    <div class="service-stage">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <span class="label label-stage label-beta">BETA</span> This is a new service – your <a href="#" title="Send feedback about CustomerPoint">feedback</a> will help us to improve it.
                </div>
            </div>
        </div>
    </div>
```

### Breadcrumb
List items to include in the breadcrumb trail

### Footer
An area to add content to a `<div class="row">`

In legacy mode some standard links are automatically included if the section is defined.

In non-legacy mode support and feedback links are displayed if the appropriate settings are configured.

### FooterScripts
Add markup such as scripts or CSS before the closing `</body>`

## Javascript

`BaseUrl` is defined in `<head>` which contains the site root (output from `Url.Content("~/")`).
