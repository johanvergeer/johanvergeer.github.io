---
Title: Creating styled boxes for a Wyam site
Published: 3/11/2019
Tags: [C#, Wyam, CSS]
author: Johan Vergeer
---
Sometimes you want to indicate a piece of information is more important then the rest. To do this you can create styled boxes with CSS. I used an example from [madcapsoftware.com](https://www.madcapsoftware.com/blog/2017/08/17/css-tip-creating-styled-boxes-notes-warnings-examples-tips/) and applied it to Wyam.

I did not create a NuGet package for this functionality (yet). But it is fairly simple to create the boxes yourself.

The boxes we'll create are:

<?# Note ?>
Note
<?#/ Note ?>

<?# Warning ?>
Warning
<?#/ Warning ?>

<?# Example ?>
Example
<?#/ Example ?>

<?# Tip ?>
Tip
<?#/ Tip ?>

# Create CSS

The CSS is to as hard as it might seem. The first part is the general box class.
As you can see, you'll need to create a `div` element with a `box` class.

```css
div.box {
     font-size: 1rem;
     -moz-border-radius: 6px;
     -webkit-border-radius: 6px;
     background-position: 9px 0px;
     background-repeat: no-repeat;
     border-radius: 6px;
     line-height: 18px;
     overflow: hidden;
     padding: 15px 60px;
     margin: 10px 0;
}
```

This will get you a box, but not the desired colors. For this we'll create four more css classes:

```css
div.box-note {
     background-color: #f0f7fb;
     background-image: url(../Images/icons/Pencil-48.png);
     border: solid 1px #3498db;
}

div.box-warning {
     background-color: #FCF7F2;
     background-image: url(../Images/icons/Warning-48.png);
     border: solid 1px #E64636;
}

div.box-example {
     background-color: #E7F6F0;
     background-image: url(../Images/icons/Check-48.png);
     border: solid 1px #2BCB6F;
}

div.box-tip {
     background-color: #FFFBEA;
     background-image: url(../Images/icons/Lightbulb-48.png);
     border: solid 1px #F1C40F;
}
```

Each class defines a `background-color`, a `color` and a `background-image`.

# Create Wyam Shortcodes

We can create some shortcodes in `config.wyam`. These shortcodes are all it takes to create the styled boxes.

```csharp
ShortcodeCollection.Add("Note", (string x) => $"<div class='box box-note'>{x}</div>");

ShortcodeCollection.Add("Warning", (string x) => $"<div class='box box-warning'>{x}</div>");

ShortcodeCollection.Add("Example", (string x) => $"<div class='box box-example'>{x}</div>");

ShortcodeCollection.Add("Tip", (string x) => $"<div class='box box-tip'>{x}</div>");
```

# Use the Shortcodes

After defining the shortcodes in `config.wyam`, you can use them. The code I used to create the boxes above is this:

```markdown
<?# Note ?>
Note
<?#/ Note ?>

<?# Warning ?>
Warning
<?#/ Warning ?>

<?# Example ?>
Example
<?#/ Example ?>

<?# Tip ?>
Tip
<?#/ Tip ?>
```

That's all, folks.