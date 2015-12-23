---
layout: default
---

<div class="page-header">
    <h1>{{ site.title }}</h1>
</div>

## Layout configuration

The following options can be set typically in the _ViewStart.cshtml file:

| Name                                        | Description                                         | Default            |
| ------------------------------------------- | --------------------------------------------------- | ------------------ |
|`ViewContext.ViewData["NgApp"]`              | Angular app name                                    |                    |
|`ViewContext.ViewData["HtmlClass"]`          | CSS class name at the HTML element level            |                    |
|`ViewContext.ViewData["ApplicationTitle"]`   | Application title, displayed in the nav bar         |                    |
|`ViewContext.ViewData["ApplicationVersion"]` | App version, displayed in the footer                |                    |
|`ViewContext.ViewData["NavBrandUrl"]`        | Navbar link URL                                     |`Url.Content("~/")` |
|`ViewContext.ViewData["NavBrandTitle"]`      | Navbar link title                                   |`Link to home`      |
|`ViewContext.ViewData["Robots"]`             |                                                     |`noindex, follow`   |
|`ViewContext.ViewData["FeedbackUrl"]`        | Url for feedback link in footer                     |                    |
|`ViewContext.ViewData["SupportUrl"]`         | Url for support link in footer                      |                    |
|`ViewContext.ViewData["LegacyMode"]`         | Display in legacy mode with logo and all white UI   |`false`             |

The template expects a CSS style bundle at the address `~/assets/css`

## Sections

