﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Configuration;
using osu.Game.Graphics.UserInterface;

namespace osu.Game.Overlays.Settings.Sections.Gameplay
{
    public class SongSelectSettings : SettingsSubsection
    {
        protected override string Header => "Song Select";

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            Children = new Drawable[]
            {
                new SettingsCheckbox
                {
                    LabelText = "Show converted beatmaps",
                    Bindable = config.GetBindable<bool>(OsuSetting.ShowConvertedBeatmaps),
                },
                new SettingsSlider<double, StarSlider>
                {
                    LabelText = "Display beatmaps from",
                    Bindable = config.GetBindable<double>(OsuSetting.DisplayStarsMinimum),
                    NormalKeyboardStep = 1f,
                    SmallKeyboardStep = 0.1f
                },
                new SettingsSlider<double, StarSlider>
                {
                    LabelText = "up to",
                    Bindable = config.GetBindable<double>(OsuSetting.DisplayStarsMaximum),
                    NormalKeyboardStep = 1f,
                    SmallKeyboardStep = 0.1f
                },
                new SettingsEnumDropdown<SelectionRandomType>
                {
                    LabelText = "Random beatmap selection",
                    Bindable = config.GetBindable<SelectionRandomType>(OsuSetting.SelectionRandomType),
                }
            };
        }

        private class StarSlider : OsuSliderBar<double>
        {
            public override string TooltipText => Current.Value.ToString(@"0.## stars");
        }
    }
}
