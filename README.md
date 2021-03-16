# Dsyon Sphere Program Mods

Series of mods for the game [Dyson Sphere Program](https://store.steampowered.com/app/1366540/Dyson_Sphere_Program/) developed by Youthcat Studio and published by [Gamera Game](https://www.gameragame.com/)

All the mods are implemented using [`Harmony`](https://harmony.pardeike.net/articles/intro.html) runtime patching mechanisms.  
All mods are QoL type mods and don't modify any entities. As such, these mods **_shouldn't_** corrupt or break save games.

---

## Mods
1. [IncreaseMaxWarpSpeed](#IncreaseMaxWarpSpeed) (Released)
2. [CopyLogisticStationConfig](#CopyLogisticStationConfig) (In Development)
3. [RecipeBrush](#RecipeBrush) (Pending)

---

## Installation Instructions.

### r2modman
Search up the mod on thunderstore and install as per r2modman instructions.

### Manual
Go to the required release for a specific mod and download the `.dll`.
Copy this `.dll` to your `BepInEx/plugins/` folder within your game install.

---

## IncreaseMaxWarpSpeed

A basic config mod that allows you to increase the maximum warp speed of the Icarus Mecha.

Note: Setting the warp speed to anything greater than 0.5 LY can cause issues "handling" the mecha.  
If you're used to crashing into planets from warp and having the game exit you, this may not be possible due to the speed of approach.  
As such, it's recommended to exit warp when you're close enough to the planet and sail the rest of the way.

---

## CopyLogisticStationConfig

A basic hotkey mod that extends the `,` and `.` copy / paste mechanisms of other facilities within the game to copy over configurations of resources as well as output filters (if belts are connected).

---

## RecipeBrush

A area-of-effect mod that allows you to select a recipe and set the recipes on all applicable facilities using a brush style tool.