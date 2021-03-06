﻿/********************************************************************
* Copyright (C) 2015-2017 Antoine Aflalo
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
********************************************************************/

using System.Linq;
using AudioDefaultSwitcherWrapper;
using SoundSwitch.Localization;
using SoundSwitch.Model;

namespace SoundSwitch.Framework.TooltipInfoManager.TootipInfo
{
    public class TooltipInfoRecording : ITooltipInfo
    {
        public TooltipInfoTypeEnum TypeEnum => TooltipInfoTypeEnum.Recording;
        public string Label => SettingsStrings.tooltipOnHoverOptionRecordingDevice;

        /// <summary>
        /// The text to display for this ToolTip
        /// </summary>
        /// <returns></returns>
        public string TextToDisplay()
        {
            var recordingDevice = AppModel.Instance.ActiveAudioDeviceLister.RecordingDevices                                  .FirstOrDefault(device => AudioController.IsDefault(device.Id, (DeviceType)device.Type, DeviceRole.Console));
            return recordingDevice == null ? null : string.Format(SettingsStrings.activeRecording, recordingDevice);
        }

        public override string ToString()
        {
            return Label;
        }
    }
}