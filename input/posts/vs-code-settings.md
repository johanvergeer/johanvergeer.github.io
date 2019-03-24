---
Title: VS Code Settings
Published: 3/24/2019
Tags: [VS Code, Visual Studio Code]
author: Johan Vergeer
---

VS Code is very configurable. In this post I'll share the configuration I like to use. 

# Auto save

Most of the time I like my IDE to save files automatically instead of having to save each and every file independently. I know, I can save all files, but that's still more work that letting the IDE do it. 

To configure this, just add the following to the main object in `settings.json`:

```json
"files.autoSave": "afterDelay"
```

