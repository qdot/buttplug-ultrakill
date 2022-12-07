# STOP. DO NOT USE THIS. USE UKBUTT: THE OFFICIAL ULTRAKILL BUTTPLUG.IO MOD

This project is now deprecated in preference to the [OFFICIAL ULTRAKILL BUTTPLUG.IO MOD, UKBUTT](https://github.com/PITR-DEV/ukbutt-mod).

https://github.com/PITR-DEV/ukbutt-mod

This repo will stick around as a fond memory of the dumb project I built in like 2 hours, but if you want something that actually works with Ultrakill the way it was *meant* to be experienced, use UKBUTT.

# Buttplug.io proof-of-concept mod for Ultrakill

[![Patreon donate button](https://img.shields.io/badge/patreon-donate-yellow.svg)](https://www.patreon.com/qdot)
[![Github donate button](https://img.shields.io/badge/github-donate-ff69b4.svg)](https://www.github.com/sponsors/qdot)
[![Discord](https://img.shields.io/discord/353303527587708932.svg?logo=discord)](https://discord.buttplug.io)
[![Twitter](https://img.shields.io/twitter/follow/buttplugio.svg?style=social&logo=twitter)](https://twitter.com/buttplugio)

So [Shammy](https://twitter.com/shammytv) made a tweet about wanting a [Buttplug](https://buttplug.io) mod for [Ultrakill](https://store.steampowered.com/app/1229490/ULTRAKILL/).

And I made one in a couple of hours, just 'cause I hadn't done a game mod in a while and wanted to see how fast it came together.

**NOTE:** BETTER ULTRAKILL BUTTPLUG MODS ARE COMING. They're just still in development by other devs. Once they're available, I'll add links here.

## I require video proof

[Ok here's a youtube video showing it in action](https://www.youtube.com/watch?v=FVZKfSLxrck)

## Wait what

Ok so here's the deal. This mod is a **PROOF OF CONCEPT** to show how one would mod Ultrakill for Buttplug. It's not a *good* mod, mostly because I am extremely unfamiliar with the game, but it is a *working* mod, and that's what matters because I strive for honesty in my shitposts.

This mod uses:

- [Buttplug.io](https://buttplug.io) for toy control.
  - Using the [ManagedButtplugio](https://github.com/Er1807/ManagedButtplugIo/) C# Client
    implementation because the official Buttplug.io C# library current sucks (I know, I wrote it).

And copypastas heavily from:

- [Ultrakill One Hit KO Mod](https://github.com/Dazegambler/Ultrakill-OneHitKO) - Because it was
  suepr simple as a starting framework.
- [EasyPZ Ultrakill Mod](https://github.com/Hydraxous/EasyPZ-ULTRAKILL/) - Because it had the stats
  objects access I needed to find some event to trigger some sort of toy control from.

## So what does it do

Every time the enemy count changes in the current session (meaning enemies spawn, or an enemy is killed), all connected devices that support vibration will vibrate all 100% for 500 milliseconds.

That's it. That's the mod.

## Ok but have you considered using the style sys...

YES I AM AWARE OF THE STYLE SYSTEM AND YES IT WOULD BE A MUCH BETTER IDEA THAN ENEMY COUNT BUT I WAS TRYING TO GET THIS DONE IN LESS THAN 2 HOURS AND HAD NEVER PLAYED THE GAME BEFORE SO I WENT WITH THE OBVIOUS THING.

I MAY UPDATE FOR STYLE AT SOMEPOINT IN THE FUTURE JUST BECAUSE I WILL BE ENDLESSLY POKED IF I DO NOT.

ugh people all wanting me to heed the defining mechanics and systems of the game or some shit instead of picking a random semi-frequent event

## Ok I wanna use it

You'll need

- [Intiface Central](https://github.com/intiface/intiface-central/releases) - This is basically the
  "hardware hub" program for Buttplug. It's free (and soon to be open source, just finishing up some
  licensing stuff)! It currently works on Windows and Mac, Linux coming soon, Android/iOS apps in
  app store review now!
- A compatible vibrator (we support like, 200+ in Buttplug.io, see IOSTIndex for a list. Good news
  is: XBOX COMPATIBLE GAMEPADS WORK. YES THIS MOD ALSO JUST ADDS RUMBLE TO ULTRAKILL.)
- This mod (see the Releases directory)

To install:

- Download zip
- Unzip in your [ULTRAKILL Install Dir]/BepInEx/Plugins directory

To run:
- Start Intiface Central
- Start Intiface Central Server (hit the big play button in Intiface Central)
- THOSE TWO STEPS MUST HAPPEN FIRST, THE MOD IS EXTREMELY DUMB AND WILL NOT RETRY
- Start Ultrakill

You should see "UK.Buttplug Connect" appear in the control panel of Intiface Central.

## Ok I wanna build it

You'll need to

- Clone [ManagedButtplugio](https://github.com/Er1807/ManagedButtplugIo/) next to this repo. Or go
  fix up the project files yourself. Whatever. I'm lazy and didn't want to do submodules.
- Set up the linkage to the Assembly-CSharp DLL included with the version of ULTRAKILL THAT YOU HAVE
  BOUGHT YOURSELF WITH YOUR OWN MONEY BECAUSE THE DEVELOPERS DESERVE IT.
- Hit build. It should build. If it doesn't build, file an issue here. I may not really be dedicated
  enough to add more features here right now but I'll at least make sure the damn thing works.

## LICENSE

ULTRABUTTKILL and Buttplug.io are BSD 3-Clause Licensed, Copyright 2022 Nonpolynomial Labs, LLC

```
Copyright (c) 2016-2022, Nonpolynomial Labs, LLC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

* Neither the name of buttplug nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
```

--

Ultrakill OneHitKO is MIT Licensed:

```
MIT License

Copyright (c) 2021 Dazegambler

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
