[![Build Status](https://johanvergeer.visualstudio.com/johanvergeer.github.io/_apis/build/status/johanvergeer.johanvergeer.github.io?branchName=source)](https://johanvergeer.visualstudio.com/johanvergeer.github.io/_build/latest?definitionId=5&branchName=source)

# Page metadata

Each page can take some metadata that has impact on it's behavior.

## Page metadata for menu

All pages are added automatically to the menu. This can be disabled by setting `ShowInNavbar: false`, on the page.

Each page can have a Fontawesome icon. The default is `angle-double-right`. This value can be overridden by setting `FontAwesome: <tag>` on the page. For example:

```yml
FontAwesome: user
```