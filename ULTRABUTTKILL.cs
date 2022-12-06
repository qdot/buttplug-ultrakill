using System;
using System.Threading.Tasks;
using BepInEx;
// Note to anyone trying to build this: ButtplugManaged is NOT INCLUDED IN THIS PROJECT BECAUSE
// I HAVE ALLERGIES AND/OR RELIGIOUS OBJECTIONS TO GIT SUBMODULES. So you'll need to clone that
// repo and include it here or something. I don't think it has a nuget package yet. Maybe
// someday I'll finally make the official buttplug C# package usable again and it'll have a nice
// nuget but until then, suffer.
using ButtplugManaged;

namespace ULTRABUTTKILL
{
    [BepInPlugin("UK.Buttplug", "UKButtplug", "1.0.0")]

    public class Plugin : BaseUnityPlugin
    {
        ButtplugClient client = new ButtplugClient("UK.Buttplug");
        
        int lastEnemyCount = 0;
        public void Start()
        {
            // But what if connection fails?
            //
            // lol
            Task.Run(async () =>
            {
                await client.ConnectAsync(new ButtplugWebsocketConnectorOptions(new Uri("ws://127.0.0.1:12345/")));
                await client.StartScanningAsync();
            });
        }
        public void Update()
        {
            // Is there a better way to store this so we only use it during game instances? Probably.
            // Do I care? No. It's a singleton, so it's not like we're newing up anything, it's just a table lookup.
            var tracker = MonoSingleton<EnemyTracker>.Instance;
            if (tracker == null)
            {
                return;
            }
            // Just fire all the vibrators if enemy count changes at all. This is a game for ADHD people,
            // it's not like they're going to notice. 
            var enemyCount = tracker.GetCurrentEnemies().Count;
            if (enemyCount != lastEnemyCount)
            {
                foreach (var device in client.Devices)
                {
                    // Make sure the device at least handles VibrateCmd.
                    if (device.AllowedMessages.ContainsKey("VibrateCmd"))
                    {
                        // So the interesting thing is here, if we kill a whole bunch of things quickly, this will fire
                        // multiple times and therefore end randomly since it's not really guarded anywhere. This could
                        // probably do with some sort of scope lock, but I'll leave that as an exercise for someone else
                        // who will actually maintain this.
                        Task.Run(async () =>
                        {
                            await device.SendVibrateCmd(1.0);
                            await Task.Delay(500);
                            await device.SendVibrateCmd(0.0);
                        });
                    }
                }
                lastEnemyCount = enemyCount;
            }
        }
    }
}
