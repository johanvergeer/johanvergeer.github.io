---
Title: VS Code Extensions
Published: 3/24/2019
Tags: [VS Code, Visual Studio Code]
author: Johan Vergeer
---

One of the many great things about VS Code is it's extensibility, and the many extensions that are out there in the marketplace. This is a list of extensions I use and wanted to share with you.

Since all extensions provide pretty to very good documentation, I won't go into too much detail about them. 

# HTML and CSS
## Emmet

Emmit is already pre installed on VS Code, and it helps you to create HTML and CSS really quickly. 

## Live Server

Makes developing pure HTML and CSS websites a lot easier. 

## CSS Peek

Allows you to see __and edit__ CSS from a mini window from your HTML. 

After installing, when you hit `F12`, it opens a mini window that allows you to edit the CSS right away without leaving the HTML. Hit `Esc` to get out of it.

# Themes

## Material Theme

One of the most popular themes for VS Code. Just search for `Material Theme` in the extensions Marketplace. It comes with several different looks.

To change the theme you can use `Ctrl+k+t`.

# Code Highlighting and formatting

## Color Highlight

This plugin highlights RGB or Hex colors right in the editor. You can change the marker type in settings &rarr; Color highlight.

## Bracket pair colorizer 2

_Bracket pair colorizer 2_ is the successor of the very popular _Bracket pair colorizer_ extension.

It colorizes the brackets in programming languages so you can see matching brackets better. In `settings.json` you can set the colors to be used for each level.

```json
    "bracket-pair-colorizer-2.colors": [
        "#00BCD4",
        "#CDDC39",
        "#EC407A",
        "#9C27B0"
    ]
```

You can changes these colors to your liking.

## Prettier - Code Formatter

There are a couple of extensions that will make your code prettier. The most popular is __Prettier - Code Formatter__. It does exactly what it says, it makes your code prettier.

# Snippets

There are several extensions that use can use to create snippets. I don't use them very often, but to some people they can be very useful.
Just search for a snippet library for your language and install it. 

# Git

## Git Project Manager

Allows you to change easily between git projects.

## GitLens

GitLens supercharges the Git capabilities built into Visual Studio Code. It helps you to visualize code authorship at a glance via Git blame annotations and code lens, seamlessly navigate and explore Git repositories, gain valuable insights via powerful comparison commands, and so much more.

## Git Graph

View a Git Graph of your repository, and perform Git actions from the graph.

# DocFX

## DocFX Assistant

An extension for VS Code that provides tools for authoring content using Microsoft DocFX.

# Markdown

## Markdown All in One

All you need for Markdown (keyboard shortcuts, table of contents, auto preview and more).

## Markdown Table Formatter

A simple markdown plugin to format tables.

# YAML

YAML Language Support by Red Hat, with built-in Kubernetes and Kedge syntax support

# XML

XML Language Support by Red Hat

# PowerShell

Develop PowerShell scripts in Visual Studio Code!
